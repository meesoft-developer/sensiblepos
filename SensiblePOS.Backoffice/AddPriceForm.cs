using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SensiblePOS.Data;
namespace SensiblePOS.Backoffice
{
    public partial class AddPriceForm : Form
    {
        public Price NewItem { get; set; }
        private decimal _lastPrice = 0;
        private ResourceManager _locRM = new ResourceManager("SensiblePOS.Backoffice.Resources.AddPriceForm", typeof(AddPriceForm).Assembly);
        public AddPriceForm(decimal currentPrice)
        {
            InitializeComponent();
            _lastPrice = currentPrice;
        }

        private void AddPriceForm_Load(object sender, EventArgs e)
        {
            priceNumericUpDown.Value = _lastPrice;
            effectiveDateTimePicker.MinDate = DateTime.Now.Date;
            expireDateTimePicker.Value = DateTime.Now.Date.AddMonths(3);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var realExpDate = expireDateTimePicker.Value.Date.AddDays(1).AddMinutes(-1);
            if (effectiveDateTimePicker.Value > realExpDate)
            {
                //MessageBox.Show("Effective must before Expire.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(_locRM.GetString("DAILOG_MSG_EFFECTIVE_ERROR"), _locRM.GetString("DAILOG_TITLE_VALIDATION"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                effectiveDateTimePicker.Select();
                return;
            }
            NewItem = new Price
            {
                Value = priceNumericUpDown.Value,
                ProductId = 0,
                EffectiveDate = effectiveDateTimePicker.Value.Date,
                ExpireDate = realExpDate,
                WorkdaySale = workdayCheckBox.Checked,
                NotWorkdaySale = weekendCheckBox.Checked,
                FirstHalfSale = firstHalfCheckBox.Checked,
                SecondHalfSale = secondHalfCheckBox.Checked,
                Inactive = false,
            };
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
