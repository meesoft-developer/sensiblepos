using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensiblePOS
{
    public partial class FullTaxForm : Form
    {
        public string Customer { get; set; }
        public string TaxId { get; set; }
        public string Address { get; set; }
        public FullTaxForm(string name, string taxId, string address)
        {
            InitializeComponent();

            nameTextBox.Text = name;
            taxIdTextBox.Text = taxId;
            addressTextBox.Text = address;
        }

        private void canceButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Customer = nameTextBox.Text;
            TaxId = taxIdTextBox.Text;
            Address = addressTextBox.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
