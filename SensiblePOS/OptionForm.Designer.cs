
namespace SensiblePOS
{
    partial class OptionForm
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
            this.findReceiptButton = new System.Windows.Forms.Button();
            this.productsButton = new System.Windows.Forms.Button();
            this.systemConfigButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.promotionsButton = new System.Windows.Forms.Button();
            this.accountsButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.changePasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.reportsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // findReceiptButton
            // 
            this.findReceiptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.findReceiptButton.Location = new System.Drawing.Point(213, 11);
            this.findReceiptButton.Margin = new System.Windows.Forms.Padding(2);
            this.findReceiptButton.Name = "findReceiptButton";
            this.findReceiptButton.Size = new System.Drawing.Size(140, 32);
            this.findReceiptButton.TabIndex = 1;
            this.findReceiptButton.Text = "ค้นหาใบเสร็จ";
            this.findReceiptButton.UseVisualStyleBackColor = true;
            this.findReceiptButton.Click += new System.EventHandler(this.findReceiptButton_Click);
            // 
            // productsButton
            // 
            this.productsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productsButton.Enabled = false;
            this.productsButton.Location = new System.Drawing.Point(213, 47);
            this.productsButton.Margin = new System.Windows.Forms.Padding(2);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(140, 32);
            this.productsButton.TabIndex = 2;
            this.productsButton.Text = "ข้อมูลสินค้า";
            this.productsButton.UseVisualStyleBackColor = true;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            // 
            // systemConfigButton
            // 
            this.systemConfigButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.systemConfigButton.Enabled = false;
            this.systemConfigButton.Location = new System.Drawing.Point(213, 209);
            this.systemConfigButton.Margin = new System.Windows.Forms.Padding(2);
            this.systemConfigButton.Name = "systemConfigButton";
            this.systemConfigButton.Size = new System.Drawing.Size(140, 32);
            this.systemConfigButton.TabIndex = 3;
            this.systemConfigButton.Text = "ตั้งค่าระบบ";
            this.systemConfigButton.UseVisualStyleBackColor = true;
            this.systemConfigButton.Click += new System.EventHandler(this.systemConfigButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(213, 255);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(140, 32);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "ปิด";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.clนหำButton_Click);
            // 
            // promotionsButton
            // 
            this.promotionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.promotionsButton.Enabled = false;
            this.promotionsButton.Location = new System.Drawing.Point(213, 83);
            this.promotionsButton.Margin = new System.Windows.Forms.Padding(2);
            this.promotionsButton.Name = "promotionsButton";
            this.promotionsButton.Size = new System.Drawing.Size(140, 32);
            this.promotionsButton.TabIndex = 5;
            this.promotionsButton.Text = "โปรโมชั่น";
            this.promotionsButton.UseVisualStyleBackColor = true;
            this.promotionsButton.Click += new System.EventHandler(this.promotionsButton_Click);
            // 
            // accountsButton
            // 
            this.accountsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accountsButton.Enabled = false;
            this.accountsButton.Location = new System.Drawing.Point(213, 173);
            this.accountsButton.Margin = new System.Windows.Forms.Padding(2);
            this.accountsButton.Name = "accountsButton";
            this.accountsButton.Size = new System.Drawing.Size(140, 32);
            this.accountsButton.TabIndex = 6;
            this.accountsButton.Text = "ผู้ใช้งาน";
            this.accountsButton.UseVisualStyleBackColor = true;
            this.accountsButton.Click += new System.EventHandler(this.accountsButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.Location = new System.Drawing.Point(12, 22);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(83, 21);
            this.usernameLabel.TabIndex = 7;
            this.usernameLabel.Text = "Username";
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstnameLabel.Location = new System.Drawing.Point(27, 60);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(69, 19);
            this.firstnameLabel.TabIndex = 8;
            this.firstnameLabel.Text = "Firstname";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastnameLabel.Location = new System.Drawing.Point(27, 91);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(68, 19);
            this.lastnameLabel.TabIndex = 9;
            this.lastnameLabel.Text = "Lastname";
            // 
            // changePasswordLinkLabel
            // 
            this.changePasswordLinkLabel.ActiveLinkColor = System.Drawing.Color.Blue;
            this.changePasswordLinkLabel.AutoSize = true;
            this.changePasswordLinkLabel.Location = new System.Drawing.Point(27, 153);
            this.changePasswordLinkLabel.Name = "changePasswordLinkLabel";
            this.changePasswordLinkLabel.Size = new System.Drawing.Size(83, 17);
            this.changePasswordLinkLabel.TabIndex = 10;
            this.changePasswordLinkLabel.TabStop = true;
            this.changePasswordLinkLabel.Text = "เปลี่ยนรหัสผ่าน";
            this.changePasswordLinkLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.changePasswordLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.changePasswordLinkLabel_LinkClicked);
            // 
            // reportsButton
            // 
            this.reportsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reportsButton.Enabled = false;
            this.reportsButton.Location = new System.Drawing.Point(213, 119);
            this.reportsButton.Margin = new System.Windows.Forms.Padding(2);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(140, 32);
            this.reportsButton.TabIndex = 11;
            this.reportsButton.Text = "รายงาน";
            this.reportsButton.UseVisualStyleBackColor = true;
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // OptionForm
            // 
            this.AcceptButton = this.closeButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(364, 301);
            this.ControlBox = false;
            this.Controls.Add(this.reportsButton);
            this.Controls.Add(this.changePasswordLinkLabel);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.accountsButton);
            this.Controls.Add(this.promotionsButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.systemConfigButton);
            this.Controls.Add(this.productsButton);
            this.Controls.Add(this.findReceiptButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ตัวเลือก";
            this.Load += new System.EventHandler(this.OptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findReceiptButton;
        private System.Windows.Forms.Button productsButton;
        private System.Windows.Forms.Button systemConfigButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button promotionsButton;
        private System.Windows.Forms.Button accountsButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.LinkLabel changePasswordLinkLabel;
        private System.Windows.Forms.Button reportsButton;
    }
}