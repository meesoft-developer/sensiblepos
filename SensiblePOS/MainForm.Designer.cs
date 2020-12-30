
namespace SensiblePOS
{
    partial class MainForm
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
            this.rightPanel = new System.Windows.Forms.Panel();
            this.salePanel = new System.Windows.Forms.Panel();
            this.cartTabControl = new System.Windows.Forms.TabControl();
            this.cartTabPage = new System.Windows.Forms.TabPage();
            this.cartDataGridView = new System.Windows.Forms.DataGridView();
            this.cartOptionPanel = new System.Windows.Forms.Panel();
            this.clearLinkLabel = new System.Windows.Forms.LinkLabel();
            this.summaryDescriptionLabel = new System.Windows.Forms.Label();
            this.promotionTabPage = new System.Windows.Forms.TabPage();
            this.promotionGridView = new System.Windows.Forms.DataGridView();
            this.promotionControlPanel = new System.Windows.Forms.Panel();
            this.deletePromoButton = new System.Windows.Forms.Button();
            this.addPromoButton = new System.Windows.Forms.Button();
            this.summaryPanel = new System.Windows.Forms.Panel();
            this.selectPaymentLabel = new System.Windows.Forms.Label();
            this.paymentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.staticTotalLabel = new System.Windows.Forms.Label();
            this.staticDiscountLabel = new System.Windows.Forms.Label();
            this.staticSubTotlaLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.optionButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.cartItemInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.promotionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leftPpanel = new System.Windows.Forms.Panel();
            this.productPanel = new System.Windows.Forms.Panel();
            this.productTabControl = new System.Windows.Forms.TabControl();
            this.productTabPage = new System.Windows.Forms.TabPage();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.addFavoriteContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addFavoriteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.productOptionPanel = new System.Windows.Forms.Panel();
            this.productCountLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.staticCategoryLabel = new System.Windows.Forms.Label();
            this.favoriteTabPage = new System.Windows.Forms.TabPage();
            this.favoriteGridView = new System.Windows.Forms.DataGridView();
            this.favoriteContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeFavoriteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.scanPanel = new System.Windows.Forms.Panel();
            this.scanBarcodeTextBox = new System.Windows.Forms.TextBox();
            this.staticScanLabel = new System.Windows.Forms.Label();
            this.customerPanel = new System.Windows.Forms.Panel();
            this.previousReceiptLabel = new System.Windows.Forms.Label();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.customerTelLabel = new System.Windows.Forms.Label();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.customerLastnameLabel = new System.Windows.Forms.Label();
            this.memoTextBox = new System.Windows.Forms.TextBox();
            this.customerNoteLabel = new System.Windows.Forms.Label();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.customerFirstnameLabel = new System.Windows.Forms.Label();
            this.customerCodeTextBox = new System.Windows.Forms.TextBox();
            this.customerCodeLabel = new System.Windows.Forms.Label();
            this.commonInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.favoriteInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.versionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lastReceiptStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.userStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.otherStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainHorizonSplitter = new System.Windows.Forms.Splitter();
            this.rightPanel.SuspendLayout();
            this.salePanel.SuspendLayout();
            this.cartTabControl.SuspendLayout();
            this.cartTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).BeginInit();
            this.cartOptionPanel.SuspendLayout();
            this.promotionTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.promotionGridView)).BeginInit();
            this.promotionControlPanel.SuspendLayout();
            this.summaryPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartItemInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionInfoBindingSource)).BeginInit();
            this.leftPpanel.SuspendLayout();
            this.productPanel.SuspendLayout();
            this.productTabControl.SuspendLayout();
            this.productTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.addFavoriteContextMenu.SuspendLayout();
            this.productOptionPanel.SuspendLayout();
            this.favoriteTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteGridView)).BeginInit();
            this.favoriteContextMenu.SuspendLayout();
            this.scanPanel.SuspendLayout();
            this.customerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commonInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteInfoBindingSource)).BeginInit();
            this.mainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.salePanel);
            this.rightPanel.Controls.Add(this.controlPanel);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(568, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(440, 679);
            this.rightPanel.TabIndex = 0;
            // 
            // salePanel
            // 
            this.salePanel.Controls.Add(this.cartTabControl);
            this.salePanel.Controls.Add(this.summaryPanel);
            this.salePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salePanel.Location = new System.Drawing.Point(0, 0);
            this.salePanel.Margin = new System.Windows.Forms.Padding(2);
            this.salePanel.Name = "salePanel";
            this.salePanel.Size = new System.Drawing.Size(440, 635);
            this.salePanel.TabIndex = 3;
            // 
            // cartTabControl
            // 
            this.cartTabControl.Controls.Add(this.cartTabPage);
            this.cartTabControl.Controls.Add(this.promotionTabPage);
            this.cartTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartTabControl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cartTabControl.Location = new System.Drawing.Point(0, 147);
            this.cartTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.cartTabControl.Name = "cartTabControl";
            this.cartTabControl.SelectedIndex = 0;
            this.cartTabControl.Size = new System.Drawing.Size(440, 488);
            this.cartTabControl.TabIndex = 2;
            // 
            // cartTabPage
            // 
            this.cartTabPage.Controls.Add(this.cartDataGridView);
            this.cartTabPage.Controls.Add(this.cartOptionPanel);
            this.cartTabPage.Location = new System.Drawing.Point(4, 26);
            this.cartTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.cartTabPage.Name = "cartTabPage";
            this.cartTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.cartTabPage.Size = new System.Drawing.Size(432, 458);
            this.cartTabPage.TabIndex = 0;
            this.cartTabPage.Text = "รายการสินค้า";
            this.cartTabPage.UseVisualStyleBackColor = true;
            // 
            // cartDataGridView
            // 
            this.cartDataGridView.AllowUserToAddRows = false;
            this.cartDataGridView.AllowUserToDeleteRows = false;
            this.cartDataGridView.AllowUserToResizeRows = false;
            this.cartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartDataGridView.Location = new System.Drawing.Point(2, 2);
            this.cartDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.cartDataGridView.Name = "cartDataGridView";
            this.cartDataGridView.RowHeadersVisible = false;
            this.cartDataGridView.RowHeadersWidth = 32;
            this.cartDataGridView.RowTemplate.Height = 30;
            this.cartDataGridView.Size = new System.Drawing.Size(428, 413);
            this.cartDataGridView.TabIndex = 1;
            this.cartDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.cartDataGridView_CellBeginEdit);
            this.cartDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartDataGridView_CellContentClick);
            this.cartDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartDataGridView_CellEndEdit);
            this.cartDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.cartDataGridView_DataError);
            // 
            // cartOptionPanel
            // 
            this.cartOptionPanel.Controls.Add(this.clearLinkLabel);
            this.cartOptionPanel.Controls.Add(this.summaryDescriptionLabel);
            this.cartOptionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cartOptionPanel.Location = new System.Drawing.Point(2, 415);
            this.cartOptionPanel.Margin = new System.Windows.Forms.Padding(2);
            this.cartOptionPanel.Name = "cartOptionPanel";
            this.cartOptionPanel.Size = new System.Drawing.Size(428, 41);
            this.cartOptionPanel.TabIndex = 0;
            // 
            // clearLinkLabel
            // 
            this.clearLinkLabel.ActiveLinkColor = System.Drawing.Color.Blue;
            this.clearLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearLinkLabel.AutoSize = true;
            this.clearLinkLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearLinkLabel.Location = new System.Drawing.Point(348, 9);
            this.clearLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clearLinkLabel.Name = "clearLinkLabel";
            this.clearLinkLabel.Size = new System.Drawing.Size(73, 17);
            this.clearLinkLabel.TabIndex = 3;
            this.clearLinkLabel.TabStop = true;
            this.clearLinkLabel.Text = "ล้างรายการ...";
            this.clearLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.clearLinkLabel_LinkClicked);
            // 
            // summaryDescriptionLabel
            // 
            this.summaryDescriptionLabel.AutoSize = true;
            this.summaryDescriptionLabel.Location = new System.Drawing.Point(1, 4);
            this.summaryDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.summaryDescriptionLabel.Name = "summaryDescriptionLabel";
            this.summaryDescriptionLabel.Size = new System.Drawing.Size(39, 17);
            this.summaryDescriptionLabel.TabIndex = 2;
            this.summaryDescriptionLabel.Text = "Total:";
            // 
            // promotionTabPage
            // 
            this.promotionTabPage.Controls.Add(this.promotionGridView);
            this.promotionTabPage.Controls.Add(this.promotionControlPanel);
            this.promotionTabPage.Location = new System.Drawing.Point(4, 26);
            this.promotionTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.promotionTabPage.Name = "promotionTabPage";
            this.promotionTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.promotionTabPage.Size = new System.Drawing.Size(432, 458);
            this.promotionTabPage.TabIndex = 1;
            this.promotionTabPage.Text = "โปรโมชั่น";
            this.promotionTabPage.UseVisualStyleBackColor = true;
            // 
            // promotionGridView
            // 
            this.promotionGridView.AllowUserToAddRows = false;
            this.promotionGridView.AllowUserToDeleteRows = false;
            this.promotionGridView.AllowUserToResizeRows = false;
            this.promotionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.promotionGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.promotionGridView.Location = new System.Drawing.Point(2, 2);
            this.promotionGridView.Margin = new System.Windows.Forms.Padding(2);
            this.promotionGridView.Name = "promotionGridView";
            this.promotionGridView.ReadOnly = true;
            this.promotionGridView.RowHeadersVisible = false;
            this.promotionGridView.RowHeadersWidth = 32;
            this.promotionGridView.RowTemplate.Height = 30;
            this.promotionGridView.Size = new System.Drawing.Size(428, 413);
            this.promotionGridView.TabIndex = 2;
            // 
            // promotionControlPanel
            // 
            this.promotionControlPanel.Controls.Add(this.deletePromoButton);
            this.promotionControlPanel.Controls.Add(this.addPromoButton);
            this.promotionControlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.promotionControlPanel.Location = new System.Drawing.Point(2, 415);
            this.promotionControlPanel.Name = "promotionControlPanel";
            this.promotionControlPanel.Size = new System.Drawing.Size(428, 41);
            this.promotionControlPanel.TabIndex = 3;
            // 
            // deletePromoButton
            // 
            this.deletePromoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePromoButton.Location = new System.Drawing.Point(44, 4);
            this.deletePromoButton.Name = "deletePromoButton";
            this.deletePromoButton.Size = new System.Drawing.Size(32, 32);
            this.deletePromoButton.TabIndex = 1;
            this.deletePromoButton.Text = "-";
            this.deletePromoButton.UseVisualStyleBackColor = true;
            this.deletePromoButton.Click += new System.EventHandler(this.deletePromoButton_Click);
            // 
            // addPromoButton
            // 
            this.addPromoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPromoButton.Location = new System.Drawing.Point(6, 4);
            this.addPromoButton.Name = "addPromoButton";
            this.addPromoButton.Size = new System.Drawing.Size(32, 32);
            this.addPromoButton.TabIndex = 0;
            this.addPromoButton.Text = "+";
            this.addPromoButton.UseVisualStyleBackColor = true;
            this.addPromoButton.Click += new System.EventHandler(this.addPromoButton_Click);
            // 
            // summaryPanel
            // 
            this.summaryPanel.Controls.Add(this.selectPaymentLabel);
            this.summaryPanel.Controls.Add(this.paymentTypeComboBox);
            this.summaryPanel.Controls.Add(this.purchaseButton);
            this.summaryPanel.Controls.Add(this.totalLabel);
            this.summaryPanel.Controls.Add(this.discountLabel);
            this.summaryPanel.Controls.Add(this.subtotalLabel);
            this.summaryPanel.Controls.Add(this.staticTotalLabel);
            this.summaryPanel.Controls.Add(this.staticDiscountLabel);
            this.summaryPanel.Controls.Add(this.staticSubTotlaLabel);
            this.summaryPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.summaryPanel.Location = new System.Drawing.Point(0, 0);
            this.summaryPanel.Margin = new System.Windows.Forms.Padding(2);
            this.summaryPanel.Name = "summaryPanel";
            this.summaryPanel.Size = new System.Drawing.Size(440, 147);
            this.summaryPanel.TabIndex = 1;
            // 
            // selectPaymentLabel
            // 
            this.selectPaymentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectPaymentLabel.AutoSize = true;
            this.selectPaymentLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectPaymentLabel.Location = new System.Drawing.Point(150, 107);
            this.selectPaymentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectPaymentLabel.Name = "selectPaymentLabel";
            this.selectPaymentLabel.Size = new System.Drawing.Size(74, 20);
            this.selectPaymentLabel.TabIndex = 10;
            this.selectPaymentLabel.Text = "[selected]";
            // 
            // paymentTypeComboBox
            // 
            this.paymentTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.paymentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentTypeComboBox.FormattingEnabled = true;
            this.paymentTypeComboBox.Location = new System.Drawing.Point(13, 103);
            this.paymentTypeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.paymentTypeComboBox.Name = "paymentTypeComboBox";
            this.paymentTypeComboBox.Size = new System.Drawing.Size(133, 28);
            this.paymentTypeComboBox.TabIndex = 9;
            this.paymentTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.paymentTypeComboBox_SelectedIndexChanged);
            // 
            // purchaseButton
            // 
            this.purchaseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.purchaseButton.Location = new System.Drawing.Point(291, 95);
            this.purchaseButton.Margin = new System.Windows.Forms.Padding(2);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(140, 42);
            this.purchaseButton.TabIndex = 8;
            this.purchaseButton.Text = "ชำระเงิน";
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalLabel.Location = new System.Drawing.Point(216, 54);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(211, 34);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "XXX บาท";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // discountLabel
            // 
            this.discountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.discountLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.discountLabel.Location = new System.Drawing.Point(260, 33);
            this.discountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(169, 18);
            this.discountLabel.TabIndex = 6;
            this.discountLabel.Text = "XXX บาท";
            this.discountLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.subtotalLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subtotalLabel.Location = new System.Drawing.Point(260, 10);
            this.subtotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(169, 18);
            this.subtotalLabel.TabIndex = 5;
            this.subtotalLabel.Text = "XXX บาท";
            this.subtotalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // staticTotalLabel
            // 
            this.staticTotalLabel.AutoSize = true;
            this.staticTotalLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.staticTotalLabel.Location = new System.Drawing.Point(13, 62);
            this.staticTotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.staticTotalLabel.Name = "staticTotalLabel";
            this.staticTotalLabel.Size = new System.Drawing.Size(74, 20);
            this.staticTotalLabel.TabIndex = 4;
            this.staticTotalLabel.Text = "ยอดชำระ:";
            // 
            // staticDiscountLabel
            // 
            this.staticDiscountLabel.AutoSize = true;
            this.staticDiscountLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.staticDiscountLabel.Location = new System.Drawing.Point(13, 33);
            this.staticDiscountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.staticDiscountLabel.Name = "staticDiscountLabel";
            this.staticDiscountLabel.Size = new System.Drawing.Size(53, 20);
            this.staticDiscountLabel.TabIndex = 3;
            this.staticDiscountLabel.Text = "ส่วนลด:";
            // 
            // staticSubTotlaLabel
            // 
            this.staticSubTotlaLabel.AutoSize = true;
            this.staticSubTotlaLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.staticSubTotlaLabel.Location = new System.Drawing.Point(13, 10);
            this.staticSubTotlaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.staticSubTotlaLabel.Name = "staticSubTotlaLabel";
            this.staticSubTotlaLabel.Size = new System.Drawing.Size(58, 20);
            this.staticSubTotlaLabel.TabIndex = 2;
            this.staticSubTotlaLabel.Text = "ยอดรวม:";
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.optionButton);
            this.controlPanel.Controls.Add(this.logoutButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 635);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(440, 44);
            this.controlPanel.TabIndex = 0;
            // 
            // optionButton
            // 
            this.optionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.optionButton.Location = new System.Drawing.Point(7, 7);
            this.optionButton.Margin = new System.Windows.Forms.Padding(2);
            this.optionButton.Name = "optionButton";
            this.optionButton.Size = new System.Drawing.Size(108, 32);
            this.optionButton.TabIndex = 2;
            this.optionButton.Text = "ตัวเลือก...";
            this.optionButton.UseVisualStyleBackColor = true;
            this.optionButton.Click += new System.EventHandler(this.optionButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.Location = new System.Drawing.Point(291, 7);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(140, 32);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "ลงชื่อออก";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // cartItemInfoBindingSource
            // 
            this.cartItemInfoBindingSource.DataSource = typeof(SensiblePOS.Models.CartItemInfo);
            this.cartItemInfoBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.cartItemInfoBindingSource_ListChanged);
            // 
            // promotionInfoBindingSource
            // 
            this.promotionInfoBindingSource.DataSource = typeof(SensiblePOS.Models.PromotionInfo);
            // 
            // leftPpanel
            // 
            this.leftPpanel.Controls.Add(this.productPanel);
            this.leftPpanel.Controls.Add(this.customerPanel);
            this.leftPpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPpanel.Location = new System.Drawing.Point(0, 0);
            this.leftPpanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftPpanel.Name = "leftPpanel";
            this.leftPpanel.Size = new System.Drawing.Size(562, 679);
            this.leftPpanel.TabIndex = 1;
            // 
            // productPanel
            // 
            this.productPanel.Controls.Add(this.productTabControl);
            this.productPanel.Controls.Add(this.scanPanel);
            this.productPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPanel.Location = new System.Drawing.Point(0, 108);
            this.productPanel.Margin = new System.Windows.Forms.Padding(2);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(562, 571);
            this.productPanel.TabIndex = 4;
            // 
            // productTabControl
            // 
            this.productTabControl.Controls.Add(this.productTabPage);
            this.productTabControl.Controls.Add(this.favoriteTabPage);
            this.productTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productTabControl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productTabControl.Location = new System.Drawing.Point(0, 0);
            this.productTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.productTabControl.Name = "productTabControl";
            this.productTabControl.SelectedIndex = 0;
            this.productTabControl.Size = new System.Drawing.Size(562, 527);
            this.productTabControl.TabIndex = 3;
            // 
            // productTabPage
            // 
            this.productTabPage.Controls.Add(this.productGridView);
            this.productTabPage.Controls.Add(this.productOptionPanel);
            this.productTabPage.Location = new System.Drawing.Point(4, 26);
            this.productTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.productTabPage.Name = "productTabPage";
            this.productTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.productTabPage.Size = new System.Drawing.Size(554, 497);
            this.productTabPage.TabIndex = 0;
            this.productTabPage.Text = "สินค้า";
            this.productTabPage.UseVisualStyleBackColor = true;
            // 
            // productGridView
            // 
            this.productGridView.AllowUserToAddRows = false;
            this.productGridView.AllowUserToDeleteRows = false;
            this.productGridView.AllowUserToResizeRows = false;
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.ContextMenuStrip = this.addFavoriteContextMenu;
            this.productGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productGridView.Location = new System.Drawing.Point(2, 41);
            this.productGridView.Margin = new System.Windows.Forms.Padding(2);
            this.productGridView.Name = "productGridView";
            this.productGridView.ReadOnly = true;
            this.productGridView.RowHeadersVisible = false;
            this.productGridView.RowHeadersWidth = 32;
            this.productGridView.RowTemplate.Height = 30;
            this.productGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productGridView.Size = new System.Drawing.Size(550, 454);
            this.productGridView.TabIndex = 2;
            this.productGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productGridView_CellDoubleClick);
            this.productGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productGridView_CellMouseDown);
            // 
            // addFavoriteContextMenu
            // 
            this.addFavoriteContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.addFavoriteContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFavoriteMenu});
            this.addFavoriteContextMenu.Name = "addFavoriteContextMenu";
            this.addFavoriteContextMenu.Size = new System.Drawing.Size(180, 26);
            // 
            // addFavoriteMenu
            // 
            this.addFavoriteMenu.Name = "addFavoriteMenu";
            this.addFavoriteMenu.Size = new System.Drawing.Size(179, 22);
            this.addFavoriteMenu.Text = "เพิ่มเป็นสินค้าขายประจำ";
            this.addFavoriteMenu.Click += new System.EventHandler(this.addFavoriteMenu_Click);
            // 
            // productOptionPanel
            // 
            this.productOptionPanel.Controls.Add(this.productCountLabel);
            this.productOptionPanel.Controls.Add(this.categoryComboBox);
            this.productOptionPanel.Controls.Add(this.staticCategoryLabel);
            this.productOptionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.productOptionPanel.Location = new System.Drawing.Point(2, 2);
            this.productOptionPanel.Margin = new System.Windows.Forms.Padding(2);
            this.productOptionPanel.Name = "productOptionPanel";
            this.productOptionPanel.Size = new System.Drawing.Size(550, 39);
            this.productOptionPanel.TabIndex = 0;
            // 
            // productCountLabel
            // 
            this.productCountLabel.AutoSize = true;
            this.productCountLabel.Location = new System.Drawing.Point(266, 11);
            this.productCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productCountLabel.Name = "productCountLabel";
            this.productCountLabel.Size = new System.Drawing.Size(57, 17);
            this.productCountLabel.TabIndex = 11;
            this.productCountLabel.Text = "0 รายการ";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(76, 7);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(176, 25);
            this.categoryComboBox.TabIndex = 10;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // staticCategoryLabel
            // 
            this.staticCategoryLabel.AutoSize = true;
            this.staticCategoryLabel.Location = new System.Drawing.Point(19, 10);
            this.staticCategoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.staticCategoryLabel.Name = "staticCategoryLabel";
            this.staticCategoryLabel.Size = new System.Drawing.Size(54, 17);
            this.staticCategoryLabel.TabIndex = 1;
            this.staticCategoryLabel.Text = "หมวดหมู่:";
            // 
            // favoriteTabPage
            // 
            this.favoriteTabPage.Controls.Add(this.favoriteGridView);
            this.favoriteTabPage.Location = new System.Drawing.Point(4, 26);
            this.favoriteTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.favoriteTabPage.Name = "favoriteTabPage";
            this.favoriteTabPage.Size = new System.Drawing.Size(554, 497);
            this.favoriteTabPage.TabIndex = 1;
            this.favoriteTabPage.Text = "สินค้าขายประจำ";
            this.favoriteTabPage.UseVisualStyleBackColor = true;
            // 
            // favoriteGridView
            // 
            this.favoriteGridView.AllowUserToAddRows = false;
            this.favoriteGridView.AllowUserToDeleteRows = false;
            this.favoriteGridView.AllowUserToResizeRows = false;
            this.favoriteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.favoriteGridView.ContextMenuStrip = this.favoriteContextMenu;
            this.favoriteGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.favoriteGridView.Location = new System.Drawing.Point(0, 0);
            this.favoriteGridView.Margin = new System.Windows.Forms.Padding(2);
            this.favoriteGridView.Name = "favoriteGridView";
            this.favoriteGridView.ReadOnly = true;
            this.favoriteGridView.RowHeadersVisible = false;
            this.favoriteGridView.RowHeadersWidth = 32;
            this.favoriteGridView.RowTemplate.Height = 30;
            this.favoriteGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.favoriteGridView.Size = new System.Drawing.Size(554, 497);
            this.favoriteGridView.TabIndex = 3;
            this.favoriteGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.favoriteGridView_CellDoubleClick);
            this.favoriteGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.favoriteGridView_CellMouseDown);
            this.favoriteGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.favoriteGridView_DataError);
            // 
            // favoriteContextMenu
            // 
            this.favoriteContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.favoriteContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeFavoriteMenu});
            this.favoriteContextMenu.Name = "favoriteContextMenu";
            this.favoriteContextMenu.Size = new System.Drawing.Size(88, 26);
            // 
            // removeFavoriteMenu
            // 
            this.removeFavoriteMenu.Name = "removeFavoriteMenu";
            this.removeFavoriteMenu.Size = new System.Drawing.Size(87, 22);
            this.removeFavoriteMenu.Text = "ลบ";
            this.removeFavoriteMenu.Click += new System.EventHandler(this.removeFavoriteMenu_Click);
            // 
            // scanPanel
            // 
            this.scanPanel.Controls.Add(this.scanBarcodeTextBox);
            this.scanPanel.Controls.Add(this.staticScanLabel);
            this.scanPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.scanPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scanPanel.Location = new System.Drawing.Point(0, 527);
            this.scanPanel.Margin = new System.Windows.Forms.Padding(2);
            this.scanPanel.Name = "scanPanel";
            this.scanPanel.Size = new System.Drawing.Size(562, 44);
            this.scanPanel.TabIndex = 1;
            // 
            // scanBarcodeTextBox
            // 
            this.scanBarcodeTextBox.Location = new System.Drawing.Point(77, 9);
            this.scanBarcodeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.scanBarcodeTextBox.MaxLength = 20;
            this.scanBarcodeTextBox.Name = "scanBarcodeTextBox";
            this.scanBarcodeTextBox.Size = new System.Drawing.Size(200, 25);
            this.scanBarcodeTextBox.TabIndex = 3;
            this.scanBarcodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.scanBarcodeTextBox_KeyPress);
            // 
            // staticScanLabel
            // 
            this.staticScanLabel.AutoSize = true;
            this.staticScanLabel.Location = new System.Drawing.Point(13, 12);
            this.staticScanLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.staticScanLabel.Name = "staticScanLabel";
            this.staticScanLabel.Size = new System.Drawing.Size(60, 17);
            this.staticScanLabel.TabIndex = 2;
            this.staticScanLabel.Text = "รหัสสินค้า:";
            // 
            // customerPanel
            // 
            this.customerPanel.Controls.Add(this.previousReceiptLabel);
            this.customerPanel.Controls.Add(this.telTextBox);
            this.customerPanel.Controls.Add(this.customerTelLabel);
            this.customerPanel.Controls.Add(this.lastnameTextBox);
            this.customerPanel.Controls.Add(this.customerLastnameLabel);
            this.customerPanel.Controls.Add(this.memoTextBox);
            this.customerPanel.Controls.Add(this.customerNoteLabel);
            this.customerPanel.Controls.Add(this.firstnameTextBox);
            this.customerPanel.Controls.Add(this.customerFirstnameLabel);
            this.customerPanel.Controls.Add(this.customerCodeTextBox);
            this.customerPanel.Controls.Add(this.customerCodeLabel);
            this.customerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerPanel.Location = new System.Drawing.Point(0, 0);
            this.customerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.customerPanel.Name = "customerPanel";
            this.customerPanel.Size = new System.Drawing.Size(562, 108);
            this.customerPanel.TabIndex = 0;
            // 
            // previousReceiptLabel
            // 
            this.previousReceiptLabel.AutoSize = true;
            this.previousReceiptLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.previousReceiptLabel.Location = new System.Drawing.Point(433, 11);
            this.previousReceiptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.previousReceiptLabel.Name = "previousReceiptLabel";
            this.previousReceiptLabel.Size = new System.Drawing.Size(89, 20);
            this.previousReceiptLabel.TabIndex = 10;
            this.previousReceiptLabel.Text = "0000000000";
            // 
            // telTextBox
            // 
            this.telTextBox.Location = new System.Drawing.Point(280, 8);
            this.telTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.telTextBox.MaxLength = 20;
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(140, 25);
            this.telTextBox.TabIndex = 9;
            // 
            // customerTelLabel
            // 
            this.customerTelLabel.AutoSize = true;
            this.customerTelLabel.Location = new System.Drawing.Point(224, 9);
            this.customerTelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerTelLabel.Name = "customerTelLabel";
            this.customerTelLabel.Size = new System.Drawing.Size(30, 17);
            this.customerTelLabel.TabIndex = 8;
            this.customerTelLabel.Text = "โทร:";
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Location = new System.Drawing.Point(280, 37);
            this.lastnameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.lastnameTextBox.MaxLength = 120;
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(140, 25);
            this.lastnameTextBox.TabIndex = 7;
            // 
            // customerLastnameLabel
            // 
            this.customerLastnameLabel.AutoSize = true;
            this.customerLastnameLabel.Location = new System.Drawing.Point(224, 39);
            this.customerLastnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerLastnameLabel.Name = "customerLastnameLabel";
            this.customerLastnameLabel.Size = new System.Drawing.Size(53, 17);
            this.customerLastnameLabel.TabIndex = 6;
            this.customerLastnameLabel.Text = "นามสกุล:";
            // 
            // memoTextBox
            // 
            this.memoTextBox.Location = new System.Drawing.Point(72, 66);
            this.memoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.memoTextBox.MaxLength = 120;
            this.memoTextBox.Name = "memoTextBox";
            this.memoTextBox.Size = new System.Drawing.Size(348, 25);
            this.memoTextBox.TabIndex = 5;
            // 
            // customerNoteLabel
            // 
            this.customerNoteLabel.AutoSize = true;
            this.customerNoteLabel.Location = new System.Drawing.Point(13, 68);
            this.customerNoteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerNoteLabel.Name = "customerNoteLabel";
            this.customerNoteLabel.Size = new System.Drawing.Size(31, 17);
            this.customerNoteLabel.TabIndex = 4;
            this.customerNoteLabel.Text = "โน๊ต:";
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.Location = new System.Drawing.Point(72, 37);
            this.firstnameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.firstnameTextBox.MaxLength = 120;
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(140, 25);
            this.firstnameTextBox.TabIndex = 3;
            // 
            // customerFirstnameLabel
            // 
            this.customerFirstnameLabel.AutoSize = true;
            this.customerFirstnameLabel.Location = new System.Drawing.Point(13, 39);
            this.customerFirstnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerFirstnameLabel.Name = "customerFirstnameLabel";
            this.customerFirstnameLabel.Size = new System.Drawing.Size(26, 17);
            this.customerFirstnameLabel.TabIndex = 2;
            this.customerFirstnameLabel.Text = "ชื่อ:";
            // 
            // customerCodeTextBox
            // 
            this.customerCodeTextBox.Location = new System.Drawing.Point(72, 8);
            this.customerCodeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.customerCodeTextBox.MaxLength = 20;
            this.customerCodeTextBox.Name = "customerCodeTextBox";
            this.customerCodeTextBox.Size = new System.Drawing.Size(140, 25);
            this.customerCodeTextBox.TabIndex = 1;
            this.customerCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customerCodeTextBox_KeyPress);
            // 
            // customerCodeLabel
            // 
            this.customerCodeLabel.AutoSize = true;
            this.customerCodeLabel.Location = new System.Drawing.Point(13, 10);
            this.customerCodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerCodeLabel.Name = "customerCodeLabel";
            this.customerCodeLabel.Size = new System.Drawing.Size(59, 17);
            this.customerCodeLabel.TabIndex = 0;
            this.customerCodeLabel.Text = "รหัสลูกค้า:";
            // 
            // commonInfoBindingSource
            // 
            this.commonInfoBindingSource.DataSource = typeof(SensiblePOS.Models.ProductInfo);
            // 
            // favoriteInfoBindingSource
            // 
            this.favoriteInfoBindingSource.DataSource = typeof(SensiblePOS.Models.ProductInfo);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionStatusLabel,
            this.lastReceiptStatusLabel,
            this.userStatusLabel,
            this.otherStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 679);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.mainStatusStrip.Size = new System.Drawing.Size(1008, 22);
            this.mainStatusStrip.TabIndex = 3;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // versionStatusLabel
            // 
            this.versionStatusLabel.Name = "versionStatusLabel";
            this.versionStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.versionStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // lastReceiptStatusLabel
            // 
            this.lastReceiptStatusLabel.Name = "lastReceiptStatusLabel";
            this.lastReceiptStatusLabel.Size = new System.Drawing.Size(124, 17);
            this.lastReceiptStatusLabel.Text = "lastReceiptStatusLabel";
            // 
            // userStatusLabel
            // 
            this.userStatusLabel.Name = "userStatusLabel";
            this.userStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.userStatusLabel.Text = "toolStripStatusLabel2";
            // 
            // otherStatusLabel
            // 
            this.otherStatusLabel.Name = "otherStatusLabel";
            this.otherStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.otherStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // mainHorizonSplitter
            // 
            this.mainHorizonSplitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainHorizonSplitter.Location = new System.Drawing.Point(562, 0);
            this.mainHorizonSplitter.Margin = new System.Windows.Forms.Padding(2);
            this.mainHorizonSplitter.Name = "mainHorizonSplitter";
            this.mainHorizonSplitter.Size = new System.Drawing.Size(6, 679);
            this.mainHorizonSplitter.TabIndex = 4;
            this.mainHorizonSplitter.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 701);
            this.Controls.Add(this.leftPpanel);
            this.Controls.Add(this.mainHorizonSplitter);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.mainStatusStrip);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "SensiblePOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.rightPanel.ResumeLayout(false);
            this.salePanel.ResumeLayout(false);
            this.cartTabControl.ResumeLayout(false);
            this.cartTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).EndInit();
            this.cartOptionPanel.ResumeLayout(false);
            this.cartOptionPanel.PerformLayout();
            this.promotionTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.promotionGridView)).EndInit();
            this.promotionControlPanel.ResumeLayout(false);
            this.summaryPanel.ResumeLayout(false);
            this.summaryPanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cartItemInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionInfoBindingSource)).EndInit();
            this.leftPpanel.ResumeLayout(false);
            this.productPanel.ResumeLayout(false);
            this.productTabControl.ResumeLayout(false);
            this.productTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.addFavoriteContextMenu.ResumeLayout(false);
            this.productOptionPanel.ResumeLayout(false);
            this.productOptionPanel.PerformLayout();
            this.favoriteTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.favoriteGridView)).EndInit();
            this.favoriteContextMenu.ResumeLayout(false);
            this.scanPanel.ResumeLayout(false);
            this.scanPanel.PerformLayout();
            this.customerPanel.ResumeLayout(false);
            this.customerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commonInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteInfoBindingSource)).EndInit();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel leftPpanel;
        private System.Windows.Forms.Panel customerPanel;
        private System.Windows.Forms.Label customerCodeLabel;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel versionStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel lastReceiptStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel userStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel otherStatusLabel;
        private System.Windows.Forms.Splitter mainHorizonSplitter;
        private System.Windows.Forms.TextBox customerCodeTextBox;
        private System.Windows.Forms.TextBox telTextBox;
        private System.Windows.Forms.Label customerTelLabel;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.Label customerLastnameLabel;
        private System.Windows.Forms.TextBox memoTextBox;
        private System.Windows.Forms.Label customerNoteLabel;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.Label customerFirstnameLabel;
        private System.Windows.Forms.Panel summaryPanel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label staticTotalLabel;
        private System.Windows.Forms.Label staticDiscountLabel;
        private System.Windows.Forms.Label staticSubTotlaLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.TabControl cartTabControl;
        private System.Windows.Forms.TabPage cartTabPage;
        private System.Windows.Forms.TabPage promotionTabPage;
        private System.Windows.Forms.ComboBox paymentTypeComboBox;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.Button optionButton;
        private System.Windows.Forms.Panel scanPanel;
        private System.Windows.Forms.TextBox scanBarcodeTextBox;
        private System.Windows.Forms.Label staticScanLabel;
        private System.Windows.Forms.TabControl productTabControl;
        private System.Windows.Forms.TabPage productTabPage;
        private System.Windows.Forms.Panel cartOptionPanel;
        private System.Windows.Forms.LinkLabel clearLinkLabel;
        private System.Windows.Forms.Label summaryDescriptionLabel;
        private System.Windows.Forms.Panel productOptionPanel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label staticCategoryLabel;
        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.DataGridView favoriteGridView;
        private System.Windows.Forms.DataGridView cartDataGridView;
        private System.Windows.Forms.DataGridView promotionGridView;
        private System.Windows.Forms.BindingSource cartItemInfoBindingSource;
        private System.Windows.Forms.BindingSource commonInfoBindingSource;
        private System.Windows.Forms.BindingSource promotionInfoBindingSource;
        private System.Windows.Forms.BindingSource favoriteInfoBindingSource;
        private System.Windows.Forms.Panel salePanel;
        private System.Windows.Forms.Panel productPanel;
        private System.Windows.Forms.TabPage favoriteTabPage;
        private System.Windows.Forms.Label selectPaymentLabel;
        private System.Windows.Forms.Label productCountLabel;
        private System.Windows.Forms.Panel promotionControlPanel;
        private System.Windows.Forms.Button deletePromoButton;
        private System.Windows.Forms.Button addPromoButton;
        private System.Windows.Forms.ContextMenuStrip addFavoriteContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addFavoriteMenu;
        private System.Windows.Forms.ContextMenuStrip favoriteContextMenu;
        private System.Windows.Forms.ToolStripMenuItem removeFavoriteMenu;
        private System.Windows.Forms.Label previousReceiptLabel;
    }
}