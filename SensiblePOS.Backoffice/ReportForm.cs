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
using SensiblePOS.Backoffice;
using SensiblePOS.Backoffice.Utilities;
namespace SensiblePOS.Backoffice
{
    public partial class ReportForm : Form
    {
        enum ReportType : int
        {
            None = 0,
            Receipt = 1,
            ItemSold = 2,
            ReceiptDetail = 3,
            DailyProfit = 4,
            CurrentStock = 5,
            SalePerformance = 6
        }

        private SensiblePOSContext _context = null;
        private ReportType _reportType = ReportType.None;
        private DateTime _fromDate = DateTime.Now;
        private DateTime _toDate = DateTime.Now;
        private string _zoneName = "All";
        private string _sellerName = "All";
        private string _keyword = "";

        private ResourceManager _locRM = new ResourceManager("SensiblePOS.Backoffice.Resources.ReportForm", typeof(ReportForm).Assembly);
        public ReportForm(SensiblePOSContext context)
        {
            InitializeComponent();
            _context = context; 
            reportGridView.AutoGenerateColumns = false;
            BuildReportCombobox();
            BuildUserCombobox();
            BuildZoneCombobox();
        }

        private void BuildReportCombobox()
        {
            // Report name.
            var reports = new List<KeyValuePair<ReportType, string>>(); 
            reports.Add(new KeyValuePair<ReportType, string>(ReportType.Receipt, _locRM.GetString("REPORT_RECEIPT_TITLE")));
            reports.Add(new KeyValuePair<ReportType, string>(ReportType.ItemSold, _locRM.GetString("REPORT_ITEM_SOLD_TITLE")));
            reports.Add(new KeyValuePair<ReportType, string>(ReportType.ReceiptDetail, _locRM.GetString("REPORT_RECEIPT_DETAIL_TITLE")));
            reports.Add(new KeyValuePair<ReportType, string>(ReportType.DailyProfit, _locRM.GetString("REPORT_DAILY_PROFIT_TITLE")));
            reports.Add(new KeyValuePair<ReportType, string>(ReportType.CurrentStock, _locRM.GetString("REPORT_CURRENT_STOCK_TITLE")));
            reports.Add(new KeyValuePair<ReportType, string>(ReportType.SalePerformance, _locRM.GetString("REPORT_SALE_PERFORMANCE_TITLE")));
            reportNameComboBox.SelectedIndexChanged += ReportNameComboBox_SelectedIndexChanged;
            reportNameComboBox.DisplayMember = "Value";
            reportNameComboBox.ValueMember = "Key";
            reportNameComboBox.DataSource = new BindingSource(reports, null);
            reportNameComboBox.SelectedIndex = 0;
        }

        private void ReportNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((ReportType)reportNameComboBox.SelectedValue)
            {
                case ReportType.Receipt:
                    fromDateTimePicker.Enabled = true;
                    toDateTimePicker.Enabled = true;
                    zoneComboBox.Enabled = true;
                    sellerComboBox.Enabled = true;
                    keywordTextBox.Enabled = true;
                    keywordTextBox.PlaceholderText = _locRM.GetString("KEYWORD_PLACEHOLDER_RECEIPT");
                    break;
                case ReportType.ItemSold:
                    fromDateTimePicker.Enabled = true;
                    toDateTimePicker.Enabled = true;
                    zoneComboBox.Enabled = true;
                    sellerComboBox.Enabled = true;
                    keywordTextBox.Enabled = true;
                    keywordTextBox.PlaceholderText = _locRM.GetString("KEYWORD_PLACEHOLDER_ITEM_SOLD");
                    break;
                case ReportType.ReceiptDetail:
                    fromDateTimePicker.Enabled = true;
                    toDateTimePicker.Enabled = true;
                    zoneComboBox.Enabled = true;
                    sellerComboBox.Enabled = true;
                    keywordTextBox.Enabled = true;
                    keywordTextBox.PlaceholderText = _locRM.GetString("KEYWORD_PLACEHOLDER_RECEIPT_DETAIL");
                    break;
                case ReportType.DailyProfit:
                    fromDateTimePicker.Enabled = true;
                    toDateTimePicker.Enabled = true;
                    zoneComboBox.Enabled = false;
                    sellerComboBox.Enabled = false;
                    keywordTextBox.Enabled = false;
                    keywordTextBox.PlaceholderText = "";
                    break;
                case ReportType.CurrentStock:
                    fromDateTimePicker.Enabled = false;
                    toDateTimePicker.Enabled = false;
                    zoneComboBox.Enabled = true;
                    sellerComboBox.Enabled = false;
                    keywordTextBox.Enabled = true;
                    keywordTextBox.PlaceholderText = _locRM.GetString("KEYWORD_PLACEHOLDER_CURRENT_STOCK");
                    break;
                case ReportType.SalePerformance:
                    fromDateTimePicker.Enabled = true;
                    toDateTimePicker.Enabled = true;
                    zoneComboBox.Enabled = true;
                    sellerComboBox.Enabled = true;
                    keywordTextBox.Enabled = false;
                    keywordTextBox.PlaceholderText = "";
                    break;
            }
        }

