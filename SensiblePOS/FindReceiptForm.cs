using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;

using SensiblePOS.Data;
using SensiblePOS.LogIn;
using SensiblePOS.Models;
namespace SensiblePOS
{
    public partial class FindReceiptForm : Form
    {
        public event EventHandler<PrintRequestEventArgs> PrintRequest;
        public SensiblePOSContext Context { private get; set; }
        public string AuthenSalt { get; set; }
        private string _username = "";
        private Customer _customer;
        private Receipt _receipt;
        private ResourceManager _locRM = new ResourceManager("SensiblePOS.Resources.FindReceiptForm", typeof(FindReceiptForm).Assembly);
        public FindReceiptForm(string username, string refInvoice = "")
        {
            InitializeComponent();
            _username = username;
            keywordTextBox.Text = refInvoice;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var keyword = keywordTextBox.Text;
            var target = (from r in Context.Receipts
                          where r.SerialNumber == keyword
                          select new
                          {
                              Receipt = r,
                              Customer = Context.Customers.Where(c => c.Code == r.CustomerCode).FirstOrDefault(),
                              CreditCard = Context.CreditCardIssuers.Where(cc => cc.Id == r.CardIssuer).FirstOrDefault()
                          }).FirstOrDefault();

            if (target != null)
            {
                numberTextBox.Text = target.Receipt.SerialNumber;
                dateTextBox.Text = $"{target.Receipt.EntryDate.ToShortDateString()} {target.Receipt.EntryDate.ToShortTimeString()}";
                if (target.Receipt.IsVoid)
                {
                    statusTextBox.Text = _locRM.GetString("STATUS_VOID");
                    statusTextBox.ForeColor = Color.Red;
                    fullReceiptButton.Enabled = false;
                    voidButton.Enabled = false;
                }
                else
                {
                    statusTextBox.Text = _locRM.GetString("STATUS_PAID");
                    statusTextBox.ForeColor = Color.Black;
                    fullReceiptButton.Enabled = true;
                    voidButton.Enabled = true;
                }

                customerTextBox.Text = !string.IsNullOrEmpty(target.Customer?.FirstName) ? string.Join(' ', new string[] { target.Customer.FirstName, target.Customer.LastName }) : _locRM.GetString("DEFAULT_CUSTOMER");
                paymentTypeTextBox.Text = target.CreditCard != null ? $"{target.Receipt.PaymentType} - {target.CreditCard.Title}" : target.Receipt.PaymentType;
                totalTextBox.Text = target.Receipt.Total.ToString("N2");
                if (!string.IsNullOrEmpty(target.Receipt.Remarks))
                {
                    othersTextBox.Text += $"*{target.Receipt.Remarks}\r\n-------\r\n";
                }
                othersTextBox.Text += $"Subtotal: {target.Receipt.SubTotal.ToString("N2")}\r\n";
                othersTextBox.Text += $"Discount: {target.Receipt.Discount.ToString("N2")}\r\n";
                othersTextBox.Text += $"Seller: {target.Receipt.Seller}\r\n";

                _receipt = target.Receipt;
                _customer = target.Customer;

                var normalDetails = (from d in Context.ReceiptDetails
                                     join p in Context.Products on d.ProductId equals p.Id
                                     where d.SerialNumber == keyword && !d.IsDiscount
                                     select new CartItemInfo
                                     {
                                         SKU = d.Sku,
                                         Title = p.Title,
                                         ItemType = _locRM.GetString("PRODUCT_TYPE"),
                                         UnitPrice = d.UnitPrice,
                                         Qty = d.Qty,
                                         SubTotalPrice = d.SubTotal,
                                         Discount = d.Discount,
                                         TotalPrice = d.TotalPrice,
                                         Remarks = d.Remarks,
                                         IsFine = false,
                                         IsDC = false,
                                         PromotionEffect = false,
                                         Removable = false
                                     }).ToList();

                var dcDetails = (from d in Context.ReceiptDetails
                                 join p in Context.Promotions on d.ProductId equals p.Id
                                 where d.SerialNumber == keyword  && d.IsDiscount
                                 select new CartItemInfo
                                 {
                                     SKU = d.Sku,
                                     Title = p.Title,
                                     ItemType = _locRM.GetString("DISCOUNT_TYPE"),
                                     UnitPrice = d.UnitPrice,
                                     Qty = d.Qty,
                                     SubTotalPrice = d.SubTotal,
                                     Discount = d.Discount,
                                     TotalPrice = d.TotalPrice,
                                     Remarks = d.Remarks,
                                     IsFine = false,
                                     IsDC = true,
                                     PromotionEffect = false,
                                     Removable = false
                                 }).ToList();
                var allDetails = normalDetails.Union(dcDetails).ToList();
                cartItemInfoBindingSource.DataSource = allDetails.OrderBy(c => c.IsFine).ThenBy(c => c.IsDC).ToList();
                cartItemInfoBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show(_locRM.GetString("DIALOG_MSG_RECEIPT_NOT_FOUND"), _locRM.GetString("DIALOG_TITLE_FIND_RECEIPT"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                numberTextBox.Text = "";
                statusTextBox.Text = "";
                customerTextBox.Text = "";
                dateTextBox.Text = "";
                paymentTypeTextBox.Text = "";
                totalTextBox.Text = "";
                othersTextBox.Text = "";

                _receipt = null;
                _customer = null;
                cartItemInfoBindingSource.DataSource = null;
                cartItemInfoBindingSource.ResetBindings(false);
            }
        }

        private void voidButton_Click(object sender, EventArgs e)
        {
            if (_receipt == null) return;
            var users = GetUserPasswordInfos();
            using (var loginForm = new LoginForm(users, this.Icon))
            {
                loginForm.AuthenSalt = AuthenSalt;
                loginForm.CustomErrorMessage = _locRM.GetString("LOGIN_CUSTOM_ERROR");
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    string msg = string.Format(_locRM.GetString("DIALOG_MSG_VOID_FORM"), _receipt.SerialNumber);
                    using (var voidForm = new VoidForm(msg))
                    {
                        if (voidForm.ShowDialog() == DialogResult.OK)
                        {
                            var target = Context.Receipts.FirstOrDefault(b => b.Id == _receipt.Id);
                            if (target != null)
                            {
                                target.IsVoid = true;
                                target.VoidAdmin = loginForm.SuccessUser.Username;
                                target.UpdateDate = DateTime.Now;
                                AdminLog log = new AdminLog
                                {
                                    EntryDate = DateTime.Now,
                                    UserName = loginForm.SuccessUser.Username,
                                    Action = "VoidReceipt",
                                    Detail = string.Format("Receipt:{0};Reason:{1}", _receipt.SerialNumber, voidForm.ReasonText)
                                };
                                Context.AdminLogs.Add(log);
                                Context.SaveChanges();
                                // Return product stock
                                if (voidForm.Restock)
                                {
                                    var receiptDetails = (from rd in Context.ReceiptDetails
                                                          where rd.SerialNumber == target.SerialNumber
                                                          select rd).ToList();
                                    foreach (var item in receiptDetails)
                                    {
                                        var product = (from p in Context.Products
                                                       where p.Id == item.ProductId
                                                       select p).SingleOrDefault();
                                        if (product != null)
                                        {
                                            product.Qty += item.Qty;
                                        }
                                        var zoneProd = (from zp in Context.ZoneProducts
                                                        join p in Context.Products on zp.ProductId equals p.Id
                                                        where zp.ZoneId == target.ZoneId && zp.ProductId == item.ProductId
                                                        && !zp.Inactive
                                                        select zp).SingleOrDefault();
                                        if (zoneProd != null)
                                        {
                                            zoneProd.Qty += item.Qty;
                                        }
                                    }
                                }
                                Context.SaveChanges();

                                OnPrintRequest(new PrintRequestEventArgs
                                {
                                    NumberOfCopy = 1,
                                    SerialNumber = _receipt.SerialNumber,
                                    Reprint = false
                                });
                                MessageBox.Show(_locRM.GetString("DIALOG_MSG_VOID_DONE"), _locRM.GetString("DIALOG_TITLE_VOID_RECEIPT"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                                searchButton_Click(this, null);
                            }
                            else
                            {
                                MessageBox.Show(_locRM.GetString("DIALOG_MSG_INTERNAL_ERROR"), _locRM.GetString("DIALOG_TITLE_VOID_RECEIPT"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void reprintButton_Click(object sender, EventArgs e)
        {
            if (_receipt == null) return;
            var users = GetUserPasswordInfos();
            using (var loginForm = new LoginForm(users, this.Icon))
            {
                loginForm.AuthenSalt = AuthenSalt;
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    OnPrintRequest(new PrintRequestEventArgs
                    {
                        NumberOfCopy = 1,
                        SerialNumber = _receipt.SerialNumber,
                        Reprint = true
                    });
                }
            }
        }

        private void fullReceiptButton_Click(object sender, EventArgs e)
        {
            if (_receipt == null) return;
            var users = GetUserPasswordInfos();
            using (var loginForm = new LoginForm(users, this.Icon))
            {
                loginForm.AuthenSalt = AuthenSalt;
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    var targetTax = Context.CustomerTaxes.Where(t => t.CustomerCode == _receipt.CustomerCode).FirstOrDefault();
                    using (var fullCustomerForm = new FullTaxForm(targetTax?.TaxName, targetTax?.TaxId, targetTax?.TaxAddress))
                    {
                        if (fullCustomerForm.ShowDialog() == DialogResult.OK)
                        {
                            if(targetTax != null)
                            {
                                targetTax.TaxName = fullCustomerForm.Customer;
                                targetTax.TaxId = fullCustomerForm.TaxId;
                                targetTax.TaxAddress = fullCustomerForm.Address;
                            }
                            OnPrintRequest(new PrintRequestEventArgs
                            {
                                NumberOfCopy = 1,
                                SerialNumber = _receipt.SerialNumber,
                                Reprint = false,
                                FullTax = true,
                                CustomerName = fullCustomerForm.Customer,
                                CustomerTax = fullCustomerForm.TaxId,
                                CustomerAddress = fullCustomerForm.Address
                            });
                        }
                    }
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        protected virtual void OnPrintRequest(PrintRequestEventArgs args)
        {
            var handler = PrintRequest;
            if (handler != null)
            {
                handler.Invoke(this, args);
            }
        }

        private List<UserPasswordInfo> GetUserPasswordInfos()
        {
            return (from a in Context.Accounts
                    join at in Context.AccountTypes on a.AccountType equals at.Id
                    where !a.Inactive && !at.Inactive && at.CanVoidReceipt
                    select new UserPasswordInfo
                    {
                        Username = a.Username,
                        Password = a.Password
                    }).ToList();
        }
    }

    public class PrintRequestEventArgs : EventArgs
    {
        public int NumberOfCopy { get; set; }
        public string SerialNumber { get; set; }
        public bool Reprint { get; set; }
        public bool FullTax { get; set; }
        public string CustomerTax { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
    }
}
