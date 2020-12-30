using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SensiblePOS.Models;
namespace SensiblePOS
{
    public partial class SelectCardIssuerForm : Form
    {
        public SelectableItemInfo SelectedItem { get; set; }
        public SelectCardIssuerForm(List<SelectableItemInfo> choices)
        {
            InitializeComponent();
            selectableItemInfoBindingSource.DataSource = choices;
        }

        private void itemDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectAndClose();
        }

        private void canceButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SelectAndClose();
        }

        private void SelectAndClose()
        {
            this.SelectedItem = selectableItemInfoBindingSource.Current as SelectableItemInfo;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
