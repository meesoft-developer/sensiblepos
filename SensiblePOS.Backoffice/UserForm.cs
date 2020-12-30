using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;

using SensiblePOS.Data;
using SensiblePOS.LogIn;
namespace SensiblePOS.Backoffice
{
    public partial class UserForm : Form
    {
        private BindingSource userBindingSource;
        private SensiblePOSContext _context = null;
        private string _passwordSalt = "";
        private string _adminname = "";
        private List<Account> _users = null;
        private List<AccountType> _types = null;

        private ResourceManager _locRM = new ResourceManager("SensiblePOS.Backoffice.Resources.UserForm", typeof(UserForm).Assembly);
        public UserForm(SensiblePOSContext context, string salt, string username)
        {
            InitializeComponent();
            InitBindingSourceAndMapping();
            BuildGridView();
            _context = context;
            _passwordSalt = salt;
            _adminname = username;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            _types = _context.AccountTypes.Where(t => !t.Inactive).ToList();
            _users = _context.Accounts.OrderBy(a => a.Username).ToList();
            userBindingSource.DataSource = _users;
            userBindingSource.ResetBindings(false);

            typeComboBox.DisplayMember = "Title";
            typeComboBox.ValueMember = "Id";
            typeComboBox.DataSource = _types;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            FilterProductList(keywordTextBox.Text);
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            using (var newUserForm = new AddUserForm(_types, _users.Select(u => u.Username).ToList()))
            {
                if (newUserForm.ShowDialog() == DialogResult.OK)
                {
                    var newItem = newUserForm.NewItem;
                    var randomPassword = newItem.Password;
                    newItem.Password = AuthenTools.GetPasswordHash(newItem.Username, newItem.Password, _passwordSalt);
                    _context.Accounts.Add(newItem);
                    var typeName = _types.Where(t => t.Id == newItem.AccountType).Select(t => t.Title).FirstOrDefault();
                    var log = new AdminLog
                    {
                        Action = "NewUser",
                        EntryDate = DateTime.Now,
                        UserName = _adminname,
                        Detail = string.Format("for user:{0}; ({1})", newItem.Username, typeName)
                    };
                    _context.AdminLogs.Add(log);
                    _context.SaveChanges();

                    string messageText = string.Format(_locRM.GetString("DIALOG_MSG_ADD_USER"), 
                        newItem.Username, randomPassword);
                    MessageBox.Show(messageText, _locRM.GetString("DIALOG_TITLE_ADD_USER"), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _users.Add(newItem);
                    userBindingSource.DataSource = _users;
                    userBindingSource.ResetBindings(false);
                    userBindingSource.MoveLast();
                    keywordTextBox.Text = "";
                }
            }
        } 

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Account currentUser = (Account)userBindingSource.Current;
            if (currentUser != null)
            {
                currentUser.AccountType = (int)typeComboBox.SelectedValue;
            }
        }

        private void resetPasswordButton_Click(object sender, EventArgs e)
        {
            Account currentUser = (Account)userBindingSource.Current;
            if (currentUser != null)
            {
                var rand = new Random();
                string randomPassword = rand.Next(999).ToString("000") + rand.Next(999).ToString("000");
                currentUser.Password = AuthenTools.GetPasswordHash(currentUser.Username, randomPassword, _passwordSalt);
                var typeName = _types.Where(t => t.Id == currentUser.AccountType).Select(t => t.Title).FirstOrDefault();
                var log = new AdminLog
                {
                    Action = "ResetPassword",
                    EntryDate = DateTime.Now,
                    UserName = _adminname,
                    Detail = string.Format("for user:{0}; ({1})", currentUser.Username, typeName)
                };
                _context.AdminLogs.Add(log);
                _context.SaveChanges();
                
                string messageText = string.Format(_locRM.GetString("DIALOG_MSG_RESET_PASSWORD"), currentUser.Username, randomPassword);
                MessageBox.Show(messageText, _locRM.GetString("DIALOG_TITLE_RESET_PASSWORD"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UserBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var user = userBindingSource.Current as Account;
            if (user != null)
            {
                var userType = _types.Where(t => t.Id == user.AccountType).FirstOrDefault();
                typeComboBox.SelectedValue = userType.Id;
            }
        }

        private void UserBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (SaveChange())
            {
                saveButton.Enabled = false;
            }
        }

        private void BuildGridView()
        { 
            var usernameTextBoxColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Username",
                HeaderText = "Username",
                AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true,
            }; 

            userGridView.AutoGenerateColumns = false;
            userGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                usernameTextBoxColumn});
            userGridView.DataSource = userBindingSource;
        }

        private void InitBindingSourceAndMapping()
        {
            userBindingSource = new BindingSource();
            userBindingSource.DataSource = typeof(Account);
            userBindingSource.CurrentChanged += UserBindingSource_CurrentChanged;
            userBindingSource.CurrentItemChanged += UserBindingSource_CurrentItemChanged;
            // Map data in General group box.
            usernameTextBox.DataBindings.Add(new Binding("Text", userBindingSource, "Username", true));
            firstnameTextBox.DataBindings.Add(new Binding("Text", userBindingSource, "Firstname", true));
            lastnameTextBox.DataBindings.Add(new Binding("Text", userBindingSource, "Lastname", true)); 
            inactiveCheckBox.DataBindings.Add(new Binding("Checked", userBindingSource, "Inactive", true)); 
        } 

        private void FilterProductList(string keyword = "")
        {
            List<Account> result = _users;
            if (!string.IsNullOrEmpty(keyword))
            {
                result = _users.Where(p => p.Username.Contains(keyword)).ToList();
            }
            userBindingSource.DataSource = result;
            userBindingSource.ResetBindings(false);
        }

        private bool SaveChange()
        {
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
