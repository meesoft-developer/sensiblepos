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
namespace SensiblePOS.Backoffice
{
    public partial class AddPromotionForm : Form
    {
        public Promotion NewItem { get; set; }
        private SensiblePOSContext _context = null;
        private List<ProductWithQualityInfo> _attachInfos = new List<ProductWithQualityInfo>();
        private Product _targetProduct = null;
        private List<Product> _products = null;
        private BindingSource productBindingSource = new BindingSource();
        private ResourceManager _locRM = new ResourceManager("SensiblePOS.Backoffice.Resources.AddPromotionForm", typeof(AddProductForm).Assembly);
        public AddPromotionForm(SensiblePOSContext context, List<Product> products)
        {
            InitializeComponent();
            _context = context;
            _products = products;
            productBindingSource.DataSource = _attachInfos;
            BuildGridView();
        }

        private void AddPromotionForm_Load(object sender, EventArgs e)
        {
            // Create Issuer combobox.
            var methods = new List<KeyValuePair<int, string>>();
            methods.Add(new KeyValuePair<int, string>(0, _locRM.GetString("PAY_METHOD_NOT_SPECIFIC")));
            methods.Add(new KeyValuePair<int, string>(-1, _locRM.GetString("PAY_METHOD_CASH")));
            methods.Add(new KeyValuePair<int, string>(-2, _locRM.GetString("PAY_METHOD_PROMPTPAY"))); 
            methods.AddRange(_context.CreditCardIssuers.ToDictionary(c => c.Id, c => c.Title).ToList());
            paywithComboBox.DisplayMember = "Value";
            paywithComboBox.ValueMember = "Key";
            paywithComboBox.DataSource = methods;
        }

        private void valueDcNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (maxDcNumeric.Value > 0 && maxDcNumeric.Value < valueDcNumeric.Value)
            {
                maxDcNumeric.Value = valueDcNumeric.Value;
            }
        }

