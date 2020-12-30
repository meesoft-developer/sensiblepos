
namespace SensiblePOS
{
    partial class LogoutForm
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
            this.canceButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.printLinkLabel = new System.Windows.Forms.LinkLabel();
            this.memoTextBox = new System.Windows.Forms.TextBox();
            this.performGroupBox = new System.Windows.Forms.GroupBox();
            this.totalCountLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.totalCaptionLabel = new System.Windows.Forms.Label();
            this.promptpayCountLabel = new System.Windows.Forms.Label();
            this.promptpayTextBox = new System.Windows.Forms.TextBox();
            this.promptpayCaptionLabel = new System.Windows.Forms.Label();
            this.creditcardCountLabel = new System.Windows.Forms.Label();
            this.cashCountLabel = new System.Windows.Forms.Label();
            this.creditcardTextBox = new System.Windows.Forms.TextBox();
            this.cashTextBox = new System.Windows.Forms.TextBox();
            this.creditcardCaptionLabel = new System.Windows.Forms.Label();
            this.cashCaptionLabel = new System.Windows.Forms.Label();
            this.userGroupBox = new System.Windows.Forms.GroupBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.toCaptionLabel = new System.Windows.Forms.Label();
            this.fromCaptionLabel = new System.Windows.Forms.Label();
            this.userCaptionLabel = new System.Windows.Forms.Label();
            this.savePerformanceCheckBox = new System.Windows.Forms.CheckBox();
            this.updateStockCheckBox = new System.Windows.Forms.CheckBox();
            this.progressLabel = new System.Windows.Forms.Label();
            this.performGroupBox.SuspendLayout();
            this.userGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // canceButton
            // 
            this.canceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.canceButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.canceButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.canceButton.Location = new System.Drawing.Point(186, 593);
            this.canceButton.Name = "canceButton";
            this.canceButton.Size = new System.Drawing.Size(100, 36);
            this.canceButton.TabIndex = 23;
            this.canceButton.Text = "ยกเลิก";
            this.canceButton.UseVisualStyleBackColor = true;
            this.canceButton.Click += new System.EventHandler(this.canceButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.okButton.Location = new System.Drawing.Point(80, 593);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 36);
            this.okButton.TabIndex = 22;
            this.okButton.Text = "ตกลง";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "โน๊ต:";
            // 
            // printLinkLabel
            // 
            this.printLinkLabel.ActiveLinkColor = System.Drawing.Color.Blue;
            this.printLinkLabel.AutoSize = true;
            this.printLinkLabel.Enabled = false;
            this.printLinkLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.printLinkLabel.Location = new System.Drawing.Point(245, 371);
            this.printLinkLabel.Name = "printLinkLabel";
            this.printLinkLabel.Size = new System.Drawing.Size(105, 20);
            this.printLinkLabel.TabIndex = 20;
            this.printLinkLabel.TabStop = true;
            this.printLinkLabel.Text = "พิมพ์รายงานนี้";
            this.printLinkLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.printLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.printLinkLabel_LinkClicked);
            // 
            // memoTextBox
            // 
            this.memoTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.memoTextBox.Location = new System.Drawing.Point(12, 394);
            this.memoTextBox.MaxLength = 200;
            this.memoTextBox.Multiline = true;
            this.memoTextBox.Name = "memoTextBox";
            this.memoTextBox.PlaceholderText = "200 ตัวอักษร";
            this.memoTextBox.Size = new System.Drawing.Size(340, 112);
            this.memoTextBox.TabIndex = 19;
            // 
            // performGroupBox
            // 
            this.performGroupBox.Controls.Add(this.totalCountLabel);
            this.performGroupBox.Controls.Add(this.totalTextBox);
            this.performGroupBox.Controls.Add(this.totalCaptionLabel);
            this.performGroupBox.Controls.Add(this.promptpayCountLabel);
            this.performGroupBox.Controls.Add(this.promptpayTextBox);
            this.performGroupBox.Controls.Add(this.promptpayCaptionLabel);
            this.performGroupBox.Controls.Add(this.creditcardCountLabel);
            this.performGroupBox.Controls.Add(this.cashCountLabel);
            this.performGroupBox.Controls.Add(this.creditcardTextBox);
            this.performGroupBox.Controls.Add(this.cashTextBox);
            this.performGroupBox.Controls.Add(this.creditcardCaptionLabel);
            this.performGroupBox.Controls.Add(this.cashCaptionLabel);
            this.performGroupBox.Location = new System.Drawing.Point(10, 142);
            this.performGroupBox.Name = "performGroupBox";
            this.performGroupBox.Size = new System.Drawing.Size(340, 226);
            this.performGroupBox.TabIndex = 18;
            this.performGroupBox.TabStop = false;
            // 
            // totalCountLabel
            // 
            this.totalCountLabel.AutoSize = true;
            this.totalCountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalCountLabel.Location = new System.Drawing.Point(130, 195);
            this.totalCountLabel.Name = "totalCountLabel";
            this.totalCountLabel.Size = new System.Drawing.Size(55, 15);
            this.totalCountLabel.TabIndex = 12;
            this.totalCountLabel.Text = "0 รายการ";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalTextBox.Location = new System.Drawing.Point(130, 165);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(131, 27);
            this.totalTextBox.TabIndex = 11;
            // 
            // totalCaptionLabel
            // 
            this.totalCaptionLabel.AutoSize = true;
            this.totalCaptionLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalCaptionLabel.Location = new System.Drawing.Point(70, 168);
            this.totalCaptionLabel.Name = "totalCaptionLabel";
            this.totalCaptionLabel.Size = new System.Drawing.Size(39, 20);
            this.totalCaptionLabel.TabIndex = 10;
            this.totalCaptionLabel.Text = "รวม:";
            // 
            // promptpayCountLabel
            // 
            this.promptpayCountLabel.AutoSize = true;
            this.promptpayCountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.promptpayCountLabel.Location = new System.Drawing.Point(130, 147);
            this.promptpayCountLabel.Name = "promptpayCountLabel";
            this.promptpayCountLabel.Size = new System.Drawing.Size(55, 15);
            this.promptpayCountLabel.TabIndex = 9;
            this.promptpayCountLabel.Text = "0 รายการ";
            // 
            // promptpayTextBox
            // 
            this.promptpayTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.promptpayTextBox.Location = new System.Drawing.Point(130, 117);
            this.promptpayTextBox.Name = "promptpayTextBox";
            this.promptpayTextBox.Size = new System.Drawing.Size(131, 27);
            this.promptpayTextBox.TabIndex = 8;
            // 
            // promptpayCaptionLabel
            // 
            this.promptpayCaptionLabel.AutoSize = true;
            this.promptpayCaptionLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.promptpayCaptionLabel.Location = new System.Drawing.Point(31, 120);
            this.promptpayCaptionLabel.Name = "promptpayCaptionLabel";
            this.promptpayCaptionLabel.Size = new System.Drawing.Size(78, 20);
            this.promptpayCaptionLabel.TabIndex = 7;
            this.promptpayCaptionLabel.Text = "พร้อมเพย์:";
            // 
            // creditcardCountLabel
            // 
            this.creditcardCountLabel.AutoSize = true;
            this.creditcardCountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.creditcardCountLabel.Location = new System.Drawing.Point(130, 99);
            this.creditcardCountLabel.Name = "creditcardCountLabel";
            this.creditcardCountLabel.Size = new System.Drawing.Size(55, 15);
            this.creditcardCountLabel.TabIndex = 6;
            this.creditcardCountLabel.Text = "0 รายการ";
            // 
            // cashCountLabel
            // 
            this.cashCountLabel.AutoSize = true;
            this.cashCountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cashCountLabel.Location = new System.Drawing.Point(130, 51);
            this.cashCountLabel.Name = "cashCountLabel";
            this.cashCountLabel.Size = new System.Drawing.Size(55, 15);
            this.cashCountLabel.TabIndex = 5;
            this.cashCountLabel.Text = "0 รายการ";
            // 
            // creditcardTextBox
            // 
            this.creditcardTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.creditcardTextBox.Location = new System.Drawing.Point(130, 69);
            this.creditcardTextBox.Name = "creditcardTextBox";
            this.creditcardTextBox.Size = new System.Drawing.Size(131, 27);
            this.creditcardTextBox.TabIndex = 4;
            // 
            // cashTextBox
            // 
            this.cashTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cashTextBox.Location = new System.Drawing.Point(130, 21);
            this.cashTextBox.Name = "cashTextBox";
            this.cashTextBox.Size = new System.Drawing.Size(131, 27);
            this.cashTextBox.TabIndex = 3;
            // 
            // creditcardCaptionLabel
            // 
            this.creditcardCaptionLabel.AutoSize = true;
            this.creditcardCaptionLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.creditcardCaptionLabel.Location = new System.Drawing.Point(31, 72);
            this.creditcardCaptionLabel.Name = "creditcardCaptionLabel";
            this.creditcardCaptionLabel.Size = new System.Drawing.Size(83, 20);
            this.creditcardCaptionLabel.TabIndex = 2;
            this.creditcardCaptionLabel.Text = "บัตรเครดิต:";
            // 
            // cashCaptionLabel
            // 
            this.cashCaptionLabel.AutoSize = true;
            this.cashCaptionLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cashCaptionLabel.Location = new System.Drawing.Point(59, 24);
            this.cashCaptionLabel.Name = "cashCaptionLabel";
            this.cashCaptionLabel.Size = new System.Drawing.Size(55, 20);
            this.cashCaptionLabel.TabIndex = 1;
            this.cashCaptionLabel.Text = "เงินสด:";
            // 
            // userGroupBox
            // 
            this.userGroupBox.Controls.Add(this.toLabel);
            this.userGroupBox.Controls.Add(this.fromLabel);
            this.userGroupBox.Controls.Add(this.userLabel);
            this.userGroupBox.Controls.Add(this.toCaptionLabel);
            this.userGroupBox.Controls.Add(this.fromCaptionLabel);
            this.userGroupBox.Controls.Add(this.userCaptionLabel);
            this.userGroupBox.Location = new System.Drawing.Point(12, 12);
            this.userGroupBox.Name = "userGroupBox";
            this.userGroupBox.Size = new System.Drawing.Size(340, 124);
            this.userGroupBox.TabIndex = 17;
            this.userGroupBox.TabStop = false;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toLabel.Location = new System.Drawing.Point(122, 80);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(107, 20);
            this.toLabel.TabIndex = 5;
            this.toLabel.Text = "--/--/-- --:--:--";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fromLabel.Location = new System.Drawing.Point(122, 52);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(107, 20);
            this.fromLabel.TabIndex = 4;
            this.fromLabel.Text = "--/--/-- --:--:--";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userLabel.Location = new System.Drawing.Point(122, 24);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(40, 21);
            this.userLabel.TabIndex = 3;
            this.userLabel.Text = "-----";
            // 
            // toCaptionLabel
            // 
            this.toCaptionLabel.AutoSize = true;
            this.toCaptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toCaptionLabel.Location = new System.Drawing.Point(77, 80);
            this.toCaptionLabel.Name = "toCaptionLabel";
            this.toCaptionLabel.Size = new System.Drawing.Size(31, 21);
            this.toCaptionLabel.TabIndex = 2;
            this.toCaptionLabel.Text = "ถึง:";
            // 
            // fromCaptionLabel
            // 
            this.fromCaptionLabel.AutoSize = true;
            this.fromCaptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fromCaptionLabel.Location = new System.Drawing.Point(70, 52);
            this.fromCaptionLabel.Name = "fromCaptionLabel";
            this.fromCaptionLabel.Size = new System.Drawing.Size(38, 21);
            this.fromCaptionLabel.TabIndex = 1;
            this.fromCaptionLabel.Text = "เริ่ม:";
            // 
            // userCaptionLabel
            // 
            this.userCaptionLabel.AutoSize = true;
            this.userCaptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userCaptionLabel.Location = new System.Drawing.Point(63, 24);
            this.userCaptionLabel.Name = "userCaptionLabel";
            this.userCaptionLabel.Size = new System.Drawing.Size(45, 21);
            this.userCaptionLabel.TabIndex = 0;
            this.userCaptionLabel.Text = "ผุ้ใช้:";
            // 
            // savePerformanceCheckBox
            // 
            this.savePerformanceCheckBox.AutoSize = true;
            this.savePerformanceCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.savePerformanceCheckBox.Location = new System.Drawing.Point(109, 514);
            this.savePerformanceCheckBox.Name = "savePerformanceCheckBox";
            this.savePerformanceCheckBox.Size = new System.Drawing.Size(161, 21);
            this.savePerformanceCheckBox.TabIndex = 24;
            this.savePerformanceCheckBox.Text = "บันทึกการนำส่งเงินก่อนออก";
            this.savePerformanceCheckBox.UseVisualStyleBackColor = true;
            // 
            // updateStockCheckBox
            // 
            this.updateStockCheckBox.AutoSize = true;
            this.updateStockCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateStockCheckBox.Location = new System.Drawing.Point(109, 541);
            this.updateStockCheckBox.Name = "updateStockCheckBox";
            this.updateStockCheckBox.Size = new System.Drawing.Size(136, 21);
            this.updateStockCheckBox.TabIndex = 25;
            this.updateStockCheckBox.Text = "ปรับปรุงสต๊อกก่อนออก";
            this.updateStockCheckBox.UseVisualStyleBackColor = true;
            // 
            // progressLabel
            // 
            this.progressLabel.Location = new System.Drawing.Point(12, 565);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(340, 23);
            this.progressLabel.TabIndex = 26;
            this.progressLabel.Text = "waiting";
            this.progressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.progressLabel.Visible = false;
            // 
            // LogoutForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(364, 641);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.updateStockCheckBox);
            this.Controls.Add(this.savePerformanceCheckBox);
            this.Controls.Add(this.canceButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printLinkLabel);
            this.Controls.Add(this.memoTextBox);
            this.Controls.Add(this.performGroupBox);
            this.Controls.Add(this.userGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "สรุปการทำงาน";
            this.Load += new System.EventHandler(this.LogoutForm_Load);
            this.performGroupBox.ResumeLayout(false);
            this.performGroupBox.PerformLayout();
            this.userGroupBox.ResumeLayout(false);
            this.userGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button canceButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel printLinkLabel;
        private System.Windows.Forms.TextBox memoTextBox;
        private System.Windows.Forms.GroupBox performGroupBox;
        private System.Windows.Forms.Label totalCountLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label totalCaptionLabel;
        private System.Windows.Forms.Label promptpayCountLabel;
        private System.Windows.Forms.TextBox promptpayTextBox;
        private System.Windows.Forms.Label promptpayCaptionLabel;
        private System.Windows.Forms.Label creditcardCountLabel;
        private System.Windows.Forms.Label cashCountLabel;
        private System.Windows.Forms.TextBox creditcardTextBox;
        private System.Windows.Forms.TextBox cashTextBox;
        private System.Windows.Forms.Label creditcardCaptionLabel;
        private System.Windows.Forms.Label cashCaptionLabel;
        private System.Windows.Forms.GroupBox userGroupBox;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label toCaptionLabel;
        private System.Windows.Forms.Label fromCaptionLabel;
        private System.Windows.Forms.Label userCaptionLabel;
        private System.Windows.Forms.CheckBox savePerformanceCheckBox;
        private System.Windows.Forms.CheckBox updateStockCheckBox;
        private System.Windows.Forms.Label progressLabel;
    }
}