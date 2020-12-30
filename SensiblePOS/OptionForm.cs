using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SensiblePOS.LogIn;
using SensiblePOS.Data;

namespace SensiblePOS
{
    public enum OptionCommand
    {
        FindReceipt,
        ProductForm,
        PromotionForm,
        AccountForm,
        ReportForm,
        SystemForm
    }
    public partial class OptionForm : Form
    {
        public OptionCommand Selected { get; set; }

        private SensiblePOSContext _context;
        private string _currentUser;
        private string _authenSalt;

        private ResourceManager _locRM = new ResourceManager("SensiblePOS.Resources.OptionForm", typeof(OptionForm).Assembly);
        public OptionForm(SensiblePOSContext context, string username, string authenSalt)
        {
            InitializeComponent();
            _context = context;
            _currentUser = username;
            _authenSalt = authenSalt;
        }
        
        private void OptionForm_Load(object sender, EventArgs e)
        {
            var targetUser = _context.Accounts.FirstOrDefault(a => a.Username == _currentUser);
            usernameLabel.Text = targetUser?.Username;
            firstnameLabel.Text = targetUser?.Firstname;
            lastnameLabel.Text = targetUser?.Lastname;
            var accountType = _context.AccountTypes.FirstOrDefault(t => t.Id == targetUser.AccountType);
            if(accountType != null)
            {
                productsButton.Enabled = accountType.AccessPortal;
                promotionsButton.Enabled = accountType.AccessPortal;
                reportsButton.Enabled = accountType.AccessReport;
                accountsButton.Enabled = accountType.AccessAccountReport;
                systemConfigButton.Enabled = accountType.AccessPortal;
            }
        }

        private void changePasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var targetUser = _context.Accounts.FirstOrDefault(a => a.Username == _currentUser);
            if (targetUser == null) return;
            using (var changeForm = new ChangePasswordForm(targetUser.Username, targetUser.Password))
            {
                changeForm.Salt = _authenSalt;
                if (changeForm.ShowDialog() == DialogResult.OK)
                {
                    targetUser.Password = changeForm.NewPassword;
                    _context.SaveChanges();
                    MessageBox.Show(_locRM.GetString("DIALOG_MSG_PASSWORD_CHANGED"), _locRM.GetString("DIALOG_TITLE_CHANGE_PASSWORD"), MessageBoxButtons.OK); 
                }
            }
        }

        private void findReceiptButton_Click(object sender, EventArgs e)
        {
            Selected = OptionCommand.FindReceipt;
            DialogResult = DialogResult.OK;
        } 

        private void productsButton_Click(object sender, EventArgs e)
        {
            Selected = OptionCommand.ProductForm;
            DialogResult = DialogResult.OK; 
        }

        private void promotionsButton_Click(object sender, EventArgs e)
        {
            Selected = OptionCommand.PromotionForm;
            DialogResult = DialogResult.OK;
        }
        private void reportsButton_Click(object sender, EventArgs e)
        {
            Selected = OptionCommand.ReportForm;
            DialogResult = DialogResult.OK;
        }

        private void accountsButton_Click(object sender, EventArgs e)
        {
            Selected = OptionCommand.AccountForm;
            DialogResult = DialogResult.OK;
        }

        private void systemConfigButton_Click(object sender, EventArgs e)
        {
            Selected = OptionCommand.SystemForm;
            DialogResult = DialogResult.OK;
        }

        private void clนหำButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