        private void BuildZoneCombobox()
        {
            var zones = new List<KeyValuePair<int, string>>();
            zones.Add(new KeyValuePair<int, string>(0, _locRM.GetString("ALL_ITEM")));
            var listZones = (from z in _context.Zones
                         orderby z.Title
                         where !z.Inactive
                         select new 
                         {
                             Id = z.Id,
                             Title = z.Title
                         }).ToDictionary(z => z.Id, z => z.Title).ToList();
            zones.AddRange(listZones);
            zoneComboBox.DisplayMember = "Value";
            zoneComboBox.ValueMember = "Key";
            zoneComboBox.DataSource = zones;
        }

        private void BuildUserCombobox()
        {
            var sellers = new List<KeyValuePair<int, string>>(); 
            sellers.Add(new KeyValuePair<int, string>(0, _locRM.GetString("ALL_ITEM")));
            var listSellers = (from z in _context.Accounts
                             orderby z.Username
                             where !z.Inactive
                             select new
                             {
                                 Id = z.Id,
                                 Title = z.Username
                             }).ToDictionary(z => z.Id, z => z.Title).ToList();
            sellers.AddRange(listSellers);
            sellerComboBox.DisplayMember = "Value";
            sellerComboBox.ValueMember = "Key";
            sellerComboBox.DataSource = sellers;
        }

        private void CreateReceiptGridViewHeader()
        {
            var rightAndFormatN2CellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleRight,
                Format = "N2"
            };

