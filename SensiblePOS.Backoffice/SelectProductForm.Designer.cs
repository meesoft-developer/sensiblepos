
namespace SensiblePOS.Backoffice
{
    partial class SelectProductForm
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
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.keywordTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.qtyNumeric = new System.Windows.Forms.NumericUpDown();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // productGridView
            // 
            this.productGridView.AllowUserToAddRows = false;
            this.productGridView.AllowUserToDeleteRows = false;
            this.productGridView.AllowUserToResizeRows = false;
            this.productGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(11, 43);
            this.productGridView.Margin = new System.Windows.Forms.Padding(2);
            this.productGridView.Name = "productGridView";
            this.productGridView.ReadOnly = true;
            this.productGridView.RowHeadersVisible = false;
            this.productGridView.RowHeadersWidth = 32;
            this.productGridView.RowTemplate.Height = 30;
            this.productGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productGridView.Size = new System.Drawing.Size(342, 385);
            this.productGridView.TabIndex = 2;
            this.productGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productGridView_CellDoubleClick);
            // 
            // keywordTextBox
            // 
            this.keywordTextBox.Location = new System.Drawing.Point(12, 15);
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.PlaceholderText = "ชื่อ หรือ รหัสสินค้า";
            this.keywordTextBox.Size = new System.Drawing.Size(203, 23);
            this.keywordTextBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(221, 15);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(72, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "ค้นหา";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // qtyNumeric
            // 
            this.qtyNumeric.Location = new System.Drawing.Point(56, 443);
            this.qtyNumeric.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.qtyNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qtyNumeric.Name = "qtyNumeric";
            this.qtyNumeric.Size = new System.Drawing.Size(74, 23);
            this.qtyNumeric.TabIndex = 13;
            this.qtyNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.qtyNumeric.ThousandsSeparator = true;
            this.qtyNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.Location = new System.Drawing.Point(10, 445);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(40, 15);
            this.qtyLabel.TabIndex = 12;
            this.qtyLabel.Text = "จำนวน:";
            this.qtyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(272, 443);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 23);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "ยกเลิก";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(186, 443);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(80, 23);
            this.okButton.TabIndex = 14;
            this.okButton.Text = "ตกลง";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // SelectProductForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(364, 478);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.qtyNumeric);
            this.Controls.Add(this.qtyLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.keywordTextBox);
            this.Controls.Add(this.productGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SelectProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "เลือกสินค้า";
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtyNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.TextBox keywordTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.NumericUpDown qtyNumeric;
        private System.Windows.Forms.Label qtyLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
    }
}