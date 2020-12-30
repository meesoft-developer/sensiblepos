using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SensiblePOS.LogIn
{
    public partial class LoginForm : Form
    {
        public UserPasswordInfo SuccessUser { get; set; }

        public string CustomErrorMessage { get; set; }

        public string AuthenSalt { get; set; }

        private List<UserPasswordInfo> _users = null;

        public LoginForm(List<UserPasswordInfo> users, Icon icon = null)
        {
            InitializeComponent();
            _users = users;
            if (icon != null)
            {
                this.Icon = icon;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string user = usernameTextBox.Text;
            string password = AuthenTools.GetPasswordHash(user, passwordTextBox.Text, AuthenSalt); 
            var exist = _users.FirstOrDefault(u => u.Username == user && u.Password == password);
            if (exist != null)
            {
                SuccessUser = exist;
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                string msg = !string.IsNullOrEmpty(CustomErrorMessage) ? CustomErrorMessage : "Invalid username or password.";
                MessageBox.Show(msg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
