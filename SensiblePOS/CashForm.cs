using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SensiblePOS.Models;

namespace SensiblePOS
{
    public partial class CashForm : Form
    {
        public PaymentSummaryInfo Payment { get; set; }
        private decimal _totalFee = 0;
        private decimal _change = 0;
        public CashForm(PaymentSummaryInfo summary)
        {
            InitializeComponent();
            Payment = summary;
            _totalFee = summary.Total;
        }

        private void CashForm_Load(object sender, EventArgs e)
        {
            totalFeeTextBox.Text = _totalFee.ToString("N2");
        }

        private void canceButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            decimal change = 0;
            if (!CaculateIncomeText(out change))
            {
                incomeTextBox.Focus();
                okButton.Enabled = false;
                _change = change;
                changeTxtBox.Text = _change.ToString("0.00");
                return;
            }
            else
            {
                if (change != _change)
                {
                    _change = change;
                    changeTxtBox.Text = _change.ToString("0.00");
                    return;
                }
            }

            Payment.Payment = Convert.ToDecimal(incomeTextBox.Text);
            Payment.Change = _change;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void incomeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8) //Back space.
            {
                if (e.KeyChar == 13)
                {
                    if (CaculateIncomeText(out _change))
                    {
                        okButton.Enabled = true;
                        okButton.Select();
                    }
                    else
                    {
                        okButton.Enabled = false;
                    }
                    changeTxtBox.Text = _change.ToString("0.00");

                    e.Handled = false;
                    return;
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                    e.Handled = true;
            }
        }

        private bool CaculateIncomeText(out decimal change)
        {
            change = 0;
            if (string.IsNullOrEmpty(incomeTextBox.Text))
            {
                incomeTextBox.Text = "0";
            }
            if (Convert.ToInt32(incomeTextBox.Text) >= _totalFee)
            {
                change = Convert.ToInt32(incomeTextBox.Text) - _totalFee;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
