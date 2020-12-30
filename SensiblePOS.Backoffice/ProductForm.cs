using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

using SensiblePOS.Backoffice.Models;
using SensiblePOS.Data;

namespace SensiblePOS.Backoffice
{
    public partial class ProductForm : Form
    {
        private SensiblePOSContext _context = null;
        private List<Product> _products = null;
        private ResourceManager _locRM = new ResourceManager("SensiblePOS.Backoffice.Resources.ProductForm", typeof(ProductForm).Assembly);
       
        public ProductForm(SensiblePOSContext context)
        {
            InitializeComponent();
            BuildGridView();
            MapBindingSource();
            _context = context;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            _products = _context.Products.Where(p => !p.Inactive).OrderBy(p => p.Sku).ToList();

            productBindingSource.DataSource = _products;
            productBindingSource.ResetBindings(false);
        }

        private void BuildGridView()
        {
            // Product gridview.
            var productSkuTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Sku",
                HeaderText = "SKU",
                MinimumWidth = 80,
                Width = 80,
                ReadOnly = true,
            };
            var productTitleTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Title",
                HeaderText = "Title",
                MinimumWidth = 8,
                AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true,
            };
            productGridView.AutoGenerateColumns = false;
            productGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                productSkuTextBoxColumn,
                productTitleTextBoxColumn});
            productGridView.DataSource = productBindingSource;

            // Price gridview.
            DataGridViewCellStyle priceGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleRight,
                Format = "N2",
                NullValue = "0"
            };
            var effectiveDateTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EffectiveDate",
                HeaderText = "Effective",
                Width = 120,
                ReadOnly = true,
            };
            var expireDateTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ExpireDate",
                HeaderText = "Expire",
                Width = 120,
                ReadOnly = true,
            };

            var priceTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Value",
                DefaultCellStyle = priceGridViewCellStyle,
                HeaderText = "Price",
                ReadOnly = true,
            };
            var weekdayCheckBoxColumn = new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "WorkdaySale",
                HeaderText = "Day",
                Width = 60,
                ReadOnly = true,
            };
            var weekendCheckBoxColumn = new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "NotWorkdaySale",
                HeaderText = "Holiday",
                Width = 60,
                ReadOnly = true,
            };
            var firstHalfCheckBoxColumn = new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "FirstHalfSale",
                HeaderText = "1st",
                ReadOnly = true,
                Width = 60,
            };
            var secondHalfCheckBoxColumn = new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "SecondHalfSale",
                HeaderText = "2nd",
                Width = 60,
                ReadOnly = true,
            };

            priceGridView.AutoGenerateColumns = false;
            priceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                effectiveDateTextBoxColumn,
                expireDateTextBoxColumn,
                priceTextBoxColumn,
                weekdayCheckBoxColumn,
                weekendCheckBoxColumn,
                firstHalfCheckBoxColumn,
                secondHalfCheckBoxColumn});
            priceGridView.DataSource = priceBindingSource;


            // Stock gridview. 

            DataGridViewCellStyle qtyGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleRight,
            };
            var zoneNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ZoneName",
                HeaderText = "Zone",
                Width = 80,
                ReadOnly = true,
            };
            var categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Category",
                HeaderText = "Category",
                ReadOnly = true,
            };
            var qtyDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Qty",
                DefaultCellStyle = qtyGridViewCellStyle,
                HeaderText = "Qty",
                Width = 80,
                ReadOnly = true,
            };
            var lastQtyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LastQty",
                DefaultCellStyle = qtyGridViewCellStyle,
                HeaderText = "Last Qty",
                Width = 80,
                ReadOnly = true,
            };
            var updateDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UpdateDate",
                HeaderText = "Update",
                Width = 120,
                ReadOnly = true,
            };

            stockGridView.AutoGenerateColumns = false;
            stockGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                zoneNameDataGridViewTextBoxColumn,
                categoryDataGridViewTextBoxColumn,
                qtyDataGridViewTextBoxColumn2,
                lastQtyDataGridViewTextBoxColumn,
                updateDateDataGridViewTextBoxColumn});
            stockGridView.DataSource = stockBindingSource;
        }

        private void MapBindingSource()
        {
            // General group box.
            skuTextBox.DataBindings.Add(new Binding("Text", productBindingSource, "Sku", true));
            titleTextBox.DataBindings.Add(new Binding("Text", productBindingSource, "Title", true));
            remarkTextBox.DataBindings.Add(new Binding("Text", productBindingSource, "Remarks", true));
            salableCheckBox.DataBindings.Add(new Binding("Checked", productBindingSource, "Salable", true));
            promoEffectCheckBox.DataBindings.Add(new Binding("Checked", productBindingSource, "PromotionEffect", true));
            serviceChargeEffectCheckBox.DataBindings.Add(new Binding("Checked", productBindingSource, "ServiceChargeSupport", true));
            inactiveCheckBox.DataBindings.Add(new Binding("Checked", productBindingSource, "Inactive", true));
            // Stock grob box.
            currentQtyTextBox.DataBindings.Add(new Binding("Text", productBindingSource, "Qty", true));
            useQtyTextBox.DataBindings.Add(new Binding("Text", productBindingSource, "UseQty", true));
        }

        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var product = productBindingSource.Current as Product;
            if (product != null)
            {
                RefreshProductPriceTier(product.Id);
                RefreshProductZone(product.Id);
            }
        }

        private void productBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            FilterProductList(keywordTextBox.Text);
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            using (AddProductForm addForm = new AddProductForm(_context))
            {
                if (addForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    _products.Add(addForm.NewItem);
                    productBindingSource.DataSource = _products;
                    productBindingSource.ResetBindings(false);
                    productBindingSource.MoveLast();
                }
            }
        }
        
        private void addPriceButton_Click(object sender, EventArgs e)
        {
            var product = productBindingSource.Current as Product;
            if (product != null)
            {
                decimal currentPrice = 0;
                if (!decimal.TryParse(currentPriceTextBox.Text, out currentPrice))
                {
                    var prices = priceBindingSource.DataSource as List<Price>;
                    var lastest = prices.OrderByDescending(t => t.EffectiveDate).FirstOrDefault();
                    if (lastest != null)
                    {
                        currentPrice = lastest.Value;
                    }
                }
                if (AddNewPriceTier(product.Id, currentPrice))
                {
                    RefreshProductPriceTier(product.Id);
                }
            }
        }

        private void closePriceButton_Click(object sender, EventArgs e)
        {
            var current = priceBindingSource.Current as Price;
            if (current != null)
            {
                if (MessageBox.Show(_locRM.GetString("DAILOG_TITLE_END_PRICE"), _locRM.GetString("DAILOG_TITLE_END_PRICE"), 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    current.ExpireDate = (current.EffectiveDate < DateTime.Now) ? DateTime.Now : current.EffectiveDate;
                    _context.SaveChanges();
                    var product = productBindingSource.Current as Product;
                    if (product != null)
                    {
                        RefreshProductPriceTier(current.ProductId);
                    }
                }
            }
        }

        private void addStockButton_Click(object sender, EventArgs e)
        {
            var product = productBindingSource.Current as Product;
            if (product != null)
            {
                var toAddZone = (from z in _context.Zones
                                 where !z.Inactive
                                 orderby z.Title
                                 select new ProductZoneInfo
                                 {
                                     Id = z.Id,
                                     ZoneName = z.Title,
                                     Qty = (from q in _context.ZoneProducts
                                           where q.ProductId == product.Id 
                                           && q.ZoneId == z.Id
                                           && !q.Inactive
                                           select q.Qty).FirstOrDefault(),
                                 }).ToList();
                using (AddStockForm addForm = new AddStockForm(toAddZone, product.Qty))
                {
                    if (addForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        //_context.ZoneProducts..Reload();
                        var target = _context.ZoneProducts.FirstOrDefault(z => z.ProductId == product.Id && z.ZoneId == addForm.SelectedZoneId && !z.Inactive);
                        if (target != null)
                        {
                            target.Qty += addForm.SelectedQty;
                            target.LastQty = target.Qty;
                        }
                        else
                        {
                            var newZone = new ZoneProduct
                            {
                                ZoneId = addForm.SelectedZoneId,
                                ProductId = product.Id,
                                Category = "",
                                Qty = addForm.SelectedQty,
                                LastQty = addForm.SelectedQty,
                                UpdateDate = DateTime.Now, 
                                Inactive = false,
                            };
                            _context.ZoneProducts.Add(newZone);
                        }
                        _context.SaveChanges();

                        RefreshProductZone(product.Id);
                    }
                }
            }
        }

        private void removeStockButton_Click(object sender, EventArgs e)
        {
            var current = stockBindingSource.Current as ProductZoneInfo;
            if (current != null)
            {
                string msg = string.Format(_locRM.GetString("DAILOG_MSG_REMOVE_STOCK"), current.ZoneName);
                if (MessageBox.Show(msg, _locRM.GetString("DIALOG_TITLE_REMOVE_STOCK"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var target = _context.ZoneProducts.FirstOrDefault(z => z.Id == current.Id);
                    if (target != null)
                    {
                        target.Inactive = true;
                        target.LastQty = target.Qty;
                        target.UpdateDate = DateTime.Now;
                        _context.SaveChanges();
                        RefreshProductZone(target.ProductId);
                    }
                }
            }
        }

        private void setStockCategoryButton_Click(object sender, EventArgs e)
        {
            var current = stockBindingSource.Current as ProductZoneInfo;
            if (current != null)
            {
                using (var setForm = new InputForm(current.Category))
                {
                    setForm.Text = setStockCategoryButton.Text;
                    if (setForm.ShowDialog() == DialogResult.OK)
                    {
                        var target = _context.ZoneProducts.FirstOrDefault(z => z.Id == current.Id);
                        if (target != null)
                        {
                            target.Category = setForm.Value;
                            _context.SaveChanges();
                            current.Category = target.Category;
                        }
                    }
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (SaveChange())
            {
                saveButton.Enabled = false;
            }
        }
         
        private void FilterProductList(string keyword = "")
        {
            List<Product> result = _products;
            if (!string.IsNullOrEmpty(keyword))
            {
                result = _products.Where(p => p.Sku.StartsWith(keyword) || p.Title.ToLower().Contains(keyword)).ToList();
            }
            productBindingSource.DataSource = result;
            productBindingSource.ResetBindings(false);
        }

        private bool SaveChange()
        {
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool AddNewPriceTier(int productId, decimal currentPrice)
        {
            try
            {
                using (var addForm = new AddPriceForm(currentPrice))
                {
                    if (addForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        var newPrice = addForm.NewItem;
                        // รายการที่ถูกตัวใหม่ทับแบบสมบูรณ์
                        var insides = _context.Prices.Where(t => !t.Inactive && t.ProductId == productId
                            && t.EffectiveDate >= newPrice.EffectiveDate && t.ExpireDate <= newPrice.ExpireDate).ToList();
                        _context.Prices.RemoveRange(insides);

                        /// รายการที่ถูกตัวใหม่ทับช่วงเริ่มต้น
                        var laterTiers = _context.Prices.Where(t => !t.Inactive && t.ProductId == productId
                            && t.ExpireDate > newPrice.ExpireDate && t.EffectiveDate <= newPrice.ExpireDate).ToList();
                        foreach (var late in laterTiers)
                        {
                            late.EffectiveDate = newPrice.ExpireDate.AddDays(1).Date;
                        }

                        /// รายการที่ถูกตัวใหม่ทับช่วงปลาย
                        var earlyTiers = _context.Prices.Where(t => !t.Inactive && t.ProductId == productId
                            && t.ExpireDate >= newPrice.EffectiveDate && t.EffectiveDate < newPrice.EffectiveDate).ToList();

                        foreach (var ear in earlyTiers)
                        {
                            ear.ExpireDate = newPrice.EffectiveDate.AddDays(-1).Date;
                        }

                        newPrice.ProductId = productId;
                        _context.Prices.Add(newPrice);
                        _context.SaveChanges();

                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        private void RefreshProductPriceTier(int productId)
        {
            var tiers = (from t in _context.Prices
                         where t.ProductId == productId
                         && !t.Inactive
                         orderby t.ExpireDate descending
                         select t).ToList();
            priceBindingSource.DataSource = tiers;
            priceBindingSource.ResetBindings(false);
            var currentPrice = tiers.FirstOrDefault(t => t.EffectiveDate <= DateTime.Now && t.ExpireDate > DateTime.Now);

            currentPriceTextBox.Text = currentPrice != null ? currentPrice.Value.ToString("N2") : _locRM.GetString("EXPIRED_PRICE");
            currentPriceTextBox.ForeColor = currentPrice != null && currentPrice.Value > 0 ? Color.Black : Color.Red;

            workdayCheckBox.Checked = currentPrice != null ? currentPrice.WorkdaySale : false;
            weekendCheckBox.Checked = currentPrice != null ? currentPrice.NotWorkdaySale : false;
            firstHalfCheckBox.Checked = currentPrice != null ? currentPrice.FirstHalfSale : false;
            secondHalfCheckBox.Checked = currentPrice != null ? currentPrice.SecondHalfSale : false;
        }

        private void RefreshProductZone(int productId)
        {
            var zones = (from pz in _context.ZoneProducts
                         join z in _context.Zones on pz.ZoneId equals z.Id
                         where !pz.Inactive && pz.ProductId == productId
                         orderby z.Id
                         select new ProductZoneInfo
                         {
                             Id = pz.Id,
                             ZoneId = z.Id,
                             ZoneName = z.Title,
                             ProductId = pz.ProductId,
                             Category = pz.Category,
                             Qty = pz.Qty,
                             LastQty = pz.LastQty,
                             UpdateDate = pz.UpdateDate.GetValueOrDefault()
                         }).ToList();
            stockBindingSource.DataSource = zones;
            stockBindingSource.ResetBindings(false);
        }
    }
}
