using System;
using System.Windows.Forms;

namespace SensiblePOS
{
    public partial class VoidForm : Form
    {
        public string ReasonText { get; set; }
        public bool NeedPrint { get; set; }
        public bool Restock { get; set; }
        public VoidForm(string message)
        {
            InitializeComponent();
            messageLabel.Text = message;
        }

        private void canceButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            ReasonText = reasonTextBox.Text;
            NeedPrint = printCheckBox.Checked;
            Restock = restockCheckBox.Checked;
            DialogResult = DialogResult.OK;
        }
    }
}
