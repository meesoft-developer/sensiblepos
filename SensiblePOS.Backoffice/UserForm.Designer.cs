
namespace SensiblePOS.Backoffice
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listPanel = new System.Windows.Forms.Panel();
            this.addUserButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.keywordTextBox = new System.Windows.Forms.TextBox();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.generalGroupBox = new System.Windows.Forms.GroupBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.inactiveCheckBox = new System.Windows.Forms.CheckBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.resetPasswordButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.listPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            this.generalGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listPanel
            // 
            this.listPanel.Controls.Add(this.addUserButton);
            this.listPanel.Controls.Add(this.searchButton);
            this.listPanel.Controls.Add(this.keywordTextBox);
            this.listPanel.Controls.Add(this.userGridView);
            this.listPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.listPanel.Location = new System.Drawing.Point(0, 0);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(300, 661);
            this.listPanel.TabIndex = 2;
            // 
            // addUserButton
            // 
            this.addUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addUserButton.Location = new System.Drawing.Point(11, 626);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(32, 23);
            this.addUserButton.TabIndex = 3;
            this.addUserButton.Text = "+";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(219, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(81, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "ค้นหา";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // keywordTextBox
            // 
            this.keywordTextBox.Location = new System.Drawing.Point(13, 12);
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.PlaceholderText = "username";
            this.keywordTextBox.Size = new System.Drawing.Size(200, 23);
            this.keywordTextBox.TabIndex = 0;
            // 
            // userGridView
            // 
            this.userGridView.AllowUserToAddRows = false;
            this.userGridView.AllowUserToDeleteRows = false;
            this.userGridView.AllowUserToResizeRows = false;
            this.userGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView.Location = new System.Drawing.Point(11, 41);
            this.userGridView.Margin = new System.Windows.Forms.Padding(2);
            this.userGridView.Name = "userGridView";
            this.userGridView.ReadOnly = true;
            this.userGridView.RowHeadersVisible = false;
            this.userGridView.RowHeadersWidth = 32;
            this.userGridView.RowTemplate.Height = 30;
            this.userGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userGridView.Size = new System.Drawing.Size(289, 580);
            this.userGridView.TabIndex = 2;
            // 
            // generalGroupBox
            // 
            this.generalGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalGroupBox.Controls.Add(this.typeComboBox);
            this.generalGroupBox.Controls.Add(this.typeLabel);
            this.generalGroupBox.Controls.Add(this.inactiveCheckBox);
            this.generalGroupBox.Controls.Add(this.lastnameTextBox);
            this.generalGroupBox.Controls.Add(this.lastnameLabel);
            this.generalGroupBox.Controls.Add(this.firstnameTextBox);
            this.generalGroupBox.Controls.Add(this.firstnameLabel);
            this.generalGroupBox.Controls.Add(this.usernameTextBox);
            this.generalGroupBox.Controls.Add(this.usernameLabel);
            this.generalGroupBox.Location = new System.Drawing.Point(312, 12);
            this.generalGroupBox.Name = "generalGroupBox";
            this.generalGroupBox.Size = new System.Drawing.Size(660, 157);
            this.generalGroupBox.TabIndex = 3;
            this.generalGroupBox.TabStop = false;
            this.generalGroupBox.Text = "ข้อมูลทั่วไป";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(27, 120);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(67, 15);
            this.typeLabel.TabIndex = 12;
            this.typeLabel.Text = "ประเภทบัญชี:";
            // 
            // inactiveCheckBox
            // 
            this.inactiveCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inactiveCheckBox.AutoSize = true;
            this.inactiveCheckBox.Location = new System.Drawing.Point(565, 22);
            this.inactiveCheckBox.Name = "inactiveCheckBox";
            this.inactiveCheckBox.Size = new System.Drawing.Size(74, 19);
            this.inactiveCheckBox.TabIndex = 9;
            this.inactiveCheckBox.Text = "ระงับใช้งาน";
            this.inactiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Location = new System.Drawing.Point(96, 88);
            this.lastnameTextBox.MaxLength = 128;
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(180, 23);
            this.lastnameTextBox.TabIndex = 10;
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(27, 91);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(48, 15);
            this.lastnameLabel.TabIndex = 4;
            this.lastnameLabel.Text = "นามสกุล:";
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.Location = new System.Drawing.Point(96, 59);
            this.firstnameTextBox.MaxLength = 128;
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(180, 23);
            this.firstnameTextBox.TabIndex = 3;
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Location = new System.Drawing.Point(27, 62);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(23, 15);
            this.firstnameLabel.TabIndex = 2;
            this.firstnameLabel.Text = "ชื่อ:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.usernameTextBox.Location = new System.Drawing.Point(96, 30);
            this.usernameTextBox.MaxLength = 100;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            this.usernameTextBox.Size = new System.Drawing.Size(180, 23);
            this.usernameTextBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(27, 33);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(47, 15);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "ชื่อบัญชี:";
            // 
            // resetPasswordButton
            // 
            this.resetPasswordButton.Location = new System.Drawing.Point(312, 175);
            this.resetPasswordButton.Name = "resetPasswordButton";
            this.resetPasswordButton.Size = new System.Drawing.Size(120, 23);
            this.resetPasswordButton.TabIndex = 14;
            this.resetPasswordButton.Text = "รีเซ็ตพาสเวิร์ด...";
            this.resetPasswordButton.UseVisualStyleBackColor = true;
            this.resetPasswordButton.Click += new System.EventHandler(this.resetPasswordButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(852, 617);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 32);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "บันทึก";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(96, 117);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(180, 23);
            this.typeComboBox.TabIndex = 13;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // UserForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resetPasswordButton);
            this.Controls.Add(this.generalGroupBox);
            this.Controls.Add(this.listPanel);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "จัดการผู้ใช้งาน";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.listPanel.ResumeLayout(false);
            this.listPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            this.generalGroupBox.ResumeLayout(false);
            this.generalGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox keywordTextBox;
        private System.Windows.Forms.DataGridView userGridView;
        private System.Windows.Forms.GroupBox generalGroupBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.CheckBox inactiveCheckBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button resetPasswordButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox typeComboBox;
    }
}