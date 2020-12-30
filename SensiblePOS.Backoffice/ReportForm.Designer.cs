
namespace SensiblePOS.Backoffice
{
    partial class ReportForm
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
            this.reportNameComboBox = new System.Windows.Forms.ComboBox();
            this.reportNameLabel = new System.Windows.Forms.Label();
            this.zoneComboBox = new System.Windows.Forms.ComboBox();
            this.zoneLabel = new System.Windows.Forms.Label();
            this.toDateLabel = new System.Windows.Forms.Label();
            this.fromDateLabel = new System.Windows.Forms.Label();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sellerComboBox = new System.Windows.Forms.ComboBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.keywordTextBox = new System.Windows.Forms.TextBox();
            this.keywordLabel = new System.Windows.Forms.Label();
            this.summaryTextBox = new System.Windows.Forms.TextBox();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.reportGridView = new System.Windows.Forms.DataGridView();
            this.summaryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // reportNameComboBox
            // 
            this.reportNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportNameComboBox.FormattingEnabled = true;
            this.reportNameComboBox.Location = new System.Drawing.Point(73, 12);
            this.reportNameComboBox.Name = "reportNameComboBox";
            this.reportNameComboBox.Size = new System.Drawing.Size(158, 23);
            this.reportNameComboBox.TabIndex = 21;
            // 
            // reportNameLabel
            // 
            this.reportNameLabel.AutoSize = true;
            this.reportNameLabel.Location = new System.Drawing.Point(23, 15);
            this.reportNameLabel.Name = "reportNameLabel";
            this.reportNameLabel.Size = new System.Drawing.Size(43, 15);
            this.reportNameLabel.TabIndex = 20;
            this.reportNameLabel.Text = "รายงาน:";
            // 
            // zoneComboBox
            // 
            this.zoneComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zoneComboBox.FormattingEnabled = true;
            this.zoneComboBox.Location = new System.Drawing.Point(73, 70);
            this.zoneComboBox.Name = "zoneComboBox";
            this.zoneComboBox.Size = new System.Drawing.Size(110, 23);
            this.zoneComboBox.TabIndex = 23;
            // 
            // zoneLabel
            // 
            this.zoneLabel.AutoSize = true;
            this.zoneLabel.Location = new System.Drawing.Point(37, 73);
            this.zoneLabel.Name = "zoneLabel";
            this.zoneLabel.Size = new System.Drawing.Size(29, 15);
            this.zoneLabel.TabIndex = 22;
            this.zoneLabel.Text = "โซน:";
            // 
            // toDateLabel
            // 
            this.toDateLabel.AutoSize = true;
            this.toDateLabel.Location = new System.Drawing.Point(195, 45);
            this.toDateLabel.Name = "toDateLabel";
            this.toDateLabel.Size = new System.Drawing.Size(36, 15);
            this.toDateLabel.TabIndex = 27;
            this.toDateLabel.Text = "สิ้นสุด:";
            this.toDateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fromDateLabel
            // 
            this.fromDateLabel.AutoSize = true;
            this.fromDateLabel.Location = new System.Drawing.Point(42, 45);
            this.fromDateLabel.Name = "fromDateLabel";
            this.fromDateLabel.Size = new System.Drawing.Size(25, 15);
            this.fromDateLabel.TabIndex = 26;
            this.fromDateLabel.Text = "เริ่ม:";
            this.fromDateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(237, 41);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(110, 23);
            this.toDateTimePicker.TabIndex = 25;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(73, 41);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(110, 23);
            this.fromDateTimePicker.TabIndex = 24;
            // 
            // sellerComboBox
            // 
            this.sellerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sellerComboBox.FormattingEnabled = true;
            this.sellerComboBox.Location = new System.Drawing.Point(237, 70);
            this.sellerComboBox.Name = "sellerComboBox";
            this.sellerComboBox.Size = new System.Drawing.Size(110, 23);
            this.sellerComboBox.TabIndex = 29;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(201, 73);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(30, 15);
            this.userLabel.TabIndex = 28;
            this.userLabel.Text = "จนท:";
            // 
            // keywordTextBox
            // 
            this.keywordTextBox.Location = new System.Drawing.Point(73, 99);
            this.keywordTextBox.MaxLength = 64;
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.Size = new System.Drawing.Size(158, 23);
            this.keywordTextBox.TabIndex = 31;
            // 
            // keywordLabel
            // 
            this.keywordLabel.AutoSize = true;
            this.keywordLabel.Location = new System.Drawing.Point(36, 102);
            this.keywordLabel.Name = "keywordLabel";
            this.keywordLabel.Size = new System.Drawing.Size(36, 15);
            this.keywordLabel.TabIndex = 30;
            this.keywordLabel.Text = "คำค้น:";
            // 
            // summaryTextBox
            // 
            this.summaryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.summaryTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.summaryTextBox.Location = new System.Drawing.Point(11, 22);
            this.summaryTextBox.MaxLength = 10000;
            this.summaryTextBox.Multiline = true;
            this.summaryTextBox.Name = "summaryTextBox";
            this.summaryTextBox.ReadOnly = true;
            this.summaryTextBox.Size = new System.Drawing.Size(521, 53);
            this.summaryTextBox.TabIndex = 32;
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.Controls.Add(this.saveButton);
            this.summaryGroupBox.Controls.Add(this.summaryTextBox);
            this.summaryGroupBox.Location = new System.Drawing.Point(12, 128);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Size = new System.Drawing.Size(960, 89);
            this.summaryGroupBox.TabIndex = 33;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "ผลสรุป";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(548, 44);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 29);
            this.saveButton.TabIndex = 35;
            this.saveButton.Text = "บันทึกลงไฟล์...";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(379, 94);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(123, 31);
            this.generateReportButton.TabIndex = 34;
            this.generateReportButton.Text = "สร้างรายงาน";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // reportGridView
            // 
            this.reportGridView.AllowUserToAddRows = false;
            this.reportGridView.AllowUserToDeleteRows = false;
            this.reportGridView.AllowUserToResizeRows = false;
            this.reportGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportGridView.Location = new System.Drawing.Point(12, 222);
            this.reportGridView.Margin = new System.Windows.Forms.Padding(2);
            this.reportGridView.Name = "reportGridView";
            this.reportGridView.ReadOnly = true;
            this.reportGridView.RowHeadersVisible = false;
            this.reportGridView.RowHeadersWidth = 32;
            this.reportGridView.RowTemplate.Height = 30;
            this.reportGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportGridView.Size = new System.Drawing.Size(960, 428);
            this.reportGridView.TabIndex = 35;
            // 
            // ReportForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.reportGridView);
            this.Controls.Add(this.generateReportButton);
            this.Controls.Add(this.summaryGroupBox);
            this.Controls.Add(this.keywordTextBox);
            this.Controls.Add(this.keywordLabel);
            this.Controls.Add(this.sellerComboBox);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.toDateLabel);
            this.Controls.Add(this.fromDateLabel);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.zoneComboBox);
            this.Controls.Add(this.zoneLabel);
            this.Controls.Add(this.reportNameComboBox);
            this.Controls.Add(this.reportNameLabel);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "รายงาน";
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox reportNameComboBox;
        private System.Windows.Forms.Label reportNameLabel;
        private System.Windows.Forms.ComboBox zoneComboBox;
        private System.Windows.Forms.Label zoneLabel;
        private System.Windows.Forms.Label toDateLabel;
        private System.Windows.Forms.Label fromDateLabel;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.ComboBox sellerComboBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox keywordTextBox;
        private System.Windows.Forms.Label keywordLabel;
        private System.Windows.Forms.TextBox summaryTextBox;
        private System.Windows.Forms.GroupBox summaryGroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.DataGridView reportGridView;
    }
}