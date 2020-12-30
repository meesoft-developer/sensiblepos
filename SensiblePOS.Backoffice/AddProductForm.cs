using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;
using SensiblePOS.Data;
namespace SensiblePOS.Backoffice
{
    public partial class AddProductForm : Form
    {
        public Product NewItem { get; set; }
        private SensiblePOSContext _context = null;
        private ResourceManager _locRM = new ResourceManager("SensiblePOS.Backoffice.Resources.AddProductForm", typeof(AddProductForm).Assembly);

        public AddProductForm(SensiblePOSContext context)
        {
            InitializeComponent();
            _context = context;
            var zones = _context.Zones.Where(z => !z.Inactive).OrderBy(z => z.Title).ToList();
            zoneComboBox.DisplayMember = "Title";
            zoneComboBox.ValueMember = "Id";
            zoneComboBox.DataSource = new BindingSource(zones, null);
            zoneComboBox.SelectedIndex = 0;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            // Validate completation data.
            //
            if (string.IsNullOrEmpty(skuTextBox.Text))
            {
                MessageBox.Show(_locRM.GetString("DIALOG_MSG_SKU_MISSING"), _locRM.GetString("DAILOG_TITLE_VALIDATION"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                skuTextBox.Select();
                return;
            }
            var existSku = _context.Products.FirstOrDefault(p => p.Sku == skuTextBox.Text);
            if (existSku != null)
            {
                MessageBox.Show(_locRM.GetString("DIALOG_MSG_SKU_ALREADY_EXIST"), _locRM.GetString("DAILOG_TITLE_VALIDATION"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                skuTextBox.Select();
                return;
            }
            if (string.IsNullOrEmpty(titleTextBox.Text))
            {
                MessageBox.Show(_locRM.GetString("DIALOG_MSG_TITLE_MISSING"), _locRM.GetString("DAILOG_TITLE_VALIDATION"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                titleTextBox.Select();
                return;
            }

            var product = new Product
            {
                Code = Guid.NewGuid().ToString("N"),
                Sku = skuTextBox.Text,
                Title = titleTextBox.Text,  
                Salable = true,
                UnitName = _locRM.GetString("DEFAULT_UNIT_NAME"),
                PromotionEffect = promoEffectCheckBox.Checked,
                Qty =  (int)qtyNumeric.Value, 
                UseQty = 1,
                Inactive = false,
            };
            _context.Products.Add(product);
            _context.SaveChanges();
            var tier = new Price
            {
                EffectiveDate = effectiveDateTimePicker.Value,
                ExpireDate = expireDateTimePicker.Value.Date.AddDays(1).AddMinutes(-1),
                Inactive = false,
                Value = priceNumeric.Value,
                ProductId = product.Id,
                FirstHalfSale = true,
                SecondHalfSale = true,
                WorkdaySale = true,
                NotWorkdaySale = true
            };
            _context.Prices.Add(tier);

            var stock = new ZoneProduct
            {
                ZoneId = (int)zoneComboBox.SelectedValue,
                ProductId = product.Id,
                Category = "",
                Qty = (int)qtyNumeric.Value,
                LastQty = (int)qtyNumeric.Value,
                UpdateDate = DateTime.Now,
                Inactive = false
            };
            _context.ZoneProducts.Add(stock);
            _context.SaveChanges();
            NewItem = product;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
