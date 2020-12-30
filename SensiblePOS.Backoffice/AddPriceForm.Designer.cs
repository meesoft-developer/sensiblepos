
namespace SensiblePOS.Backoffice
{
    partial class AddPriceForm
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
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.effectiveDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.expireDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.advanceGroupBox = new System.Windows.Forms.GroupBox();
            this.secondHalfCheckBox = new System.Windows.Forms.CheckBox();
            this.firstHalfCheckBox = new System.Windows.Forms.CheckBox();
            this.weekendCheckBox = new System.Windows.Forms.CheckBox();
            this.workdayCheckBox = new System.Windows.Forms.CheckBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            this.advanceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Location = new System.Drawing.Point(110, 23);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(110, 23);
            this.priceNumericUpDown.TabIndex = 0;
            this.priceNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.priceNumericUpDown.ThousandsSeparator = true;
            // 
            // effectiveDateTimePicker
            // 
            this.effectiveDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.effectiveDateTimePicker.Location = new System.Drawing.Point(110, 52);
            this.effectiveDateTimePicker.Name = "effectiveDateTimePicker";
            this.effectiveDateTimePicker.Size = new System.Drawing.Size(110, 23);
            this.effectiveDateTimePicker.TabIndex = 1;
            // 
            // expireDateTimePicker
            // 
            this.expireDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expireDateTimePicker.Location = new System.Drawing.Point(110, 81);
            this.expireDateTimePicker.Name = "expireDateTimePicker";
            this.expireDateTimePicker.Size = new System.Drawing.Size(110, 23);
            this.expireDateTimePicker.TabIndex = 2;
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.Location = new System.Drawing.Point(106, 226);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(80, 23);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "สร้าง";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(192, 226);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "ยกเลิก";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // advanceGroupBox
            // 
            this.advanceGroupBox.Controls.Add(this.secondHalfCheckBox);
            this.advanceGroupBox.Controls.Add(this.firstHalfCheckBox);
            this.advanceGroupBox.Controls.Add(this.weekendCheckBox);
            this.advanceGroupBox.Controls.Add(this.workdayCheckBox);
            this.advanceGroupBox.Location = new System.Drawing.Point(12, 110);
            this.advanceGroupBox.Name = "advanceGroupBox";
            this.advanceGroupBox.Size = new System.Drawing.Size(260, 103);
            this.advanceGroupBox.TabIndex = 5;
            this.advanceGroupBox.TabStop = false;
            this.advanceGroupBox.Text = "ช่วงขาย";
            // 
            // secondHalfCheckBox
            // 
            this.secondHalfCheckBox.AutoSize = true;
            this.secondHalfCheckBox.Checked = true;
            this.secondHalfCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.secondHalfCheckBox.Location = new System.Drawing.Point(122, 63);
            this.secondHalfCheckBox.Name = "secondHalfCheckBox";
            this.secondHalfCheckBox.Size = new System.Drawing.Size(61, 19);
            this.secondHalfCheckBox.TabIndex = 3;
            this.secondHalfCheckBox.Text = "ครึ่งหลัง";
            this.secondHalfCheckBox.UseVisualStyleBackColor = true;
            // 
            // firstHalfCheckBox
            // 
            this.firstHalfCheckBox.AutoSize = true;
            this.firstHalfCheckBox.Checked = true;
            this.firstHalfCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.firstHalfCheckBox.Location = new System.Drawing.Point(30, 63);
            this.firstHalfCheckBox.Name = "firstHalfCheckBox";
            this.firstHalfCheckBox.Size = new System.Drawing.Size(61, 19);
            this.firstHalfCheckBox.TabIndex = 2;
            this.firstHalfCheckBox.Text = "ครึ่งแรก";
            this.firstHalfCheckBox.UseVisualStyleBackColor = true;
            // 
            // weekendCheckBox
            // 
            this.weekendCheckBox.AutoSize = true;
            this.weekendCheckBox.Checked = true;
            this.weekendCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.weekendCheckBox.Location = new System.Drawing.Point(122, 24);
            this.weekendCheckBox.Name = "weekendCheckBox";
            this.weekendCheckBox.Size = new System.Drawing.Size(58, 19);
            this.weekendCheckBox.TabIndex = 1;
            this.weekendCheckBox.Text = "วันหยุด";
            this.weekendCheckBox.UseVisualStyleBackColor = true;
            // 
            // workdayCheckBox
            // 
            this.workdayCheckBox.AutoSize = true;
            this.workdayCheckBox.Checked = true;
            this.workdayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.workdayCheckBox.Location = new System.Drawing.Point(30, 24);
            this.workdayCheckBox.Name = "workdayCheckBox";
            this.workdayCheckBox.Size = new System.Drawing.Size(73, 19);
            this.workdayCheckBox.TabIndex = 0;
            this.workdayCheckBox.Text = "วันธรรมดา";
            this.workdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(72, 27);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(32, 15);
            this.priceLabel.TabIndex = 0;
            this.priceLabel.Text = "ราคา:";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "เริ่ม:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "สิ้นสุด:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AddPriceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.advanceGroupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.expireDateTimePicker);
            this.Controls.Add(this.effectiveDateTimePicker);
            this.Controls.Add(this.priceNumericUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "AddPriceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "กำหลดราคา";
            this.Load += new System.EventHandler(this.AddPriceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            this.advanceGroupBox.ResumeLayout(false);
            this.advanceGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.DateTimePicker effectiveDateTimePicker;
        private System.Windows.Forms.DateTimePicker expireDateTimePicker;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox advanceGroupBox;
        private System.Windows.Forms.CheckBox secondHalfCheckBox;
        private System.Windows.Forms.CheckBox firstHalfCheckBox;
        private System.Windows.Forms.CheckBox weekendCheckBox;
        private System.Windows.Forms.CheckBox workdayCheckBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}