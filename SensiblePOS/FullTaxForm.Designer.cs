
namespace SensiblePOS
{
    partial class FullTaxForm
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
            this.nameCaptionLabel = new System.Windows.Forms.Label();
            this.taxCaptionLabel = new System.Windows.Forms.Label();
            this.addressCaptionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.taxIdTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.canceButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameCaptionLabel
            // 
            this.nameCaptionLabel.AutoSize = true;
            this.nameCaptionLabel.Location = new System.Drawing.Point(12, 28);
            this.nameCaptionLabel.Name = "nameCaptionLabel";
            this.nameCaptionLabel.Size = new System.Drawing.Size(30, 17);
            this.nameCaptionLabel.TabIndex = 0;
            this.nameCaptionLabel.Text = "ชื่อ: ";
            // 
            // taxCaptionLabel
            // 
            this.taxCaptionLabel.AutoSize = true;
            this.taxCaptionLabel.Location = new System.Drawing.Point(12, 58);
            this.taxCaptionLabel.Name = "taxCaptionLabel";
            this.taxCaptionLabel.Size = new System.Drawing.Size(53, 17);
            this.taxCaptionLabel.TabIndex = 1;
            this.taxCaptionLabel.Text = "TAX ID: ";
            // 
            // addressCaptionLabel
            // 
            this.addressCaptionLabel.AutoSize = true;
            this.addressCaptionLabel.Location = new System.Drawing.Point(12, 92);
            this.addressCaptionLabel.Name = "addressCaptionLabel";
            this.addressCaptionLabel.Size = new System.Drawing.Size(63, 17);
            this.addressCaptionLabel.TabIndex = 2;
            this.addressCaptionLabel.Text = "Address: ";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(82, 25);
            this.nameTextBox.MaxLength = 80;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(301, 25);
            this.nameTextBox.TabIndex = 1;
            // 
            // taxIdTextBox
            // 
            this.taxIdTextBox.Location = new System.Drawing.Point(82, 58);
            this.taxIdTextBox.MaxLength = 15;
            this.taxIdTextBox.Name = "taxIdTextBox";
            this.taxIdTextBox.Size = new System.Drawing.Size(301, 25);
            this.taxIdTextBox.TabIndex = 2;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(81, 92);
            this.addressTextBox.MaxLength = 200;
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(301, 92);
            this.addressTextBox.TabIndex = 3;
            // 
            // canceButton
            // 
            this.canceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.canceButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.canceButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.canceButton.Location = new System.Drawing.Point(283, 205);
            this.canceButton.Name = "canceButton";
            this.canceButton.Size = new System.Drawing.Size(100, 36);
            this.canceButton.TabIndex = 5;
            this.canceButton.Text = "ยกเลิก";
            this.canceButton.UseVisualStyleBackColor = true;
            this.canceButton.Click += new System.EventHandler(this.canceButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.okButton.Location = new System.Drawing.Point(177, 205);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 36);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "ตกลง";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // FullTaxForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.canceButton;
            this.ClientSize = new System.Drawing.Size(405, 253);
            this.Controls.Add(this.canceButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.taxIdTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addressCaptionLabel);
            this.Controls.Add(this.taxCaptionLabel);
            this.Controls.Add(this.nameCaptionLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FullTaxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ข้อมูลลูกค้า";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameCaptionLabel;
        private System.Windows.Forms.Label taxCaptionLabel;
        private System.Windows.Forms.Label addressCaptionLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox taxIdTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button canceButton;
        private System.Windows.Forms.Button okButton;
    }
}