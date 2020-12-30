
namespace SensiblePOS.Backoffice
{
    partial class AddProductForm
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
            this.generalGroupBox = new System.Windows.Forms.GroupBox();
            this.inactiveCheckBox = new System.Windows.Forms.CheckBox();
            this.serviceChargeEffectCheckBox = new System.Windows.Forms.CheckBox();
            this.promoEffectCheckBox = new System.Windows.Forms.CheckBox();
            this.salableCheckBox = new System.Windows.Forms.CheckBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.skuTextBox = new System.Windows.Forms.TextBox();
            this.skuLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.expireDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.effectiveDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.priceNumeric = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.zoneComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qtyNumeric = new System.Windows.Forms.NumericUpDown();
            this.cancelButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.generalGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // generalGroupBox
            // 
            this.generalGroupBox.Controls.Add(this.inactiveCheckBox);
            this.generalGroupBox.Controls.Add(this.serviceChargeEffectCheckBox);
            this.generalGroupBox.Controls.Add(this.promoEffectCheckBox);
            this.generalGroupBox.Controls.Add(this.salableCheckBox);
            this.generalGroupBox.Controls.Add(this.titleTextBox);
            this.generalGroupBox.Controls.Add(this.titleLabel);
            this.generalGroupBox.Controls.Add(this.skuTextBox);
            this.generalGroupBox.Controls.Add(this.skuLabel);
            this.generalGroupBox.Location = new System.Drawing.Point(12, 12);
            this.generalGroupBox.Name = "generalGroupBox";
            this.generalGroupBox.Size = new System.Drawing.Size(272, 104);
            this.generalGroupBox.TabIndex = 3;
            this.generalGroupBox.TabStop = false;
            this.generalGroupBox.Text = "ข้อมูลทั่วไป";
            // 
            // inactiveCheckBox
            // 
            this.inactiveCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inactiveCheckBox.AutoSize = true;
            this.inactiveCheckBox.Location = new System.Drawing.Point(593, 97);
            this.inactiveCheckBox.Name = "inactiveCheckBox";
            this.inactiveCheckBox.Size = new System.Drawing.Size(74, 19);
            this.inactiveCheckBox.TabIndex = 9;
            this.inactiveCheckBox.Text = "ระงับใช้งาน";
            this.inactiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // serviceChargeEffectCheckBox
            // 
            this.serviceChargeEffectCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceChargeEffectCheckBox.AutoSize = true;
            this.serviceChargeEffectCheckBox.Location = new System.Drawing.Point(593, 72);
            this.serviceChargeEffectCheckBox.Name = "serviceChargeEffectCheckBox";
            this.serviceChargeEffectCheckBox.Size = new System.Drawing.Size(119, 19);
            this.serviceChargeEffectCheckBox.TabIndex = 8;
            this.serviceChargeEffectCheckBox.Text = "คืด Service charge";
            this.serviceChargeEffectCheckBox.UseVisualStyleBackColor = true;
            // 
            // promoEffectCheckBox
            // 
            this.promoEffectCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.promoEffectCheckBox.AutoSize = true;
            this.promoEffectCheckBox.Location = new System.Drawing.Point(593, 47);
            this.promoEffectCheckBox.Name = "promoEffectCheckBox";
            this.promoEffectCheckBox.Size = new System.Drawing.Size(82, 19);
            this.promoEffectCheckBox.TabIndex = 7;
            this.promoEffectCheckBox.Text = "ร่วมโปรโมชั่น";
            this.promoEffectCheckBox.UseVisualStyleBackColor = true;
            // 
            // salableCheckBox
            // 
            this.salableCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salableCheckBox.AutoSize = true;
            this.salableCheckBox.Location = new System.Drawing.Point(593, 22);
            this.salableCheckBox.Name = "salableCheckBox";
            this.salableCheckBox.Size = new System.Drawing.Size(61, 19);
            this.salableCheckBox.TabIndex = 6;
            this.salableCheckBox.Text = "เปิดขาย";
            this.salableCheckBox.UseVisualStyleBackColor = true;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(64, 59);
            this.titleTextBox.MaxLength = 128;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(180, 23);
            this.titleTextBox.TabIndex = 3;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(34, 62);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(23, 15);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "ชื่อ:";
            // 
            // skuTextBox
            // 
            this.skuTextBox.Location = new System.Drawing.Point(64, 30);
            this.skuTextBox.MaxLength = 64;
            this.skuTextBox.Name = "skuTextBox";
            this.skuTextBox.Size = new System.Drawing.Size(180, 23);
            this.skuTextBox.TabIndex = 1;
            // 
            // skuLabel
            // 
            this.skuLabel.AutoSize = true;
            this.skuLabel.Location = new System.Drawing.Point(27, 33);
            this.skuLabel.Name = "skuLabel";
            this.skuLabel.Size = new System.Drawing.Size(31, 15);
            this.skuLabel.TabIndex = 0;
            this.skuLabel.Text = "SKU:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.priceLabel);
            this.groupBox1.Controls.Add(this.expireDateTimePicker);
            this.groupBox1.Controls.Add(this.effectiveDateTimePicker);
            this.groupBox1.Controls.Add(this.priceNumeric);
            this.groupBox1.Location = new System.Drawing.Point(12, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 121);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ราคา";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "สิ้นสุด:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "เริ่ม:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(26, 26);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(32, 15);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "ราคา:";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // expireDateTimePicker
            // 
            this.expireDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expireDateTimePicker.Location = new System.Drawing.Point(64, 80);
            this.expireDateTimePicker.Name = "expireDateTimePicker";
            this.expireDateTimePicker.Size = new System.Drawing.Size(132, 23);
            this.expireDateTimePicker.TabIndex = 11;
            // 
            // effectiveDateTimePicker
            // 
            this.effectiveDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.effectiveDateTimePicker.Location = new System.Drawing.Point(64, 51);
            this.effectiveDateTimePicker.Name = "effectiveDateTimePicker";
            this.effectiveDateTimePicker.Size = new System.Drawing.Size(132, 23);
            this.effectiveDateTimePicker.TabIndex = 10;
            // 
            // priceNumeric
            // 
            this.priceNumeric.DecimalPlaces = 2;
            this.priceNumeric.Location = new System.Drawing.Point(64, 22);
            this.priceNumeric.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.priceNumeric.Name = "priceNumeric";
            this.priceNumeric.Size = new System.Drawing.Size(132, 23);
            this.priceNumeric.TabIndex = 9;
            this.priceNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.priceNumeric.ThousandsSeparator = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.zoneComboBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.qtyNumeric);
            this.groupBox2.Location = new System.Drawing.Point(12, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 93);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "สต๊อก";
            // 
            // zoneComboBox
            // 
            this.zoneComboBox.FormattingEnabled = true;
            this.zoneComboBox.Location = new System.Drawing.Point(64, 51);
            this.zoneComboBox.Name = "zoneComboBox";
            this.zoneComboBox.Size = new System.Drawing.Size(132, 23);
            this.zoneComboBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "เช้าโซน:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "จำนวน:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // qtyNumeric
            // 
            this.qtyNumeric.Location = new System.Drawing.Point(64, 22);
            this.qtyNumeric.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.qtyNumeric.Name = "qtyNumeric";
            this.qtyNumeric.Size = new System.Drawing.Size(132, 23);
            this.qtyNumeric.TabIndex = 11;
            this.qtyNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.qtyNumeric.ThousandsSeparator = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(210, 357);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "ยกเลิก";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.Location = new System.Drawing.Point(124, 357);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(80, 23);
            this.createButton.TabIndex = 6;
            this.createButton.Text = "สร้าง";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(302, 392);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.generalGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "เพิมข้อมูลสินค้า";
            this.generalGroupBox.ResumeLayout(false);
            this.generalGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox generalGroupBox;
        private System.Windows.Forms.CheckBox inactiveCheckBox;
        private System.Windows.Forms.CheckBox serviceChargeEffectCheckBox;
        private System.Windows.Forms.CheckBox promoEffectCheckBox;
        private System.Windows.Forms.CheckBox salableCheckBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox skuTextBox;
        private System.Windows.Forms.Label skuLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.DateTimePicker expireDateTimePicker;
        private System.Windows.Forms.DateTimePicker effectiveDateTimePicker;
        private System.Windows.Forms.NumericUpDown priceNumeric;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox zoneComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown qtyNumeric;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button createButton;
    }
}