            var entryDateColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EntryDate",
                HeaderText = "Date",
                Width = 120,
                ReadOnly = true,
            };
            var invoiceColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Invoice",
                DefaultCellStyle = rightAndFormatN2CellStyle,
                HeaderText = "Invoice",
                Width = 80,
                ReadOnly = true,
            };
            var customerColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerName",
                HeaderText = "Customer",
                Width = 80,
                ReadOnly = true,
            };
            var zoneColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ZoneName",
                HeaderText = "Zone",
                Width = 80,
                ReadOnly = true,
            };
            var paymentTypeColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PaymentType",
                HeaderText = "Payment",
                Width = 80,
                ReadOnly = true,
            };
            var issuerColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Issuer",
                HeaderText = "Card",
                Width = 80,
                ReadOnly = true,
            };
            var subTotalColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SubTotal",
                DefaultCellStyle = rightAndFormatN2CellStyle,
                HeaderText = "Sub Total",
                Width = 80,
                ReadOnly = true,
            };
            var discountColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Discount",
                DefaultCellStyle = rightAndFormatN2CellStyle,
                HeaderText = "Discount",
                Width = 70,
                ReadOnly = true,
            };
            var totalColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Total",
                DefaultCellStyle = rightAndFormatN2CellStyle,
                HeaderText = "Total",
                Width = 80,
                ReadOnly = true,
            };
            var excludeVatColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ExcludeVat",
                DefaultCellStyle = rightAndFormatN2CellStyle,
                HeaderText = "Exc.VAT",
                Width = 80,
                ReadOnly = true,
            };
            var vatColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Vat",
                DefaultCellStyle = rightAndFormatN2CellStyle,
                HeaderText = "VAT",
                Width = 70,
                ReadOnly = true,
            };
            var vatTypeColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "VatType",
                HeaderText = "VAT Type",
                Width = 80,
                ReadOnly = true,
            };
            var sellerColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Seller",
                HeaderText = "Seller",
                Width = 80,
                ReadOnly = true,
            };
            var stationColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Station",
                HeaderText = "Station",
                Width = 80,
                ReadOnly = true,
            };
            var isVoidColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IsVoid",
                HeaderText = "Void",
                Width = 60,
                ReadOnly = true,
            };
            var voidAdminColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "VoidAdmin",
                HeaderText = "Void.Admin",
                Width = 80,
                ReadOnly = true,
            };
            var remarksColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Remarks",
                HeaderText = "Remarks",
                Width = 120,
                ReadOnly = true,
            };
            reportGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                entryDateColumn,
                invoiceColumn,
                customerColumn,
                zoneColumn,
                paymentTypeColumn,
                issuerColumn,
                subTotalColumn,
                discountColumn,
                totalColumn,
                excludeVatColumn,
                vatColumn,
                vatTypeColumn,
                sellerColumn,
                stationColumn,
                isVoidColumn,
                voidAdminColumn,
                remarksColumn});
        }

        private void CreateItemSoldGridViewHeader()
        {
            var rightAndFormatN2CellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleRight,
                Format = "N2"
            };

            var skuColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Sku",
                HeaderText = "SKU",
                Width = 80,
                ReadOnly = true,
            };
            var titleColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ItemName",
                HeaderText = "Title",
                Width = 80,
                ReadOnly = true,
            };
            var typeColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ItemType",
                HeaderText = "Type",
                Width = 60,
                ReadOnly = true,
            };
            var zoneColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ZoneName",
                HeaderText = "Zone",
                Width = 80,
                ReadOnly = true,
            };
            var sellerColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Seller",
                HeaderText = "Seller",
                Width = 80,
                ReadOnly = true,
            };
            var stationColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Station",
                HeaderText = "Station",
                Width = 80,
                ReadOnly = true,
            };
            var entryDateColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EntryDate",
                HeaderText = "Date",
                Width = 120,
                ReadOnly = true,
            };
            var qtyColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Qty",
                DefaultCellStyle = rightAndFormatN2CellStyle,
                HeaderText = "Qty",
                Width = 60,
                ReadOnly = true,
            };
            var ppuColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UnitPrice",
                DefaultCellStyle = rightAndFormatN2CellStyle,
                HeaderText = "PPU",
                Width = 60,
                ReadOnly = true,
            };
            var totalColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Total",
                DefaultCellStyle = rightAndFormatN2CellStyle,
                HeaderText = "Total",
                Width = 80,
                ReadOnly = true,
            };
            
            reportGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                skuColumn,
                titleColumn,
                typeColumn,
                zoneColumn,
                sellerColumn,
                stationColumn,
                entryDateColumn,
                qtyColumn,
                ppuColumn,
                totalColumn});
        }

        private void CreateReceiptDetailGridViewHeader()
        {
            var rightAndFormatN2CellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleRight,
                Format = "N2"
            };
            var rightAndFormatN0CellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleRight,
                Format = "N0"
            };
            var entryDateColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EntryDate",
                HeaderText = "Date",
                Width = 120,
                ReadOnly = true,
            };
            var invoiceColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Invoice", 
                HeaderText = "Invoice",
                Width = 80,
                ReadOnly = true,
            };
            var skuColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductSku", 
                HeaderText = "SKU",
                Width = 80,
                ReadOnly = true,
            };
            var titleColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductName",
                HeaderText = "Title",
                Width = 80,
                ReadOnly = true,
            };
            var customerColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerName",
                HeaderText = "Customer",
                Width = 80,
                ReadOnly = true,
            };
            var zoneColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ZoneName",
                HeaderText = "Zone",
                Width = 80,
                ReadOnly = true,
            };
            var qtyColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Qty",
                DefaultCellStyle = rightAndFormatN0CellStyle,
                HeaderText = "Qty",
                Width = 80,
                ReadOnly = true,
            };
            var ppuColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UnitPrice",
                DefaultCellStyle = rightAndFormatN2CellStyle,
                HeaderText = "PPU",
                Width = 80,
                ReadOnly = true,
            };
            var subTotalColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SubTotal",
                DefaultCellStyle = rightAndFormatN2CellStyle,
                HeaderText = "Sub Total",
                Width = 80,
                ReadOnly = true,
            };
            var discountColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Discount",
                DefaultCellStyle = rightAndFormatN2CellStyle,
                HeaderText = "Discount",
                Width = 70,
                ReadOnly = true,
            };
            var totalColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Total",
                DefaultCellStyle = rightAndFormatN2CellStyle,
                HeaderText = "Total",
                Width = 80,
                ReadOnly = true,
            };
            var sellerColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Seller",
                HeaderText = "Seller",
                Width = 80,
                ReadOnly = true,
            };
            var stationColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Station",
                HeaderText = "Station",
                Width = 80,
                ReadOnly = true,
            };
            var isVoidColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IsVoid",
                HeaderText = "Void",
                Width = 60,
                ReadOnly = true,
            };
            var voidAdminColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "VoidAdmin",
                HeaderText = "Void.Admin",
                Width = 80,
                ReadOnly = true,
            };
            var updateColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UpdateDate",
                HeaderText = "Update",
                Width = 120,
                ReadOnly = true,
            };
            reportGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                entryDateColumn,
                invoiceColumn,
                skuColumn,
                titleColumn,
                customerColumn,
                zoneColumn,
                qtyColumn,
                ppuColumn,
                subTotalColumn,
                discountColumn,
                totalColumn,
                sellerColumn,
                stationColumn,
                isVoidColumn,
                voidAdminColumn,
                updateColumn});
        }

        private void CreateDailyProfitGridViewHeader()
        {
            var rightAndFormatN2CellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleRight,
                Format = "N2"
            };
            var dateColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EntryDate",
                HeaderText = "Date",
                Width = 120,
                ReadOnly = true,
            };
            var paymentColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PaymentType",
                HeaderText = "Payment",
                Width = 100,
                ReadOnly = true,
            };
            var totalColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Total",
                DefaultCellStyle = rightAndFormatN2CellStyle,
                HeaderText = "Total",
                Width = 80,
                ReadOnly = true,
            };
            var excludeVatColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ExcludeVat",
                DefaultCellStyle = rightAndFormatN2CellStyle,
                HeaderText = "Exc.VAT",
                Width = 80,
                ReadOnly = true,
            };
            var vatColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Vat",
                DefaultCellStyle = rightAndFormatN2CellStyle,
                HeaderText = "VAT",
                Width = 80,
                ReadOnly = true,
            };

            reportGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                dateColumn,
                paymentColumn,
                totalColumn,
                excludeVatColumn,
                vatColumn});
        }

        private void CreateCurrentStockGridViewHeader()
        {
            var rightAndFormatN0CellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleRight,
                Format = "N0"
            };
            var skuColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductSKU",
                HeaderText = "SKU",
                Width = 80,
                ReadOnly = true,
            };
            var titleColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductName",
                HeaderText = "Title",
                Width = 100,
                ReadOnly = true,
            };
            var zoneColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ZoneName",
                HeaderText = "Zone",
                Width = 80,
                ReadOnly = true,
            };
            var categoryColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Category",
                HeaderText = "Category",
                Width = 80,
                ReadOnly = true,
            };
            var qtyColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Qty",
                DefaultCellStyle = rightAndFormatN0CellStyle,
                HeaderText = "Qty",
                Width = 80,
                ReadOnly = true,
            };
            var mailQtyColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MainQty",
                DefaultCellStyle = rightAndFormatN0CellStyle,
                HeaderText = "Main Qty",
                Width = 100,
                ReadOnly = true,
            };
            var lastQtyColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LastQty",
                DefaultCellStyle = rightAndFormatN0CellStyle,
                HeaderText = "Last Add Qty",
                Width = 100,
                ReadOnly = true,
            };
            var updateDateColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Update",
                HeaderText = "Update",
                Width = 120,
                ReadOnly = true,
            };

            reportGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                skuColumn,
                titleColumn, 
                zoneColumn,
                categoryColumn,
                qtyColumn,
                mailQtyColumn,
                lastQtyColumn,
                updateDateColumn});
        }

        private void CreateSalePerformanceGridViewHeader()
        {
            var rightAndFormatN2CellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleRight,
                Format = "N2"
            };
            var rightAndFormatN0CellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleRight,
                Format = "N0"
            };
 
            var sellerColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Seller",
                HeaderText = "Seller",
                Width = 100,
                ReadOnly = true,
            };
            var fromColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FromDate",
                HeaderText = "From",
                Width = 120,
                ReadOnly = true,
            };
            var toColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ToDate",
                HeaderText = "To",
                Width = 120,
                ReadOnly = true,
            };
            var zoneColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ZoneName",
                HeaderText = "Zone",
                Width = 100,
                ReadOnly = true,
            };
            var totalColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Total",
                DefaultCellStyle = rightAndFormatN2CellStyle,
                HeaderText = "Total",
                Width = 80,
                ReadOnly = true,
            };
             
            var qtyColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Qty",
                DefaultCellStyle = rightAndFormatN0CellStyle,
                HeaderText = "Sold Qty",
                Width = 80,
                ReadOnly = true,
            };

            reportGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                sellerColumn,
                fromColumn,
                toColumn,
                zoneColumn,
                totalColumn,
                qtyColumn});
        }

        private void BuildReceiptReport()
        {
            CreateReceiptGridViewHeader();
            var receiptHeaders = _context.Receipts.AsQueryable();
            if ((int)sellerComboBox.SelectedValue > 0)
            {
                receiptHeaders = receiptHeaders.Where(r => r.Seller == _sellerName);
            }
            
            var customers = _context.Customers.AsQueryable();
            var zones = _context.Zones.AsQueryable();
            if ((int)zoneComboBox.SelectedValue > 0)
            {
                zones = zones.Where(r => r.Id == (int)zoneComboBox.SelectedValue);
            }
            var targets = (from r in receiptHeaders
                           join z in zones on r.ZoneId equals z.Id
                           where r.EntryDate >= _fromDate && r.EntryDate <= _toDate
                           select new
                           {
                               Receipt = r,
                               Zone = z,
                               Customer = (from c in _context.Customers
                                           where r.CustomerCode == c.Code
                                           select c).FirstOrDefault(),
                               Issuer = (from i in _context.CreditCardIssuers
                                         where i.Id == r.CardIssuer
                                         select i).FirstOrDefault(),
                           }).ToList();
            if (!string.IsNullOrEmpty(_keyword))
            {
                targets = targets.Where(t => t.Receipt.SerialNumber.Contains(_keyword)).ToList();
            }
            var infos = (from t in targets
                         select new Models.Reports.ReceiptInfo
                         {
                             EntryDate = t.Receipt.EntryDate,
                             Invoice = t.Receipt.SerialNumber,
                             PaymentType = t.Receipt.PaymentType,
                             Issuer = t.Issuer != null ? t.Issuer.Title : t.Receipt.PaymentType,
                             CustomerName = t.Customer != null ? t.Customer.FirstName + " " + t.Customer.LastName : "Take away",
                             ZoneName = t.Zone.Title,
                             SubTotal = t.Receipt.SubTotal,
                             Discount = t.Receipt.Discount,
                             Total = t.Receipt.Total,
                             Seller = t.Receipt.Seller,
                             Station = t.Receipt.StationName,
                             IsVoid = t.Receipt.IsVoid,
                             VoidAdmin = t.Receipt.VoidAdmin,
                             Remarks = t.Receipt.Remarks,
                             UpdateDate = t.Receipt.UpdateDate,
                             VatType = t.Receipt.VatType,
                             ExcludeVat = t.Receipt.VatType == "include" ? t.Receipt.Total - t.Receipt.Vat : t.Receipt.Total,
                             Vat = t.Receipt.Vat,
                         }).ToList();
            if (!string.IsNullOrEmpty(_keyword))
            {
                if (_keyword.StartsWith("inv:"))
                {
                    infos = infos.Where(i => i.Invoice.Contains(_keyword.Substring(4))).ToList();
                } 
                else
                {
                    infos = infos.Where(i => i.Invoice.Contains(_keyword)).ToList();
                }
            }
            reportGridView.DataSource = infos.OrderByDescending(i => i.EntryDate).ThenBy(i => i.IsVoid).ToList();
            reportGridView.Refresh();

            var sumTotal = infos.Where(i => !i.IsVoid).Sum(i => i.Total);
            var sumDC = infos.Where(i => !i.IsVoid).Sum(i => i.Discount);
            var sumExVat = infos.Where(i => !i.IsVoid).Sum(i => i.ExcludeVat);
            var sumVat = infos.Where(i => !i.IsVoid).Sum(i => i.Vat);

            summaryTextBox.Text = string.Format("Total: {0:N2}*. (Discount {1:N2})\r\nBefore VAT: {2:N2} bath (VAT: {3:N2})\r\nFrom {4:N0} records.\r\n*Exclude VOID item.",
                sumTotal,
                sumDC,
                sumExVat,
                sumVat,
                infos.Count);
        }

        private void BuildItemSoldReport()
        {
            CreateItemSoldGridViewHeader();
            var receiptHeaders = _context.Receipts.AsQueryable();
            if ((int)sellerComboBox.SelectedValue > 0)
            {
                receiptHeaders = receiptHeaders.Where(r => r.Seller == _sellerName);
            }
            var zones = _context.Zones.AsQueryable();
            if ((int)zoneComboBox.SelectedValue > 0)
            {
                zones = zones.Where(r => r.Id == (int)zoneComboBox.SelectedValue);
            }
            var targets = (from d in _context.ReceiptDetails
                           join r in receiptHeaders on d.SerialNumber equals r.SerialNumber
                           join z in zones on r.ZoneId equals z.Id
                           where r.EntryDate >= _fromDate 
                           && r.EntryDate <= _toDate
                           && !r.IsVoid
                           select new
                           {
                               Receipt = r,
                               Detail = d,
                               Zone = z,
                               Product = !d.IsDiscount ? (from p in _context.Products
                                          where p.Id == d.ProductId
                                          select p).FirstOrDefault() : null,
                               Promotion = d.IsDiscount ? (from pm in _context.Promotions
                                                           where pm.Id == d.ProductId
                                                           select pm).FirstOrDefault() : null
                           }).ToList();
            var infos = (from t in targets
                         select new Models.Reports.SaleItemInfo
                         {
                             EntryDate = t.Receipt.EntryDate.Date,
                             Sku = t.Detail.IsDiscount && t.Promotion != null ? t.Promotion.Code : t.Detail.Sku,
                             ProductId = t.Product != null ? t.Product.Id : t.Detail.ProductId,
                             ItemName = t.Detail.IsDiscount && t.Promotion != null ? t.Promotion.Title : t.Product != null ? t.Product.Title : t.Detail.Sku,
                             ItemType = t.Detail.IsDiscount ? "Discount" : t.Detail.Sku == "SERVICE" ? "Service" : "Item",
                             ZoneId = t.Zone.Id,
                             ZoneName = t.Zone.Title,
                             UnitPrice = t.Detail.UnitPrice,
                             Qty = t.Detail.Qty,
                             Total = t.Detail.TotalPrice,
                             Seller = t.Receipt.Seller,
                             Station = t.Receipt.StationName,
                         }).ToList();
            if (!string.IsNullOrEmpty(_keyword))
            {
                if (_keyword.StartsWith("sku:"))
                {
                    infos = infos.Where(i => i.Sku.Contains(_keyword.Substring(4))).ToList();
                }
                else
                {
                    infos = infos.Where(i => i.Sku.Contains(_keyword)).ToList();
                }
            }
            var grouped = infos.GroupBy(i => new { i.EntryDate.Date, i.ProductId, i.ZoneId, i.Seller, i.Station });
            var result = new List<Models.Reports.SaleItemInfo>();
            foreach (var g in grouped)
            {
                var firstItem = g.First();
                result.Add(new Models.Reports.SaleItemInfo
                {
                    EntryDate = g.Key.Date,
                    ProductId = g.Key.ProductId,
                    Sku = firstItem.Sku,
                    ItemName = firstItem.ItemName,
                    ZoneId = firstItem.ZoneId,
                    ZoneName = firstItem.ZoneName,
                    Seller = g.Key.Seller,
                    Station = g.Key.Station,
                    ItemType = firstItem.ItemType,
                    UnitPrice = firstItem.UnitPrice,
                    Qty = g.Sum(s => s.Qty),
                    Total = g.Sum(s => s.Total)
                });
            }
            reportGridView.DataSource = result.OrderBy(a => a.Sku).ThenBy(a => a.ZoneId).ThenByDescending(a => a.EntryDate).ToList();
            reportGridView.Refresh();

            var sumTotal = result.Sum(i => i.Total);

            summaryTextBox.Text = string.Format("Total: {0:N2}*\r\nFrom {1:N0} records.\r\n*Exclude VOID item.",
                sumTotal,
                infos.Count);
        }

        private void BuildDailyProfitReport()
        {
            CreateDailyProfitGridViewHeader(); 
            var receiptHeaders = _context.Receipts.AsQueryable(); 
            var zones = _context.Zones.AsQueryable();
            var infos = (from h in receiptHeaders
                         join z in zones on h.ZoneId equals z.Id
                         where h.EntryDate >= _fromDate && h.EntryDate <= _toDate
                         && !h.IsVoid
                         select new Models.Reports.ReceiptInfo
                         {
                             EntryDate = h.EntryDate.Date,
                             SubTotal = h.SubTotal,
                             Discount = h.Discount,
                             Total = h.Total,
                             Vat = h.Vat,
                             PaymentType = h.PaymentType,
                             ExcludeVat = h.VatType == "include" ? h.Total - h.Vat : h.Total,
                             VatType = h.VatType
                         }).ToList();
            var grouped = infos.GroupBy(i => new { i.EntryDate, i.PaymentType });
            List<Models.Reports.ReceiptInfo> result = new List<Models.Reports.ReceiptInfo>();
            foreach (var g in grouped)
            {
                result.Add(new Models.Reports.ReceiptInfo
                {
                    EntryDate = g.Key.EntryDate,
                    PaymentType = g.Key.PaymentType,
                    SubTotal = g.Sum(s => s.SubTotal),
                    Discount = g.Sum(s => s.Discount),
                    Total = g.Sum(s => s.Total),
                    ExcludeVat = g.Sum(s => s.ExcludeVat),
                    Vat = g.Sum(s => s.Vat), 
                }); 
            }

            reportGridView.DataSource = result.OrderByDescending(r => r.EntryDate).ThenByDescending(r => r.PaymentType).ToList();
            reportGridView.Refresh();

            var sumTotal = result.Sum(i => i.Total);
            var sumDC = result.Sum(i => i.Discount);
            var sumExVat = result.Sum(i => i.ExcludeVat);
            var sumVat = result.Sum(i => i.Vat);

            var cashTotal = result.Where(i => !i.IsVoid && i.PaymentType == "cash").Sum(i => i.Total);
            var creditTotal = result.Where(i => !i.IsVoid && i.PaymentType != "cash").Sum(i => i.Total);
            var promptpayTotal = result.Where(i => !i.IsVoid && i.PaymentType != "promptpay").Sum(i => i.Total);
            summaryTextBox.Text = string.Format("Total: {0:N2}. (Discount {1:N2})\r\nCash: {2:N2}, Credit: {3:N2}, Promptpay: {4:N2}\r\nBefore VAT : {5:N2} (VAT: {6:N2})\r\nFrom {7:N0} records.",
                sumTotal,
                sumDC,
                cashTotal,
                creditTotal,
                promptpayTotal,
                sumExVat,
                sumVat,
                result.Count);
        }

        private void BuildReceiptDetailReport()
        {
            CreateReceiptDetailGridViewHeader();
            var products = _context.Products.AsQueryable();
            var details = _context.ReceiptDetails.AsQueryable();
              
            var receiptHeaders = _context.Receipts.AsQueryable();
            if ((int)sellerComboBox.SelectedValue > 0)
            {
                receiptHeaders = receiptHeaders.Where(r => r.Seller == _sellerName);
            }
            var zones = _context.Zones.AsQueryable();
            if ((int)zoneComboBox.SelectedValue > 0)
            {
                zones = zones.Where(r => r.Id == (int)zoneComboBox.SelectedValue);
            }

            var targets = (from d in details
                           join h in receiptHeaders on d.SerialNumber equals h.SerialNumber
                           join z in zones on h.ZoneId equals z.Id
                           where h.EntryDate >= _fromDate && h.EntryDate <= _toDate
                           && !h.IsVoid
                           select new
                           {
                               Receipt = h,
                               Detail = d,
                               Zone = z,
                               Customer = (from c in _context.Customers
                                           where h.CustomerCode == c.Code
                                           select c).FirstOrDefault(),
                               Product = !d.IsDiscount ? _context.Products.Where(p => p.Id == d.ProductId).FirstOrDefault() : null,
                               Promotion = d.IsDiscount ? _context.Promotions.Where(pro => pro.Id  == d.ProductId).FirstOrDefault() : null
                           }).ToList();

            var infos = (from t in targets
                         select new Models.Reports.ReceiptDetailInfo
                         {
                             EntryDate = t.Receipt.EntryDate,
                             Invoice = t.Receipt.SerialNumber,
                             ProductSku = t.Promotion != null ? t.Promotion.Code : t.Product != null ? t.Product.Sku : t.Detail.Sku,
                             ProductName = t.Promotion != null ? t.Promotion.Title : t.Product != null ? t.Product.Title : t.Detail.Sku,
                             CustomerName = t.Customer != null ? t.Customer.FirstName + " " + t.Customer.LastName : "Take away",
                             ZoneName = t.Zone.Title, 
                             UnitPrice = t.Detail.UnitPrice,
                             Qty = t.Detail.Qty,
                             SubTotal = t.Detail.SubTotal,
                             Discount = t.Detail.Discount,
                             Total = t.Detail.TotalPrice,
                             Seller = t.Receipt.Seller,
                             Station = t.Receipt.StationName, 
                             UpdateDate = t.Receipt.UpdateDate
                         }).OrderByDescending(i => i.EntryDate).ToList();
            if (!string.IsNullOrEmpty(_keyword))
            {
                if (_keyword.StartsWith("inv:"))
                {
                    infos = infos.Where(i => i.Invoice.Contains(_keyword.Substring(4))).ToList();
                }
                else if (_keyword.StartsWith("sku:"))
                {
                    infos = infos.Where(i => i.ProductSku.Contains(_keyword.Substring(4))).ToList();
                }
                else
                {
                    infos = infos.Where(i => i.ProductSku.Contains(_keyword) || i.Invoice.Contains(_keyword)).ToList();
                }
            }
            reportGridView.DataSource = infos.OrderByDescending(i => i.EntryDate).ToList();
            reportGridView.Refresh();

            var sumTotal = infos.Sum(i => i.Total);
            var sumDC = infos.Sum(i => i.Discount);

            summaryTextBox.Text = string.Format("Total: {0:N2}. (Discount {1:N2})\r\nFrom {2:N0} records.",
                sumTotal,
                sumDC,
                infos.Count());
        }

        private void BuildCurrentStockReport()
        {
            CreateCurrentStockGridViewHeader();
            var zones = _context.Zones.AsQueryable();
            if ((int)zoneComboBox.SelectedValue > 0)
            {
                zones = zones.Where(r => r.Id == (int)zoneComboBox.SelectedValue);
            }
            var products = _context.Products.AsQueryable(); 
            var infos = (from zp in _context.ZoneProducts
                         join p in products on zp.ProductId equals p.Id
                         join z in zones on zp.ZoneId equals z.Id
                         where !p.Inactive && !zp.Inactive
                         select new Models.Reports.StockInfo
                         {
                             ZoneName = z.Title,
                             ProductName = p.Title,
                             ProductSKU = p.Sku,
                             Category = zp.Category,
                             Qty = zp.Qty,
                             LastQty = zp.LastQty,
                             MainQty = p.Qty,
                             Update = zp.UpdateDate ?? DateTime.Now
                         }).ToList();
             
            if (!string.IsNullOrEmpty(_keyword))
            {
                if (_keyword.StartsWith("sku:"))
                {
                    infos = infos.Where(i => i.ProductSKU.Contains(_keyword.Substring(4))).ToList();
                }
                else if (_keyword.StartsWith("cat:"))
                {
                    infos = infos.Where(i => i.Category.Contains(_keyword.Substring(4))).ToList();
                }
                else
                {
                    infos = infos.Where(i => i.ProductSKU.Contains(_keyword) || i.Category.Contains(_keyword)).ToList();
                }
            }

            reportGridView.DataSource = infos.OrderBy(r => r.ProductSKU).ThenBy(r => r.ZoneName).ThenBy(r => r.Category).ToList();
            reportGridView.Refresh();

            var sumTotal = infos.Sum(i => i.Qty);
            summaryTextBox.Text = string.Format("Total: {0:N0}.\r\nFrom {1:N0} records.",
                sumTotal,
                infos.Count);
        }

        private void BuildSalePerformanceReport()
        {
            CreateSalePerformanceGridViewHeader();
            var products = _context.Products.AsQueryable();
            var receiptHeaders = _context.Receipts.AsQueryable();
            if ((int)sellerComboBox.SelectedValue > 0)
            {
                receiptHeaders = receiptHeaders.Where(r => r.Seller == _sellerName);
            }
            var zones = _context.Zones.AsQueryable();
            if ((int)zoneComboBox.SelectedValue > 0)
            {
                zones = zones.Where(r => r.Id == (int)zoneComboBox.SelectedValue);
            }
            var details = _context.ReceiptDetails.AsQueryable();
            var infos = (from d in details
                         join h in receiptHeaders on d.SerialNumber equals h.SerialNumber 
                         join z in zones on h.ZoneId equals z.Id 
                         where h.EntryDate >= _fromDate && h.EntryDate <= _toDate
                         && !h.IsVoid 
                         select new 
                         {
                             EntryDate = h.EntryDate,
                             ZoneId = z.Id,
                             ZoneName = z.Title, 
                             Qty = d.Qty, 
                             Total = d.TotalPrice,
                             Seller = h.Seller,
                         }).ToList();
            var result = new List<Models.Reports.SalePerformanceInfo>();
            foreach (var g in infos.GroupBy(i => new { i.Seller }))
            {
                var datas = g.OrderBy(i => i.EntryDate);
                var firstItem = datas.First();
                var lastItem = datas.Last();

                result.Add(new Models.Reports.SalePerformanceInfo
                {
                    FromDate = firstItem.EntryDate,
                    ToDate = lastItem.EntryDate,
                    ZoneName = firstItem.ZoneName,
                    Qty = g.Sum(i => i.Qty),
                    Seller = g.Key.Seller,
                    Total = g.Sum(i => i.Total), 
                });
            }

            reportGridView.DataSource = result.OrderBy(a => a.Seller).ThenBy(a => a.FromDate).ThenBy(a => a.ToDate).ThenBy(a => a.ZoneName).ToList();
            reportGridView.Refresh();

            var sumTotal = result.Sum(i => i.Total);
            var sumQty = result.Sum(i => i.Qty);

            summaryTextBox.Text = string.Format("Total: {0:N2}. ({1:N0} items sold.)\r\nFrom {2:N0} records.",
                sumTotal,
                sumQty,
                result.Count);

        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            reportGridView.Columns.Clear();
            _reportType = (ReportType)reportNameComboBox.SelectedValue;
            _fromDate = fromDateTimePicker.Value;
            _toDate = toDateTimePicker.Value;
            _keyword = keywordTextBox.Text;
            _zoneName = zoneComboBox.Text;
            _sellerName = sellerComboBox.Text;

            switch (_reportType)
            {
                case ReportType.Receipt:
                    BuildReceiptReport();
                    break;
                case ReportType.ItemSold:
                    BuildItemSoldReport();
                    break;
                case ReportType.ReceiptDetail:
                    BuildReceiptDetailReport();
                    break;
                case ReportType.DailyProfit:
                    BuildDailyProfitReport();
                    break;
                case ReportType.CurrentStock:
                    BuildCurrentStockReport();
                    break;
                case ReportType.SalePerformance:
                    BuildSalePerformanceReport();
                    break;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string defaultName = "";
            List<string> lines = new List<string>();
            switch (_reportType)
            {
                case ReportType.Receipt: 
                    lines.Add(string.Format("From:,{0}", _fromDate.ToString()));
                    lines.Add(string.Format("To:,{0}", _toDate.ToString()));
                    lines.Add(string.Format("Zone:,{0}", _zoneName));
                    lines.Add(string.Format("Seller:,{0}", _sellerName));
                    lines.Add(string.Format("Keyword:,{0}", _keyword));
                    lines.Add(string.Format("Summary:,{0}", summaryTextBox.Text.Replace(",", "").Replace("\r\n", " ")));
                    defaultName = "Receipt";
                    break;
                case ReportType.ItemSold:
                    lines.Add(string.Format("From:,{0}", _fromDate.ToString()));
                    lines.Add(string.Format("To:,{0}", _toDate.ToString()));
                    lines.Add(string.Format("Zone:,{0}", _zoneName));
                    lines.Add(string.Format("Seller:,{0}", _sellerName));
                    lines.Add(string.Format("Keyword:,{0}", _keyword));
                    lines.Add(string.Format("Summary:,{0}", summaryTextBox.Text.Replace(",", "").Replace("\r\n", " ")));
                    defaultName = "ItemSold";
                    break;
                case ReportType.ReceiptDetail:
                    lines.Add(string.Format("From:,{0}", _fromDate.ToString()));
                    lines.Add(string.Format("To:,{0}", _toDate.ToString()));
                    lines.Add(string.Format("Zone:,{0}", _zoneName));
                    lines.Add(string.Format("Keyword:,{0}", _keyword));
                    lines.Add(string.Format("Summary:,{0}", summaryTextBox.Text.Replace(",", "").Replace("\r\n", " ")));
                    defaultName = "Detail";
                    break;
                case ReportType.DailyProfit:
                    lines.Add(string.Format("From:,{0}", _fromDate.ToString()));
                    lines.Add(string.Format("To:,{0}", _toDate.ToString()));
                    lines.Add(string.Format("Zone:,{0}", _zoneName));
                    lines.Add(string.Format("Summary:,{0}", summaryTextBox.Text.Replace(",", "").Replace("\r\n", " ")));
                    defaultName = "DailyProfit";
                    break;
                case ReportType.CurrentStock:
                    lines.Add(string.Format("Zone:,{0}", _zoneName));
                    lines.Add(string.Format("Summary:,{0}", summaryTextBox.Text.Replace(",", "").Replace("\r\n", " ")));
                    defaultName = "Stock";
                    break;
                case ReportType.SalePerformance:
                    lines.Add(string.Format("From:,{0}", _fromDate.ToString()));
                    lines.Add(string.Format("To:,{0}", _toDate.ToString()));
                    lines.Add(string.Format("Zone:,{0}", _zoneName));
                    lines.Add(string.Format("Seller:,{0}", _sellerName));
                    lines.Add(string.Format("Summary:,{0}", summaryTextBox.Text.Replace(",", "").Replace("\r\n", " ")));
                    defaultName = "Performance";
                    break;
            }
            var path = ExportTools.ShowSaveFileDialog(defaultName);
            if (!string.IsNullOrEmpty(path))
            {
                ExportTools.ExportGridViewToCSV(reportGridView, lines, path, Encoding.UTF8); 
                MessageBox.Show(_locRM.GetString("DIALOG_MSG_EXPORT_SUCCESS"), _locRM.GetString("DIALOG_TITLE_EXPORT_CSV"), MessageBoxButtons.OK);
            }
        }
    }
}
