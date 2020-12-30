
namespace SensiblePOS
{
    partial class SelectPromotionForm
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
            this.promotionDataGridView = new System.Windows.Forms.DataGridView();
            this.itemCodeTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promotionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.findPromotionTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.promotionNameLabel = new System.Windows.Forms.Label();
            this.canceButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.promotionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionInfoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // promotionDataGridView
            // 
            this.promotionDataGridView.AllowUserToAddRows = false;
            this.promotionDataGridView.AllowUserToDeleteRows = false;
            this.promotionDataGridView.AutoGenerateColumns = false;
            this.promotionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.promotionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemCodeTextBoxColumn,
            this.titleTextBoxColumn});
            this.promotionDataGridView.DataSource = this.promotionInfoBindingSource;
            this.promotionDataGridView.Location = new System.Drawing.Point(14, 16);
            this.promotionDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.promotionDataGridView.Name = "promotionDataGridView";
            this.promotionDataGridView.ReadOnly = true;
            this.promotionDataGridView.RowHeadersVisible = false;
            this.promotionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.promotionDataGridView.Size = new System.Drawing.Size(358, 308);
            this.promotionDataGridView.TabIndex = 1;
            this.promotionDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.promotionDataGridView_CellDoubleClick);
            // 
            // itemCodeTextBoxColumn
            // 
            this.itemCodeTextBoxColumn.DataPropertyName = "ItemCode";
            this.itemCodeTextBoxColumn.HeaderText = "รหัส";
            this.itemCodeTextBoxColumn.MinimumWidth = 80;
            this.itemCodeTextBoxColumn.Name = "itemCodeTextBoxColumn";
            this.itemCodeTextBoxColumn.ReadOnly = true;
            this.itemCodeTextBoxColumn.Width = 80;
            // 
            // titleTextBoxColumn
            // 
            this.titleTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleTextBoxColumn.DataPropertyName = "Title";
            this.titleTextBoxColumn.HeaderText = "ชื่อ";
            this.titleTextBoxColumn.Name = "titleTextBoxColumn";
            this.titleTextBoxColumn.ReadOnly = true;
            // 
            // promotionInfoBindingSource
            // 
            this.promotionInfoBindingSource.DataSource = typeof(SensiblePOS.Models.PromotionInfo);
            this.promotionInfoBindingSource.CurrentChanged += new System.EventHandler(this.promotionInfoBindingSource_CurrentChanged);
            // 
            // findPromotionTextBox
            // 
            this.findPromotionTextBox.Location = new System.Drawing.Point(21, 36);
            this.findPromotionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.findPromotionTextBox.Name = "findPromotionTextBox";
            this.findPromotionTextBox.Size = new System.Drawing.Size(313, 27);
            this.findPromotionTextBox.TabIndex = 4;
            this.findPromotionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.findPromotionTextBox_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.promotionNameLabel);
            this.groupBox1.Controls.Add(this.findPromotionTextBox);
            this.groupBox1.Location = new System.Drawing.Point(14, 332);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(358, 109);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ค้นหาโปรโมชั่น";
            // 
            // promotionNameLabel
            // 
            this.promotionNameLabel.Location = new System.Drawing.Point(21, 72);
            this.promotionNameLabel.Name = "promotionNameLabel";
            this.promotionNameLabel.Size = new System.Drawing.Size(114, 31);
            this.promotionNameLabel.TabIndex = 0;
            this.promotionNameLabel.Text = "[-ยังไม่ระบบ-]";
            // 
            // canceButton
            // 
            this.canceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.canceButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.canceButton.Location = new System.Drawing.Point(196, 462);
            this.canceButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.canceButton.Name = "canceButton";
            this.canceButton.Size = new System.Drawing.Size(100, 36);
            this.canceButton.TabIndex = 2;
            this.canceButton.Text = "ยกเลิก";
            this.canceButton.UseVisualStyleBackColor = true;
            this.canceButton.Click += new System.EventHandler(this.canceButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okButton.Location = new System.Drawing.Point(90, 462);
            this.okButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 36);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "ตกลง";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // SelectPromotionForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.canceButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.promotionDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectPromotionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "เลือกโปรโมชั่น";
            this.Load += new System.EventHandler(this.SelectPromotionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.promotionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionInfoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView promotionDataGridView;
        private System.Windows.Forms.TextBox findPromotionTextBox;
        private System.Windows.Forms.Button canceButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label promotionNameLabel;
        private System.Windows.Forms.BindingSource promotionInfoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCodeTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleTextBoxColumn;
    }
}