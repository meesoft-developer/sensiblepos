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
    public partial class ChangePasswordForm : Form
    {
        public string NewPassword { get; set; }
        public string Salt { get; set; }
        private string _currentUserName = "";
        private string _oldPassword = "";
        public ChangePasswordForm(string userName, string oldPassword)
        {
            InitializeComponent();
            _currentUserName = userName;
            _oldPassword = oldPassword;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            // Validate length.
            if (newPassTextBox.Text.Length < 4)
            {
                MessageBox.Show("Require at least 4 charactors password length.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newPassTextBox.Select();
                return;
            }
            // Validate new & confirm.

            if (newPassTextBox.Text != confirmPassTextBox.Text)
            {
                MessageBox.Show("New Password and Confirm password should be same.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                confirmPassTextBox.Select();
                return;
            }

            // Validate currentPassword.
            var currentPassKey = AuthenTools.GetPasswordHash(_currentUserName, currentPassTextBox.Text, Salt);
            if (currentPassKey != _oldPassword)
            {
                MessageBox.Show("Invalid Password.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentPassTextBox.Focus();
                return;
            }
            NewPassword = AuthenTools.GetPasswordHash(_currentUserName, newPassTextBox.Text, Salt);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
