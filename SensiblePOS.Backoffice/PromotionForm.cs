using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;

using SensiblePOS.Backoffice.Models;
using SensiblePOS.Data;

namespace SensiblePOS.Backoffice
{
    public partial class PromotionForm : Form
    {
        private SensiblePOSContext _context = null;
        private List<Promotion> _promotions = null;
        private List<Product> _products = null;
        private Dictionary<int, string> _productDict = new Dictionary<int, string>();
        private ResourceManager _locRM = new ResourceManager("SensiblePOS.Backoffice.Resources.PromotionForm", typeof(PromotionForm).Assembly);

        public PromotionForm(SensiblePOSContext context)
        {
            InitializeComponent();
            BuildGridView();
            MapBindingSource();
            _context = context;
        }
        
        private void PromotionForm_Load(object sender, EventArgs e)
        {
            _products = _context.Products.Where(p => !p.Inactive).ToList();
            _productDict = _products.ToDictionary(p => p.Id, p => p.Title);
            _promotions = _context.Promotions.Where(p => !p.Inactive).OrderBy(p => p.Code).ToList();

            promotionBindingSource.DataSource = _promotions;
            promotionBindingSource.ResetBindings(false);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            FilterPromotionList(keywordTextBox.Text);
        } 

        private void promotionBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var current = promotionBindingSource.Current as Promotion;
            if (current != null)
            {
                var items = (from c in _context.PromotionConditions 
                             where c.PromotionId == current.Id
                             select new 
                             {
                                 Action = c.Condition == "pay" ? "Pay with" : c.Condition == "buy" ? "Buy item" : "Spend",
                                 Condition = c,
                                 Card = c.Condition == "pay" && c.TargetId > 0 ? _context.CreditCardIssuers.Where(cc => cc.Id == c.TargetId).FirstOrDefault() : null
                             }).ToList();
                var conditions = (from i in items
                                  select new PromotionConditionInfo
                                  {
                                      ActionName = i.Action,
                                      ItemName = i.Card != null ? i.Card.Title : i.Condition.TargetId == -1 ? _locRM.GetString("PAY_METHOD_CASH") : i.Condition.TargetId == -2 ? _locRM.GetString("PAY_METHOD_PROMPTPAY") : _locRM.GetString("PAY_METHOD_NOT_SPECIFIC"),
                                      Remarks = i.Condition.Remarks
                                  }).ToList();
                conditionGridView.DataSource = conditions;

                var attach = from a in _context.PromotionAttachments
                             join p in _context.Products on a.ProductId equals p.Id
                             where a.PromotionId == current.Id
                             select new Product
                             {
                                 Title = p.Title,
                                 Sku = p.Sku,
                                 Qty = a.ProductQty
                             };

                attachmentGridView.DataSource = attach.ToList();

                if (current.TargetProductId > 0)
                {
                    string title = "";
                    if (_productDict.TryGetValue(current.TargetProductId, out title))
                    {
                        targetProductTextBox.Text = title;
                    }
                    else
                    {
                        targetProductTextBox.Text = current.TargetProductId.ToString();
                    }
                }
                else
                {
                    targetProductTextBox.Text = _locRM.GetString("TARGET_PRODUCT_NONE");
                }
            }
        }

        private void promotionBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = true;
        }

        private void addPromotionnButton_Click(object sender, EventArgs e)
        {
            using (AddPromotionForm addForm = new AddPromotionForm(_context, _products))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    _promotions.Add(addForm.NewItem);
                    promotionBindingSource.DataSource = _promotions;
                    promotionBindingSource.ResetBindings(false);
                    promotionBindingSource.MoveLast();
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

        private void BuildGridView()
        {
            var qtyGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleRight,
                Format = "N0",
                NullValue = "0"
            };
            // Promotion gridview.
            var promoCodeTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Code",
                HeaderText = "Code",
                MinimumWidth = 80,
                Width = 80,
                ReadOnly = true,
            };
            var promoTitleTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Title",
                HeaderText = "Title",
                MinimumWidth = 8,
                AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true,
            };
            promotionGridView.AutoGenerateColumns = false;
            promotionGridView.Columns.AddRange(new DataGridViewColumn[] {
                promoCodeTextBoxColumn,
                promoTitleTextBoxColumn});
            promotionGridView.DataSource = promotionBindingSource;

            // condition gridview.

            var conditionActionTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ActionName",
                HeaderText = "Action",
                MinimumWidth = 80,
                Width = 80,
                ReadOnly = true,
            };
            var conditionTitleTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ItemName",
                HeaderText = "ItemName",
                AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true,
            };
            var conditionRemarkTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Remarks",
                HeaderText = "Remarks",
                MinimumWidth = 100,
                Width = 160,
                ReadOnly = true,
            };
            conditionGridView.AutoGenerateColumns = false;
            conditionGridView.Columns.AddRange(new DataGridViewColumn[] {
                conditionActionTextBoxColumn,
                conditionTitleTextBoxColumn,
                conditionRemarkTextBoxColumn}); 

            // Attachment gridview.
            var attachSkuTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Sku",
                HeaderText = "SKU",
                MinimumWidth = 80,
                Width = 80,
                ReadOnly = true,
            };
            var attachTitleTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Title",
                HeaderText = "Title",
                MinimumWidth = 8,
                AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true,
            };
            var attachQtyTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Qty",
                HeaderText = "Qty",
                DefaultCellStyle = qtyGridViewCellStyle,
                MinimumWidth = 60,
                Width = 60,
                ReadOnly = true,
            };
            attachmentGridView.AutoGenerateColumns = false;
            attachmentGridView.Columns.AddRange(new DataGridViewColumn[] {
                attachSkuTextBoxColumn,
                attachTitleTextBoxColumn,
                attachQtyTextBoxColumn});
        }

        private void MapBindingSource()
        {
            codeTextBox.DataBindings.Add(new Binding("Text", promotionBindingSource, "Code", true));
            titleTextBox.DataBindings.Add(new Binding("Text", promotionBindingSource, "Title", true));
            descriptionTextBox.DataBindings.Add(new Binding("Text", promotionBindingSource, "Description", true));
            showInListCheckBox.DataBindings.Add(new Binding("Checked", promotionBindingSource, "ShowInList", true));
            inactiveCheckBox.DataBindings.Add(new Binding("Checked", promotionBindingSource, "Inactive", true));
            percentTextBox.DataBindings.Add(new Binding("Text", promotionBindingSource, "PercentDc", true));
            valueTextBox.DataBindings.Add(new Binding("Text", promotionBindingSource, "ValueDc", true));
            maximunTextBox.DataBindings.Add(new Binding("Text", promotionBindingSource, "MaximumDc", true));
            effectiveTextBox.DataBindings.Add(new Binding("Text", promotionBindingSource, "Effective", true));
            expireTextBox.DataBindings.Add(new Binding("Text", promotionBindingSource, "Expire", true));
        }

        private void FilterPromotionList(string keyword = "")
        {
            var result = _promotions;
            if (!string.IsNullOrEmpty(keyword))
            {
                result = _promotions.Where(p => p.Code.StartsWith(keyword) || p.Title.ToLower().Contains(keyword)).ToList();
            }
            promotionBindingSource.DataSource = result;
            promotionBindingSource.ResetBindings(false);
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
    }
}
