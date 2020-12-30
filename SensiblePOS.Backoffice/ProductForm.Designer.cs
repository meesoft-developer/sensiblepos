
namespace SensiblePOS.Backoffice
{
    partial class ProductForm
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
            this.keywordTextBox = new System.Windows.Forms.TextBox();
            this.listPanel = new System.Windows.Forms.Panel();
            this.addProductButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.generalGroupBox = new System.Windows.Forms.GroupBox();
            this.inactiveCheckBox = new System.Windows.Forms.CheckBox();
            this.serviceChargeEffectCheckBox = new System.Windows.Forms.CheckBox();
            this.promoEffectCheckBox = new System.Windows.Forms.CheckBox();
            this.salableCheckBox = new System.Windows.Forms.CheckBox();
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.skuTextBox = new System.Windows.Forms.TextBox();
            this.skuLabel = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceGroupBox = new System.Windows.Forms.GroupBox();
            this.closePriceButton = new System.Windows.Forms.Button();
            this.addPriceButton = new System.Windows.Forms.Button();
            this.priceGridView = new System.Windows.Forms.DataGridView();
            this.secondHalfCheckBox = new System.Windows.Forms.CheckBox();
            this.firstHalfCheckBox = new System.Windows.Forms.CheckBox();
            this.weekendCheckBox = new System.Windows.Forms.CheckBox();
            this.workdayCheckBox = new System.Windows.Forms.CheckBox();
            this.currentPriceTextBox = new System.Windows.Forms.TextBox();
            this.currentPriceLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.priceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockGroupBox = new System.Windows.Forms.GroupBox();
            this.setStockCategoryButton = new System.Windows.Forms.Button();
            this.removeStockButton = new System.Windows.Forms.Button();
            this.addStockButton = new System.Windows.Forms.Button();
            this.useQtyTextBox = new System.Windows.Forms.TextBox();
            this.useQtyLabel = new System.Windows.Forms.Label();
            this.stockGridView = new System.Windows.Forms.DataGridView();
            this.currentQtyTextBox = new System.Windows.Forms.TextBox();
            this.currentQtyLabel = new System.Windows.Forms.Label();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.generalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.priceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBindingSource)).BeginInit();
            this.stockGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // keywordTextBox
            // 
            this.keywordTextBox.Location = new System.Drawing.Point(13, 12);
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.PlaceholderText = "ชื่อ หรือ รหัสสินค้า";
            this.keywordTextBox.Size = new System.Drawing.Size(200, 23);
            this.keywordTextBox.TabIndex = 0;
            // 
            // listPanel
            // 
            this.listPanel.Controls.Add(this.addProductButton);
            this.listPanel.Controls.Add(this.searchButton);
            this.listPanel.Controls.Add(this.keywordTextBox);
            this.listPanel.Controls.Add(this.productGridView);
            this.listPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.listPanel.Location = new System.Drawing.Point(0, 0);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(300, 641);
            this.listPanel.TabIndex = 1;
            // 
            // addProductButton
            // 
            this.addProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addProductButton.Location = new System.Drawing.Point(11, 606);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(32, 23);
            this.addProductButton.TabIndex = 3;
            this.addProductButton.Text = "+";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(219, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(81, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "ค้นหา";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
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
            this.productGridView.Location = new System.Drawing.Point(11, 41);
            this.productGridView.Margin = new System.Windows.Forms.Padding(2);
            this.productGridView.Name = "productGridView";
            this.productGridView.ReadOnly = true;
            this.productGridView.RowHeadersVisible = false;
            this.productGridView.RowHeadersWidth = 32;
            this.productGridView.RowTemplate.Height = 30;
            this.productGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productGridView.Size = new System.Drawing.Size(289, 560);
            this.productGridView.TabIndex = 2;
            // 
            // generalGroupBox
            // 
            this.generalGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalGroupBox.Controls.Add(this.inactiveCheckBox);
            this.generalGroupBox.Controls.Add(this.serviceChargeEffectCheckBox);
            this.generalGroupBox.Controls.Add(this.promoEffectCheckBox);
            this.generalGroupBox.Controls.Add(this.salableCheckBox);
            this.generalGroupBox.Controls.Add(this.remarkTextBox);
            this.generalGroupBox.Controls.Add(this.label2);
            this.generalGroupBox.Controls.Add(this.titleTextBox);
            this.generalGroupBox.Controls.Add(this.titleLabel);
            this.generalGroupBox.Controls.Add(this.skuTextBox);
            this.generalGroupBox.Controls.Add(this.skuLabel);
            this.generalGroupBox.Location = new System.Drawing.Point(312, 12);
            this.generalGroupBox.Name = "generalGroupBox";
            this.generalGroupBox.Size = new System.Drawing.Size(660, 174);
            this.generalGroupBox.TabIndex = 2;
            this.generalGroupBox.TabStop = false;
            this.generalGroupBox.Text = "ข้อมูลทั่วไป";
            // 
            // inactiveCheckBox
            // 
            this.inactiveCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inactiveCheckBox.AutoSize = true;
            this.inactiveCheckBox.Location = new System.Drawing.Point(521, 97);
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
            this.serviceChargeEffectCheckBox.Location = new System.Drawing.Point(521, 72);
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
            this.promoEffectCheckBox.Location = new System.Drawing.Point(521, 47);
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
            this.salableCheckBox.Location = new System.Drawing.Point(521, 22);
            this.salableCheckBox.Name = "salableCheckBox";
            this.salableCheckBox.Size = new System.Drawing.Size(61, 19);
            this.salableCheckBox.TabIndex = 6;
            this.salableCheckBox.Text = "เปิดขาย";
            this.salableCheckBox.UseVisualStyleBackColor = true;
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.Location = new System.Drawing.Point(64, 88);
            this.remarkTextBox.MaxLength = 250;
            this.remarkTextBox.Multiline = true;
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(272, 73);
            this.remarkTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "หมายเหตุ:";
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
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(SensiblePOS.Data.Product);
            this.productBindingSource.CurrentChanged += new System.EventHandler(this.productBindingSource_CurrentChanged);
            this.productBindingSource.CurrentItemChanged += new System.EventHandler(this.productBindingSource_CurrentItemChanged);
            // 
            // priceGroupBox
            // 
            this.priceGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceGroupBox.Controls.Add(this.closePriceButton);
            this.priceGroupBox.Controls.Add(this.addPriceButton);
            this.priceGroupBox.Controls.Add(this.priceGridView);
            this.priceGroupBox.Controls.Add(this.secondHalfCheckBox);
            this.priceGroupBox.Controls.Add(this.firstHalfCheckBox);
            this.priceGroupBox.Controls.Add(this.weekendCheckBox);
            this.priceGroupBox.Controls.Add(this.workdayCheckBox);
            this.priceGroupBox.Controls.Add(this.currentPriceTextBox);
            this.priceGroupBox.Controls.Add(this.currentPriceLabel);
            this.priceGroupBox.Location = new System.Drawing.Point(312, 192);
            this.priceGroupBox.Name = "priceGroupBox";
            this.priceGroupBox.Size = new System.Drawing.Size(660, 158);
            this.priceGroupBox.TabIndex = 3;
            this.priceGroupBox.TabStop = false;
            this.priceGroupBox.Text = "ราคา";
            // 
            // closePriceButton
            // 
            this.closePriceButton.Location = new System.Drawing.Point(552, 19);
            this.closePriceButton.Name = "closePriceButton";
            this.closePriceButton.Size = new System.Drawing.Size(64, 23);
            this.closePriceButton.TabIndex = 10;
            this.closePriceButton.Text = "ลบ...";
            this.closePriceButton.UseVisualStyleBackColor = true;
            this.closePriceButton.Click += new System.EventHandler(this.closePriceButton_Click);
            // 
            // addPriceButton
            // 
            this.addPriceButton.Location = new System.Drawing.Point(482, 19);
            this.addPriceButton.Name = "addPriceButton";
            this.addPriceButton.Size = new System.Drawing.Size(64, 23);
            this.addPriceButton.TabIndex = 9;
            this.addPriceButton.Text = "เพิ่ม...";
            this.addPriceButton.UseVisualStyleBackColor = true;
            this.addPriceButton.Click += new System.EventHandler(this.addPriceButton_Click);
            // 
            // priceGridView
            // 
            this.priceGridView.AllowUserToAddRows = false;
            this.priceGridView.AllowUserToDeleteRows = false;
            this.priceGridView.AllowUserToResizeRows = false;
            this.priceGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.priceGridView.Location = new System.Drawing.Point(12, 52);
            this.priceGridView.Margin = new System.Windows.Forms.Padding(2);
            this.priceGridView.Name = "priceGridView";
            this.priceGridView.ReadOnly = true;
            this.priceGridView.RowHeadersVisible = false;
            this.priceGridView.RowHeadersWidth = 32;
            this.priceGridView.RowTemplate.Height = 30;
            this.priceGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.priceGridView.Size = new System.Drawing.Size(638, 97);
            this.priceGridView.TabIndex = 8;
            // 
            // secondHalfCheckBox
            // 
            this.secondHalfCheckBox.Location = new System.Drawing.Point(388, 24);
            this.secondHalfCheckBox.Name = "secondHalfCheckBox";
            this.secondHalfCheckBox.Size = new System.Drawing.Size(74, 21);
            this.secondHalfCheckBox.TabIndex = 7;
            this.secondHalfCheckBox.Text = "ครึ่งหลัง";
            this.secondHalfCheckBox.UseVisualStyleBackColor = true;
            // 
            // firstHalfCheckBox
            // 
            this.firstHalfCheckBox.Location = new System.Drawing.Point(311, 24);
            this.firstHalfCheckBox.Name = "firstHalfCheckBox";
            this.firstHalfCheckBox.Size = new System.Drawing.Size(74, 21);
            this.firstHalfCheckBox.TabIndex = 6;
            this.firstHalfCheckBox.Text = "ครึ่งแรก";
            this.firstHalfCheckBox.UseVisualStyleBackColor = true;
            // 
            // weekendCheckBox
            // 
            this.weekendCheckBox.Location = new System.Drawing.Point(233, 24);
            this.weekendCheckBox.Name = "weekendCheckBox";
            this.weekendCheckBox.Size = new System.Drawing.Size(74, 21);
            this.weekendCheckBox.TabIndex = 5;
            this.weekendCheckBox.Text = "วันหยุด";
            this.weekendCheckBox.UseVisualStyleBackColor = true;
            // 
            // workdayCheckBox
            // 
            this.workdayCheckBox.Location = new System.Drawing.Point(155, 24);
            this.workdayCheckBox.Name = "workdayCheckBox";
            this.workdayCheckBox.Size = new System.Drawing.Size(74, 21);
            this.workdayCheckBox.TabIndex = 4;
            this.workdayCheckBox.Text = "วันธรรมดา";
            this.workdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // currentPriceTextBox
            // 
            this.currentPriceTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.currentPriceTextBox.Location = new System.Drawing.Point(64, 22);
            this.currentPriceTextBox.MaxLength = 64;
            this.currentPriceTextBox.Name = "currentPriceTextBox";
            this.currentPriceTextBox.ReadOnly = true;
            this.currentPriceTextBox.Size = new System.Drawing.Size(80, 23);
            this.currentPriceTextBox.TabIndex = 3;
            // 
            // currentPriceLabel
            // 
            this.currentPriceLabel.AutoSize = true;
            this.currentPriceLabel.Location = new System.Drawing.Point(15, 25);
            this.currentPriceLabel.Name = "currentPriceLabel";
            this.currentPriceLabel.Size = new System.Drawing.Size(43, 15);
            this.currentPriceLabel.TabIndex = 2;
            this.currentPriceLabel.Text = "ปัจจุบัน:";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(852, 597);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 32);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "บันทึก";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // priceBindingSource
            // 
            this.priceBindingSource.DataSource = typeof(SensiblePOS.Data.Price);
            // 
            // stockGroupBox
            // 
            this.stockGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockGroupBox.Controls.Add(this.setStockCategoryButton);
            this.stockGroupBox.Controls.Add(this.removeStockButton);
            this.stockGroupBox.Controls.Add(this.addStockButton);
            this.stockGroupBox.Controls.Add(this.useQtyTextBox);
            this.stockGroupBox.Controls.Add(this.useQtyLabel);
            this.stockGroupBox.Controls.Add(this.stockGridView);
            this.stockGroupBox.Controls.Add(this.currentQtyTextBox);
            this.stockGroupBox.Controls.Add(this.currentQtyLabel);
            this.stockGroupBox.Location = new System.Drawing.Point(312, 356);
            this.stockGroupBox.Name = "stockGroupBox";
            this.stockGroupBox.Size = new System.Drawing.Size(660, 191);
            this.stockGroupBox.TabIndex = 5;
            this.stockGroupBox.TabStop = false;
            this.stockGroupBox.Text = "สต๊อก";
            // 
            // setStockCategoryButton
            // 
            this.setStockCategoryButton.Location = new System.Drawing.Point(510, 21);
            this.setStockCategoryButton.Name = "setStockCategoryButton";
            this.setStockCategoryButton.Size = new System.Drawing.Size(90, 23);
            this.setStockCategoryButton.TabIndex = 13;
            this.setStockCategoryButton.Text = "ตั้งชื่อหมวดหมู่";
            this.setStockCategoryButton.UseVisualStyleBackColor = true;
            this.setStockCategoryButton.Click += new System.EventHandler(this.setStockCategoryButton_Click);
            // 
            // removeStockButton
            // 
            this.removeStockButton.Location = new System.Drawing.Point(414, 21);
            this.removeStockButton.Name = "removeStockButton";
            this.removeStockButton.Size = new System.Drawing.Size(90, 23);
            this.removeStockButton.TabIndex = 12;
            this.removeStockButton.Text = " ลบ...";
            this.removeStockButton.UseVisualStyleBackColor = true;
            this.removeStockButton.Click += new System.EventHandler(this.removeStockButton_Click);
            // 
            // addStockButton
            // 
            this.addStockButton.Location = new System.Drawing.Point(321, 21);
            this.addStockButton.Name = "addStockButton";
            this.addStockButton.Size = new System.Drawing.Size(87, 23);
            this.addStockButton.TabIndex = 11;
            this.addStockButton.Text = "เพิ่ม...";
            this.addStockButton.UseVisualStyleBackColor = true;
            this.addStockButton.Click += new System.EventHandler(this.addStockButton_Click);
            // 
            // useQtyTextBox
            // 
            this.useQtyTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.useQtyTextBox.Location = new System.Drawing.Point(215, 22);
            this.useQtyTextBox.MaxLength = 64;
            this.useQtyTextBox.Name = "useQtyTextBox";
            this.useQtyTextBox.ReadOnly = true;
            this.useQtyTextBox.Size = new System.Drawing.Size(80, 23);
            this.useQtyTextBox.TabIndex = 10;
            // 
            // useQtyLabel
            // 
            this.useQtyLabel.AutoSize = true;
            this.useQtyLabel.Location = new System.Drawing.Point(155, 25);
            this.useQtyLabel.Name = "useQtyLabel";
            this.useQtyLabel.Size = new System.Drawing.Size(54, 15);
            this.useQtyLabel.TabIndex = 9;
            this.useQtyLabel.Text = "จำนวนตัด:";
            // 
            // stockGridView
            // 
            this.stockGridView.AllowUserToAddRows = false;
            this.stockGridView.AllowUserToDeleteRows = false;
            this.stockGridView.AllowUserToResizeRows = false;
            this.stockGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockGridView.Location = new System.Drawing.Point(12, 50);
            this.stockGridView.Margin = new System.Windows.Forms.Padding(2);
            this.stockGridView.Name = "stockGridView";
            this.stockGridView.ReadOnly = true;
            this.stockGridView.RowHeadersVisible = false;
            this.stockGridView.RowHeadersWidth = 32;
            this.stockGridView.RowTemplate.Height = 30;
            this.stockGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockGridView.Size = new System.Drawing.Size(638, 124);
            this.stockGridView.TabIndex = 8;
            // 
            // currentQtyTextBox
            // 
            this.currentQtyTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.currentQtyTextBox.Location = new System.Drawing.Point(64, 22);
            this.currentQtyTextBox.MaxLength = 64;
            this.currentQtyTextBox.Name = "currentQtyTextBox";
            this.currentQtyTextBox.ReadOnly = true;
            this.currentQtyTextBox.Size = new System.Drawing.Size(80, 23);
            this.currentQtyTextBox.TabIndex = 3;
            // 
            // currentQtyLabel
            // 
            this.currentQtyLabel.AutoSize = true;
            this.currentQtyLabel.Location = new System.Drawing.Point(15, 25);
            this.currentQtyLabel.Name = "currentQtyLabel";
            this.currentQtyLabel.Size = new System.Drawing.Size(43, 15);
            this.currentQtyLabel.TabIndex = 2;
            this.currentQtyLabel.Text = "ปัจจุบัน:";
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataSource = typeof(SensiblePOS.Backoffice.Models.ProductZoneInfo);
            // 
            // ProductForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 641);
            this.Controls.Add(this.stockGroupBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.priceGroupBox);
            this.Controls.Add(this.generalGroupBox);
            this.Controls.Add(this.listPanel);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ข้อมูลสินค้า";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.listPanel.ResumeLayout(false);
            this.listPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.generalGroupBox.ResumeLayout(false);
            this.generalGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.priceGroupBox.ResumeLayout(false);
            this.priceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBindingSource)).EndInit();
            this.stockGroupBox.ResumeLayout(false);
            this.stockGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox keywordTextBox;
        private System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox generalGroupBox;
        private System.Windows.Forms.CheckBox inactiveCheckBox;
        private System.Windows.Forms.CheckBox serviceChargeEffectCheckBox;
        private System.Windows.Forms.CheckBox promoEffectCheckBox;
        private System.Windows.Forms.CheckBox salableCheckBox;
        private System.Windows.Forms.TextBox remarkTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox skuTextBox;
        private System.Windows.Forms.Label skuLabel;
        private System.Windows.Forms.GroupBox priceGroupBox;
        private System.Windows.Forms.CheckBox secondHalfCheckBox;
        private System.Windows.Forms.CheckBox firstHalfCheckBox;
        private System.Windows.Forms.CheckBox weekendCheckBox;
        private System.Windows.Forms.CheckBox workdayCheckBox;
        private System.Windows.Forms.TextBox currentPriceTextBox;
        private System.Windows.Forms.Label currentPriceLabel;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView priceGridView;
        private System.Windows.Forms.BindingSource priceBindingSource;
        private System.Windows.Forms.Button closePriceButton;
        private System.Windows.Forms.Button addPriceButton;
        private System.Windows.Forms.GroupBox stockGroupBox;
        private System.Windows.Forms.TextBox useQtyTextBox;
        private System.Windows.Forms.Label useQtyLabel;
        private System.Windows.Forms.DataGridView stockGridView;
        private System.Windows.Forms.TextBox currentQtyTextBox;
        private System.Windows.Forms.Label currentQtyLabel;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private System.Windows.Forms.Button setStockCategoryButton;
        private System.Windows.Forms.Button removeStockButton;
        private System.Windows.Forms.Button addStockButton;
    }
}