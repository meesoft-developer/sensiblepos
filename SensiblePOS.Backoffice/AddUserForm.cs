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

using SensiblePOS.Data;
namespace SensiblePOS.Backoffice
{
    public partial class AddUserForm : Form
    {
        public Account NewItem { get; set; }
        private List<string> _existUsers;
        private ResourceManager _locRM = new ResourceManager("SensiblePOS.Backoffice.Resources.AddUserForm", typeof(AddUserForm).Assembly);
        public AddUserForm(List<AccountType> accountTypes, List<string> existUsers)
        {
            InitializeComponent();
            _existUsers = existUsers;
            typeComboBox.DisplayMember = "Value";
            typeComboBox.ValueMember = "Key";
            typeComboBox.DataSource = accountTypes.ToDictionary(z => z.Id, z => z.Title).ToList();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var username = usernameTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(username)) return;
            if (_existUsers.Contains(username))
            {
                string msg = string.Format(_locRM.GetString("DIALOG_MSG_USER_ALREADY_EXIST"), username);
                MessageBox.Show(msg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var rand = new Random();
            NewItem = new Account
            {
                Username = username,
                Password = rand.Next(999).ToString("000") + rand.Next(999).ToString("000"),
                Firstname = firstnameTextBox.Text, 
                Lastname = lastnameTextBox.Text,
                Effective = DateTime.Now,
                Expire = DateTime.Now.AddYears(5),
                AccountType = (int)typeComboBox.SelectedValue,
                Inactive = false,
            };
            DialogResult = DialogResult.OK;
        }
    }
}
