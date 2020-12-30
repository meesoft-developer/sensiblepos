
namespace SensiblePOS.Backoffice
{
    partial class AddPromotionForm
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
            this.effectiveGroupBox = new System.Windows.Forms.GroupBox();
            this.expireDateTimeLabel = new System.Windows.Forms.Label();
            this.effectiveDateTimeLabel = new System.Windows.Forms.Label();
            this.expireDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.effectiveDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.percentDcLabel = new System.Windows.Forms.Label();
            this.percentDcNumeric = new System.Windows.Forms.NumericUpDown();
            this.generalGroupBox = new System.Windows.Forms.GroupBox();
            this.detailTextBox = new System.Windows.Forms.TextBox();
            this.detailLabel = new System.Windows.Forms.Label();
            this.inactiveCheckBox = new System.Windows.Forms.CheckBox();
            this.serviceChargeEffectCheckBox = new System.Windows.Forms.CheckBox();
            this.promoEffectCheckBox = new System.Windows.Forms.CheckBox();
            this.salableCheckBox = new System.Windows.Forms.CheckBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.discountGroupBox = new System.Windows.Forms.GroupBox();
            this.maxDcRemarkLabel = new System.Windows.Forms.Label();
            this.maxDcNumeric = new System.Windows.Forms.NumericUpDown();
            this.maxDcLabel = new System.Windows.Forms.Label();
            this.valueDcNumeric = new System.Windows.Forms.NumericUpDown();
            this.valueDcLabel = new System.Windows.Forms.Label();
            this.targetProductGroupBox = new System.Windows.Forms.GroupBox();
            this.clearTargetProductButton = new System.Windows.Forms.Button();
            this.selectTargetProductButton = new System.Windows.Forms.Button();
            this.targetProductLimitQtyNumeric = new System.Windows.Forms.NumericUpDown();
            this.targetProductLimitQtyLabel = new System.Windows.Forms.Label();
            this.targetProductTitleTextBox = new System.Windows.Forms.TextBox();
            this.targetProductTitleLabel = new System.Windows.Forms.Label();
            this.targetProductSkuTextBox = new System.Windows.Forms.TextBox();
            this.targetProductSkuLabel = new System.Windows.Forms.Label();
            this.paywithGroupBox = new System.Windows.Forms.GroupBox();
            this.paywithComboBox = new System.Windows.Forms.ComboBox();
            this.paywhitLabel = new System.Windows.Forms.Label();
            this.bundleGroupBox = new System.Windows.Forms.GroupBox();
            this.addBundleButton = new System.Windows.Forms.Button();
            this.attachProductGridView = new System.Windows.Forms.DataGridView();
            this.cancelButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.effectiveGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percentDcNumeric)).BeginInit();
            this.generalGroupBox.SuspendLayout();
            this.discountGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxDcNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueDcNumeric)).BeginInit();
            this.targetProductGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetProductLimitQtyNumeric)).BeginInit();
            this.paywithGroupBox.SuspendLayout();
            this.bundleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attachProductGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // effectiveGroupBox
            // 
            this.effectiveGroupBox.Controls.Add(this.expireDateTimeLabel);
            this.effectiveGroupBox.Controls.Add(this.effectiveDateTimeLabel);
            this.effectiveGroupBox.Controls.Add(this.expireDateTimePicker);
            this.effectiveGroupBox.Controls.Add(this.effectiveDateTimePicker);
            this.effectiveGroupBox.Location = new System.Drawing.Point(12, 318);
            this.effectiveGroupBox.Name = "effectiveGroupBox";
            this.effectiveGroupBox.Size = new System.Drawing.Size(320, 95);
            this.effectiveGroupBox.TabIndex = 6;
            this.effectiveGroupBox.TabStop = false;
            this.effectiveGroupBox.Text = "กำหนดการ";
            // 
            // expireDateTimeLabel
            // 
            this.expireDateTimeLabel.AutoSize = true;
            this.expireDateTimeLabel.Location = new System.Drawing.Point(28, 55);
            this.expireDateTimeLabel.Name = "expireDateTimeLabel";
            this.expireDateTimeLabel.Size = new System.Drawing.Size(36, 15);
            this.expireDateTimeLabel.TabIndex = 13;
            this.expireDateTimeLabel.Text = "สิ้นสุด:";
            this.expireDateTimeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // effectiveDateTimeLabel
            // 
            this.effectiveDateTimeLabel.AutoSize = true;
            this.effectiveDateTimeLabel.Location = new System.Drawing.Point(39, 26);
            this.effectiveDateTimeLabel.Name = "effectiveDateTimeLabel";
            this.effectiveDateTimeLabel.Size = new System.Drawing.Size(25, 15);
            this.effectiveDateTimeLabel.TabIndex = 12;
            this.effectiveDateTimeLabel.Text = "เริ่ม:";
            this.effectiveDateTimeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // expireDateTimePicker
            // 
            this.expireDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expireDateTimePicker.Location = new System.Drawing.Point(70, 51);
            this.expireDateTimePicker.Name = "expireDateTimePicker";
            this.expireDateTimePicker.Size = new System.Drawing.Size(132, 23);
            this.expireDateTimePicker.TabIndex = 11;
            // 
            // effectiveDateTimePicker
            // 
            this.effectiveDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.effectiveDateTimePicker.Location = new System.Drawing.Point(70, 22);
            this.effectiveDateTimePicker.Name = "effectiveDateTimePicker";
            this.effectiveDateTimePicker.Size = new System.Drawing.Size(132, 23);
            this.effectiveDateTimePicker.TabIndex = 10;
            // 
            // percentDcLabel
            // 
            this.percentDcLabel.AutoSize = true;
            this.percentDcLabel.Location = new System.Drawing.Point(9, 24);
            this.percentDcLabel.Name = "percentDcLabel";
            this.percentDcLabel.Size = new System.Drawing.Size(55, 15);
            this.percentDcLabel.TabIndex = 8;
            this.percentDcLabel.Text = "เปอร์เซนต์:";
            this.percentDcLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // percentDcNumeric
            // 
            this.percentDcNumeric.DecimalPlaces = 2;
            this.percentDcNumeric.Location = new System.Drawing.Point(70, 22);
            this.percentDcNumeric.Name = "percentDcNumeric";
            this.percentDcNumeric.Size = new System.Drawing.Size(101, 23);
            this.percentDcNumeric.TabIndex = 9;
            this.percentDcNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.percentDcNumeric.ThousandsSeparator = true;
            // 
            // generalGroupBox
            // 
            this.generalGroupBox.Controls.Add(this.detailTextBox);
            this.generalGroupBox.Controls.Add(this.detailLabel);
            this.generalGroupBox.Controls.Add(this.inactiveCheckBox);
            this.generalGroupBox.Controls.Add(this.serviceChargeEffectCheckBox);
            this.generalGroupBox.Controls.Add(this.promoEffectCheckBox);
            this.generalGroupBox.Controls.Add(this.salableCheckBox);
            this.generalGroupBox.Controls.Add(this.titleTextBox);
            this.generalGroupBox.Controls.Add(this.titleLabel);
            this.generalGroupBox.Controls.Add(this.codeTextBox);
            this.generalGroupBox.Controls.Add(this.codeLabel);
            this.generalGroupBox.Location = new System.Drawing.Point(12, 12);
            this.generalGroupBox.Name = "generalGroupBox";
            this.generalGroupBox.Size = new System.Drawing.Size(320, 176);
            this.generalGroupBox.TabIndex = 5;
            this.generalGroupBox.TabStop = false;
            this.generalGroupBox.Text = "ข้อมูลทั่วไป";
            // 
            // detailTextBox
            // 
            this.detailTextBox.Location = new System.Drawing.Point(70, 88);
            this.detailTextBox.MaxLength = 128;
            this.detailTextBox.Multiline = true;
            this.detailTextBox.Name = "detailTextBox";
            this.detailTextBox.Size = new System.Drawing.Size(228, 78);
            this.detailTextBox.TabIndex = 11;
            // 
            // detailLabel
            // 
            this.detailLabel.AutoSize = true;
            this.detailLabel.Location = new System.Drawing.Point(6, 91);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(58, 15);
            this.detailLabel.TabIndex = 10;
            this.detailLabel.Text = "รายละเอียด:";
            // 
            // inactiveCheckBox
            // 
            this.inactiveCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inactiveCheckBox.AutoSize = true;
            this.inactiveCheckBox.Location = new System.Drawing.Point(713, 97);
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
            this.serviceChargeEffectCheckBox.Location = new System.Drawing.Point(713, 72);
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
            this.promoEffectCheckBox.Location = new System.Drawing.Point(713, 47);
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
            this.salableCheckBox.Location = new System.Drawing.Point(713, 22);
            this.salableCheckBox.Name = "salableCheckBox";
            this.salableCheckBox.Size = new System.Drawing.Size(61, 19);
            this.salableCheckBox.TabIndex = 6;
            this.salableCheckBox.Text = "เปิดขาย";
            this.salableCheckBox.UseVisualStyleBackColor = true;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(70, 59);
            this.titleTextBox.MaxLength = 128;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(180, 23);
            this.titleTextBox.TabIndex = 3;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(41, 62);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(23, 15);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "ชื่อ:";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(70, 30);
            this.codeTextBox.MaxLength = 64;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(180, 23);
            this.codeTextBox.TabIndex = 1;
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(36, 33);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(28, 15);
            this.codeLabel.TabIndex = 0;
            this.codeLabel.Text = "รหัส:";
            // 
            // discountGroupBox
            // 
            this.discountGroupBox.Controls.Add(this.maxDcRemarkLabel);
            this.discountGroupBox.Controls.Add(this.maxDcNumeric);
            this.discountGroupBox.Controls.Add(this.maxDcLabel);
            this.discountGroupBox.Controls.Add(this.valueDcNumeric);
            this.discountGroupBox.Controls.Add(this.valueDcLabel);
            this.discountGroupBox.Controls.Add(this.percentDcNumeric);
            this.discountGroupBox.Controls.Add(this.percentDcLabel);
            this.discountGroupBox.Location = new System.Drawing.Point(12, 193);
            this.discountGroupBox.Name = "discountGroupBox";
            this.discountGroupBox.Size = new System.Drawing.Size(320, 119);
            this.discountGroupBox.TabIndex = 7;
            this.discountGroupBox.TabStop = false;
            this.discountGroupBox.Text = "ส่วนลด";
            // 
            // maxDcRemarkLabel
            // 
            this.maxDcRemarkLabel.AutoSize = true;
            this.maxDcRemarkLabel.Location = new System.Drawing.Point(216, 82);
            this.maxDcRemarkLabel.Name = "maxDcRemarkLabel";
            this.maxDcRemarkLabel.Size = new System.Drawing.Size(69, 15);
            this.maxDcRemarkLabel.TabIndex = 14;
            this.maxDcRemarkLabel.Text = "*0 = ไม่จำกัด";
            this.maxDcRemarkLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // maxDcNumeric
            // 
            this.maxDcNumeric.DecimalPlaces = 2;
            this.maxDcNumeric.Location = new System.Drawing.Point(70, 80);
            this.maxDcNumeric.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.maxDcNumeric.Name = "maxDcNumeric";
            this.maxDcNumeric.Size = new System.Drawing.Size(101, 23);
            this.maxDcNumeric.TabIndex = 13;
            this.maxDcNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maxDcNumeric.ThousandsSeparator = true;
            this.maxDcNumeric.ValueChanged += new System.EventHandler(this.maxDcNumeric_ValueChanged);
            // 
            // maxDcLabel
            // 
            this.maxDcLabel.AutoSize = true;
            this.maxDcLabel.Location = new System.Drawing.Point(30, 82);
            this.maxDcLabel.Name = "maxDcLabel";
            this.maxDcLabel.Size = new System.Drawing.Size(34, 15);
            this.maxDcLabel.TabIndex = 12;
            this.maxDcLabel.Text = "สูงสุด:";
            this.maxDcLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // valueDcNumeric
            // 
            this.valueDcNumeric.DecimalPlaces = 2;
            this.valueDcNumeric.Location = new System.Drawing.Point(70, 51);
            this.valueDcNumeric.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.valueDcNumeric.Name = "valueDcNumeric";
            this.valueDcNumeric.Size = new System.Drawing.Size(101, 23);
            this.valueDcNumeric.TabIndex = 11;
            this.valueDcNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valueDcNumeric.ThousandsSeparator = true;
            this.valueDcNumeric.ValueChanged += new System.EventHandler(this.valueDcNumeric_ValueChanged);
            // 
            // valueDcLabel
            // 
            this.valueDcLabel.AutoSize = true;
            this.valueDcLabel.Location = new System.Drawing.Point(29, 53);
            this.valueDcLabel.Name = "valueDcLabel";
            this.valueDcLabel.Size = new System.Drawing.Size(35, 15);
            this.valueDcLabel.TabIndex = 10;
            this.valueDcLabel.Text = "มูลค่า:";
            this.valueDcLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // targetProductGroupBox
            // 
            this.targetProductGroupBox.Controls.Add(this.clearTargetProductButton);
            this.targetProductGroupBox.Controls.Add(this.selectTargetProductButton);
            this.targetProductGroupBox.Controls.Add(this.targetProductLimitQtyNumeric);
            this.targetProductGroupBox.Controls.Add(this.targetProductLimitQtyLabel);
            this.targetProductGroupBox.Controls.Add(this.targetProductTitleTextBox);
            this.targetProductGroupBox.Controls.Add(this.targetProductTitleLabel);
            this.targetProductGroupBox.Controls.Add(this.targetProductSkuTextBox);
            this.targetProductGroupBox.Controls.Add(this.targetProductSkuLabel);
            this.targetProductGroupBox.Location = new System.Drawing.Point(347, 12);
            this.targetProductGroupBox.Name = "targetProductGroupBox";
            this.targetProductGroupBox.Size = new System.Drawing.Size(320, 150);
            this.targetProductGroupBox.TabIndex = 8;
            this.targetProductGroupBox.TabStop = false;
            this.targetProductGroupBox.Text = "ลดเฉพาะสินค้า";
            // 
            // clearTargetProductButton
            // 
            this.clearTargetProductButton.Location = new System.Drawing.Point(76, 114);
            this.clearTargetProductButton.Name = "clearTargetProductButton";
            this.clearTargetProductButton.Size = new System.Drawing.Size(75, 23);
            this.clearTargetProductButton.TabIndex = 13;
            this.clearTargetProductButton.Text = "ยกเลิก";
            this.clearTargetProductButton.UseVisualStyleBackColor = true;
            this.clearTargetProductButton.Click += new System.EventHandler(this.clearTargetProductButton_Click);
            // 
            // selectTargetProductButton
            // 
            this.selectTargetProductButton.Location = new System.Drawing.Point(214, 27);
            this.selectTargetProductButton.Name = "selectTargetProductButton";
            this.selectTargetProductButton.Size = new System.Drawing.Size(75, 23);
            this.selectTargetProductButton.TabIndex = 12;
            this.selectTargetProductButton.Text = "ระบุ...";
            this.selectTargetProductButton.UseVisualStyleBackColor = true;
            this.selectTargetProductButton.Click += new System.EventHandler(this.selectTargetProductButton_Click);
            // 
            // targetProductLimitQtyNumeric
            // 
            this.targetProductLimitQtyNumeric.Location = new System.Drawing.Point(76, 85);
            this.targetProductLimitQtyNumeric.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.targetProductLimitQtyNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.targetProductLimitQtyNumeric.Name = "targetProductLimitQtyNumeric";
            this.targetProductLimitQtyNumeric.Size = new System.Drawing.Size(75, 23);
            this.targetProductLimitQtyNumeric.TabIndex = 11;
            this.targetProductLimitQtyNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.targetProductLimitQtyNumeric.ThousandsSeparator = true;
            this.targetProductLimitQtyNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // targetProductLimitQtyLabel
            // 
            this.targetProductLimitQtyLabel.AutoSize = true;
            this.targetProductLimitQtyLabel.Location = new System.Drawing.Point(8, 87);
            this.targetProductLimitQtyLabel.Name = "targetProductLimitQtyLabel";
            this.targetProductLimitQtyLabel.Size = new System.Drawing.Size(64, 15);
            this.targetProductLimitQtyLabel.TabIndex = 10;
            this.targetProductLimitQtyLabel.Text = "จำนวนสูงสุด:";
            this.targetProductLimitQtyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // targetProductTitleTextBox
            // 
            this.targetProductTitleTextBox.Location = new System.Drawing.Point(76, 56);
            this.targetProductTitleTextBox.MaxLength = 128;
            this.targetProductTitleTextBox.Name = "targetProductTitleTextBox";
            this.targetProductTitleTextBox.Size = new System.Drawing.Size(213, 23);
            this.targetProductTitleTextBox.TabIndex = 7;
            // 
            // targetProductTitleLabel
            // 
            this.targetProductTitleLabel.AutoSize = true;
            this.targetProductTitleLabel.Location = new System.Drawing.Point(47, 59);
            this.targetProductTitleLabel.Name = "targetProductTitleLabel";
            this.targetProductTitleLabel.Size = new System.Drawing.Size(23, 15);
            this.targetProductTitleLabel.TabIndex = 6;
            this.targetProductTitleLabel.Text = "ชื่อ:";
            // 
            // targetProductSkuTextBox
            // 
            this.targetProductSkuTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.targetProductSkuTextBox.Location = new System.Drawing.Point(76, 27);
            this.targetProductSkuTextBox.MaxLength = 64;
            this.targetProductSkuTextBox.Name = "targetProductSkuTextBox";
            this.targetProductSkuTextBox.ReadOnly = true;
            this.targetProductSkuTextBox.Size = new System.Drawing.Size(132, 23);
            this.targetProductSkuTextBox.TabIndex = 5;
            // 
            // targetProductSkuLabel
            // 
            this.targetProductSkuLabel.AutoSize = true;
            this.targetProductSkuLabel.Location = new System.Drawing.Point(42, 30);
            this.targetProductSkuLabel.Name = "targetProductSkuLabel";
            this.targetProductSkuLabel.Size = new System.Drawing.Size(28, 15);
            this.targetProductSkuLabel.TabIndex = 4;
            this.targetProductSkuLabel.Text = "รหัส:";
            // 
            // paywithGroupBox
            // 
            this.paywithGroupBox.Controls.Add(this.paywithComboBox);
            this.paywithGroupBox.Controls.Add(this.paywhitLabel);
            this.paywithGroupBox.Location = new System.Drawing.Point(347, 168);
            this.paywithGroupBox.Name = "paywithGroupBox";
            this.paywithGroupBox.Size = new System.Drawing.Size(320, 70);
            this.paywithGroupBox.TabIndex = 9;
            this.paywithGroupBox.TabStop = false;
            this.paywithGroupBox.Text = "ลดเมื่อขำระผ่านช่องทาง";
            // 
            // paywithComboBox
            // 
            this.paywithComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paywithComboBox.FormattingEnabled = true;
            this.paywithComboBox.Location = new System.Drawing.Point(76, 31);
            this.paywithComboBox.Name = "paywithComboBox";
            this.paywithComboBox.Size = new System.Drawing.Size(153, 23);
            this.paywithComboBox.TabIndex = 12;
            // 
            // paywhitLabel
            // 
            this.paywhitLabel.AutoSize = true;
            this.paywhitLabel.Location = new System.Drawing.Point(25, 34);
            this.paywhitLabel.Name = "paywhitLabel";
            this.paywhitLabel.Size = new System.Drawing.Size(45, 15);
            this.paywhitLabel.TabIndex = 11;
            this.paywhitLabel.Text = "จ่ายด้วย:";
            this.paywhitLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bundleGroupBox
            // 
            this.bundleGroupBox.Controls.Add(this.addBundleButton);
            this.bundleGroupBox.Controls.Add(this.attachProductGridView);
            this.bundleGroupBox.Location = new System.Drawing.Point(347, 244);
            this.bundleGroupBox.Name = "bundleGroupBox";
            this.bundleGroupBox.Size = new System.Drawing.Size(320, 169);
            this.bundleGroupBox.TabIndex = 10;
            this.bundleGroupBox.TabStop = false;
            this.bundleGroupBox.Text = "การพ่วงสินค้า";
            // 
            // addBundleButton
            // 
            this.addBundleButton.Location = new System.Drawing.Point(11, 22);
            this.addBundleButton.Name = "addBundleButton";
            this.addBundleButton.Size = new System.Drawing.Size(73, 23);
            this.addBundleButton.TabIndex = 13;
            this.addBundleButton.Text = "ระบุ...";
            this.addBundleButton.UseVisualStyleBackColor = true;
            this.addBundleButton.Click += new System.EventHandler(this.addBundleButton_Click);
            // 
            // attachProductGridView
            // 
            this.attachProductGridView.AllowUserToAddRows = false;
            this.attachProductGridView.AllowUserToDeleteRows = false;
            this.attachProductGridView.AllowUserToResizeRows = false;
            this.attachProductGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.attachProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attachProductGridView.Location = new System.Drawing.Point(11, 50);
            this.attachProductGridView.Margin = new System.Windows.Forms.Padding(2);
            this.attachProductGridView.Name = "attachProductGridView";
            this.attachProductGridView.ReadOnly = true;
            this.attachProductGridView.RowHeadersVisible = false;
            this.attachProductGridView.RowHeadersWidth = 32;
            this.attachProductGridView.RowTemplate.Height = 30;
            this.attachProductGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.attachProductGridView.Size = new System.Drawing.Size(300, 113);
            this.attachProductGridView.TabIndex = 2;
            this.attachProductGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.attachProductGridView_CellContentClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(589, 427);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "ยกเลิก";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.Location = new System.Drawing.Point(503, 427);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(80, 23);
            this.createButton.TabIndex = 11;
            this.createButton.Text = "สร้าง";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // AddPromotionForm
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(681, 462);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.bundleGroupBox);
            this.Controls.Add(this.paywithGroupBox);
            this.Controls.Add(this.targetProductGroupBox);
            this.Controls.Add(this.discountGroupBox);
            this.Controls.Add(this.effectiveGroupBox);
            this.Controls.Add(this.generalGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddPromotionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "สร้างโปรโมชั่น";
            this.Load += new System.EventHandler(this.AddPromotionForm_Load);
            this.effectiveGroupBox.ResumeLayout(false);
            this.effectiveGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percentDcNumeric)).EndInit();
            this.generalGroupBox.ResumeLayout(false);
            this.generalGroupBox.PerformLayout();
            this.discountGroupBox.ResumeLayout(false);
            this.discountGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxDcNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueDcNumeric)).EndInit();
            this.targetProductGroupBox.ResumeLayout(false);
            this.targetProductGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetProductLimitQtyNumeric)).EndInit();
            this.paywithGroupBox.ResumeLayout(false);
            this.paywithGroupBox.PerformLayout();
            this.bundleGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.attachProductGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox effectiveGroupBox;
        private System.Windows.Forms.Label expireDateTimeLabel;
        private System.Windows.Forms.Label effectiveDateTimeLabel;
        private System.Windows.Forms.DateTimePicker expireDateTimePicker;
        private System.Windows.Forms.DateTimePicker effectiveDateTimePicker;
        private System.Windows.Forms.Label percentDcLabel;
        private System.Windows.Forms.NumericUpDown percentDcNumeric;
        private System.Windows.Forms.GroupBox generalGroupBox;
        private System.Windows.Forms.TextBox detailTextBox;
        private System.Windows.Forms.Label detailLabel;
        private System.Windows.Forms.CheckBox inactiveCheckBox;
        private System.Windows.Forms.CheckBox serviceChargeEffectCheckBox;
        private System.Windows.Forms.CheckBox promoEffectCheckBox;
        private System.Windows.Forms.CheckBox salableCheckBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.GroupBox discountGroupBox;
        private System.Windows.Forms.Label maxDcRemarkLabel;
        private System.Windows.Forms.NumericUpDown maxDcNumeric;
        private System.Windows.Forms.Label maxDcLabel;
        private System.Windows.Forms.NumericUpDown valueDcNumeric;
        private System.Windows.Forms.Label valueDcLabel;
        private System.Windows.Forms.GroupBox targetProductGroupBox;
        private System.Windows.Forms.Button clearTargetProductButton;
        private System.Windows.Forms.Button selectTargetProductButton;
        private System.Windows.Forms.NumericUpDown targetProductLimitQtyNumeric;
        private System.Windows.Forms.Label targetProductLimitQtyLabel;
        private System.Windows.Forms.TextBox targetProductTitleTextBox;
        private System.Windows.Forms.Label targetProductTitleLabel;
        private System.Windows.Forms.TextBox targetProductSkuTextBox;
        private System.Windows.Forms.Label targetProductSkuLabel;
        private System.Windows.Forms.GroupBox paywithGroupBox;
        private System.Windows.Forms.ComboBox paywithComboBox;
        private System.Windows.Forms.Label paywhitLabel;
        private System.Windows.Forms.GroupBox bundleGroupBox;
        private System.Windows.Forms.Button addBundleButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.DataGridView attachProductGridView;
    }
}