        private void maxDcNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (valueDcNumeric.Value > 0 && maxDcNumeric.Value < valueDcNumeric.Value)
            {
                valueDcNumeric.Value = maxDcNumeric.Value;
            }
        }

        private void selectTargetProductButton_Click(object sender, EventArgs e)
        {
            using (SelectProductForm selectForm = new SelectProductForm(_products))
            {
                if (selectForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (selectForm.Selected != null)
                    {
                        _targetProduct = selectForm.Selected;
                        targetProductSkuTextBox.Text = selectForm.Selected.Sku;
                        targetProductTitleTextBox.Text = selectForm.Selected.Title;
                        targetProductLimitQtyNumeric.Value = selectForm.Qty;
                        targetProductSkuTextBox.Enabled = targetProductTitleTextBox.Enabled
                            = targetProductLimitQtyNumeric.Enabled
                            = clearTargetProductButton.Enabled = true;
                    }
                }
            }
        }

        private void clearTargetProductButton_Click(object sender, EventArgs e)
        {
            _targetProduct = null;
            targetProductSkuTextBox.Text = targetProductTitleTextBox.Text = "";
            targetProductSkuTextBox.Enabled = targetProductTitleTextBox.Enabled = false;
            targetProductLimitQtyNumeric.Value = 1;
            targetProductLimitQtyNumeric.Enabled = false;
            clearTargetProductButton.Enabled = false;
        }

        private void addBundleButton_Click(object sender, EventArgs e)
        {
            using (SelectProductForm selectForm = new SelectProductForm(_products, true))
            {
                if (selectForm.ShowDialog() == DialogResult.OK)
                {
                    var selected = selectForm.Selected;
                    _attachInfos.Add(new ProductWithQualityInfo
                    {
                        Id = selected.Id,
                        Sku = selected.Sku,
                        Title = selected.Title,
                        Qty = selectForm.Qty,
                    });
                    productBindingSource.DataSource = _attachInfos;
                    productBindingSource.ResetBindings(false);
                }
            }
        }

        private void attachProductGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) // Del button
            {
                var current = productBindingSource.Current as ProductWithQualityInfo;
                if (current != null)
                {
                    productBindingSource.RemoveCurrent();
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            // Validate completed of data.
            var code = codeTextBox.Text;
            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show(_locRM.GetString("DIALOG_MSG_CODE_MISSING"), _locRM.GetString("DAILOG_TITLE_VALIDATION"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                codeTextBox.Select();
                return;
            }
            if (string.IsNullOrEmpty(titleTextBox.Text))
            {
                MessageBox.Show(_locRM.GetString("DIALOG_MSG_TITLE_MISSING"), _locRM.GetString("DAILOG_TITLE_VALIDATION"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                titleTextBox.Select();
                return;
            }

            var existCode = _context.Promotions.FirstOrDefault(p => p.Code == code);
            if (existCode != null)
            {
                MessageBox.Show(_locRM.GetString("DIALOG_MSG_CODE_ALREADY_EXIST"), _locRM.GetString("DAILOG_TITLE_VALIDATION"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                codeTextBox.Select();
                return;
            }

            // Create basic info.
            var pro = new Promotion
            {
                Code = code,
                Title = titleTextBox.Text,
                Description = detailTextBox.Text,
                ShowInList = true,  
                EntryDate = DateTime.Now,
                Effective = effectiveDateTimePicker.Value,
                Expire = expireDateTimePicker.Value,
                PercentDc = percentDcNumeric.Value,
                ValueDc = valueDcNumeric.Value,
                MaximumDc = maxDcNumeric.Value,
                MaxUsagePerDay = 0,
                HasCondition = (int)paywithComboBox.SelectedValue != 0,
                TargetProductId = _targetProduct != null ? _targetProduct.Id : 0,
                LimitProductQty =  (int)targetProductLimitQtyNumeric.Value,
                HasAttachItem = _attachInfos.Count > 0, 
                HasSubSchedule = false,
                Inactive = false,
                UpdateDate = DateTime.Now
            };
            _context.Promotions.Add(pro);
            _context.SaveChanges();

            try
            {
                // Create condition if set.
                if (pro.HasCondition)
                { 
                    var con = new PromotionCondition
                    {
                        Condition = "pay",
                        PromotionId = pro.Id,
                        TargetId = (int)paywithComboBox.SelectedValue,
                        Remarks = "Pay with " + paywithComboBox.Text,
                        Qty = 0,
                    };
                    _context.PromotionConditions.Add(con);
                }

                // Create attach product if set.
                if (pro.HasAttachItem)
                {
                    foreach (var att in _attachInfos)
                    {
                        var attP = new PromotionAttachment
                        {
                            ProductId = att.Id,
                            ProductQty = (int)att.Qty,
                            PromotionId = pro.Id,
                            IsRedeemLater = false,
                        };
                        _context.PromotionAttachments.Add(attP);
                    }
                }

                _context.SaveChanges();
                NewItem = pro;
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to create promotion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _context.Promotions.Remove(pro);
                _context.SaveChanges();
            }
        }

        private void BuildGridView()
        {
            // Product gridview.
            var qtyGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleRight,
                Format = "N0",
                NullValue = "0"
            };
            var productDeleteButtonColumn = new DataGridViewButtonColumn
            { 
                HeaderText = "Del",
                Text = "X",
                Width = 30,
                ReadOnly = true,
                UseColumnTextForButtonValue = true
            };
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
            var productQtyTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Qty",
                HeaderText = "Qty",
                DefaultCellStyle = qtyGridViewCellStyle,
                MinimumWidth = 40,
                Width = 40,
                ReadOnly = true,
            };
            attachProductGridView.AutoGenerateColumns = false;
            attachProductGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                productDeleteButtonColumn,
                productSkuTextBoxColumn,
                productTitleTextBoxColumn,
                productQtyTextBoxColumn});
            attachProductGridView.DataSource = productBindingSource;
        }

        private class ProductWithQualityInfo
        {
            public int Id { get; set; }
            public string Sku { get; set; }
            public string Title { get; set; }
            public decimal Qty { get; set; }
        }
    }
}
