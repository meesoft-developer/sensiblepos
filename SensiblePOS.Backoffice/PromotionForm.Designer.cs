
namespace SensiblePOS.Backoffice
{
    partial class PromotionForm
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
            this.generalGroupBox = new System.Windows.Forms.GroupBox();
            this.targetProductTextBox = new System.Windows.Forms.TextBox();
            this.targetProductLabel = new System.Windows.Forms.Label();
            this.inactiveCheckBox = new System.Windows.Forms.CheckBox();
            this.showInListCheckBox = new System.Windows.Forms.CheckBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.listPanel = new System.Windows.Forms.Panel();
            this.addPromotionnButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.keywordTextBox = new System.Windows.Forms.TextBox();
            this.promotionGridView = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.promotionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discountGroupBox = new System.Windows.Forms.GroupBox();
            this.maximunTextBox = new System.Windows.Forms.TextBox();
            this.maximumLabel = new System.Windows.Forms.Label();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.percentTextBox = new System.Windows.Forms.TextBox();
            this.percentLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.expireTextBox = new System.Windows.Forms.TextBox();
            this.expireLabel = new System.Windows.Forms.Label();
            this.effectiveTextBox = new System.Windows.Forms.TextBox();
            this.effectiveLabel = new System.Windows.Forms.Label();
            this.attachmentGridView = new System.Windows.Forms.DataGridView();
            this.conditionGroupBox = new System.Windows.Forms.GroupBox();
            this.conditionGridView = new System.Windows.Forms.DataGridView();
            this.attachmentGroupBox = new System.Windows.Forms.GroupBox();
            this.generalGroupBox.SuspendLayout();
            this.listPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.promotionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionBindingSource)).BeginInit();
            this.discountGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentGridView)).BeginInit();
            this.conditionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conditionGridView)).BeginInit();
            this.attachmentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // generalGroupBox
            // 
            this.generalGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalGroupBox.Controls.Add(this.targetProductTextBox);
            this.generalGroupBox.Controls.Add(this.targetProductLabel);
            this.generalGroupBox.Controls.Add(this.inactiveCheckBox);
            this.generalGroupBox.Controls.Add(this.showInListCheckBox);
            this.generalGroupBox.Controls.Add(this.descriptionTextBox);
            this.generalGroupBox.Controls.Add(this.descriptionLabel);
            this.generalGroupBox.Controls.Add(this.titleTextBox);
            this.generalGroupBox.Controls.Add(this.titleLabel);
            this.generalGroupBox.Controls.Add(this.codeTextBox);
            this.generalGroupBox.Controls.Add(this.codeLabel);
            this.generalGroupBox.Location = new System.Drawing.Point(312, 12);
            this.generalGroupBox.Name = "generalGroupBox";
            this.generalGroupBox.Size = new System.Drawing.Size(660, 155);
            this.generalGroupBox.TabIndex = 4;
            this.generalGroupBox.TabStop = false;
            this.generalGroupBox.Text = "ข้อมูลทั่วไป";
            // 
            // targetProductTextBox
            // 
            this.targetProductTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.targetProductTextBox.Location = new System.Drawing.Point(351, 120);
            this.targetProductTextBox.MaxLength = 64;
            this.targetProductTextBox.Name = "targetProductTextBox";
            this.targetProductTextBox.ReadOnly = true;
            this.targetProductTextBox.Size = new System.Drawing.Size(293, 23);
            this.targetProductTextBox.TabIndex = 5;
            // 
            // targetProductLabel
            // 
            this.targetProductLabel.AutoSize = true;
            this.targetProductLabel.Location = new System.Drawing.Point(351, 102);
            this.targetProductLabel.Name = "targetProductLabel";
            this.targetProductLabel.Size = new System.Drawing.Size(91, 15);
            this.targetProductLabel.TabIndex = 4;
            this.targetProductLabel.Text = "เจาะจงเฉพาะสินค้า:";
            // 
            // inactiveCheckBox
            // 
            this.inactiveCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inactiveCheckBox.AutoSize = true;
            this.inactiveCheckBox.Location = new System.Drawing.Point(512, 47);
            this.inactiveCheckBox.Name = "inactiveCheckBox";
            this.inactiveCheckBox.Size = new System.Drawing.Size(74, 19);
            this.inactiveCheckBox.TabIndex = 9;
            this.inactiveCheckBox.Text = "ระงับใช้งาน";
            this.inactiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // showInListCheckBox
            // 
            this.showInListCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showInListCheckBox.AutoSize = true;
            this.showInListCheckBox.Location = new System.Drawing.Point(512, 22);
            this.showInListCheckBox.Name = "showInListCheckBox";
            this.showInListCheckBox.Size = new System.Drawing.Size(93, 19);
            this.showInListCheckBox.TabIndex = 6;
            this.showInListCheckBox.Text = "แสดงในรายการ";
            this.showInListCheckBox.UseVisualStyleBackColor = true;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(64, 88);
            this.descriptionTextBox.MaxLength = 250;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(272, 55);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(6, 91);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(52, 15);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "หมายเหตุ:";
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
            // codeTextBox
            // 
            this.codeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.codeTextBox.Location = new System.Drawing.Point(64, 30);
            this.codeTextBox.MaxLength = 64;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.Size = new System.Drawing.Size(180, 23);
            this.codeTextBox.TabIndex = 1;
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(27, 33);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(28, 15);
            this.codeLabel.TabIndex = 0;
            this.codeLabel.Text = "รหัส:";
            // 
            // listPanel
            // 
            this.listPanel.Controls.Add(this.addPromotionnButton);
            this.listPanel.Controls.Add(this.searchButton);
            this.listPanel.Controls.Add(this.keywordTextBox);
            this.listPanel.Controls.Add(this.promotionGridView);
            this.listPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.listPanel.Location = new System.Drawing.Point(0, 0);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(300, 561);
            this.listPanel.TabIndex = 3;
            // 
            // addPromotionnButton
            // 
            this.addPromotionnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addPromotionnButton.Location = new System.Drawing.Point(11, 526);
            this.addPromotionnButton.Name = "addPromotionnButton";
            this.addPromotionnButton.Size = new System.Drawing.Size(32, 23);
            this.addPromotionnButton.TabIndex = 3;
            this.addPromotionnButton.Text = "+";
            this.addPromotionnButton.UseVisualStyleBackColor = true;
            this.addPromotionnButton.Click += new System.EventHandler(this.addPromotionnButton_Click);
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
            // keywordTextBox
            // 
            this.keywordTextBox.Location = new System.Drawing.Point(13, 12);
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.PlaceholderText = "ชื่อ หรือ รหัสโปรโมชั่น";
            this.keywordTextBox.Size = new System.Drawing.Size(200, 23);
            this.keywordTextBox.TabIndex = 0;
            // 
            // promotionGridView
            // 
            this.promotionGridView.AllowUserToAddRows = false;
            this.promotionGridView.AllowUserToDeleteRows = false;
            this.promotionGridView.AllowUserToResizeRows = false;
            this.promotionGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.promotionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.promotionGridView.Location = new System.Drawing.Point(11, 41);
            this.promotionGridView.Margin = new System.Windows.Forms.Padding(2);
            this.promotionGridView.Name = "promotionGridView";
            this.promotionGridView.ReadOnly = true;
            this.promotionGridView.RowHeadersVisible = false;
            this.promotionGridView.RowHeadersWidth = 32;
            this.promotionGridView.RowTemplate.Height = 30;
            this.promotionGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.promotionGridView.Size = new System.Drawing.Size(289, 480);
            this.promotionGridView.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(852, 517);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 32);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "บันทึก";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // promotionBindingSource
            // 
            this.promotionBindingSource.DataSource = typeof(SensiblePOS.Data.Promotion);
            this.promotionBindingSource.CurrentChanged += new System.EventHandler(this.promotionBindingSource_CurrentChanged);
            this.promotionBindingSource.CurrentItemChanged += new System.EventHandler(this.promotionBindingSource_CurrentItemChanged);
            // 
            // discountGroupBox
            // 
            this.discountGroupBox.Controls.Add(this.maximunTextBox);
            this.discountGroupBox.Controls.Add(this.maximumLabel);
            this.discountGroupBox.Controls.Add(this.valueTextBox);
            this.discountGroupBox.Controls.Add(this.valueLabel);
            this.discountGroupBox.Controls.Add(this.percentTextBox);
            this.discountGroupBox.Controls.Add(this.percentLabel);
            this.discountGroupBox.Location = new System.Drawing.Point(312, 173);
            this.discountGroupBox.Name = "discountGroupBox";
            this.discountGroupBox.Size = new System.Drawing.Size(260, 115);
            this.discountGroupBox.TabIndex = 6;
            this.discountGroupBox.TabStop = false;
            this.discountGroupBox.Text = "ส่วนลด";
            // 
            // maximunTextBox
            // 
            this.maximunTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.maximunTextBox.Location = new System.Drawing.Point(64, 80);
            this.maximunTextBox.MaxLength = 64;
            this.maximunTextBox.Name = "maximunTextBox";
            this.maximunTextBox.ReadOnly = true;
            this.maximunTextBox.Size = new System.Drawing.Size(123, 23);
            this.maximunTextBox.TabIndex = 7;
            // 
            // maximumLabel
            // 
            this.maximumLabel.AutoSize = true;
            this.maximumLabel.Location = new System.Drawing.Point(23, 83);
            this.maximumLabel.Name = "maximumLabel";
            this.maximumLabel.Size = new System.Drawing.Size(34, 15);
            this.maximumLabel.TabIndex = 6;
            this.maximumLabel.Text = "สูงสุด:";
            // 
            // valueTextBox
            // 
            this.valueTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.valueTextBox.Location = new System.Drawing.Point(64, 51);
            this.valueTextBox.MaxLength = 64;
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.ReadOnly = true;
            this.valueTextBox.Size = new System.Drawing.Size(123, 23);
            this.valueTextBox.TabIndex = 5;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(20, 54);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(35, 15);
            this.valueLabel.TabIndex = 4;
            this.valueLabel.Text = "มูลค่า:";
            // 
            // percentTextBox
            // 
            this.percentTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.percentTextBox.Location = new System.Drawing.Point(64, 22);
            this.percentTextBox.MaxLength = 64;
            this.percentTextBox.Name = "percentTextBox";
            this.percentTextBox.ReadOnly = true;
            this.percentTextBox.Size = new System.Drawing.Size(123, 23);
            this.percentTextBox.TabIndex = 3;
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.Location = new System.Drawing.Point(5, 25);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(50, 15);
            this.percentLabel.TabIndex = 2;
            this.percentLabel.Text = "เปอเซนต์:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.expireTextBox);
            this.groupBox2.Controls.Add(this.expireLabel);
            this.groupBox2.Controls.Add(this.effectiveTextBox);
            this.groupBox2.Controls.Add(this.effectiveLabel);
            this.groupBox2.Location = new System.Drawing.Point(578, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 113);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ระยะเวลา";
            // 
            // expireTextBox
            // 
            this.expireTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.expireTextBox.Location = new System.Drawing.Point(64, 51);
            this.expireTextBox.MaxLength = 64;
            this.expireTextBox.Name = "expireTextBox";
            this.expireTextBox.ReadOnly = true;
            this.expireTextBox.Size = new System.Drawing.Size(180, 23);
            this.expireTextBox.TabIndex = 7;
            // 
            // expireLabel
            // 
            this.expireLabel.AutoSize = true;
            this.expireLabel.Location = new System.Drawing.Point(27, 54);
            this.expireLabel.Name = "expireLabel";
            this.expireLabel.Size = new System.Drawing.Size(22, 15);
            this.expireLabel.TabIndex = 6;
            this.expireLabel.Text = "ถึง:";
            // 
            // effectiveTextBox
            // 
            this.effectiveTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.effectiveTextBox.Location = new System.Drawing.Point(64, 22);
            this.effectiveTextBox.MaxLength = 64;
            this.effectiveTextBox.Name = "effectiveTextBox";
            this.effectiveTextBox.ReadOnly = true;
            this.effectiveTextBox.Size = new System.Drawing.Size(180, 23);
            this.effectiveTextBox.TabIndex = 5;
            // 
            // effectiveLabel
            // 
            this.effectiveLabel.AutoSize = true;
            this.effectiveLabel.Location = new System.Drawing.Point(27, 25);
            this.effectiveLabel.Name = "effectiveLabel";
            this.effectiveLabel.Size = new System.Drawing.Size(25, 15);
            this.effectiveLabel.TabIndex = 4;
            this.effectiveLabel.Text = "เริ่ม:";
            // 
            // attachmentGridView
            // 
            this.attachmentGridView.Location = new System.Drawing.Point(6, 22);
            this.attachmentGridView.Name = "attachmentGridView";
            this.attachmentGridView.RowHeadersVisible = false;
            this.attachmentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.attachmentGridView.Size = new System.Drawing.Size(462, 78);
            this.attachmentGridView.TabIndex = 0;
            // 
            // conditionGroupBox
            // 
            this.conditionGroupBox.Controls.Add(this.conditionGridView);
            this.conditionGroupBox.Location = new System.Drawing.Point(312, 294);
            this.conditionGroupBox.Name = "conditionGroupBox";
            this.conditionGroupBox.Size = new System.Drawing.Size(660, 105);
            this.conditionGroupBox.TabIndex = 8;
            this.conditionGroupBox.TabStop = false;
            this.conditionGroupBox.Text = "เงือนไข";
            // 
            // conditionGridView
            // 
            this.conditionGridView.Location = new System.Drawing.Point(6, 22);
            this.conditionGridView.Name = "conditionGridView";
            this.conditionGridView.RowHeadersVisible = false;
            this.conditionGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.conditionGridView.Size = new System.Drawing.Size(462, 77);
            this.conditionGridView.TabIndex = 0;
            // 
            // attachmentGroupBox
            // 
            this.attachmentGroupBox.Controls.Add(this.attachmentGridView);
            this.attachmentGroupBox.Location = new System.Drawing.Point(312, 405);
            this.attachmentGroupBox.Name = "attachmentGroupBox";
            this.attachmentGroupBox.Size = new System.Drawing.Size(660, 106);
            this.attachmentGroupBox.TabIndex = 9;
            this.attachmentGroupBox.TabStop = false;
            this.attachmentGroupBox.Text = "สินค้าพ่วง";
            // 
            // PromotionForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.attachmentGroupBox);
            this.Controls.Add(this.conditionGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.discountGroupBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.generalGroupBox);
            this.Controls.Add(this.listPanel);
            this.Name = "PromotionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ข้อมูลโปรโมชั่น";
            this.Load += new System.EventHandler(this.PromotionForm_Load);
            this.generalGroupBox.ResumeLayout(false);
            this.generalGroupBox.PerformLayout();
            this.listPanel.ResumeLayout(false);
            this.listPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.promotionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionBindingSource)).EndInit();
            this.discountGroupBox.ResumeLayout(false);
            this.discountGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentGridView)).EndInit();
            this.conditionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.conditionGridView)).EndInit();
            this.attachmentGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox generalGroupBox;
        private System.Windows.Forms.CheckBox inactiveCheckBox;
        private System.Windows.Forms.CheckBox showInListCheckBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.Button addPromotionnButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox keywordTextBox;
        private System.Windows.Forms.DataGridView promotionGridView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.BindingSource promotionBindingSource;
        private System.Windows.Forms.GroupBox discountGroupBox;
        private System.Windows.Forms.TextBox maximunTextBox;
        private System.Windows.Forms.Label maximumLabel;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.TextBox percentTextBox;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox expireTextBox;
        private System.Windows.Forms.Label expireLabel;
        private System.Windows.Forms.TextBox effectiveTextBox;
        private System.Windows.Forms.Label effectiveLabel;
        private System.Windows.Forms.GroupBox conditionGroupBox;
        private System.Windows.Forms.TextBox targetProductTextBox;
        private System.Windows.Forms.Label targetProductLabel;
        private System.Windows.Forms.GroupBox attachmentGroupBox;
        private System.Windows.Forms.DataGridView conditionGridView;
        private System.Windows.Forms.DataGridView attachmentGridView;
    }
}