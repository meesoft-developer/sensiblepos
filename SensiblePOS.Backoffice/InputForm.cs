using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensiblePOS.Backoffice
{
    public partial class InputForm : Form
    {
        public string Value { get; set; } 
        public InputForm(string value = "", int maxLength = 250)
        {
            InitializeComponent();
            inputTextBox.Text = value;
            inputTextBox.MaxLength = maxLength;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Value = inputTextBox.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
