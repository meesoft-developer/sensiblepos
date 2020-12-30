using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SensiblePOS.Data;
using SensiblePOS.Models;
namespace SensiblePOS
{
    public partial class LogoutForm : Form
    {
        public event EventHandler<PrintSummaryEventArgs> PrintSummary;
        private SensiblePOSContext _context;
        private string _username;
        private string _slipLanguage = "TH";
        private string _stationName = "";
        private SaleLog _log = null;
        private List<Receipt> _receipts = null;
        private DateTime _fromDate = DateTime.Now;
        private DateTime _toDate = DateTime.Now;
        private decimal _total = 0;
        private string _cashPrint = "";
        private string _creditPrint = "";
        private string _promptpayPrint = "";
        private string _totalPrint = "";
        private ResourceManager _locRM = new ResourceManager("SensiblePOS.Resources.LogoutForm", typeof(LogoutForm).Assembly);
        public LogoutForm(SensiblePOSContext context, string username, string station, string slipLanguage)
        {
            InitializeComponent();
            _context = context;
            _username = username;
            _slipLanguage = slipLanguage;
            _stationName = station;
        }

        private void LogoutForm_Load(object sender, EventArgs e)
        {
            var targetUser = _context.Accounts.FirstOrDefault(a => a.Username == _username && !a.Inactive);
            if (targetUser != null)
            {
                userLabel.Text = string.Format("{0} {1}", targetUser.Firstname, targetUser.Lastname);

                // ดูว่าวันนี้เคยลงทะเบียนออกไปก่อนแล้วหรือยัง?
                var previousOut = _context.SaleLogs.Where(s => s.AccountId == targetUser.Id && s.EntryDate > DateTime.Now.Date && s.EntryDate < DateTime.Now).OrderByDescending(s => s.EntryDate).FirstOrDefault();
                DateTime start = previousOut != null ? previousOut.EntryDate : DateTime.Now.Date;

                var invoices = _context.Receipts.Where(r => r.EntryDate >= start && r.EntryDate <= DateTime.Now && r.Seller == _username && !r.IsVoid).ToList();
                _receipts = invoices;
                if (invoices.Count > 0)
                {
                    _total = invoices.Sum(i => i.Total);
                    var cashItems = invoices.Where(i => i.PaymentType == "cash").ToList();
                    var creditItems = invoices.Where(i => i.PaymentType == "credit").ToList();
                    var promptpayItems = invoices.Where(i => i.PaymentType == "promptpay").ToList();

                    var cash = cashItems.Sum(i => i.Total);
                    var credit = creditItems.Sum(i => i.Total);
                    var promptpay = promptpayItems.Sum(i => i.Total);

                    var from = invoices.OrderBy(i => i.EntryDate).Select(i => i.EntryDate).First();
                    var to = invoices.OrderByDescending(i => i.EntryDate).Select(i => i.EntryDate).First();
                    fromLabel.Text = from.ToString();
                    toLabel.Text = to.ToString();

                    _fromDate = from;
                    _toDate = to;
                    _cashPrint = cash.ToString("N2");
                    _creditPrint = credit.ToString("N2");
                    _promptpayPrint = promptpay.ToString("N2");
                    _totalPrint = _total.ToString("N2");

                    cashTextBox.Text = _cashPrint;
                    creditcardTextBox.Text = _creditPrint;
                    promptpayTextBox.Text = _promptpayPrint;
                    totalTextBox.Text = _totalPrint;

                    cashCountLabel.Text = $"{cashItems.Count} {_locRM.GetString("UNIT_NAME")}";
                    creditcardCountLabel.Text = $"{creditItems.Count} {_locRM.GetString("UNIT_NAME")}";
                    promptpayCountLabel.Text = $"{promptpayItems.Count} {_locRM.GetString("UNIT_NAME")}";
                    totalCountLabel.Text = $"{invoices.Count} {_locRM.GetString("UNIT_NAME")}";

                    _log = new SaleLog
                    {
                        EntryDate = DateTime.Now,
                        AccountId = targetUser.Id,
                        FromDate = from,
                        ToDate = to,
                        Cash = cash,
                        Credit = credit,
                        Promptpay = promptpay,
                        Total = _total,
                    };
                    savePerformanceCheckBox.Enabled = true;
                    printLinkLabel.Enabled = true;
                }
                else
                {
                    fromLabel.Text = start.ToString();
                    toLabel.Text = DateTime.Now.ToString();
                }
            }
        }

