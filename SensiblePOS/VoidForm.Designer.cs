
namespace SensiblePOS
{
    partial class VoidForm
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.reasonTextBox = new System.Windows.Forms.TextBox();
            this.reasonLabel = new System.Windows.Forms.Label();
            this.printCheckBox = new System.Windows.Forms.CheckBox();
            this.canceButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.restockCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(12, 21);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(68, 17);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "[message]";
            // 
            // reasonTextBox
            // 
            this.reasonTextBox.Location = new System.Drawing.Point(12, 74);
            this.reasonTextBox.MaxLength = 120;
            this.reasonTextBox.Multiline = true;
            this.reasonTextBox.Name = "reasonTextBox";
            this.reasonTextBox.Size = new System.Drawing.Size(440, 95);
            this.reasonTextBox.TabIndex = 1;
            // 
            // reasonLabel
            // 
            this.reasonLabel.AutoSize = true;
            this.reasonLabel.Location = new System.Drawing.Point(12, 49);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(41, 17);
            this.reasonLabel.TabIndex = 2;
            this.reasonLabel.Text = "เหตุผล";
            // 
            // printCheckBox
            // 
            this.printCheckBox.AutoSize = true;
            this.printCheckBox.Checked = true;
            this.printCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.printCheckBox.Location = new System.Drawing.Point(23, 175);
            this.printCheckBox.Name = "printCheckBox";
            this.printCheckBox.Size = new System.Drawing.Size(87, 21);
            this.printCheckBox.TabIndex = 2;
            this.printCheckBox.Text = "พิพม์ใบเสร็จ";
            this.printCheckBox.UseVisualStyleBackColor = true;
            // 
            // canceButton
            // 
            this.canceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.canceButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.canceButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.canceButton.Location = new System.Drawing.Point(352, 236);
            this.canceButton.Name = "canceButton";
            this.canceButton.Size = new System.Drawing.Size(100, 36);
            this.canceButton.TabIndex = 4;
            this.canceButton.Text = "ยกเลิก";
            this.canceButton.UseVisualStyleBackColor = true;
            this.canceButton.Click += new System.EventHandler(this.canceButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.okButton.Location = new System.Drawing.Point(246, 236);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 36);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "ตกลง";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // restockCheckBox
            // 
            this.restockCheckBox.AutoSize = true;
            this.restockCheckBox.Checked = true;
            this.restockCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.restockCheckBox.Location = new System.Drawing.Point(23, 202);
            this.restockCheckBox.Name = "restockCheckBox";
            this.restockCheckBox.Size = new System.Drawing.Size(113, 21);
            this.restockCheckBox.TabIndex = 5;
            this.restockCheckBox.Text = "คืนของเข้า stock";
            this.restockCheckBox.UseVisualStyleBackColor = true;
            // 
            // VoidForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.canceButton;
            this.ClientSize = new System.Drawing.Size(464, 284);
            this.Controls.Add(this.restockCheckBox);
            this.Controls.Add(this.canceButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.printCheckBox);
            this.Controls.Add(this.reasonLabel);
            this.Controls.Add(this.reasonTextBox);
            this.Controls.Add(this.messageLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VoidForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VOID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox reasonTextBox;
        private System.Windows.Forms.Label reasonLabel;
        private System.Windows.Forms.CheckBox printCheckBox;
        private System.Windows.Forms.Button canceButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.CheckBox restockCheckBox;
    }
}