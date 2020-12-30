
namespace SensiblePOS.Backoffice
{
    partial class SystemForm
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
            this.vatGroupBox = new System.Windows.Forms.GroupBox();
            this.vatTypeLabel = new System.Windows.Forms.Label();
            this.vatTypeComboBox = new System.Windows.Forms.ComboBox();
            this.vatLabel = new System.Windows.Forms.Label();
            this.vatNumeric = new System.Windows.Forms.NumericUpDown();
            this.receiptGroupBox = new System.Windows.Forms.GroupBox();
            this.printTailerTextBox = new System.Windows.Forms.TextBox();
            this.printTailerLabel = new System.Windows.Forms.Label();
            this.printHeaderTextBox = new System.Windows.Forms.TextBox();
            this.printHeaderLabel = new System.Windows.Forms.Label();
            this.printCopyLabel = new System.Windows.Forms.Label();
            this.printQtyNumeric = new System.Windows.Forms.NumericUpDown();
            this.promptpayGroupBox = new System.Windows.Forms.GroupBox();
            this.promptpayIdTextBox = new System.Windows.Forms.TextBox();
            this.promptpayIdLabel = new System.Windows.Forms.Label();
            this.enablePromptpayCheckBox = new System.Windows.Forms.CheckBox();
            this.servicechargeGroupBox = new System.Windows.Forms.GroupBox();
            this.enableServicechargeCheckBox = new System.Windows.Forms.CheckBox();
            this.servicechargeLabel = new System.Windows.Forms.Label();
            this.servicechargeNumeric = new System.Windows.Forms.NumericUpDown();
            this.queueGroupBox = new System.Windows.Forms.GroupBox();
            this.resetQueuButton = new System.Windows.Forms.Button();
            this.currentQueueLabel = new System.Windows.Forms.Label();
            this.queueZoneLabel = new System.Windows.Forms.Label();
            this.queueZoneComboBox = new System.Windows.Forms.ComboBox();
            this.enableQueueCheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.zoneGroupBox = new System.Windows.Forms.GroupBox();
            this.zoneGridView = new System.Windows.Forms.DataGridView();
            this.addZoneButton = new System.Windows.Forms.Button();
            this.vatGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vatNumeric)).BeginInit();
            this.receiptGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printQtyNumeric)).BeginInit();
            this.promptpayGroupBox.SuspendLayout();
            this.servicechargeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicechargeNumeric)).BeginInit();
            this.queueGroupBox.SuspendLayout();
            this.zoneGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoneGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vatGroupBox
            // 
            this.vatGroupBox.Controls.Add(this.vatTypeLabel);
            this.vatGroupBox.Controls.Add(this.vatTypeComboBox);
            this.vatGroupBox.Controls.Add(this.vatLabel);
            this.vatGroupBox.Controls.Add(this.vatNumeric);
            this.vatGroupBox.Location = new System.Drawing.Point(12, 322);
            this.vatGroupBox.Name = "vatGroupBox";
            this.vatGroupBox.Size = new System.Drawing.Size(316, 86);
            this.vatGroupBox.TabIndex = 0;
            this.vatGroupBox.TabStop = false;
            this.vatGroupBox.Text = "VAT";
            // 
            // vatTypeLabel
            // 
            this.vatTypeLabel.AutoSize = true;
            this.vatTypeLabel.Location = new System.Drawing.Point(29, 25);
            this.vatTypeLabel.Name = "vatTypeLabel";
            this.vatTypeLabel.Size = new System.Drawing.Size(42, 15);
            this.vatTypeLabel.TabIndex = 4;
            this.vatTypeLabel.Text = "รูปแบบ:";
            this.vatTypeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // vatTypeComboBox
            // 
            this.vatTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vatTypeComboBox.FormattingEnabled = true;
            this.vatTypeComboBox.Location = new System.Drawing.Point(77, 22);
            this.vatTypeComboBox.Name = "vatTypeComboBox";
            this.vatTypeComboBox.Size = new System.Drawing.Size(121, 23);
            this.vatTypeComboBox.TabIndex = 3;
            // 
            // vatLabel
            // 
            this.vatLabel.AutoSize = true;
            this.vatLabel.Location = new System.Drawing.Point(36, 53);
            this.vatLabel.Name = "vatLabel";
            this.vatLabel.Size = new System.Drawing.Size(35, 15);
            this.vatLabel.TabIndex = 1;
            this.vatLabel.Text = "มูลค่า:";
            this.vatLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // vatNumeric
            // 
            this.vatNumeric.DecimalPlaces = 2;
            this.vatNumeric.Location = new System.Drawing.Point(77, 51);
            this.vatNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.vatNumeric.Name = "vatNumeric";
            this.vatNumeric.Size = new System.Drawing.Size(121, 23);
            this.vatNumeric.TabIndex = 2;
            this.vatNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vatNumeric.ThousandsSeparator = true;
            // 
            // receiptGroupBox
            // 
            this.receiptGroupBox.Controls.Add(this.printTailerTextBox);
            this.receiptGroupBox.Controls.Add(this.printTailerLabel);
            this.receiptGroupBox.Controls.Add(this.printHeaderTextBox);
            this.receiptGroupBox.Controls.Add(this.printHeaderLabel);
            this.receiptGroupBox.Controls.Add(this.printCopyLabel);
            this.receiptGroupBox.Controls.Add(this.printQtyNumeric);
            this.receiptGroupBox.Location = new System.Drawing.Point(12, 12);
            this.receiptGroupBox.Name = "receiptGroupBox";
            this.receiptGroupBox.Size = new System.Drawing.Size(316, 304);
            this.receiptGroupBox.TabIndex = 1;
            this.receiptGroupBox.TabStop = false;
            this.receiptGroupBox.Text = "ใบเสร็จ";
            // 
            // printTailerTextBox
            // 
            this.printTailerTextBox.Location = new System.Drawing.Point(19, 160);
            this.printTailerTextBox.MaxLength = 500;
            this.printTailerTextBox.Multiline = true;
            this.printTailerTextBox.Name = "printTailerTextBox";
            this.printTailerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.printTailerTextBox.Size = new System.Drawing.Size(235, 88);
            this.printTailerTextBox.TabIndex = 9;
            // 
            // printTailerLabel
            // 
            this.printTailerLabel.AutoSize = true;
            this.printTailerLabel.Location = new System.Drawing.Point(19, 142);
            this.printTailerLabel.Name = "printTailerLabel";
            this.printTailerLabel.Size = new System.Drawing.Size(63, 15);
            this.printTailerLabel.TabIndex = 8;
            this.printTailerLabel.Text = "ท้ายกระดาษ:";
            // 
            // printHeaderTextBox
            // 
            this.printHeaderTextBox.Location = new System.Drawing.Point(19, 43);
            this.printHeaderTextBox.MaxLength = 500;
            this.printHeaderTextBox.Multiline = true;
            this.printHeaderTextBox.Name = "printHeaderTextBox";
            this.printHeaderTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.printHeaderTextBox.Size = new System.Drawing.Size(235, 88);
            this.printHeaderTextBox.TabIndex = 7;
            // 
            // printHeaderLabel
            // 
            this.printHeaderLabel.AutoSize = true;
            this.printHeaderLabel.Location = new System.Drawing.Point(19, 25);
            this.printHeaderLabel.Name = "printHeaderLabel";
            this.printHeaderLabel.Size = new System.Drawing.Size(57, 15);
            this.printHeaderLabel.TabIndex = 6;
            this.printHeaderLabel.Text = "หัวกระดาษ:";
            // 
            // printCopyLabel
            // 
            this.printCopyLabel.AutoSize = true;
            this.printCopyLabel.Location = new System.Drawing.Point(31, 266);
            this.printCopyLabel.Name = "printCopyLabel";
            this.printCopyLabel.Size = new System.Drawing.Size(40, 15);
            this.printCopyLabel.TabIndex = 3;
            this.printCopyLabel.Text = "จำนวน:";
            this.printCopyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // printQtyNumeric
            // 
            this.printQtyNumeric.Location = new System.Drawing.Point(77, 264);
            this.printQtyNumeric.Name = "printQtyNumeric";
            this.printQtyNumeric.Size = new System.Drawing.Size(73, 23);
            this.printQtyNumeric.TabIndex = 4;
            this.printQtyNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.printQtyNumeric.ThousandsSeparator = true;
            // 
            // promptpayGroupBox
            // 
            this.promptpayGroupBox.Controls.Add(this.promptpayIdTextBox);
            this.promptpayGroupBox.Controls.Add(this.promptpayIdLabel);
            this.promptpayGroupBox.Controls.Add(this.enablePromptpayCheckBox);
            this.promptpayGroupBox.Location = new System.Drawing.Point(343, 12);
            this.promptpayGroupBox.Name = "promptpayGroupBox";
            this.promptpayGroupBox.Size = new System.Drawing.Size(316, 86);
            this.promptpayGroupBox.TabIndex = 2;
            this.promptpayGroupBox.TabStop = false;
            this.promptpayGroupBox.Text = "พร้อมเพย์";
            // 
            // promptpayIdTextBox
            // 
            this.promptpayIdTextBox.Location = new System.Drawing.Point(79, 50);
            this.promptpayIdTextBox.MaxLength = 64;
            this.promptpayIdTextBox.Name = "promptpayIdTextBox";
            this.promptpayIdTextBox.PlaceholderText = "เลขบัตรประชาชน หรือ เบอร์โทรศัพท์";
            this.promptpayIdTextBox.Size = new System.Drawing.Size(180, 23);
            this.promptpayIdTextBox.TabIndex = 5;
            // 
            // promptpayIdLabel
            // 
            this.promptpayIdLabel.AutoSize = true;
            this.promptpayIdLabel.Location = new System.Drawing.Point(20, 53);
            this.promptpayIdLabel.Name = "promptpayIdLabel";
            this.promptpayIdLabel.Size = new System.Drawing.Size(50, 15);
            this.promptpayIdLabel.TabIndex = 4;
            this.promptpayIdLabel.Text = "เลขบัญชี:";
            // 
            // enablePromptpayCheckBox
            // 
            this.enablePromptpayCheckBox.AutoSize = true;
            this.enablePromptpayCheckBox.Location = new System.Drawing.Point(79, 25);
            this.enablePromptpayCheckBox.Name = "enablePromptpayCheckBox";
            this.enablePromptpayCheckBox.Size = new System.Drawing.Size(70, 19);
            this.enablePromptpayCheckBox.TabIndex = 0;
            this.enablePromptpayCheckBox.Text = "เปิดใช้งาน";
            this.enablePromptpayCheckBox.UseVisualStyleBackColor = true;
            // 
            // servicechargeGroupBox
            // 
            this.servicechargeGroupBox.Controls.Add(this.enableServicechargeCheckBox);
            this.servicechargeGroupBox.Controls.Add(this.servicechargeLabel);
            this.servicechargeGroupBox.Controls.Add(this.servicechargeNumeric);
            this.servicechargeGroupBox.Location = new System.Drawing.Point(12, 414);
            this.servicechargeGroupBox.Name = "servicechargeGroupBox";
            this.servicechargeGroupBox.Size = new System.Drawing.Size(316, 86);
            this.servicechargeGroupBox.TabIndex = 3;
            this.servicechargeGroupBox.TabStop = false;
            this.servicechargeGroupBox.Text = "Service Charge";
            // 
            // enableServicechargeCheckBox
            // 
            this.enableServicechargeCheckBox.AutoSize = true;
            this.enableServicechargeCheckBox.Location = new System.Drawing.Point(77, 25);
            this.enableServicechargeCheckBox.Name = "enableServicechargeCheckBox";
            this.enableServicechargeCheckBox.Size = new System.Drawing.Size(70, 19);
            this.enableServicechargeCheckBox.TabIndex = 5;
            this.enableServicechargeCheckBox.Text = "เปิดใช้งาน";
            this.enableServicechargeCheckBox.UseVisualStyleBackColor = true;
            // 
            // servicechargeLabel
            // 
            this.servicechargeLabel.AutoSize = true;
            this.servicechargeLabel.Location = new System.Drawing.Point(36, 52);
            this.servicechargeLabel.Name = "servicechargeLabel";
            this.servicechargeLabel.Size = new System.Drawing.Size(35, 15);
            this.servicechargeLabel.TabIndex = 3;
            this.servicechargeLabel.Text = "มูลค่า:";
            this.servicechargeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // servicechargeNumeric
            // 
            this.servicechargeNumeric.DecimalPlaces = 2;
            this.servicechargeNumeric.Location = new System.Drawing.Point(77, 50);
            this.servicechargeNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.servicechargeNumeric.Name = "servicechargeNumeric";
            this.servicechargeNumeric.Size = new System.Drawing.Size(121, 23);
            this.servicechargeNumeric.TabIndex = 4;
            this.servicechargeNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.servicechargeNumeric.ThousandsSeparator = true;
            // 
            // queueGroupBox
            // 
            this.queueGroupBox.Controls.Add(this.resetQueuButton);
            this.queueGroupBox.Controls.Add(this.currentQueueLabel);
            this.queueGroupBox.Controls.Add(this.queueZoneLabel);
            this.queueGroupBox.Controls.Add(this.queueZoneComboBox);
            this.queueGroupBox.Controls.Add(this.enableQueueCheckBox);
            this.queueGroupBox.Location = new System.Drawing.Point(343, 104);
            this.queueGroupBox.Name = "queueGroupBox";
            this.queueGroupBox.Size = new System.Drawing.Size(316, 116);
            this.queueGroupBox.TabIndex = 4;
            this.queueGroupBox.TabStop = false;
            this.queueGroupBox.Text = "คิว";
            // 
            // resetQueuButton
            // 
            this.resetQueuButton.Location = new System.Drawing.Point(184, 81);
            this.resetQueuButton.Name = "resetQueuButton";
            this.resetQueuButton.Size = new System.Drawing.Size(75, 23);
            this.resetQueuButton.TabIndex = 8;
            this.resetQueuButton.Text = "รีเซต";
            this.resetQueuButton.UseVisualStyleBackColor = true;
            this.resetQueuButton.Click += new System.EventHandler(this.resetQueuButton_Click);
            // 
            // currentQueueLabel
            // 
            this.currentQueueLabel.AutoSize = true;
            this.currentQueueLabel.Location = new System.Drawing.Point(79, 85);
            this.currentQueueLabel.Name = "currentQueueLabel";
            this.currentQueueLabel.Size = new System.Drawing.Size(46, 15);
            this.currentQueueLabel.TabIndex = 7;
            this.currentQueueLabel.Text = "คิวล่าสุด:";
            this.currentQueueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // queueZoneLabel
            // 
            this.queueZoneLabel.AutoSize = true;
            this.queueZoneLabel.Location = new System.Drawing.Point(41, 53);
            this.queueZoneLabel.Name = "queueZoneLabel";
            this.queueZoneLabel.Size = new System.Drawing.Size(29, 15);
            this.queueZoneLabel.TabIndex = 6;
            this.queueZoneLabel.Text = "โซน:";
            this.queueZoneLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // queueZoneComboBox
            // 
            this.queueZoneComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.queueZoneComboBox.FormattingEnabled = true;
            this.queueZoneComboBox.Location = new System.Drawing.Point(79, 50);
            this.queueZoneComboBox.Name = "queueZoneComboBox";
            this.queueZoneComboBox.Size = new System.Drawing.Size(121, 23);
            this.queueZoneComboBox.TabIndex = 5;
            // 
            // enableQueueCheckBox
            // 
            this.enableQueueCheckBox.AutoSize = true;
            this.enableQueueCheckBox.Location = new System.Drawing.Point(79, 25);
            this.enableQueueCheckBox.Name = "enableQueueCheckBox";
            this.enableQueueCheckBox.Size = new System.Drawing.Size(70, 19);
            this.enableQueueCheckBox.TabIndex = 1;
            this.enableQueueCheckBox.Text = "เปิดใช้งาน";
            this.enableQueueCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(541, 517);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 32);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "บันทึก";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // zoneGroupBox
            // 
            this.zoneGroupBox.Controls.Add(this.addZoneButton);
            this.zoneGroupBox.Controls.Add(this.zoneGridView);
            this.zoneGroupBox.Location = new System.Drawing.Point(343, 226);
            this.zoneGroupBox.Name = "zoneGroupBox";
            this.zoneGroupBox.Size = new System.Drawing.Size(316, 274);
            this.zoneGroupBox.TabIndex = 7;
            this.zoneGroupBox.TabStop = false;
            this.zoneGroupBox.Text = "โซนขาย";
            // 
            // zoneGridView
            // 
            this.zoneGridView.AllowUserToAddRows = false;
            this.zoneGridView.AllowUserToDeleteRows = false;
            this.zoneGridView.AllowUserToResizeRows = false;
            this.zoneGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zoneGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zoneGridView.Location = new System.Drawing.Point(14, 25);
            this.zoneGridView.Margin = new System.Windows.Forms.Padding(2);
            this.zoneGridView.Name = "zoneGridView";
            this.zoneGridView.ReadOnly = true;
            this.zoneGridView.RowHeadersVisible = false;
            this.zoneGridView.RowHeadersWidth = 32;
            this.zoneGridView.RowTemplate.Height = 30;
            this.zoneGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.zoneGridView.Size = new System.Drawing.Size(289, 210);
            this.zoneGridView.TabIndex = 3;
            // 
            // addZoneButton
            // 
            this.addZoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addZoneButton.Location = new System.Drawing.Point(14, 240);
            this.addZoneButton.Name = "addZoneButton";
            this.addZoneButton.Size = new System.Drawing.Size(32, 23);
            this.addZoneButton.TabIndex = 4;
            this.addZoneButton.Text = "+";
            this.addZoneButton.UseVisualStyleBackColor = true;
            this.addZoneButton.Click += new System.EventHandler(this.addZoneButton_Click);
            // 
            // SystemForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(673, 561);
            this.Controls.Add(this.zoneGroupBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.queueGroupBox);
            this.Controls.Add(this.servicechargeGroupBox);
            this.Controls.Add(this.promptpayGroupBox);
            this.Controls.Add(this.receiptGroupBox);
            this.Controls.Add(this.vatGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SystemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ตั้งค่า";
            this.Load += new System.EventHandler(this.SystemForm_Load);
            this.vatGroupBox.ResumeLayout(false);
            this.vatGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vatNumeric)).EndInit();
            this.receiptGroupBox.ResumeLayout(false);
            this.receiptGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printQtyNumeric)).EndInit();
            this.promptpayGroupBox.ResumeLayout(false);
            this.promptpayGroupBox.PerformLayout();
            this.servicechargeGroupBox.ResumeLayout(false);
            this.servicechargeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicechargeNumeric)).EndInit();
            this.queueGroupBox.ResumeLayout(false);
            this.queueGroupBox.PerformLayout();
            this.zoneGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zoneGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox vatGroupBox;
        private System.Windows.Forms.GroupBox receiptGroupBox;
        private System.Windows.Forms.GroupBox promptpayGroupBox;
        private System.Windows.Forms.CheckBox enablePromptpayCheckBox;
        private System.Windows.Forms.TextBox promptpayIdTextBox;
        private System.Windows.Forms.Label promptpayIdLabel;
        private System.Windows.Forms.Label vatTypeLabel;
        private System.Windows.Forms.ComboBox vatTypeComboBox;
        private System.Windows.Forms.Label vatLabel;
        private System.Windows.Forms.NumericUpDown vatNumeric;
        private System.Windows.Forms.TextBox printTailerTextBox;
        private System.Windows.Forms.Label printTailerLabel;
        private System.Windows.Forms.TextBox printHeaderTextBox;
        private System.Windows.Forms.Label printHeaderLabel;
        private System.Windows.Forms.Label printCopyLabel;
        private System.Windows.Forms.NumericUpDown printQtyNumeric;
        private System.Windows.Forms.GroupBox servicechargeGroupBox;
        private System.Windows.Forms.CheckBox enableServicechargeCheckBox;
        private System.Windows.Forms.Label servicechargeLabel;
        private System.Windows.Forms.NumericUpDown servicechargeNumeric;
        private System.Windows.Forms.GroupBox queueGroupBox;
        private System.Windows.Forms.Button resetQueuButton;
        private System.Windows.Forms.Label currentQueueLabel;
        private System.Windows.Forms.Label queueZoneLabel;
        private System.Windows.Forms.ComboBox queueZoneComboBox;
        private System.Windows.Forms.CheckBox enableQueueCheckBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox zoneGroupBox;
        private System.Windows.Forms.DataGridView zoneGridView;
        private System.Windows.Forms.Button addZoneButton;
    }
}