        private void printLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Show collected items.
            var datas = (from d in _context.ReceiptDetails
                           join h in _context.Receipts on d.SerialNumber equals h.SerialNumber
                           join z in _context.Zones on h.ZoneId equals z.Id
                           join p in _context.Products on d.ProductId equals p.Id into prod
                           from pd in prod.DefaultIfEmpty() 
                           where _receipts.Select(s => s.SerialNumber).ToList().Contains(d.SerialNumber)
                           select new 
                           {
                               Detail = d,
                               Product = (from prod in _context.Products
                                         where prod.Id == d.ProductId
                                         select prod).FirstOrDefault(),
                               Promo = d.IsDiscount ? (from prom in _context.Promotions
                                                       where prom.Id == d.PromotionId
                                                       select prom).FirstOrDefault() : null,
                               Qty = d.Qty,
                               TotalPrice = d.TotalPrice,
                               StationName = h.StationName,
                               ZoneName = z.Title,
                           }).ToList();

            var details = (from d in datas
                           select new CartItemInfo
                           {
                               SKU = d.Promo != null ? d.Promo.Code : d.Product != null ? d.Product.Sku : d.Detail.Sku,
                               Title = d.Promo != null ? d.Promo.Title : d.Product != null ? d.Product.Title : d.Detail.Sku,
                               Qty = d.Qty,
                               TotalPrice = d.TotalPrice,
                               StationName = d.StationName,
                               ZoneName = d.ZoneName,
                           }).GroupBy(d => new { d.ZoneName, d.StationName });
            
            string text = ""; 
            foreach (var g in details.OrderBy(a => a.Key.ZoneName).ThenBy(a => a.Key.StationName))
            {
                text += string.Format("\n{0}:{1}  ({2:N2})", g.Key.ZoneName, g.Key.StationName, g.Sum(a => a.TotalPrice).ToString("N2"));

                foreach (var d in g.GroupBy(s => s.SKU).OrderBy(a => a.Key))
                {
                    var first =  d.First();
                    string producName = (first != null) ? first.Title : d.Key;

                    if (producName.Length > 22)
                    {
                        producName = producName.Substring(0, 22);
                    }
                    else
                    {
                        producName = producName.PadRight(22);//28
                    }

                    text += string.Format("\n{0}{1}\t{2}", d.Sum(a => a.Qty).ToString("N0").PadRight(5), producName, d.Sum(a => a.TotalPrice).ToString("N2").PadLeft(10));
                }
            }
            var head = "";
            var tail = "";
            switch (_slipLanguage)
            {
                case "EN":
                    head = string.Format("\nUser: {0} \tStation:{1}", userLabel.Text, _stationName);
                    head += string.Format("\nTime:{0} ถึง:{1}", _fromDate.ToString("dd/MM/yy HH:mm"), _toDate.ToString("dd/MM/yy HH:mm"));
                    head += string.Format("\n====================================="); 
                    head += string.Format("\nCash:\t{0:N0}\t({1})", _cashPrint, cashCountLabel.Text);
                    head += string.Format("\nCreditCard:\t{0:N0}\t({1})", _creditPrint, creditcardCountLabel.Text);
                    head += string.Format("\nPromptpay:\t{0:N0}\t({1})", _promptpayPrint, promptpayCountLabel.Text);
                    head += string.Format("\n-------------------------------------");
                    head += string.Format("\nTotal:\t\t{0:N0}\t({1})", _totalPrint, totalCountLabel.Text);
                    head += string.Format("\n-------------------------------------");
                    tail = string.Format("\nPrinted: {0}", DateTime.Now.ToString("dd/MM/yy HH:mm"));
                    break;
                default:
                    head = string.Format("\nจนท: {0} \tStation:{1}", userLabel.Text, _stationName);
                    head += string.Format("\nเวลา:{0} ถึง:{1}", _fromDate.ToString("dd/MM/yy HH:mm"), _toDate.ToString("dd/MM/yy HH:mm"));
                    head += string.Format("\n=====================================");
                    head += string.Format("\nเงินสด:\t{0:N0}\t({1})", _cashPrint, cashCountLabel.Text);
                    head += string.Format("\nบัตรเครดิต:\t{0:N0}\t({1})", _creditPrint, creditcardCountLabel.Text);
                    head += string.Format("\nพร้อมเพย์:\t{0:N0}\t({1})", _promptpayPrint, promptpayCountLabel.Text);
                    head += string.Format("\n-------------------------------------");
                    head += string.Format("\nรวม:\t\t{0:N0}\t({1})", _totalPrint, totalCountLabel.Text);
                    head += string.Format("\n-------------------------------------");
                    tail = string.Format("\nพิมพ์เมื่อ: {0}", DateTime.Now.ToString("dd/MM/yy HH:mm"));
                    break;
            }
            text = head + text + tail;
            OnPrintRequest(new PrintSummaryEventArgs
            {
                Text = text
            });
        }

