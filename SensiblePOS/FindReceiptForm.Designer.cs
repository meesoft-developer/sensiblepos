
namespace SensiblePOS
{
    partial class FindReceiptForm
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
            this.components = new System.ComponentModel.Container();
            this.keywordLabel = new System.Windows.Forms.Label();
            this.keywordTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.othersTextBox = new System.Windows.Forms.TextBox();
            this.otherLabel = new System.Windows.Forms.Label();
            this.paymentTypeTextBox = new System.Windows.Forms.TextBox();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.cartDataGridView = new System.Windows.Forms.DataGridView();
            this.skuTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartItemInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.customerLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.voidButton = new System.Windows.Forms.Button();
            this.reprintButton = new System.Windows.Forms.Button();
            this.fullReceiptButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.mainGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartItemInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // keywordLabel
            // 
            this.keywordLabel.AutoSize = true;
            this.keywordLabel.Location = new System.Drawing.Point(25, 22);
            this.keywordLabel.Name = "keywordLabel";
            this.keywordLabel.Size = new System.Drawing.Size(72, 17);
            this.keywordLabel.TabIndex = 0;
            this.keywordLabel.Text = "เลขที่ใบเสร็จ:";
            // 
            // keywordTextBox
            // 
            this.keywordTextBox.Location = new System.Drawing.Point(103, 19);
            this.keywordTextBox.MaxLength = 10;
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.Size = new System.Drawing.Size(200, 25);
            this.keywordTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(309, 15);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(90, 32);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "ค้นหา";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Controls.Add(this.othersTextBox);
            this.mainGroupBox.Controls.Add(this.otherLabel);
            this.mainGroupBox.Controls.Add(this.paymentTypeTextBox);
            this.mainGroupBox.Controls.Add(this.paymentLabel);
            this.mainGroupBox.Controls.Add(this.totalTextBox);
            this.mainGroupBox.Controls.Add(this.totalLabel);
            this.mainGroupBox.Controls.Add(this.dateTextBox);
            this.mainGroupBox.Controls.Add(this.dateLabel);
            this.mainGroupBox.Controls.Add(this.cartDataGridView);
            this.mainGroupBox.Controls.Add(this.statusTextBox);
            this.mainGroupBox.Controls.Add(this.statusLabel);
            this.mainGroupBox.Controls.Add(this.customerTextBox);
            this.mainGroupBox.Controls.Add(this.customerLabel);
            this.mainGroupBox.Controls.Add(this.numberTextBox);
            this.mainGroupBox.Controls.Add(this.numberLabel);
            this.mainGroupBox.Location = new System.Drawing.Point(12, 64);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(476, 432);
            this.mainGroupBox.TabIndex = 3;
            this.mainGroupBox.TabStop = false;
            this.mainGroupBox.Text = "ข้อมูลใบเสร็จ";
            // 
            // othersTextBox
            // 
            this.othersTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.othersTextBox.Location = new System.Drawing.Point(70, 122);
            this.othersTextBox.Multiline = true;
            this.othersTextBox.Name = "othersTextBox";
            this.othersTextBox.ReadOnly = true;
            this.othersTextBox.Size = new System.Drawing.Size(392, 64);
            this.othersTextBox.TabIndex = 13;
            // 
            // otherLabel
            // 
            this.otherLabel.AutoSize = true;
            this.otherLabel.Location = new System.Drawing.Point(32, 125);
            this.otherLabel.Name = "otherLabel";
            this.otherLabel.Size = new System.Drawing.Size(32, 17);
            this.otherLabel.TabIndex = 12;
            this.otherLabel.Text = "อื่นๆ:";
            this.otherLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // paymentTypeTextBox
            // 
            this.paymentTypeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.paymentTypeTextBox.Location = new System.Drawing.Point(302, 91);
            this.paymentTypeTextBox.Name = "paymentTypeTextBox";
            this.paymentTypeTextBox.ReadOnly = true;
            this.paymentTypeTextBox.Size = new System.Drawing.Size(160, 25);
            this.paymentTypeTextBox.TabIndex = 11;
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Location = new System.Drawing.Point(238, 94);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(54, 17);
            this.paymentLabel.TabIndex = 10;
            this.paymentLabel.Text = "การชำระ:";
            this.paymentLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalTextBox
            // 
            this.totalTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.totalTextBox.Location = new System.Drawing.Point(70, 91);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(160, 25);
            this.totalTextBox.TabIndex = 9;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(6, 94);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(58, 17);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "ราคาสุทธิ:";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateTextBox
            // 
            this.dateTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.dateTextBox.Location = new System.Drawing.Point(302, 60);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.ReadOnly = true;
            this.dateTextBox.Size = new System.Drawing.Size(160, 25);
            this.dateTextBox.TabIndex = 7;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(259, 63);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 17);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "วันที่:";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cartDataGridView
            // 
            this.cartDataGridView.AllowUserToAddRows = false;
            this.cartDataGridView.AllowUserToDeleteRows = false;
            this.cartDataGridView.AutoGenerateColumns = false;
            this.cartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.skuTextBoxColumn,
            this.titleTextBoxColumn,
            this.unitPriceTextBoxColumn,
            this.qtyTextBoxColumn,
            this.subTotalTextBoxColumn,
            this.discountTextBoxColumn,
            this.totalTextBoxColumn,
            this.remarksTextBoxColumn});
            this.cartDataGridView.DataSource = this.cartItemInfoBindingSource;
            this.cartDataGridView.Location = new System.Drawing.Point(13, 192);
            this.cartDataGridView.Name = "cartDataGridView";
            this.cartDataGridView.ReadOnly = true;
            this.cartDataGridView.RowHeadersVisible = false;
            this.cartDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartDataGridView.Size = new System.Drawing.Size(449, 228);
            this.cartDataGridView.TabIndex = 8;
            // 
            // skuTextBoxColumn
            // 
            this.skuTextBoxColumn.DataPropertyName = "SKU";
            this.skuTextBoxColumn.HeaderText = "SKU";
            this.skuTextBoxColumn.Name = "skuTextBoxColumn";
            this.skuTextBoxColumn.ReadOnly = true;
            this.skuTextBoxColumn.Width = 80;
            // 
            // titleTextBoxColumn
            // 
            this.titleTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleTextBoxColumn.DataPropertyName = "Title";
            this.titleTextBoxColumn.HeaderText = "สินค้า";
            this.titleTextBoxColumn.Name = "titleTextBoxColumn";
            this.titleTextBoxColumn.ReadOnly = true;
            // 
            // unitPriceTextBoxColumn
            // 
            this.unitPriceTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceTextBoxColumn.HeaderText = "ต่อหน่วย";
            this.unitPriceTextBoxColumn.Name = "unitPriceTextBoxColumn";
            this.unitPriceTextBoxColumn.ReadOnly = true;
            this.unitPriceTextBoxColumn.Width = 76;
            // 
            // qtyTextBoxColumn
            // 
            this.qtyTextBoxColumn.DataPropertyName = "Qty";
            this.qtyTextBoxColumn.HeaderText = "จำนวน";
            this.qtyTextBoxColumn.Name = "qtyTextBoxColumn";
            this.qtyTextBoxColumn.ReadOnly = true;
            this.qtyTextBoxColumn.Width = 50;
            // 
            // subTotalTextBoxColumn
            // 
            this.subTotalTextBoxColumn.DataPropertyName = "SubTotalPrice";
            this.subTotalTextBoxColumn.HeaderText = "รวม";
            this.subTotalTextBoxColumn.Name = "subTotalTextBoxColumn";
            this.subTotalTextBoxColumn.ReadOnly = true;
            this.subTotalTextBoxColumn.Visible = false;
            this.subTotalTextBoxColumn.Width = 60;
            // 
            // discountTextBoxColumn
            // 
            this.discountTextBoxColumn.DataPropertyName = "Discount";
            this.discountTextBoxColumn.HeaderText = "ส่วนลด";
            this.discountTextBoxColumn.Name = "discountTextBoxColumn";
            this.discountTextBoxColumn.ReadOnly = true;
            this.discountTextBoxColumn.Visible = false;
            // 
            // totalTextBoxColumn
            // 
            this.totalTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalTextBoxColumn.HeaderText = "ราคาสุทธิ";
            this.totalTextBoxColumn.MinimumWidth = 50;
            this.totalTextBoxColumn.Name = "totalTextBoxColumn";
            this.totalTextBoxColumn.ReadOnly = true;
            // 
            // remarksTextBoxColumn
            // 
            this.remarksTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remarksTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksTextBoxColumn.HeaderText = "*";
            this.remarksTextBoxColumn.Name = "remarksTextBoxColumn";
            this.remarksTextBoxColumn.ReadOnly = true;
            this.remarksTextBoxColumn.Visible = false;
            // 
            // cartItemInfoBindingSource
            // 
            this.cartItemInfoBindingSource.DataSource = typeof(SensiblePOS.Models.CartItemInfo);
            // 
            // statusTextBox
            // 
            this.statusTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.statusTextBox.Location = new System.Drawing.Point(302, 29);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(160, 25);
            this.statusTextBox.TabIndex = 5;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(249, 32);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(43, 17);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "สถานะ:";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // customerTextBox
            // 
            this.customerTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.customerTextBox.Location = new System.Drawing.Point(70, 60);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.ReadOnly = true;
            this.customerTextBox.Size = new System.Drawing.Size(160, 25);
            this.customerTextBox.TabIndex = 3;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(26, 63);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(38, 17);
            this.customerLabel.TabIndex = 2;
            this.customerLabel.Text = "ลูกค้า:";
            this.customerLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numberTextBox
            // 
            this.numberTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.numberTextBox.Location = new System.Drawing.Point(70, 29);
            this.numberTextBox.MaxLength = 10;
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.ReadOnly = true;
            this.numberTextBox.Size = new System.Drawing.Size(160, 25);
            this.numberTextBox.TabIndex = 1;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(27, 32);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(37, 17);
            this.numberLabel.TabIndex = 0;
            this.numberLabel.Text = "เลขที่:";
            this.numberLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // voidButton
            // 
            this.voidButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.voidButton.Location = new System.Drawing.Point(12, 502);
            this.voidButton.Name = "voidButton";
            this.voidButton.Size = new System.Drawing.Size(90, 32);
            this.voidButton.TabIndex = 4;
            this.voidButton.Text = "VOID";
            this.voidButton.UseVisualStyleBackColor = true;
            this.voidButton.Click += new System.EventHandler(this.voidButton_Click);
            // 
            // reprintButton
            // 
            this.reprintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reprintButton.Location = new System.Drawing.Point(108, 502);
            this.reprintButton.Name = "reprintButton";
            this.reprintButton.Size = new System.Drawing.Size(90, 32);
            this.reprintButton.TabIndex = 5;
            this.reprintButton.Text = "พิมพ์ซ้ำ";
            this.reprintButton.UseVisualStyleBackColor = true;
            this.reprintButton.Click += new System.EventHandler(this.reprintButton_Click);
            // 
            // fullReceiptButton
            // 
            this.fullReceiptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fullReceiptButton.Location = new System.Drawing.Point(204, 502);
            this.fullReceiptButton.Name = "fullReceiptButton";
            this.fullReceiptButton.Size = new System.Drawing.Size(90, 32);
            this.fullReceiptButton.TabIndex = 6;
            this.fullReceiptButton.Text = "ใบกำกับภาษี";
            this.fullReceiptButton.UseVisualStyleBackColor = true;
            this.fullReceiptButton.Click += new System.EventHandler(this.fullReceiptButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(390, 513);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 36);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "ปิด";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // FindReceiptForm
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(502, 561);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.fullReceiptButton);
            this.Controls.Add(this.reprintButton);
            this.Controls.Add(this.voidButton);
            this.Controls.Add(this.mainGroupBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.keywordTextBox);
            this.Controls.Add(this.keywordLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindReceiptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ค้นหาใบเสร็จ";
            this.mainGroupBox.ResumeLayout(false);
            this.mainGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartItemInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label keywordLabel;
        private System.Windows.Forms.TextBox keywordTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.TextBox othersTextBox;
        private System.Windows.Forms.Label otherLabel;
        private System.Windows.Forms.TextBox paymentTypeTextBox;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Button voidButton;
        private System.Windows.Forms.Button reprintButton;
        private System.Windows.Forms.Button fullReceiptButton;
        private System.Windows.Forms.Button closeButton; 
        private System.Windows.Forms.DataGridView cartDataGridView;
        private System.Windows.Forms.BindingSource cartItemInfoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn skuTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksTextBoxColumn;
    }
}