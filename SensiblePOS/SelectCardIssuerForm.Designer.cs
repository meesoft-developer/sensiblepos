
namespace SensiblePOS
{
    partial class SelectCardIssuerForm
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
            this.canceButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectableItemInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectableItemInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // canceButton
            // 
            this.canceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.canceButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.canceButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.canceButton.Location = new System.Drawing.Point(252, 363);
            this.canceButton.Name = "canceButton";
            this.canceButton.Size = new System.Drawing.Size(100, 36);
            this.canceButton.TabIndex = 2;
            this.canceButton.Text = "ยกเลิก";
            this.canceButton.UseVisualStyleBackColor = true;
            this.canceButton.Click += new System.EventHandler(this.canceButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.okButton.Location = new System.Drawing.Point(146, 363);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 36);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "ตกลง";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.AllowUserToAddRows = false;
            this.itemDataGridView.AllowUserToDeleteRows = false;
            this.itemDataGridView.AutoGenerateColumns = false;
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.itemDataGridView.DataSource = this.selectableItemInfoBindingSource;
            this.itemDataGridView.Location = new System.Drawing.Point(11, 18);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.ReadOnly = true;
            this.itemDataGridView.RowHeadersVisible = false;
            this.itemDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemDataGridView.Size = new System.Drawing.Size(342, 339);
            this.itemDataGridView.TabIndex = 1;
            this.itemDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemDataGridView_CellDoubleClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "รหัส";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "ชื่อ";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // selectableItemInfoBindingSource
            // 
            this.selectableItemInfoBindingSource.DataSource = typeof(SensiblePOS.Models.SelectableItemInfo);
            // 
            // SelectCardIssuerForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.canceButton;
            this.ClientSize = new System.Drawing.Size(364, 411);
            this.Controls.Add(this.canceButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.itemDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectCardIssuerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "โปรดระบุ";
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectableItemInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button canceButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.BindingSource selectableItemInfoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}