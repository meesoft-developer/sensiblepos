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
    public partial class AddStockForm : Form
    {
        public int SelectedZoneId { get; set; }
        public int SelectedQty { get; set; }

        private BindingSource zoneBindingSource = null;

        private ResourceManager _locRM = new ResourceManager("SensiblePOS.Backoffice.Resources.AddStockForm", typeof(AddStockForm).Assembly);

        public AddStockForm(List<ProductZoneInfo> zoneStocks, int totalQty)
        {
            InitializeComponent();
            allZoneLabel.Text = string.Format(_locRM.GetString("MASK_ALL_ZONE_QTY"), totalQty); 
            zoneBindingSource = new BindingSource();
            zoneBindingSource.DataSource = zoneStocks;
            zoneBindingSource.CurrentChanged += ZoneBindingSource_CurrentChanged;
            zoneComboBox.DisplayMember = "ZoneName";
            zoneComboBox.ValueMember = "Id";
            zoneComboBox.DataSource = zoneBindingSource;
            zoneBindingSource.ResetBindings(false);
        }

        private void ZoneBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var current = zoneBindingSource.Current as ProductZoneInfo;
            if(current != null)
            {
                currentInZoneLabel.Text = string.Format(_locRM.GetString("MASK_CURRENT_ZONE_QTY"), current.Qty);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SelectedZoneId = (int)zoneComboBox.SelectedValue;
            SelectedQty = (int)qtyNumeric.Value;
            DialogResult = DialogResult.OK;
        }
    }
}