        private void canceButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (savePerformanceCheckBox.Checked && _log != null)
            {
                _log.Remarks = memoTextBox.Text;
                _context.SaleLogs.Add(_log);
                _context.SaveChanges();
                MessageBox.Show(_locRM.GetString("DIALOG_MSG_SEND_REPORT"), _locRM.GetString("DIALOG_TITLE_SEND_REPORT"), MessageBoxButtons.OK);
            }
            if (updateStockCheckBox.Checked)
            {
                UpdateStockLog();
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void UpdateStockLog()
        {
            UpdateProgressMsg("Update Stock...");
            progressLabel.Visible = true;

            // Create empty sheet for all products.
            UpdateProgressMsg("Build stock sheet...");
            string key = DateTime.Now.ToString("yyyyMMdd");
            var stockSheets = from sl in _context.StockLogs
                              where sl.StockKey == key && sl.Action == "SOLD"
                              select sl;
            var products = from p in _context.Products
                           where !p.Inactive
                           select new
                           {
                               Product = p,
                               Sheet = stockSheets.Where(s => s.ProductId == p.Id).FirstOrDefault()
                           };
            foreach (var p in products)
            {
                UpdateProgressMsg("Build stock sheet..." + p.Product.Sku);
                if (p.Sheet != null)
                {
                    p.Sheet.AdjustQty = p.Product.Qty;
                }
                else
                {
                    var log = new StockLog
                    {
                        StockKey = key,
                        EntryDate = DateTime.Now,
                        Action = "SOLD",
                        Qty = 0,
                        AdjustQty = p.Product.Qty,
                        ProductId = p.Product.Id,
                        Sku = p.Product.Sku,
                    };
                    _context.StockLogs.Add(log);
                }
            }
            _context.SaveChanges();

            UpdateProgressMsg("Update SOLD stock...");
            var stockOuted = (from d in _context.ReceiptDetails
                              join h in _context.Receipts on d.SerialNumber equals h.SerialNumber
                              where d.ProductId > 0 && h.EntryDate >= DateTime.Now.Date && !h.IsVoid
                              select d).AsEnumerable().GroupBy(d => d.ProductId).ToDictionary(d => d.Key, d => d.Sum(i => i.Qty));
            //Load created stock logs.
            string[] actions = new string[] { "SOLD" };
            var sheets = _context.StockLogs.Where(s => actions.Contains(s.Action) && s.StockKey == key).ToList();
            foreach (var so in stockOuted)
            {
                UpdateProgressMsg("Update SOLD stock..." + so.Key);
                var target = sheets.FirstOrDefault(s => s.ProductId == so.Key && s.Action == "SOLD");
                if (target != null)
                {
                    target.EntryDate = DateTime.Now;
                    target.Qty = so.Value;
                }
            }

            _context.SaveChanges();
            UpdateProgressMsg("DONE");
        }

        private void UpdateProgressMsg(string message)
        {
            this.Invoke(new EventHandler(delegate
            {
                progressLabel.Text = message;
                progressLabel.Update();
            }));
        }

        protected virtual void OnPrintRequest(PrintSummaryEventArgs args)
        {
            var handler = PrintSummary;
            if (handler != null)
            {
                handler.Invoke(this, args);
            }
        }
    }

    public class PrintSummaryEventArgs : EventArgs
    {
        public string Text { get; set; }
    }
}
