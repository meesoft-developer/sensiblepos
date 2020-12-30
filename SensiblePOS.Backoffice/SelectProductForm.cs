using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SensiblePOS.Data;
namespace SensiblePOS.Backoffice
{
    public partial class SelectProductForm : Form
    {
        public Product Selected { get; set; }
        public decimal Qty { get; set; }

        private List<Product> _products = null;
        private BindingSource productBindingSource = new BindingSource();
        public SelectProductForm(List<Product> products, bool showQty = false)
        {
            InitializeComponent();
            _products = products;
            qtyLabel.Visible = qtyNumeric.Visible = showQty;
            productBindingSource.DataSource = _products;
            BuildGridView();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string keyword = keywordTextBox.Text;
            var products = (from p in _products
                            where (p.Title.Contains(keyword)
                            || p.Sku.Contains(keyword))
                            select p).OrderBy(p => p.Sku).ToList();
            productBindingSource.DataSource = products;
        }

        private void productGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DoSelectItem();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DoSelectItem();
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
        }

        private void DoSelectItem()
        {
            var current = productBindingSource.Current as Product;
            if (current != null)
            {
                Selected = current;
            }
            Qty = qtyNumeric.Value;
            DialogResult = DialogResult.OK;
        }
    }
}
