using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Extensions.Configuration;

using SensiblePOS.Backoffice;
using SensiblePOS.Data;
using SensiblePOS.LogIn;
using SensiblePOS.Models;
using SensiblePOS.Utilities;

namespace SensiblePOS
{
    public partial class MainForm : Form
    {
        private static readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        private SensiblePOSContext _context = null;
        private string _connectionString = "";
        private IConfiguration Configuration;
        private string _authenSalt = "";
        private string _currentUser = "Nobody";
        private string _stationName = "";
        private ExtendForm _extendForm = null;
        private List<ProductInfo> _commonProductInfos = new List<ProductInfo>();
        private List<string> _favoriteProducts = new List<string>();
        private List<ProductInfo> _favoriteList = new List<ProductInfo>();
        private List<ProductInfo> _cacheProductInfos = new List<ProductInfo>();
        private List<CartItemInfo> _currentCarts = new List<CartItemInfo>();
        private List<PromotionInfo> _currentPromotions = new List<PromotionInfo>();
        private Dictionary<int, List<CartItemInfo>> _promotionCartItems = new Dictionary<int, List<CartItemInfo>>();

        private CustomerInfo _currentCustomer = null;
        private Receipt _currentInvoice = null;
        private CreditCardIssuer _currentCreditIssuer = null;
        private string _lastInvoice = "";

        private string _closeTime = "24:00";
        private int _lateDay = -2;

        private bool _purchasable = false;

        // For pricetier advanc setting.
        private bool _isHoliday = false;
        private bool _isSecondHalf = false;

        // Server setting.
        private decimal _systemVat = 7.0m;
        private string _systemVatType = "include";
        private bool _systemStrictStock = true;
        private bool _systemServiceChargeEnable = false;
        private decimal _systemServiceCharge = 10.0m;
        private bool _currentCartHasServiceCharge = false;
        private bool _promptpayEnable = false;
        private string _promptpayId = "";

        private bool _queueEnable = false;

        private bool _skipRebuild = false;
        private bool _isPurchasing = false;

        private string _printHeader = "";
        private string _printTailer = "";
        private string _textForPrint = "";

        private ResourceManager _locRM = new ResourceManager("SensiblePOS.Resources.MainForm", typeof(MainForm).Assembly);

        public MainForm()
        {
            InitializeComponent();
            IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true);
            Configuration = builder.Build();
            _stationName = GetAppSetting<string>("StationName");
            _connectionString = Configuration.GetConnectionString("LocalDb");
            _context = new SensiblePOSContext(_connectionString);
            Configuration = builder.Build();
            LoadSystemSetting();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Show App version. 
            string version = Application.ProductVersion;
            Version versionItem = new Version(version);
            versionStatusLabel.Text = $"Version {versionItem.ToString(2)} build {versionItem.Build}";

            _lateDay = (-1) * GetAppSetting<int>("HistoryDay");

            /// login process..
            var users = (from a in _context.Accounts
                         join at in _context.AccountTypes on a.AccountType equals at.Id
                         where !a.Inactive && !at.Inactive && at.AccessClient
                         select new UserPasswordInfo
                         {
                             Id = a.Id,
                             Username = a.Username,
                             Password = a.Password,
                         }).ToList();

            bool isAuthorize = false;
            using (var loginForm = new LoginForm(users, this.Icon))
            {
                loginForm.AuthenSalt = _authenSalt;
                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    Application.Exit();
                }
                else
                {
                    int currentZone = GetCurrentZoneId();
                    _logger.Info("Loin with user: " + loginForm.SuccessUser.Username);
                    _currentUser = loginForm.SuccessUser.Username;
                    var authorizeForZone = _context.ZoneAccounts.FirstOrDefault(z => z.AccountId == loginForm.SuccessUser.Id
                        && z.ZoneId == currentZone && !z.Inactive);
                    if (authorizeForZone != null)
                    {
                        AccountActiveZone activeLog = new AccountActiveZone
                        {
                            AccountId = loginForm.SuccessUser.Id,
                            EntryDate = DateTime.Now,
                            IsExpired = false,
                            ZoneId = currentZone
                        };
                        _context.AccountActiveZones.Add(activeLog);
                        _context.SaveChanges();

                        isAuthorize = true;
                    }
                    else
                    {
                        MessageBox.Show(_locRM.GetString("DIALOG_MSG_UNAUTHORIZED"), _locRM.GetString("DIALOG_TITLE_AUTHORIZE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        customerPanel.Enabled = productPanel.Enabled = salePanel.Enabled = false;
                    }
                    this.Text += $" - (User: {_currentUser} MODE: SALE POINT)";
                    userStatusLabel.Text = $"User: {_currentUser}";
                }
            }

            if (isAuthorize)
            {
                previousReceiptLabel.Text = "";
                RefreshProductData();
                productTabControl.SelectedTab = GetAppSetting<List<string>>("FavoriteProducts") != null ? favoriteTabPage : productTabPage;
                cartItemInfoBindingSource.DataSource = _currentCarts;
                promotionInfoBindingSource.DataSource = _currentPromotions;

                customerCodeTextBox.Select();
                customerCodeTextBox.Focus();
                UpdatePaymentMethods();

                // Create secondary form.
                if (Screen.AllScreens.Length > 1)
                {
                    var timer = new System.Timers.Timer(1000);
                    // Hook up the Elapsed event for the timer. 
                    timer.Elapsed += Timer_Elapsed;
                    timer.AutoReset = false;
                    timer.Start();
                }
                BuildGridView();
            }

            UpdateStatusText();
            this.WindowState = FormWindowState.Maximized;
        } 

