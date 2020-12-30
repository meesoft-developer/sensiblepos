
namespace SensiblePOS.Backoffice
{
    partial class AddStockForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.zoneComboBox = new System.Windows.Forms.ComboBox();
            this.zoneLabel = new System.Windows.Forms.Label();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.qtyNumeric = new System.Windows.Forms.NumericUpDown();
            this.currentInZoneLabel = new System.Windows.Forms.Label();
            this.allZoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qtyNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(192, 150);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "ยกเลิก";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(106, 150);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "เพิ่ม";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // zoneComboBox
            // 
            this.zoneComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zoneComboBox.FormattingEnabled = true;
            this.zoneComboBox.Location = new System.Drawing.Point(94, 56);
            this.zoneComboBox.Name = "zoneComboBox";
            this.zoneComboBox.Size = new System.Drawing.Size(132, 23);
            this.zoneComboBox.TabIndex = 19;
            // 
            // zoneLabel
            // 
            this.zoneLabel.AutoSize = true;
            this.zoneLabel.Location = new System.Drawing.Point(44, 59);
            this.zoneLabel.Name = "zoneLabel";
            this.zoneLabel.Size = new System.Drawing.Size(44, 15);
            this.zoneLabel.TabIndex = 18;
            this.zoneLabel.Text = "เช้าโซน:";
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.Location = new System.Drawing.Point(47, 29);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(40, 15);
            this.qtyLabel.TabIndex = 16;
            this.qtyLabel.Text = "จำนวน:";
            this.qtyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // qtyNumeric
            // 
            this.qtyNumeric.Location = new System.Drawing.Point(94, 27);
            this.qtyNumeric.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.qtyNumeric.Name = "qtyNumeric";
            this.qtyNumeric.Size = new System.Drawing.Size(132, 23);
            this.qtyNumeric.TabIndex = 17;
            this.qtyNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.qtyNumeric.ThousandsSeparator = true;
            // 
            // currentInZoneLabel
            // 
            this.currentInZoneLabel.AutoSize = true;
            this.currentInZoneLabel.Location = new System.Drawing.Point(94, 82);
            this.currentInZoneLabel.Name = "currentInZoneLabel";
            this.currentInZoneLabel.Size = new System.Drawing.Size(34, 15);
            this.currentInZoneLabel.TabIndex = 20;
            this.currentInZoneLabel.Text = "ล่าสุด:";
            // 
            // allZoneLabel
            // 
            this.allZoneLabel.AutoSize = true;
            this.allZoneLabel.Location = new System.Drawing.Point(94, 111);
            this.allZoneLabel.Name = "allZoneLabel";
            this.allZoneLabel.Size = new System.Drawing.Size(43, 15);
            this.allZoneLabel.TabIndex = 21;
            this.allZoneLabel.Text = "ทั้งหมด:";
            // 
            // AddStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 185);
            this.ControlBox = false;
            this.Controls.Add(this.allZoneLabel);
            this.Controls.Add(this.currentInZoneLabel);
            this.Controls.Add(this.zoneComboBox);
            this.Controls.Add(this.zoneLabel);
            this.Controls.Add(this.qtyLabel);
            this.Controls.Add(this.qtyNumeric);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddStockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "เพิ่มสต๊อก";
            ((System.ComponentModel.ISupportInitialize)(this.qtyNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox zoneComboBox;
        private System.Windows.Forms.Label zoneLabel;
        private System.Windows.Forms.Label qtyLabel;
        private System.Windows.Forms.NumericUpDown qtyNumeric;
        private System.Windows.Forms.Label currentInZoneLabel;
        private System.Windows.Forms.Label allZoneLabel;
    }
}