        private void BuildGridView()
        {
            DataGridViewCellStyle priceGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle()
            {
                Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight,
                Format = "N2",
                NullValue = "0"
            };

            var productSkuTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SKU",
                HeaderText = "SKU",
                MinimumWidth = 80,
                Width = 120,
                ReadOnly = true,
            };
            var productTitleTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Title",
                HeaderText = "สินค้า",
                MinimumWidth = 8,
                AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true,
            };
            var productPriceTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "ราคา",
                MinimumWidth = 80,
                DefaultCellStyle = priceGridViewCellStyle,
                ReadOnly = true,
            };
            productGridView.AutoGenerateColumns = false;
            productGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                productSkuTextBoxColumn,
                productTitleTextBoxColumn,
                productPriceTextBoxColumn});
            productGridView.DataSource = commonInfoBindingSource;

            // Favorite Gridview.
            var favoriteSkuTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SKU",
                HeaderText = "SKU",
                MinimumWidth = 80,
                Width = 120,
                ReadOnly = true,
            };
            var favoriteTitleTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Title",
                HeaderText = "สินค้า",
                MinimumWidth = 8,
                AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true,
            };
            var favoritePriceTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "ราคา",
                MinimumWidth = 80,
                ReadOnly = true,
            };
            favoriteGridView.AutoGenerateColumns = false;
            favoriteGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                favoriteSkuTextBoxColumn,
                favoriteTitleTextBoxColumn,
                favoritePriceTextBoxColumn});
            favoriteGridView.DataSource = favoriteInfoBindingSource;

            // 
            // Cart gridview.
            // 
            var cartDelButtomColumn = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Text = "X",
                MinimumWidth = 40,
                Width = 40,
                UseColumnTextForButtonValue = true,
            };
            var cartSkuTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SKU",
                HeaderText = "SKU",
                MinimumWidth = 8,
                Width = 70,
                ReadOnly = true,
                Visible = false,
            };
            var cartTitleTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Title",
                HeaderText = "สินค้า",
                MinimumWidth = 8,
                AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            };
            var cartUnitPriceTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UnitPrice",
                HeaderText = "ต่อหน่วย",
                DefaultCellStyle = priceGridViewCellStyle,
                MinimumWidth = 8,
                Width = 80,
                ReadOnly = true,
            };
            var cartQtyTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Qty",
                HeaderText = "จำนวน",
                MinimumWidth = 8,
                Width = 70
            };
            var cartSubTotalPriceTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SubTotalPrice",
                HeaderText = "รวม",
                MinimumWidth = 8,
                DefaultCellStyle = priceGridViewCellStyle,
                Width = 80,
                Visible = false,
            };
            var cartDiscountTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Discount",
                HeaderText = "ส่วนลด",
                MinimumWidth = 8,
                DefaultCellStyle = priceGridViewCellStyle,
                Width = 80,
                Visible = false,
            };
            var cartTotalPriceTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalPrice",
                HeaderText = "ราคา",
                MinimumWidth = 8,
                DefaultCellStyle = priceGridViewCellStyle,
                Width = 90,
                ReadOnly = true,
            };
            cartDataGridView.AutoGenerateColumns = false;
            cartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                cartDelButtomColumn,
                cartSkuTextBoxColumn,
                cartTitleTextBoxColumn,
                cartUnitPriceTextBoxColumn,
                cartQtyTextBoxColumn,
                cartSubTotalPriceTextBoxColumn,
                cartDiscountTextBoxColumn,
                cartTotalPriceTextBoxColumn });
            cartDataGridView.DataSource = this.cartItemInfoBindingSource;

            // 
            // Promotion gridview.
            // 
            var promoTitleTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Title",
                HeaderText = "ชื่อ",
                MinimumWidth = 100,
                Width = 150,
                ReadOnly = true,
            };
            var promoDescriptionTexBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "คำอธิบาย",
                AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            }; 
            var promoDcTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ExactDC",
                HeaderText = "บาท",
                DefaultCellStyle = priceGridViewCellStyle,
                MinimumWidth = 40,
                Width = 78,
                ReadOnly = true,
            }; 
            var promoMeetConditionCheckBoxColumn = new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "MeetCondition",
                HeaderText = "ใช้งานได้",
                MinimumWidth = 40,
                Width = 78,
                ReadOnly = true,
            };
            promotionGridView.AutoGenerateColumns = false;
            promotionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                promoTitleTextBoxColumn,
                promoDescriptionTexBoxColumn,
                promoDcTextBoxColumn,
                promoMeetConditionCheckBoxColumn});
            promotionGridView.DataSource = this.promotionInfoBindingSource;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Invoke(new EventHandler(delegate
            {
                var thisScreen = Screen.FromControl(this);
                var otherScreen = Screen.AllScreens.Where(s => s != thisScreen).FirstOrDefault();
                if (otherScreen != null)
                {
                    _extendForm = new ExtendForm();
                    _extendForm.Location = otherScreen.WorkingArea.Location;
                    _extendForm.Show();
                }
            }));
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                int zoneId = GetCurrentZoneId();
                var logs = from l in _context.AccountActiveZones
                           join a in _context.Accounts on l.AccountId equals a.Id
                           where a.Username == _currentUser && !a.Inactive
                           && !l.IsExpired && l.ZoneId == zoneId
                           select l;
                foreach (var l in logs)
                {
                    l.ExpireDate = DateTime.Now;
                    l.IsExpired = true;
                }
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Cannot update zone inactive.");
            }
        }

        #region Gridview & Datasource events.

        private void cartDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var current = cartItemInfoBindingSource.Current as CartItemInfo;
            if (current != null && !current.Removable)
            {
                e.Cancel = true;
            }
        }

        private void cartDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) // Del button
            {
                var current = cartItemInfoBindingSource.Current as CartItemInfo;
                if (current != null && current.Removable)
                {
                    cartItemInfoBindingSource.RemoveCurrent();
                }
            }
        }

        private void cartDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var current = cartItemInfoBindingSource.Current as CartItemInfo;
            if (current != null)
            {
                if (current.Qty <= 0) current.Qty = 1;

                current.SubTotalPrice = current.UnitPrice * current.Qty;
                current.Discount = 0;
                current.TotalDeposit = current.DepositValue * current.Qty;
                current.TotalPrice = current.UnitPrice * current.Qty;
                RefreshSummary();
            }
        }

        private void cartDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void favoriteGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectItem = favoriteInfoBindingSource.Current as ProductInfo;
            if (selectItem != null)
            {
                AddProductToCart(selectItem);
            }
        }

        private void favoriteGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    favoriteInfoBindingSource.Position = rowSelected;
                }
            }
        }

        private void favoriteGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void productGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectItem = commonInfoBindingSource.Current as ProductInfo;
            if (selectItem != null)
            {
                AddProductToCart(selectItem);
            }
        }

        private void productGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    commonInfoBindingSource.Position = rowSelected;
                }
            }
        }

        private void cartItemInfoBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (_extendForm != null && _currentCarts.Count > 0)
            {
                // If e.NewIndex -1 mean list change by add otherwise list was edit.
                var lastest = e.NewIndex >= 0 ? _currentCarts[e.NewIndex] : _currentCarts.Last();
                if (lastest != null)
                {
                    _extendForm.UpdateCart(lastest.Title, lastest.UnitPrice);
                }
            }
            //update 
            RefreshSummary();
            if (_currentCartHasServiceCharge)
            {
                purchaseButton.Text = _locRM.GetString("LABEL_CALCULATE");
                _purchasable = false;
            }
        }

        #endregion

        private void addFavoriteMenu_Click(object sender, EventArgs e)
        {
            ProductInfo selected = null;
            if (productTabControl.SelectedTab == productTabPage)
            {
                selected = commonInfoBindingSource.Current as ProductInfo;
            }

            if (selected != null)
            {
                string code = selected.SKU;

                if (!_favoriteProducts.Contains(code))
                {
                    _favoriteProducts.Add(code);
                    _favoriteList.Add(selected);
                    SortFavoriteItem();
                }
            }
        }

        private void removeFavoriteMenu_Click(object sender, EventArgs e)
        {
            if (productTabControl.SelectedTab == favoriteTabPage)
            {
                var selected = favoriteInfoBindingSource.Current as ProductInfo;
                if (selected != null)
                {
                    var code = selected.SKU;
                    _favoriteProducts.Remove(code);
                    _favoriteList.Remove(selected);
                    favoriteInfoBindingSource.DataSource = _favoriteList;
                    favoriteInfoBindingSource.ResetBindings(false);
                }
            }
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string val = (string)categoryComboBox.SelectedValue;
            var items = categoryComboBox.SelectedIndex == 0 ? _commonProductInfos : _commonProductInfos.Where(p => p.Category == val).ToList();
            commonInfoBindingSource.DataSource = items;
            commonInfoBindingSource.ResetBindings(false);
            productCountLabel.Text = string.Format("{0} รายการ", items.Count);
        }

        private void paymentTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)paymentTypeComboBox.SelectedValue == "credit")
            {
                var creditcardIssuers = _context.CreditCardIssuers.ToList();
                var selectableItems = (from c in creditcardIssuers
                                       orderby c.Title
                                       select new SelectableItemInfo
                                       {
                                           Code = c.Code,
                                           Name = c.Title,
                                           Description = c.Description
                                       }).ToList();
                using (SelectCardIssuerForm selectForm = new SelectCardIssuerForm(selectableItems))
                {
                    if (selectForm.ShowDialog() == DialogResult.OK)
                    {
                        if (selectForm.SelectedItem != null)
                        {
                            selectPaymentLabel.Text = $" - {selectForm.SelectedItem.Name}";
                            //creditCardRadioButton.Text = "บัตรเครดิต - " + selectForm.SelectedItem.Name;
                            _currentCreditIssuer = creditcardIssuers.FirstOrDefault(c => c.Code == selectForm.SelectedItem.Code);
                        }
                    }
                    else
                    {
                        paymentTypeComboBox.SelectedIndex = 0;
                        //cashRadioButton.Checked = true;
                        _currentCreditIssuer = null;
                        //creditCardRadioButton.Checked = false;
                    }
                }
            }
            else
            {
                _currentCreditIssuer = null;
                selectPaymentLabel.Text = "";
            }
            UpdatePurchaseButtonWithPromotion();
        }

        private void addPromoButton_Click(object sender, EventArgs e)
        {
            using (SelectPromotionForm selectForm = new SelectPromotionForm())
            {
                selectForm.Context = _context;
                if (selectForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var selectPro = selectForm.SelecedtPromotion;
                    selectPro.Index = _currentPromotions.Count + 1;
                    _currentPromotions.Add(selectPro);
                    ProcessCurrentAddPromotion(selectPro);
                    cartItemInfoBindingSource.ResetBindings(false);
                    promotionInfoBindingSource.DataSource = _currentPromotions;
                    promotionInfoBindingSource.ResetBindings(false);
                    UpdatePurchaseButtonWithPromotion();
                }
            };
        }

        private void deletePromoButton_Click(object sender, EventArgs e)
        {
            var selected = promotionInfoBindingSource.Current as PromotionInfo;
            if (selected != null)
            {
                if (_promotionCartItems.ContainsKey(selected.Index))
                {
                    foreach (var cartItem in _promotionCartItems[selected.Index])
                    {
                        _currentCarts.Remove(cartItem);
                    }
                    cartItemInfoBindingSource.ResetBindings(false);
                    _promotionCartItems.Remove(selected.Index);
                }
                promotionInfoBindingSource.RemoveCurrent();
                _currentPromotions.Remove(selected);
                // Reset all product in cart with dc.
                var itemWithDcs = _currentCarts.Where(c => c.EffectPromotionId > 0 && !c.IsDC && !c.IsFine && !c.IsPaid).ToList();
                foreach (var item in itemWithDcs)
                {
                    item.EffectPromotionId = 0;
                    item.TotalPrice = item.SubTotalPrice;
                    item.Discount = 0;
                }
                _currentCarts.RemoveAll(c => c.IsDC);
                cartItemInfoBindingSource.ResetBindings(false);
                UpdatePurchaseButtonWithPromotion();
            }
        }

        private void clearLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show(_locRM.GetString("DIALOG_MSG_CLEAR_ORDERS"), _locRM.GetString("DIALOG_TITLE_CLEAR_ORDERS"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                _currentCarts.Clear();
                _currentCartHasServiceCharge = false;
                cartItemInfoBindingSource.ResetBindings(false);

                _currentPromotions.Clear();
                promotionInfoBindingSource.ResetBindings(false);
            }
        }

        private void customerCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                QueryCustomer();
            }
        }

        private void scanBarcodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                var code = scanBarcodeTextBox.Text;
                if (!string.IsNullOrEmpty(code))
                {
                    var target = _cacheProductInfos.Where(p => p.SKU == code).FirstOrDefault();
                    if (target != null)
                    {
                        AddProductToCart(target);
                    }
                    else
                    {
                        MessageBox.Show(_locRM.GetString("DIALOG_MSG_PRODUCT_NOT_FOUND"), _locRM.GetString("DIALOG_TITLE_SEARCH_PRODUCT"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                e.Handled = false;
                scanBarcodeTextBox.Text = "";
                return;
            }
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            _isPurchasing = true;
            if (_currentCarts.Count == 0)
            {
                _isPurchasing = false;
                return;
            }
            _context = GetFreshContext();
            if (!_purchasable)
            {
                RefreshSummary(true);
                _skipRebuild = true;
                cartItemInfoBindingSource.ResetBindings(false);
                promotionInfoBindingSource.ResetBindings(false);
                //purchaseButton.ImageKey = "money_dollar.png";
                purchaseButton.Text = _locRM.GetString("LABEL_PAY");
                _purchasable = true;
                purchaseButton.Select();
                _isPurchasing = false;
                return;
            }

            string remarksText = "";
            if (!string.IsNullOrEmpty(customerCodeTextBox.Text))
            {
                if (_currentCustomer == null || (_currentCustomer.DefaultTag != customerCodeTextBox.Text))
                {
                    _currentCustomer = CreateNewCustomer();
                }
                else
                {
                    var targetCust = _context.Customers.FirstOrDefault(c => c.Id == _currentCustomer.Id);
                    if (targetCust != null)
                    {
                        if (!string.IsNullOrEmpty(firstnameTextBox.Text))
                        {
                            targetCust.FirstName = firstnameTextBox.Text;
                        }

                        targetCust.LastName = lastnameTextBox.Text;
                        if (!string.IsNullOrEmpty(telTextBox.Text))
                        {
                            targetCust.Phone = telTextBox.Text;
                        }

                        if (!string.IsNullOrEmpty(memoTextBox.Text))
                        {
                            targetCust.Comment = memoTextBox.Text;
                        }

                        _context.SaveChanges();

                        _currentCustomer = GetCustomerInfo("code", customerCodeTextBox.Text);
                    }
                }
            }
            if (_currentInvoice == null)
            {
                _context = GetFreshContext();
                var summary = GetCartSummary(true);
                var selectedPaymentMethod = (string)paymentTypeComboBox.SelectedValue;
                if (selectedPaymentMethod == "promptpay")
                {
                    if (_extendForm == null)
                    {
                        MessageBox.Show("ไม่สามารถแสดงพร้อมเพย์บนจอที่สองได้", "ชำระด้วยพร้อมเพย์", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    _extendForm.ShowPromptpayBarcode(_promptpayId, summary.Total);
                    if (MessageBox.Show("หากได้รับเงินแล้วให้กด 'ตกลง'", "ชำระด้วยพร้อมเพย์", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    {
                        _extendForm.CancelPromptpayBarcode();
                        return;
                    }
                    remarksText += $"Promptpay:{_promptpayId}";
                }
                var zoneId = GetCurrentZoneId();
                Receipt invoice = null;
                if (selectedPaymentMethod == "credit" || selectedPaymentMethod == "promptpay")
                {
                    invoice = new Receipt
                    {
                        EntryDate = DateTime.Now,
                        CustomerCode = _currentCustomer != null ? _currentCustomer.Code : "000000",
                        SerialNumber = "",
                        SubTotal = summary.SubTotal,
                        Discount = summary.Discount,
                        Vat = summary.Vat,
                        VatType = _systemVatType,
                        VatPercent = summary.VatPercent,
                        Total = summary.Total,
                        Payment = summary.Total,
                        Change = 0,
                        PaymentType = selectedPaymentMethod,
                        CardIssuer = _currentCreditIssuer != null ? _currentCreditIssuer.Id : 0,
                        Seller = _currentUser,
                        IsVoid = false,
                        ZoneId = zoneId,
                        StationName = _stationName,
                        UpdateDate = DateTime.Now,
                        Remarks = remarksText
                    };
                    _context.Receipts.Add(invoice);
                    _context.SaveChanges();
                }
                else
                {
                    using (CashForm billForm = new CashForm(summary))
                    {
                        if (billForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            invoice = new Receipt()
                            {
                                EntryDate = DateTime.Now,
                                CustomerCode = _currentCustomer != null ? _currentCustomer.Code : "000000",
                                SerialNumber = "",
                                SubTotal = billForm.Payment.SubTotal,
                                Discount = billForm.Payment.Discount,
                                Vat = summary.Vat,
                                VatType = _systemVatType,
                                VatPercent = summary.VatPercent,
                                Total = billForm.Payment.Total,
                                Payment = billForm.Payment.Payment,
                                Change = billForm.Payment.Change,
                                PaymentType = "cash",
                                CardIssuer = 0,
                                Seller = _currentUser,
                                IsVoid = false,
                                ZoneId = zoneId,
                                StationName = _stationName,
                                UpdateDate = DateTime.Now,
                                Remarks = remarksText
                            };
                            _context.Receipts.Add(invoice);
                            _context.SaveChanges();
                        }
                        else
                        {
                            _isPurchasing = false;
                            return;
                        }
                    }
                }
                _isPurchasing = false;
                if (invoice == null) return;
                long queue = 0;
                if (_queueEnable)
                {
                    // find for this zone.
                    var targetQueue = _context.ZoneQueues.Where(q => q.ZoneId == zoneId && !q.Inactive).FirstOrDefault();
                    if (targetQueue != null)
                    {
                        targetQueue.CurrentQueue++;
                        _context.SaveChanges();
                        queue = targetQueue.CurrentQueue;
                    }
                }
                invoice.SerialNumber = string.Format("{0:0000000000}", invoice.Id);
                invoice.QueueNumber = queue;
                if (_currentCustomer != null)
                {
                    // update last receipt for customer.
                    var tCustomer = _context.Customers.FirstOrDefault(c => c.Id == _currentCustomer.Id);
                    if (tCustomer != null)
                    {
                        tCustomer.LastReceipt = invoice.SerialNumber;
                    }
                }
                // Create invoice detail.
                int index = 1;
                foreach (var p in _currentCarts)
                {
                    var invoiceDetail = new ReceiptDetail
                    {
                        SerialNumber = invoice.SerialNumber,
                        ProductId = p.ProductId,
                        Sku = p.SKU,
                        UnitPrice = p.UnitPrice,
                        SubTotal = p.SubTotalPrice,
                        Discount = p.Discount,
                        PromotionId = p.EffectPromotionId,
                        IsDiscount = p.IsDC,
                        TotalPrice = p.TotalPrice,
                        OrderIndex = index,
                        Qty = Convert.ToInt32(p.Qty),
                        Remarks = p.Remarks,
                        StockUpdated = p.IsStockUpdated,
                    };
                    _context.ReceiptDetails.Add(invoiceDetail);

                    index++;
                }
                _context.SaveChanges();
                if (_extendForm != null)
                {
                    _extendForm.ShowPaidbill(invoice.PaymentType, invoice.Payment, invoice.Change);
                }
                _context = GetFreshContext();
                _currentInvoice = invoice;

                LogPromotionUsage(invoice.SerialNumber);

                lastReceiptStatusLabel.Text = string.Format("Last Receipt: {0}", invoice.SerialNumber);
                // Print Slip
                if (!GetAppSetting<bool>("SkipPrintNonPayment") || invoice.SubTotal != 0)
                {
                    purchaseButton.Enabled = false;
                    int numberOfCopy = GetAppSetting<int>("NumberOfSlip");
                    PrintSlip(invoice.SerialNumber, numberOfCopy, false);
                }
            }
            _context.SaveChanges();

            bool forceUpdateProduct = false;
            UpdateRealTimeStock(_currentInvoice.SerialNumber, out forceUpdateProduct);
            if (!_systemStrictStock && forceUpdateProduct) forceUpdateProduct = false;
            _lastInvoice = _currentInvoice.SerialNumber;
            _currentInvoice = null;

            // Completed.
            RefreshProductDataCore(forceUpdateProduct);
            ClearScreen();
        }

        private void optionButton_Click(object sender, EventArgs e)
        {
            using (var optionForm = new OptionForm(GetFreshContext(), _currentUser, _authenSalt))
            {
                if (optionForm.ShowDialog() == DialogResult.OK)
                {
                    switch (optionForm.Selected)
                    {
                        case OptionCommand.FindReceipt:
                            using (var findReceiptForm = new FindReceiptForm(_lastInvoice))
                            {
                                findReceiptForm.Context = _context = GetFreshContext();
                                findReceiptForm.AuthenSalt = _authenSalt;
                                findReceiptForm.PrintRequest += findReceiptForm_PrintRequest;
                                findReceiptForm.ShowDialog();
                            }
                            break;
                        case OptionCommand.ProductForm:
                            using (var productForm = new ProductForm(GetFreshContext()))
                            {
                                productForm.ShowDialog();
                            }
                            break;
                        case OptionCommand.PromotionForm:
                            using (var promoForm = new PromotionForm(GetFreshContext()))
                            {
                                promoForm.ShowDialog();
                            }
                            break;
                        case OptionCommand.AccountForm:
                            using (var userForm = new UserForm(GetFreshContext(), _authenSalt, _currentUser))
                            {
                                userForm.ShowDialog();
                            }
                            break;
                        case OptionCommand.ReportForm:
                            using (var reportForm = new ReportForm(GetFreshContext()))
                            {
                                reportForm.ShowDialog();
                            }
                            break;
                        case OptionCommand.SystemForm:
                            using (var systemForm = new SystemForm(GetFreshContext()))
                            {
                                systemForm.ShowDialog();
                            }
                            break;
                    }
                }
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            var slipLanguage = GetAppSetting<string>("SlipLanguage");
            using (var reportSale = new LogoutForm(GetFreshContext(), _currentUser, _stationName, slipLanguage))
            {
                reportSale.PrintSummary += ReportSale_PrintSummary;
                if (reportSale.ShowDialog() == DialogResult.OK)
                {
                    _logger.Info("Logoff of user: " + _currentUser);
                    Application.Exit();
                }
                else
                {
                    reportSale.PrintSummary -= ReportSale_PrintSummary;
                }
            }
        }

        private void ReportSale_PrintSummary(object sender, PrintSummaryEventArgs e)
        {
            SendToPrint(e.Text, 1, $"summary:{_currentUser}:{DateTime.Now.ToString("yyyyMMdd_HHmmss")}");
        }

        private void LoadSystemSetting()
        {
            var systems = _context.SystemInfos.ToDictionary(s => s.Name, s => s.Value);
            // Load system salt.
            _authenSalt = GetSystemConfiguration<string>(systems, "AUTHEN_SALT", "");
            if (string.IsNullOrEmpty(_authenSalt))
            {
                // System salt was reset or first time use.
                // Regenerate salt then create all user's password as '0000'.
                _authenSalt = Guid.NewGuid().ToString("N");
                var newSalt = new SystemInfo
                {
                    Name = "AUTHEN_SALT",
                    Value = _authenSalt
                };
                _context.SystemInfos.Add(newSalt);
                var existUsers = _context.Accounts.Where(a => !a.Inactive);
                foreach (var usr in existUsers)
                {
                    usr.Password = AuthenTools.GetPasswordHash(usr.Username, "0000", _authenSalt);
                }
                _context.SaveChanges();
            }
            _systemServiceChargeEnable = GetSystemConfiguration<bool>(systems, "SERVICE_CHARGE_ENABLE", false);
            _systemServiceCharge = GetSystemConfiguration<decimal>(systems, "SERVICE_CHARGE", 10.0m);
            _systemVat = GetSystemConfiguration<decimal>(systems, "VAT", 10.0m);
            _systemVatType = GetSystemConfiguration<string>(systems, "VAT_TYPE", "include");
            _systemStrictStock = GetSystemConfiguration<bool>(systems, "STRICT_STOCK", true);
            _printHeader = GetSystemConfiguration<string>(systems, "RECEIPT_HEADER", "");
            _printTailer = GetSystemConfiguration<string>(systems, "RECEIPT_TAILER", "");
            _promptpayEnable = GetSystemConfiguration<bool>(systems, "PROMPTPAY_ENABLE", false);
            _promptpayId = GetSystemConfiguration<string>(systems, "PROMPTPAY_ID", "");
            _queueEnable = GetSystemConfiguration<bool>(systems, "QUEUE_ENABLE", false);
        }

        private void RefreshSummary(bool validPromotion = false)
        {
            // Remove Relate Promotions then rebuild again.
            if (!_skipRebuild)
            {
                if (_context != null)
                {
                    _currentPromotions = _currentPromotions.Where(p => p.ReferenceId == 0).ToList();
                }
            }

            var summary = GetCartSummary(validPromotion);
            summaryDescriptionLabel.Text = string.Format(_locRM.GetString("LABEL_TOTAL_PRODUCTS"), summary.ItemQty);
            bool isFinal = validPromotion;
            subtotalLabel.Text = summary.SubTotal.ToString("N2");
            discountLabel.Text = summary.Discount.ToString("N2");
            totalLabel.Text = string.Format("{0:N2}", summary.Total);
            if (_extendForm != null)
            {
                _extendForm.UpdateSummary(summary.ItemQty, summary.Total, isFinal);
            }
            UpdatePurchaseButtonWithPromotion();
            _skipRebuild = false;
        }

        private PaymentSummaryInfo GetCartSummary(bool validatePromotion = false)
        {
            if (_currentCarts.Count == 0 && _currentPromotions.Count == 0)
            {
                return new PaymentSummaryInfo();
            }

            var subTotal = _currentCarts.Where(c => !c.IsPaid).Sum(c => c.SubTotalPrice);
            decimal discount = 0;
            if (validatePromotion)
            {
                // For recalculate must reset all effectpromotionId to 0.
                // and also delete all dc item.
                foreach (var item in _currentCarts.Where(c => !c.IsPaid))
                {
                    item.EffectPromotionId = 0;
                    item.EffectByPromotionQty = 0;
                }
                _currentCarts.RemoveAll(c => c.IsDC);
                _currentCarts.RemoveAll(c => c.IsFromTempPromotion);

                foreach (var pro in _currentPromotions.Where(p => !p.HasCondition).OrderByDescending(p => p.EffectProductId).OrderBy(p => p.HasAttachProduct))
                {
                    pro.MeetCondition = false;
                    //var previousDC = discount;
                    decimal exactDc = 0;
                    if (pro.PercentDC > 0)
                    {
                        if (pro.EffectProductId != 0)
                        {
                            var targetPs = _currentCarts.Where(c => c.ProductId == pro.EffectProductId && (c.EffectPromotionId == 0 || (c.EffectPromotionId > 0 && c.EffectByPromotionQty < c.Qty)) && c.PromotionEffect && !c.IsDC && !c.IsFine && !c.IsPaid).ToList();
                            if (targetPs.Count > 0)
                            {
                                var totalQty = targetPs.Sum(c => c.Qty);
                                //var totalQty = targetPs.Sum(c => c.Qty - c.EffectByPromotionQty);

                                //bool seperateDcItemReq = false;
                                decimal totalDC = 0;
                                /// กรณีเจาะจงสินค้า จะใช้แค่จำนวนเป้นตัวกำหนดเท่านั้น MaximumDC จะไม่มีผล
                                if (totalQty > pro.LimitedProductQty)
                                {
                                    var evalDC = targetPs.Sum(c => c.SubTotalPrice * (pro.PercentDC / 100));
                                    decimal qtyCount = 0;
                                    bool isServiceChargeSupport = false;
                                    foreach (var p in targetPs)
                                    {
                                        isServiceChargeSupport = p.ServiceChargeSupported;
                                        p.EffectPromotionId = pro.Id;
                                        if (qtyCount < pro.LimitedProductQty)
                                        {
                                            var mulQty = p.Qty;
                                            if (qtyCount + p.Qty > pro.LimitedProductQty)
                                            {
                                                mulQty = pro.LimitedProductQty - qtyCount;
                                            }
                                            totalDC += p.UnitPrice * mulQty * (pro.PercentDC / 100);
                                            qtyCount += mulQty;
                                            p.EffectByPromotionQty += Convert.ToInt32(mulQty);
                                        }
                                    }
                                    var dcItem = new CartItemInfo
                                    {
                                        SubTotalPrice = 0,
                                        Discount = totalDC,
                                        TotalPrice = 0 - totalDC,
                                        IsDC = true,
                                        IsFine = false,
                                        PromotionEffect = false,
                                        ProductId = pro.Id,
                                        SKU = string.Format("DC_{0:0000}", pro.Id),
                                        Title = string.Format(_locRM.GetString("ITEM_DISCOUNT_TITLE"), pro.Title),
                                        ItemType = _locRM.GetString("DISCOUNT_TYPE"),
                                        UnitPrice = 0,
                                        Qty = 1,
                                        UnitName = _locRM.GetString("UNIT_NAME"),
                                        Removable = false,
                                        ServiceChargeSupported = isServiceChargeSupport,
                                        Remarks = string.Format(_locRM.GetString("REMARK_DISCOUNT_TYPE_1"), pro.LimitedProductQty),
                                    };
                                    _currentCarts.Add(dcItem);
                                }
                                else
                                {
                                    // จ.น. น้อยกว่าสิทธ์โปรโมชั่น
                                    // Apply ส่วนลดแต่ละรายการได้เลย
                                    foreach (var p in targetPs)
                                    {
                                        var dc = (p.UnitPrice * (pro.PercentDC / 100)) * p.Qty;
                                        p.EffectPromotionId = pro.Id;
                                        p.Discount = dc;
                                        p.TotalPrice = p.SubTotalPrice - dc;
                                        p.EffectByPromotionQty = p.Qty;
                                        totalDC += dc;
                                    }
                                }

                                exactDc = totalDC;
                                discount += totalDC;
                            }
                        }
                        else
                        {
                            // DC all item 
                            decimal totalDC = 0;
                            bool isServiceChargeSupport = false;
                            var effectCartItems = _currentCarts.Where(c => c.EffectPromotionId == 0 && c.PromotionEffect && !c.IsDC && !c.IsFine && !c.IsPaid).ToList();
                            foreach (var c in effectCartItems)
                            {
                                isServiceChargeSupport = c.ServiceChargeSupported;
                                var dc = c.SubTotalPrice * (pro.PercentDC / 100);
                                c.EffectPromotionId = pro.Id;
                                c.Discount = dc;
                                c.TotalPrice = c.SubTotalPrice - dc;
                                totalDC += dc;
                            }
                            if (pro.MaximumDC > 0 && totalDC > pro.MaximumDC)
                            {
                                // กรณีส่วนลดไม่เป็นตามที่ควรเป้นให้ reset ค่ากลับเป็นค่าเดิมแล้วแจ้งส่วนลดแบบรวม.
                                totalDC = pro.MaximumDC;
                                foreach (var c in effectCartItems)
                                {
                                    c.Discount = 0;
                                    c.TotalPrice = c.SubTotalPrice;
                                }
                                var dcItem = new CartItemInfo
                                {
                                    SubTotalPrice = 0,
                                    Discount = totalDC,
                                    TotalPrice = 0 - totalDC,
                                    IsDC = true,
                                    IsFine = false,
                                    PromotionEffect = false,
                                    ProductId = pro.Id,
                                    SKU = string.Format("DC_{0:0000}", pro.Id),
                                    Title = string.Format(_locRM.GetString("ITEM_DISCOUNT_TITLE"), pro.Title),
                                    ItemType = _locRM.GetString("DISCOUNT_TYPE"),
                                    UnitPrice = 0,
                                    Qty = 1,
                                    UnitName = _locRM.GetString("UNIT_NAME"),
                                    Removable = false,
                                    ServiceChargeSupported = isServiceChargeSupport,
                                    Remarks = _locRM.GetString("REMARK_DISCOUNT_TYPE_2"),
                                };
                                _currentCarts.Add(dcItem);
                            }
                            exactDc = totalDC;
                            discount += totalDC;// subTotal * (pro.PercentDC / 100);
                        }
                    }
                    else if (pro.ValueDC > 0)
                    {
                        if (pro.EffectProductId > 0)
                        {
                            var targetPs = _currentCarts.Where(c => c.ProductId == pro.EffectProductId && (c.EffectPromotionId == 0 || (c.EffectPromotionId > 0 && c.EffectByPromotionQty < c.Qty)) && c.PromotionEffect && !c.IsDC && !c.IsFine && !c.IsPaid).ToList();
                            //if (targetPs != null)
                            if (targetPs.Count > 0)
                            {
                                bool isServiceChargeSupport = false;
                                var totalQty = targetPs.Sum(c => c.Qty);
                                decimal totalDC = 0;
                                /// กรณีเจาะจงสินค้า จะใช้แค่จำนวนเป้นตัวกำหนดเท่านั้น MaximumDC จะไม่มีผล
                                if (totalQty > pro.LimitedProductQty)
                                {
                                    totalDC = pro.ValueDC * pro.LimitedProductQty;
                                    decimal qtyCount = 0;
                                    //foreach (var p in targetPs)
                                    //{
                                    //    p.EffectPromotionId = pro.Id;
                                    //}

                                    foreach (var p in targetPs)
                                    {
                                        isServiceChargeSupport = p.ServiceChargeSupported;
                                        p.EffectPromotionId = pro.Id;
                                        if (qtyCount < pro.LimitedProductQty)
                                        {
                                            var mulQty = p.Qty;
                                            if (qtyCount + p.Qty > pro.LimitedProductQty)
                                            {
                                                mulQty = pro.LimitedProductQty - qtyCount;
                                            }
                                            //totalDC += mulQty * pro.ValueDC;
                                            qtyCount += mulQty;
                                            p.EffectByPromotionQty += mulQty;
                                        }
                                    }
                                    var dcItem = new CartItemInfo
                                    {
                                        SubTotalPrice = 0,// totalDC * (-1),// dcVal,
                                        Discount = totalDC,
                                        TotalPrice = 0 - totalDC,// * (-1),//dcVal,
                                        IsDC = true,
                                        IsFine = false,
                                        PromotionEffect = false,
                                        ProductId = pro.Id,
                                        SKU = string.Format("DC_{0:0000}", pro.Id),
                                        Title = string.Format(_locRM.GetString("ITEM_DISCOUNT_TITLE"), pro.Title),
                                        //Title = string.Format("ส่วนลด: {0}", pro.Title),
                                        ItemType = _locRM.GetString("DISCOUNT_TYPE"),
                                        //ItemType = "ส่วนลด",
                                        UnitPrice = 0,
                                        Qty = 1,
                                        UnitName = _locRM.GetString("UNIT_NAME"),
                                        //UnitName = "รายการ",
                                        Removable = false,
                                        ServiceChargeSupported = isServiceChargeSupport,
                                        Remarks = _locRM.GetString("REMARK_DISCOUNT_TYPE_3"),
                                        //Remarks = "ส่วนลดที่ไม่สามารถแบ่งคำนวนได้ (เกินจำนวนที่กำหนด)",
                                    };
                                    _currentCarts.Add(dcItem);
                                }
                                else
                                {
                                    // จ.น. น้อยกว่าสิทธ์โปรโมชั่น / น้อยกว่ามูลค่าสูงสุดที่กำหนด
                                    // Apply ส่วนลดแต่ละรายการได้เลย
                                    foreach (var p in targetPs)
                                    {
                                        var dc = pro.ValueDC * p.Qty;
                                        p.EffectPromotionId = pro.Id;
                                        p.Discount = dc;
                                        p.TotalPrice = p.SubTotalPrice - dc;
                                        p.EffectByPromotionQty = p.Qty;
                                        totalDC += dc;
                                    }
                                }

                                exactDc = totalDC;
                                discount += totalDC;
                            }
                        }
                        else
                        {
                            // กรณีนี้จะเป็นเหมือนใส่ voucher เข้ามา ซึ่งจะไม่ต้องอั้นเรื่องว่าสินค้านี้เคยได้ลดมาแล้ว (เฉพาะเคสนี้เท่านั้น)
                            //var effectCartItems = _currentCarts.Where(c => c.IsPromotionEffect && !c.IsDC && !c.IsFine && !c.IsPaid).ToList();
                            // พวกค่าปรับ และสินค้าที่ไม่เข้าร่วมสามารถลดได้
                            var effectCartItems = _currentCarts.Where(c => /*c.IsPromotionEffect && !c.IsFine &&*/ !c.IsDC && !c.IsPaid).ToList();
                            if (effectCartItems.Count > 0)
                            {
                                bool isServiceChargeSupport = effectCartItems.First().ServiceChargeSupported;
                                var uneffectSubTotal = effectCartItems.Sum(c => c.SubTotalPrice);
                                //foreach (var c in effectCartItems)
                                //{
                                //    c.EffectPromotionId = pro.Id;
                                //}
                                // Create dc item in cart.
                                var dcVal = pro.ValueDC;// *(-1);
                                if (pro.ValueDC > uneffectSubTotal)
                                {
                                    dcVal = uneffectSubTotal;// *(-1);
                                }

                                var dcItem = new CartItemInfo
                                {
                                    SubTotalPrice = 0,
                                    Discount = dcVal,
                                    TotalPrice = 0 - dcVal,
                                    IsDC = true,
                                    IsFine = false,
                                    PromotionEffect = false,
                                    ProductId = pro.Id,
                                    SKU = string.Format("DC_{0:0000}", pro.Id),
                                    Title = string.Format(_locRM.GetString("ITEM_DISCOUNT_TITLE"), pro.Title),
                                    ItemType = _locRM.GetString("DISCOUNT_TYPE"),
                                    UnitPrice = 0,
                                    Qty = 1,
                                    UnitName = _locRM.GetString("UNIT_NAME"),
                                    Removable = false,
                                    ServiceChargeSupported = isServiceChargeSupport,
                                    Remarks = _locRM.GetString("REMARK_DISCOUNT_TYPE_4"),
                                };
                                _currentCarts.Add(dcItem);

                                exactDc = dcVal;
                                discount += pro.ValueDC;
                            }
                        }
                    }
                    if (pro.HasAttachProduct)
                    {
                        ProcessCurrentAddPromotion(pro);
                    }
                    pro.MeetCondition = exactDc > 0 || pro.HasAttachProduct;
                    pro.ExactDC = exactDc;
                }

                foreach (var pro in _currentPromotions.Where(p => p.HasCondition))
                {
                    pro.MeetCondition = false;
                    var nonBuyConCodes = new string[] { "pay", "value" };
                    var nonbuyConditions = from c in _context.PromotionConditions
                                           join p in _context.Promotions on c.PromotionId equals p.Id
                                           where nonBuyConCodes.Contains(c.Condition)
                                           && c.PromotionId == pro.Id
                                           orderby c.Condition descending
                                           select new
                                           {
                                               Condition = c,
                                               Promotion = p
                                           };
                    bool isMeetCondition = true;
                    var tempTotal = subTotal - discount;
                    foreach (var con in nonbuyConditions)
                    {
                        if (isMeetCondition)
                        {
                            if (con.Condition != null)
                            {
                                if (con.Condition.Condition == "value")
                                {
                                    isMeetCondition = (con.Condition.Qty <= tempTotal);
                                }
                                else if (con.Condition.Condition == "pay")
                                {
                                    if(con.Condition.TargetId > 0)
                                    {
                                        isMeetCondition = (_currentCreditIssuer != null && (_currentCreditIssuer.Id == con.Condition.TargetId));
                                    }
                                    else if(con.Condition.TargetId == -1) // Cash
                                    {
                                        isMeetCondition = (string)paymentTypeComboBox.SelectedValue == "cash";
                                    }
                                    else if(con.Condition.TargetId == -2)
                                    {
                                        isMeetCondition = (string)paymentTypeComboBox.SelectedValue == "promptpay";
                                    }
                                    else
                                    {
                                        isMeetCondition = false;
                                    }
                                }
                            }
                        }
                    }
                    if (isMeetCondition)
                    {
                        // Clear all dc in carts.
                        foreach (var c in _currentCarts)
                        {
                            c.Discount = 0;
                        }
                        tempTotal = _currentCarts.Where(c => !c.IsPaid && c.PromotionEffect).Sum(c => c.SubTotalPrice);
                        var thisDC = CalculateTopupDC(tempTotal, pro);
                        discount += thisDC;
                        // Create dc item.
                        var dcItem = new CartItemInfo
                        {
                            SubTotalPrice = 0,
                            Discount = thisDC,
                            TotalPrice = 0 - thisDC,
                            IsDC = true,
                            IsFine = false,
                            PromotionEffect = false,
                            ProductId = pro.Id,
                            SKU = string.Format("DC_{0:0000}", pro.Id),
                            Title = string.Format(_locRM.GetString("ITEM_DISCOUNT_TITLE"), pro.Title),
                            ItemType = _locRM.GetString("DISCOUNT_TYPE"),
                            UnitPrice = 0,
                            Qty = 1,
                            UnitName = _locRM.GetString("UNIT_NAME"),
                            Removable = false,
                            Remarks = _locRM.GetString("REMARK_DISCOUNT_TYPE_4"),
                        };
                        _currentCarts.Add(dcItem);

                        pro.MeetCondition = true;
                        pro.ExactDC = thisDC;
                    }
                }

                if (_systemServiceChargeEnable)
                {
                    var totalFormChargableProducts = _currentCarts.Where(c => !c.IsPaid && c.ServiceChargeSupported && !c.IsServiceCharge).Sum(c => c.TotalPrice);
                    var charge = totalFormChargableProducts * (_systemServiceCharge / 100);
                    if (charge > 0)
                    {
                        var existChargeItem = _currentCarts.Where(c => c.IsServiceCharge).FirstOrDefault();
                        if (existChargeItem != null)
                        {
                            existChargeItem.SubTotalPrice = charge;
                            existChargeItem.TotalPrice = charge;
                        }
                        else
                        {
                            var chargeItem = new CartItemInfo
                            {
                                SubTotalPrice = charge,
                                Discount = 0,
                                TotalPrice = charge,
                                IsDC = false,
                                IsFine = false,
                                PromotionEffect = false,
                                IsServiceCharge = true,
                                ProductId = 0,
                                SKU = "SERVICE",
                                Title = string.Format("Service Charge: {0:N2}%", _systemServiceCharge),
                                ItemType = "Service",
                                UnitPrice = _systemServiceCharge,
                                Qty = 1,
                                UnitName = _locRM.GetString("UNIT_NAME"),
                                Removable = false,
                                Remarks = string.Format("Service {0:N2}%", _systemServiceCharge),
                            };
                            _currentCarts.Add(chargeItem);
                        }
                    }
                }
            }
            var finalSubTotal = _currentCarts.Where(c => !c.IsPaid).Sum(c => c.SubTotalPrice);
            var total = _currentCarts.Where(c => !c.IsPaid).Sum(c => c.TotalPrice);
            var finalDC = _currentCarts.Where(c => !c.IsPaid).Sum(c => c.Discount);
            var fineCount = _currentCarts.Count(item => item.IsFine);
            var productCount = _currentCarts.Count(item => !item.IsFine);
            var productQty = (int)_currentCarts.Where(item => !item.IsFine).Sum(item => item.Qty);

            decimal vat = 0;
            if (_systemVatType == "exclude")
            {
                vat = total * (decimal)(_systemVat / 100m);
                total = total + vat;
            }
            else if (_systemVatType == "include")
            {
                decimal divide = (100 + _systemVat) / 100;
                decimal net = Convert.ToDecimal(total / divide);
                vat = total - net;
            }

            return new PaymentSummaryInfo
            {
                SubTotal = finalSubTotal,
                Discount = finalDC,
                Vat = vat,
                VatPercent = _systemVat,
                Total = total,
                FineCont = fineCount,
                ItemCount = productCount,
                ItemQty = productQty
            };
        }

        private decimal CalculateTopupDC(decimal value, PromotionInfo promotion)
        {
            decimal topUpDC = 0;
            if (promotion == null) return 0;
            if (promotion.PercentDC > 0)
            {
                topUpDC = value * (promotion.PercentDC / 100);
            }
            else if (promotion.ValueDC > 0)
            {
                topUpDC = promotion.ValueDC;
            }
            if (promotion.MaximumDC > 0 && topUpDC > promotion.MaximumDC)
            {
                topUpDC = promotion.MaximumDC;
            }
            return topUpDC;
        }

        private void ProcessCurrentAddPromotion(PromotionInfo selectPro)
        {
            //// รายการบังคับซื้อ 
            if (selectPro.EffectProductId > 0)
            {
                // ตรวจดูว่าใน cart ปัจจุบีนมีสินค้าชนิดนี้อยู่หรือไม่ ถ้าไม่พบค่อยเพิ่มลงไป (กรณีพบจะข้ามไปโดยไม่สนใจ QTY)
                var existProductInCart = _currentCarts.Where(c => c.ProductId == selectPro.EffectProductId).FirstOrDefault();//.Sum(c => c.Qty);

                if (existProductInCart == null)
                {
                    var cartItems = (from p in _context.Products
                                     join t in _context.Prices on p.Id equals t.ProductId
                                     where p.Id == selectPro.EffectProductId && !p.Inactive
                                     && t.EffectiveDate <= DateTime.Now && t.ExpireDate >= DateTime.Now && !t.Inactive
                                     select new CartItemInfo
                                     {
                                         SKU = p.Sku,
                                         ProductId = p.Id,
                                         Title = p.Title,
                                         SubTotalPrice = t.Value * selectPro.LimitedProductQty,
                                         TotalPrice = t.Value * selectPro.LimitedProductQty,
                                         ItemType = _locRM.GetString("PRODUCT_TYPE"),
                                         UnitName = p.UnitName,
                                         UnitPrice = t.Value,
                                         Removable = false,  // ถ้าจะลบต้องลบ promotion ออก
                                         Qty = selectPro.LimitedProductQty,
                                         IsFine = false,
                                         PromotionEffect = p.PromotionEffect,
                                         IsFromTempPromotion = selectPro.ReferenceId != 0,
                                         ReferenceId = selectPro.NeedDeductSubscription ? selectPro.CustomerSubscriptionId : 0,
                                         Remarks = "PROMO:" + selectPro.Title
                                     }).ToList();

                    AddProductsToCart(cartItems);
                    /// ** จริงๆแล้ว ไม่ต้องใส่ในรายการที่ถูกนำเข้าเพราะ Promotion เพราะถ้าไม่ใช้ promotion ก็ต้องจ่ายเต็มจำนวนอยู่แล้ว
                    if (!_promotionCartItems.ContainsKey(selectPro.Index))
                    {
                        _promotionCartItems.Add(selectPro.Index, cartItems);
                    }
                    else
                    {
                        _promotionCartItems[selectPro.Index].AddRange(cartItems);
                    }
                }

            }
            // รายการแถม
            if (selectPro.HasAttachProduct)
            {
                var attachs = (from a in _context.PromotionAttachments
                               join p in _context.Products on a.ProductId equals p.Id
                               where a.PromotionId == selectPro.Id && !p.Inactive
                               select new CartItemInfo
                               {
                                   SKU = p.Sku,
                                   ProductId = p.Id,
                                   Title = p.Title,
                                   TotalPrice = 0,
                                   ItemType = _locRM.GetString("PRODUCT_TYPE"),
                                   UnitName = p.UnitName,
                                   UnitPrice = 0,
                                   Removable = false,  // ถ้าจะลบต้องลบ promotion ออก
                                   Qty = a.ProductQty,
                                   IsFine = false,
                                   PromotionEffect = p.PromotionEffect,
                                   //IsFromTempPromotion = selectPro.ReferenceId != 0,
                                   IsFromTempPromotion = true,
                                   ReferenceId = selectPro.NeedDeductSubscription ? selectPro.CustomerSubscriptionId : 0,
                                   Remarks = "PROMO:" + selectPro.Title
                               }).ToList();

                AddProductsToCart(attachs, false);

                if (!_promotionCartItems.ContainsKey(selectPro.Index))
                {
                    _promotionCartItems.Add(selectPro.Index, attachs);
                }
                else
                {
                    _promotionCartItems[selectPro.Index].AddRange(attachs);
                }
            }

            // รายการเงื่อนไขซื้อ ที่ต้องซื้อบางอย่าง conditions
            var buyConds = (from b in _context.PromotionConditions
                            join p in _context.Products on b.TargetId equals p.Id
                            join t in _context.Prices on p.Id equals t.ProductId
                            where !p.Inactive && b.PromotionId == selectPro.Id && b.Condition == "buy"
                            && t.EffectiveDate <= DateTime.Now && t.ExpireDate >= DateTime.Now && !t.Inactive
                            select new CartItemInfo
                            {
                                SKU = p.Sku,
                                ProductId = p.Id,
                                Title = p.Title,
                                SubTotalPrice = t.Value * b.Qty,
                                TotalPrice = t.Value * b.Qty,
                                ItemType = _locRM.GetString("PRODUCT_TYPE"),
                                UnitName = p.UnitName,
                                UnitPrice = t.Value,
                                Removable = false,  // ถ้าจะลบต้องลบ promotion ออก
                                Qty = b.Qty,
                                IsFine = false,
                                PromotionEffect = p.PromotionEffect,
                                IsFromTempPromotion = selectPro.ReferenceId != 0,
                                ReferenceId = selectPro.NeedDeductSubscription ? selectPro.CustomerSubscriptionId : 0,
                                Remarks = "PROMO:" + selectPro.Title
                            }).ToList();
            if (buyConds.Count > 0)
            {
                AddProductsToCart(buyConds);
                if (!_promotionCartItems.ContainsKey(selectPro.Index))
                {
                    _promotionCartItems.Add(selectPro.Index, buyConds);
                }
                else
                {
                    _promotionCartItems[selectPro.Index].AddRange(buyConds);
                }
            }
        }

        private void UpdatePurchaseButtonWithPromotion()
        {
            if (_currentPromotions.Count > 0)
            {
                purchaseButton.Text = _locRM.GetString("LABEL_CALCULATE");
                _purchasable = false;
            }
            else
            {
                purchaseButton.Text = _locRM.GetString("LABEL_PAY");
                _purchasable = true;
            }
        }

        private void AddProductToCart(ProductInfo product, bool isPaid = false)
        {
            CartItemInfo exist = _currentCarts.FirstOrDefault(c => c.ProductId == product.Id && c.UnitPrice == product.Price);
            if (exist != null)
            {
                exist.Qty++;
                exist.SubTotalPrice = exist.UnitPrice * exist.Qty;
                exist.Discount = 0;
                exist.TotalPrice = exist.UnitPrice * exist.Qty;
                exist.TotalDeposit = exist.DepositValue * exist.Qty;
            }
            else
            {
                var newCartItem = new CartItemInfo
                {
                    ProductId = product.Id,
                    SKU = product.SKU,
                    Title = product.Title,
                    Qty = 1,
                    SubTotalPrice = product.Price,
                    Discount = 0,
                    TotalPrice = product.Price,
                    UnitPrice = product.Price,
                    UnitName = product.UnitName,
                    ReferenceId = product.ReferenceId,
                    ItemType = _locRM.GetString("PRODUCT_TYPE"),
                    PromotionEffect = product.PromotionEffect,
                    ServiceChargeSupported = product.ServiceChargeSupported,
                    Removable = true,
                };
                _currentCarts.Add(newCartItem);
            }

            _skipRebuild = false;
            if (!_currentCartHasServiceCharge && _systemServiceChargeEnable && product.ServiceChargeSupported)
            {
                _currentCartHasServiceCharge = true;
            }
            cartItemInfoBindingSource.ResetBindings(false);
        }

        private void AddProductsToCart(List<CartItemInfo> items, bool updateCurrent = true)
        {
            var forAddItems = updateCurrent ? _currentCarts : new List<CartItemInfo>();
            foreach (var it in items)
            {
                var exist = forAddItems.Where(c => c.ProductId == it.ProductId && c.IsFromTempPromotion == it.IsFromTempPromotion).FirstOrDefault();
                if (exist != null)
                {
                    exist.Qty += it.Qty;
                }
                else
                {
                    forAddItems.Add(it);
                }
            }
            if (!updateCurrent && forAddItems.Count > 0) _currentCarts.AddRange(forAddItems);
        }

        private void RefreshProductData()
        {
            RefreshProductDataCore(true);
        }

        private void RefreshProductDataCore(bool forceLoad)
        {
            int dayIndex = (int)DateTime.Now.DayOfWeek;
            var calDate = DateTime.Now;
            // Download days form range 
            var days = _context.Workdays.ToList();
            var today = days.Where(d => d.DayNumber == dayIndex).FirstOrDefault();
            if (today != null)
            {
                var start = DateTimeTools.StringToTime(today.StartTime, DateTime.Now.Date);
                if (DateTime.Now < start) // มาก่อนเวลาเขา อาจจะเป็นเพราะการข้ามวันของวันก่อน
                {
                    var backDay = DateTime.Now.AddDays(-1);
                    int pDayIndex = (int)backDay.DayOfWeek;
                    var previousDay = days.Where(d => d.DayNumber == pDayIndex).FirstOrDefault();
                    if (previousDay != null)
                    {
                        var end = DateTimeTools.StringToTime(previousDay.EndTime, backDay.Date);
                        if (end >= DateTime.Now)
                        {
                            today = previousDay;
                            calDate = backDay;
                        }
                    }
                }
            }

            bool isHoliday = today != null ? today.IsWeekend : false;
            if (!isHoliday)
            {
                var holiday = _context.Holidays.FirstOrDefault(h => h.Effective <= calDate && h.Expire >= calDate);
                isHoliday = holiday != null;
            }

            string halfTimeStr = today != null ? today.HalfTime : "12:00";
            bool isSecondHalf = DateTimeTools.StringToTime(halfTimeStr, calDate.Date) <= DateTime.Now;

            if (!forceLoad && isHoliday == _isHoliday && isSecondHalf == _isSecondHalf) return; // Dont load any more.

            _isHoliday = isHoliday;
            _isSecondHalf = isSecondHalf;
            UpdateStatusText();
            var currentZoneId = GetCurrentZoneId();

            var productInZones = from p in _context.Products
                                 join z in _context.ZoneProducts on p.Id equals z.ProductId
                                 where !p.Inactive && z.ZoneId == currentZoneId && !z.Inactive && p.Salable
                                 select new
                                 {
                                     Id = p.Id,
                                     Info = p,
                                     Category = z.Category,
                                     Qty = z.Qty,
                                 };
            if (_systemStrictStock)
            {
                productInZones = productInZones.Where(p => p.Qty > 0);
            }

            var priceTiers = _context.Prices.Where(t => t.EffectiveDate <= DateTime.Now && t.ExpireDate >= DateTime.Now && !t.Inactive);
            // calculate by criteria...
            priceTiers = (isHoliday) ? priceTiers.Where(t => t.NotWorkdaySale) : priceTiers.Where(t => t.WorkdaySale);
            priceTiers = (isSecondHalf) ? priceTiers.Where(t => t.SecondHalfSale) : priceTiers.Where(t => t.FirstHalfSale);

            var products = (from p in productInZones
                            join t in priceTiers on p.Id equals t.ProductId into pList
                            from price in pList.DefaultIfEmpty()
                            where price != null
                            select new ProductInfo
                            {
                                Id = p.Id,
                                Code = p.Info.Code,
                                SKU = p.Info.Sku,
                                Title = p.Info.Title,
                                Category = p.Category,
                                ImageData = p.Info.ImageData != null ? p.Info.ImageData.ToArray() : null,
                                UnitName = p.Info.UnitName,
                                Price = price.Value,
                                ServiceChargeSupported = p.Info.ServiceChargeSupport,
                                PromotionEffect = p.Info.PromotionEffect,
                            }).ToList();

            _cacheProductInfos = products;
            _commonProductInfos = products.OrderBy(p => p.SKU).ToList();

            if (GetAppSetting<bool>("ShowProductCategory"))
            {
                var categories = new List<KeyValuePair<string, string>>();

                categories.Add(new KeyValuePair<string, string>("ALL", _locRM.GetString("ALL_CATEGORY")));
                foreach (var info in _commonProductInfos.GroupBy(p => p.Category).OrderBy(p => p.Key))
                {
                    if (!string.IsNullOrEmpty(info.Key))
                    {
                        categories.Add(new KeyValuePair<string, string>(info.Key, info.Key));
                    }
                }
                if (categories.Count > 1)
                {
                    categories.Add(new KeyValuePair<string, string>("", "-Others-"));
                }
                categoryComboBox.DisplayMember = "Value";
                categoryComboBox.ValueMember = "Key";
                categoryComboBox.DataSource = new BindingSource(categories, null);
                categoryComboBox.SelectedIndex = 0;
            }
            /// Load Common products.
            commonInfoBindingSource.DataSource = _commonProductInfos;
            commonInfoBindingSource.ResetBindings(false);

            /// Load Favorite products.
            var favoriteCodes = _favoriteProducts;
            if (favoriteCodes != null)
            {
                _favoriteList = products.Where(p => favoriteCodes.Contains(p.SKU)).OrderBy(p => p.SKU).ToList();
                favoriteInfoBindingSource.DataSource = _favoriteList;
                SortFavoriteItem();
            }
        }

        private void SortFavoriteItem()
        {
            int index = 0;
            foreach (var code in _favoriteProducts)
            {
                var target = _favoriteList.FirstOrDefault(p => p.SKU == code);
                if (target != null)
                {
                    target.SortIndex = index;
                }
                index++;
            }
            favoriteInfoBindingSource.DataSource = _favoriteList.OrderBy(f => f.SortIndex).ToList();
            favoriteInfoBindingSource.ResetBindings(false);
        }

        private void LogPromotionUsage(string invoiceNO)
        {
            try
            {
                foreach (var promotion in _currentPromotions.Where(p => p.MeetCondition))
                {
                    PromotionUsage usageLog = new PromotionUsage
                    {
                        CustomerId = _currentCustomer != null ? _currentCustomer.Id : 0,
                        Invoice = invoiceNO,
                        PromotionId = promotion.Id,
                        TotalDc = promotion.ExactDC * (-1),
                        IsClose = true
                    };
                    _context.PromotionUsages.Add(usageLog);
                }
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Logging promotion usage.");
            }
        }

        private void QueryCustomer()
        {
            var code = customerCodeTextBox.Text;

            var customer = GetCustomerInfo("code", code);
            previousReceiptLabel.Text = "";
            if (customer != null) // Exist customer.
            {
                clearLinkLabel.Show();
                firstnameTextBox.Text = customer.FirstName;
                lastnameTextBox.Text = customer.LastName;
                telTextBox.Text = customer.MobileNumber;
                memoTextBox.Text = customer.Comment;

                _currentCustomer = customer;
                // Point to product code scan box.
                scanBarcodeTextBox.Select();
                scanBarcodeTextBox.Focus();
                if (!string.IsNullOrEmpty(customer.LastReceipt))
                {
                    previousReceiptLabel.Text = string.Format(_locRM.GetString("LABEL_PREVIOUS_RECEIPT"), customer.LastReceipt);
                }
            }
            else
            {
                // new Customer.
                _currentCustomer = null;
                firstnameTextBox.Text = "";
                lastnameTextBox.Text = "";
                telTextBox.Text = "";

                firstnameTextBox.Select();
                firstnameTextBox.Focus();
            }

            // Clear previous promotion from member using.
            if (_currentPromotions != null && _currentPromotions.Count > 0)
            {
                _currentPromotions = _currentPromotions.Where(p => p.CustomerSubscriptionId == 0).ToList();
                promotionInfoBindingSource.DataSource = _currentPromotions;
                promotionInfoBindingSource.ResetBindings(false);
            }
        }

        private CustomerInfo CreateNewCustomer()
        {
            // New customer.
            Customer newCustomer = new Customer
            {
                Code = Guid.NewGuid().ToString("N"),
                EntryDate = DateTime.Now,
                Title = "คุณ",
                FirstName = firstnameTextBox.Text,
                LastName = lastnameTextBox.Text,
                Phone = telTextBox.Text,
                IdCard = "",
                Email = "",
                ImageData = ImageTools.GetByteArray(null),
                Comment = memoTextBox.Text,
            };
            _context.Customers.Add(newCustomer);

            // Create token code.
            CustomerTag newTag = new CustomerTag
            {
                CallerNumber = customerCodeTextBox.Text,
                EntryDate = DateTime.Now,
                CustomerCode = newCustomer.Code,
                Inactive = false,
                TagType = "code",
                UpdateDate = DateTime.Now
            };
            _context.CustomerTags.Add(newTag);
            // Also add phone as tags.
            if (!string.IsNullOrEmpty(telTextBox.Text)
                && telTextBox.Text != customerCodeTextBox.Text)
            {
                CustomerTag phoneTag = new CustomerTag
                {
                    CallerNumber = telTextBox.Text,
                    EntryDate = DateTime.Now,
                    CustomerCode = newCustomer.Code,
                    Inactive = false,
                    TagType = "phone",
                    UpdateDate = DateTime.Now
                };
                _context.CustomerTags.Add(phoneTag);
            }
            _context.SaveChanges();

            return GetCustomerInfo("code", newTag.CallerNumber);
        }

        private CustomerInfo GetCustomerInfo(string type, string tagId)
        {
            /// availabel type is : 
            /// Code, Card 
            var customers = _context.Customers.AsQueryable();
            if (type == "tag")
            {
                // on ticket mode tagid is customer's code.
                customers = from c in _context.Customers
                            where c.Code == tagId
                            select c;
            }
            else
            {
                customers = from c in _context.Customers
                            join t in _context.CustomerTags on c.Code equals t.CustomerCode
                            where t.TagType == type && t.CallerNumber == tagId && !t.Inactive
                            select c;
            }

            var target = (from c in customers
                          select new CustomerInfo
                          {
                              Id = c.Id,
                              Code = c.Code,
                              DefaultTag = tagId,
                              Title = c.Title,
                              FirstName = c.FirstName,
                              LastName = c.LastName,
                              NickName = c.NickName,
                              MobileNumber = c.Phone,
                              EmailAddress = c.Email,
                              LastReceipt = c.LastReceipt,
                              //ImageUrl = c.ImageUrl,
                              ImageData = c.ImageData != null ? c.ImageData.ToArray() : null,
                              Address = c.RegisterAddress,
                              IdCard = c.IdCard,
                              Gender = c.Gender,
                              Comment = c.Comment,
                          }).FirstOrDefault();

            return target;
        }

        private void UpdateRealTimeStock(string receiptNo, out bool forceUpdateProduct)
        {
            forceUpdateProduct = false;
            try
            {
                var targets = from d in _context.ReceiptDetails
                              join h in _context.Receipts on d.SerialNumber equals h.SerialNumber
                              //join pz in _context.ZoneProducts on new { h.ZoneId, d.ProductId } equals new { pz.ZoneId, pz.ProductId }
                              join p in _context.Products on d.ProductId equals p.Id
                              where d.SerialNumber == receiptNo && !d.StockUpdated
                              select new
                              {
                                  Detail = d,
                                  Product = p,
                                  ProductZone = (from pz in _context.ZoneProducts
                                                 where pz.ZoneId == h.ZoneId && pz.ProductId == d.ProductId
                                                 && !pz.Inactive
                                                 select pz).FirstOrDefault()
                              };
                foreach (var t in targets)
                {
                    if (t.Product.UseQty > 0)
                    {
                        t.Product.Qty -= t.Detail.Qty * t.Product.UseQty;
                        if (t.ProductZone != null) t.ProductZone.Qty -= t.Detail.Qty * t.Product.UseQty;
                        if (t.Product.Qty <= 0) forceUpdateProduct = true;
                    }
                    t.Detail.StockUpdated = true;
                }
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                // do nothing.
                _logger.Error(ex, $"Update stock of [{receiptNo}]");
            }
        }

        private void PrintSlip(string receiptNumber, int numberOfCopy, bool isRePrint = false, bool isFullTAX = false, string customerTax = "", string customerTitle = "", string customerAddress = "")
        {
            string textForPrint = "";
            if (isRePrint)
            {
                Receipt targetReceipt = _context.Receipts.FirstOrDefault(r => r.SerialNumber == receiptNumber);
                if (targetReceipt != null)
                {
                    PrintJob targetPj = _context.PrintJobs.Where(pj => pj.RefNo == receiptNumber).OrderByDescending(pj => pj.Id).FirstOrDefault();
                    if (targetPj != null)
                    {
                        textForPrint = "************* RE-PRINT *************\n";
                        if (targetReceipt.IsVoid)
                        {
                            textForPrint += "************** VOID **************\n";
                        }
                        textForPrint += targetPj.Text;
                    }
                }
            }
            if (string.IsNullOrEmpty(textForPrint))
            {
                string othersString;
                string itemString;
                string receiptNoString;
                string fullTaxLabelString;
                string taxIdLabelString;
                string customerLabelString;
                string sellerLabelString;
                string subTotalLabelString;
                string discountLabelString;
                string changeLabelString;
                string queueLabelString;
                var slipLanguage = GetAppSetting<string>("SlipLanguage");
                switch (slipLanguage)
                {
                    case "TH":
                        othersString = "บุคคลทั่วไป";
                        itemString = "สินค้า";
                        receiptNoString = "เลขที่";
                        customerLabelString = "ลูกค้า";
                        fullTaxLabelString = "ช้อมูลผู้ซื้อ";
                        taxIdLabelString = "เลขประจำตัวผู้เสียภาษี";
                        sellerLabelString = "จนท";
                        subTotalLabelString = "รวม";
                        discountLabelString = "ส่วนลด";
                        changeLabelString = "เงินทอน";
                        queueLabelString = "คิวที่";
                        break;
                    default:
                        othersString = "Others";
                        itemString = "Item";
                        receiptNoString = "ID";
                        fullTaxLabelString = "Customer Information";
                        taxIdLabelString = "TAXID";
                        customerLabelString = "Customer";
                        sellerLabelString = "Seller";
                        subTotalLabelString = "S.Total";
                        discountLabelString = "Discount";
                        changeLabelString = "Change";
                        queueLabelString = "Queue NO.";
                        break;
                }

                var target = (from r in _context.Receipts
                              where r.SerialNumber == receiptNumber
                              select new
                              {
                                  Receipt = r,
                                  Owner = (from c in _context.Customers
                                           where c.Code == r.CustomerCode
                                           select c).FirstOrDefault(),
                                  Issuer = (from ci in _context.CreditCardIssuers
                                            where ci.Id == r.CardIssuer
                                            select ci).FirstOrDefault(),
                              }).FirstOrDefault();


                if (target != null)
                {
                    var targetReceipt = new ReceiptHeaderInfo
                    {
                        SerialNumber = target.Receipt.SerialNumber,
                        Seller = target.Receipt.Seller,
                        EntryDate = target.Receipt.EntryDate,
                        SubTotal = target.Receipt.SubTotal,
                        Discount = target.Receipt.Discount,
                        Vat = target.Receipt.Vat,
                        VatType = target.Receipt.VatType,
                        Total = target.Receipt.Total,
                        Payment = target.Receipt.Payment,
                        Change = target.Receipt.Change,
                        Remarks = target.Receipt.Remarks,
                        CustomerFirstName = target.Owner != null ? target.Owner.FirstName : othersString,
                        CustomerLastName = target.Owner != null ? target.Owner.LastName : "",
                        CustomerPhone = target.Owner != null ? target.Owner.Phone : "",
                        PaymentType = target.Receipt.PaymentType,
                        CardIssuer = target.Issuer != null ? target.Issuer.Title : "",
                        IsVoid = target.Receipt.IsVoid,
                        Station = target.Receipt.StationName,
                        QueueNumber = target.Receipt.QueueNumber
                    };
                    var normalDetails = (from d in _context.ReceiptDetails
                                         join p in _context.Products on d.ProductId equals p.Id
                                         where d.SerialNumber == receiptNumber && !d.IsDiscount
                                         select new CartItemInfo
                                         {
                                             SKU = d.Sku,
                                             Title = p.Title,
                                             ItemType = itemString,
                                             UnitPrice = d.UnitPrice,
                                             Qty = d.Qty,
                                             SubTotalPrice = d.SubTotal,
                                             Discount = d.Discount,
                                             TotalPrice = d.TotalPrice,
                                             Remarks = d.Remarks,
                                             IsFine = false,
                                             IsDC = false,
                                             IsServiceCharge = false,
                                             IsMoneyCollect = false,
                                             Removable = false,
                                             PrintOrder = 0
                                         }).ToList();

                    var promos = _context.Promotions.AsQueryable();
                    var dcDetails = (from d in _context.PromotionUsages
                                     join p in promos on d.PromotionId equals p.Id
                                     where d.Invoice == receiptNumber
                                     select new CartItemInfo
                                     {
                                         SKU = p.Code,
                                         Title = p.Title,
                                         ItemType = _locRM.GetString("DISCOUNT_TYPE"),
                                         UnitPrice = 0,
                                         Qty = 1,
                                         SubTotalPrice = 0,
                                         Discount = 0,
                                         TotalPrice = d.TotalDc,
                                         Remarks = "",
                                         IsFine = false,
                                         IsDC = true,
                                         IsServiceCharge = false,
                                         IsMoneyCollect = false,
                                         Removable = false,
                                         PrintOrder = 2
                                     }).ToList();

                    var serviceCharge = (from d in _context.ReceiptDetails
                                         where d.SerialNumber == receiptNumber && d.ProductId == 0 && d.Sku == "SERVICE"
                                         && !d.IsDiscount
                                         select new CartItemInfo
                                         {
                                             SKU = d.Sku,
                                             Title = d.Remarks,
                                             ItemType = "Service",
                                             UnitPrice = 0,
                                             Qty = 1,
                                             SubTotalPrice = 0,
                                             Discount = 0,
                                             TotalPrice = d.TotalPrice,
                                             Remarks = "",
                                             IsFine = false,
                                             IsDC = false,
                                             IsServiceCharge = true,
                                             IsMoneyCollect = false,
                                             Removable = false,
                                             PrintOrder = 3
                                         }).ToList();

                    var allDetails = new List<CartItemInfo>();
                    allDetails.AddRange(normalDetails);
                    allDetails.AddRange(dcDetails);
                    allDetails.AddRange(serviceCharge);
                    string text = string.Format("{0}: {1} @ {2}", receiptNoString, receiptNumber, targetReceipt.EntryDate.ToString("dd/MM/yy HH:mm"));

                    if (isFullTAX)
                    {
                        var taxLines = new List<string>();
                        taxLines.Add(customerTitle);
                        taxLines.AddRange(customerAddress.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries));
                        taxLines.Add($"{taxIdLabelString}: {customerTax}");
                        var taxDetails = "";
                        foreach (var l in taxLines)
                        {
                            taxDetails += $"\n {l}";
                        }
                        text += $"\n{fullTaxLabelString}:{taxDetails}";
                    }
                    else
                    {
                        var customerName = string.Join(" ", new string[] { targetReceipt.CustomerFirstName, targetReceipt.CustomerLastName });
                        text += string.Format("\n{0}: {1}{2}", customerLabelString, customerName, !string.IsNullOrEmpty(targetReceipt.CustomerPhone) ? "|" + targetReceipt.CustomerPhone : "");
                    }

                    text += string.Format("\n{0}: {1}  Station:{2}", sellerLabelString, targetReceipt.Seller, targetReceipt.Station);
                    text += string.Format("\n");

                    foreach (var line in allDetails.OrderBy(d => d.PrintOrder).ThenBy(d => d.Title))
                    {
                        string producName = line.Title;
                        if (producName.Length > 17)
                        {
                            producName = line.Title.Substring(0, 17);
                        }
                        else if (producName.Length < 10)
                        {
                            producName = line.Title.PadRight(13);
                        }
                        if (!line.IsDC)
                        {
                            text += string.Format("\n{0}\t{1}\t{2}", line.Qty.ToString("N0").PadRight(3), producName, line.Discount > 0 ? line.SubTotalPrice.ToString("N2").PadLeft(10) : line.TotalPrice.ToString("N2").PadLeft(10));
                        }
                        else
                        {
                            text += string.Format("\n{0}\t{1}", line.Qty.ToString("N0").PadRight(3), producName);
                        }
                    }
                    text += string.Format("\n{0} ({1:N0}):\t\t{2}", subTotalLabelString, allDetails.Sum(a => a.Qty), targetReceipt.SubTotal.ToString("N2").PadLeft(10));
                    text += string.Format("\n{0}:\t\t{1}", discountLabelString, targetReceipt.Discount.ToString("N2").PadLeft(10));
                    if (targetReceipt.VatType == "exclude")
                    {
                        text += string.Format("\nVat {0:N1}%:\t\t{1}", _systemVat, targetReceipt.Vat.ToString("N2").PadLeft(10, ' '));
                    }
                    text += string.Format("\n-------------------------------------");
                    var finalTotal = targetReceipt.Total;
                    text += string.Format("\nTotal:\t\t{0}", finalTotal.ToString("N2").PadLeft(10));
                    text += string.Format("\n-------------------------------------");
                    var noneCreditcardMethod = new string[] { "cash", "promptpay" };
                    if (noneCreditcardMethod.Contains(targetReceipt.PaymentType))
                    {
                        text += string.Format("\n{0}:\t\t{1}", targetReceipt.PaymentType, targetReceipt.Payment.ToString("N2").PadLeft(10));
                        text += string.Format("\n{0}:\t\t{1}", changeLabelString, targetReceipt.Change.ToString("N2").PadLeft(10));
                    }
                    else
                    {
                        string credit = targetReceipt.CardIssuer;
                        if (credit.Length > 12)
                        {
                            credit = credit.Substring(0, 12);
                        }
                        else
                        {
                            credit = credit.PadRight(12);
                        }
                        text += string.Format("\n{0}\t{1}", credit, targetReceipt.Total.ToString("N2").PadLeft(10));
                    }
                    if (targetReceipt.VatType == "include")
                    {
                        //decimal vatPercent = _systemVat;// 7.0m;
                        //decimal divide = (100 + vatPercent) / 100;
                        //decimal net = Convert.ToDecimal(targetReceipt.Total / divide);
                        //decimal vat = Convert.ToDecimal(targetReceipt.Total - net);
                        //text += string.Format("\nExc.Vat :\t\t{0}", net.ToString("N2").PadLeft(10, ' '));
                        //text += string.Format("\nVat {0:N1}%:\t\t{1}", vatPercent, vat.ToString("N2").PadLeft(10, ' '));
                        decimal net = targetReceipt.Total - targetReceipt.Vat;
                        text += string.Format("\nExc.Vat :\t\t{0}", net.ToString("N2").PadLeft(10, ' '));
                        text += string.Format("\nVat {0:N1}%:\t\t{1}", _systemVat, targetReceipt.Vat.ToString("N2").PadLeft(10, ' '));
                    }

                    text += "\n";

                    // Get header & tailer.

                    string header = "";
                    if (targetReceipt.IsVoid)
                    {
                        header = "************** VOID **************\n";
                    }
                    if (_queueEnable)
                    {
                        var queueString = $"{queueLabelString}:  {targetReceipt.QueueNumber}";
                        // 37 is char per line.
                        var whiteSpaceCount = 37 - queueString.Length;
                        if (whiteSpaceCount > 0)
                        {
                            var left = whiteSpaceCount / 2;
                            queueString = queueString.PadLeft(left + queueString.Length).PadRight(37);
                        }
                        header += $"{queueString}\n\n";
                    }
                    // only vat bill will show this line.
                    if (targetReceipt.VatType != "none")
                    {
                        header += isFullTAX ? "-------------TAX INVOICE-------------\n" : "----------TAX INVOICE(ABB)-----------\n";
                    }

                    header += $"{_printHeader}\n";

                    string tailer = $"{_printTailer}\n\nPowered by meeSoft www.meesoft.co.th";

                    textForPrint = header + text + tailer;
                    if (isRePrint)
                    {
                        textForPrint = "************* RE-PRINT *************\n" + header + text + tailer;
                    }
                    else
                    {
                        PrintJob job = new PrintJob()
                        {
                            RefNo = receiptNumber,
                            Text = textForPrint,
                            NumberOfCopy = numberOfCopy,
                            SuccessCount = 1,
                            LastPrintDate = DateTime.Now,
                            IsSuccess = true,
                            IpAddress = "0.0.0.0"
                        };
                        _context.PrintJobs.Add(job);
                        _context.SaveChanges();
                    }
                }
            }

            SendToPrint(textForPrint, numberOfCopy, receiptNumber);
        }

        private void SendToPrint(string textForPrint, int numberOfCopy, string refNumber)
        {
            if (string.IsNullOrEmpty(textForPrint)) return; // Nothing to print.
            _textForPrint = textForPrint;
            var totalLines = textForPrint.Split(new char[] { '\n' }).Length;
            var estimateHeight = Convert.ToInt32(13.76 * totalLines) + 40; // 13.76 for "Courier New", 8.75f, FontStyle.Regular.
            var printDocument = new PrintDocument();
            printDocument.DefaultPageSettings.Margins.Left = 10;
            printDocument.DefaultPageSettings.Margins.Top = 10;
            printDocument.DefaultPageSettings.Margins.Right = 10;
            printDocument.DefaultPageSettings.Margins.Bottom = 30;
            printDocument.PrintPage += PrintDocument_PrintPage;

            int printWidth = Convert.ToInt32(GetAppSetting<decimal>("PrintingWidth") * 100);
            int printHeight = Convert.ToInt32(GetAppSetting<decimal>("PrintingHeight") * 100);
            if (printHeight < estimateHeight) printHeight = estimateHeight;
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("Custom Paper Size", printWidth, printHeight);

            for (int i = 0; i < numberOfCopy; i++)
            {
                try
                {
                    printDocument.Print();
                }
                catch (Exception ex)
                {
                    _logger.Error(ex, $"Error on printing [{refNumber}], copy:{i + 1}");
                }
            }
            _textForPrint = "";
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            StringFormat stringFormat = new StringFormat();
            float[] tabs = { 30, 40, 30, 40 };
            stringFormat.SetTabStops(0, tabs);
            string line = null;
            var printFont = new Font("Courier New", 8.75f, FontStyle.Regular);
            var lineHeight = printFont.GetHeight(g);
            var stringReader = new StringReader(_textForPrint);
            linesPerPage = e.MarginBounds.Height / lineHeight;
            while (count < linesPerPage && ((line = stringReader.ReadLine()) != null))
            {
                yPos = topMargin + (count * lineHeight);
                g.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, stringFormat);
                count++;
            }

            if (line != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
        }

        private void findReceiptForm_PrintRequest(object sender, PrintRequestEventArgs e)
        {
            PrintSlip(e.SerialNumber, e.NumberOfCopy, e.Reprint, e.FullTax, e.CustomerTax, e.CustomerName, e.CustomerAddress);
        }

        #region UI update functions.

        private void UpdatePaymentMethods()
        {
            var methods = new List<KeyValuePair<string, string>>();

            methods.Add(new KeyValuePair<string, string>("cash", _locRM.GetString("PAY_METHOD_CASH")));
            methods.Add(new KeyValuePair<string, string>("credit", _locRM.GetString("PAY_METHOD_CREDIT_CARD")));
            if (_promptpayEnable && !string.IsNullOrEmpty(_promptpayId))
            {
                methods.Add(new KeyValuePair<string, string>("promptpay", _locRM.GetString("PAY_METHOD_PROMPTPAY")));
            }
            paymentTypeComboBox.DisplayMember = "Value";
            paymentTypeComboBox.ValueMember = "Key";
            paymentTypeComboBox.DataSource = new BindingSource(methods, null);
            paymentTypeComboBox.SelectedIndex = 0;
        }

        private void UpdateStatusText()
        {
            otherStatusLabel.Text = string.Format("Stock: {0} Mode,  Shop close@{1} ({2}),  Refresh {3} days", _systemStrictStock ? "Strict" : "Easy", _closeTime, _isHoliday ? "Holiday" : "Normal", _lateDay);
        }

        private void ClearScreen()
        {
            purchaseButton.Enabled = true;
            // Clear all about customer.
            customerCodeTextBox.Text = "";
            firstnameTextBox.Text = lastnameTextBox.Text = telTextBox.Text = memoTextBox.Text = "";

            _currentCustomer = null;
            // clear cart.
            _currentCarts.Clear();
            _currentCartHasServiceCharge = false;
            cartItemInfoBindingSource.ResetBindings(false);

            // clear promotion.
            //promotionUseCheckBox.Checked = false;
            _currentPromotions.Clear();
            promotionInfoBindingSource.DataSource = _currentPromotions;
            promotionInfoBindingSource.ResetBindings(false);

            // Reset payment method to default.
            UpdatePaymentMethods();

            customerCodeTextBox.Select();
            customerCodeTextBox.Focus();
            previousReceiptLabel.Text = "";

            // Reset to cart tab.
            cartTabControl.SelectTab(cartTabPage);
            customerCodeTextBox.Enabled = true;
        }

        #endregion

        #region System & Configs functions.

        private SensiblePOSContext GetFreshContext()
        {
            return new SensiblePOSContext(_connectionString);
        }

        private T GetSystemConfiguration<T>(Dictionary<string, string> systems, string key, object defaultVal = null)
        {
            string value = "";
            systems.TryGetValue(key, out value);
            try
            {
                return (T)Convert.ChangeType(value, typeof(T));
            }
            catch (Exception ex)
            {
                _logger.Warn(ex, $"Failed on get systemInfo [{key}]");
                return defaultVal != null ? (T)defaultVal : default(T);
            }
        }

        private int GetCurrentZoneId()
        {
            return GetAppSetting<int>("ZoneId");
        }

        private T GetAppSetting<T>(string keyName)
        {
            return Configuration.GetSection($"AppSettings:{keyName}").Get<T>();
        }

        #endregion

    }
}
