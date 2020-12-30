
namespace SensiblePOS
{
    partial class ExtendForm
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
            this.upperPanel = new System.Windows.Forms.Panel();
            this.lastItemPanel = new System.Windows.Forms.Panel();
            this.lastItemPriceLabel = new System.Windows.Forms.Label();
            this.lastItemCaptionLabel = new System.Windows.Forms.Label();
            this.lastItemNameLabel = new System.Windows.Forms.Label();
            this.summaryPanel = new System.Windows.Forms.Panel();
            this.summaryValueLabel = new System.Windows.Forms.Label();
            this.summaryCaptionLabel = new System.Windows.Forms.Label();
            this.barcodePictureBox = new System.Windows.Forms.PictureBox();
            this.barcodePanel = new System.Windows.Forms.Panel();
            this.barcodePriceLabel = new System.Windows.Forms.Label();
            this.barcodeIdLabel = new System.Windows.Forms.Label();
            this.upperPanel.SuspendLayout();
            this.lastItemPanel.SuspendLayout();
            this.summaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodePictureBox)).BeginInit();
            this.barcodePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // upperPanel
            // 
            this.upperPanel.Controls.Add(this.lastItemPanel);
            this.upperPanel.Controls.Add(this.summaryPanel);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(800, 132);
            this.upperPanel.TabIndex = 0;
            // 
            // lastItemPanel
            // 
            this.lastItemPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lastItemPanel.Controls.Add(this.lastItemPriceLabel);
            this.lastItemPanel.Controls.Add(this.lastItemCaptionLabel);
            this.lastItemPanel.Controls.Add(this.lastItemNameLabel);
            this.lastItemPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastItemPanel.Location = new System.Drawing.Point(0, 0);
            this.lastItemPanel.Name = "lastItemPanel";
            this.lastItemPanel.Size = new System.Drawing.Size(454, 132);
            this.lastItemPanel.TabIndex = 5;
            // 
            // lastItemPriceLabel
            // 
            this.lastItemPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lastItemPriceLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastItemPriceLabel.Location = new System.Drawing.Point(286, 76);
            this.lastItemPriceLabel.Name = "lastItemPriceLabel";
            this.lastItemPriceLabel.Size = new System.Drawing.Size(162, 39);
            this.lastItemPriceLabel.TabIndex = 4;
            this.lastItemPriceLabel.Text = "[บาท]";
            this.lastItemPriceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lastItemCaptionLabel
            // 
            this.lastItemCaptionLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastItemCaptionLabel.Location = new System.Drawing.Point(12, 9);
            this.lastItemCaptionLabel.Name = "lastItemCaptionLabel";
            this.lastItemCaptionLabel.Size = new System.Drawing.Size(314, 39);
            this.lastItemCaptionLabel.TabIndex = 2;
            this.lastItemCaptionLabel.Text = "รายการ";
            // 
            // lastItemNameLabel
            // 
            this.lastItemNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastItemNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastItemNameLabel.Location = new System.Drawing.Point(12, 76);
            this.lastItemNameLabel.Name = "lastItemNameLabel";
            this.lastItemNameLabel.Size = new System.Drawing.Size(268, 39);
            this.lastItemNameLabel.TabIndex = 3;
            this.lastItemNameLabel.Text = "[รายการ]";
            // 
            // summaryPanel
            // 
            this.summaryPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.summaryPanel.Controls.Add(this.summaryValueLabel);
            this.summaryPanel.Controls.Add(this.summaryCaptionLabel);
            this.summaryPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.summaryPanel.Location = new System.Drawing.Point(454, 0);
            this.summaryPanel.Name = "summaryPanel";
            this.summaryPanel.Size = new System.Drawing.Size(346, 132);
            this.summaryPanel.TabIndex = 0;
            // 
            // summaryValueLabel
            // 
            this.summaryValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.summaryValueLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.summaryValueLabel.Location = new System.Drawing.Point(20, 70);
            this.summaryValueLabel.Name = "summaryValueLabel";
            this.summaryValueLabel.Size = new System.Drawing.Size(302, 48);
            this.summaryValueLabel.TabIndex = 1;
            this.summaryValueLabel.Text = "[ราคารวม]";
            this.summaryValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // summaryCaptionLabel
            // 
            this.summaryCaptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.summaryCaptionLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.summaryCaptionLabel.Location = new System.Drawing.Point(20, 9);
            this.summaryCaptionLabel.Name = "summaryCaptionLabel";
            this.summaryCaptionLabel.Size = new System.Drawing.Size(302, 39);
            this.summaryCaptionLabel.TabIndex = 0;
            this.summaryCaptionLabel.Text = "ราคารวม";
            this.summaryCaptionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // barcodePictureBox
            // 
            this.barcodePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.barcodePictureBox.Location = new System.Drawing.Point(18, 48);
            this.barcodePictureBox.Name = "barcodePictureBox";
            this.barcodePictureBox.Size = new System.Drawing.Size(300, 300);
            this.barcodePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barcodePictureBox.TabIndex = 1;
            this.barcodePictureBox.TabStop = false;
            // 
            // barcodePanel
            // 
            this.barcodePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.barcodePanel.Controls.Add(this.barcodePriceLabel);
            this.barcodePanel.Controls.Add(this.barcodeIdLabel);
            this.barcodePanel.Controls.Add(this.barcodePictureBox);
            this.barcodePanel.Location = new System.Drawing.Point(233, 176);
            this.barcodePanel.Name = "barcodePanel";
            this.barcodePanel.Size = new System.Drawing.Size(336, 412);
            this.barcodePanel.TabIndex = 2;
            // 
            // barcodePriceLabel
            // 
            this.barcodePriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barcodePriceLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barcodePriceLabel.Location = new System.Drawing.Point(18, 351);
            this.barcodePriceLabel.Name = "barcodePriceLabel";
            this.barcodePriceLabel.Size = new System.Drawing.Size(300, 42);
            this.barcodePriceLabel.TabIndex = 5;
            this.barcodePriceLabel.Text = "[ราคา]";
            this.barcodePriceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // barcodeIdLabel
            // 
            this.barcodeIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barcodeIdLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barcodeIdLabel.Location = new System.Drawing.Point(18, 6);
            this.barcodeIdLabel.Name = "barcodeIdLabel";
            this.barcodeIdLabel.Size = new System.Drawing.Size(300, 39);
            this.barcodeIdLabel.TabIndex = 4;
            this.barcodeIdLabel.Text = "[หมายเลข]";
            this.barcodeIdLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ExtendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.barcodePanel);
            this.Controls.Add(this.upperPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExtendForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ExternalForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExtendForm_Load);
            this.upperPanel.ResumeLayout(false);
            this.lastItemPanel.ResumeLayout(false);
            this.summaryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barcodePictureBox)).EndInit();
            this.barcodePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.Panel lastItemPanel;
        private System.Windows.Forms.Label lastItemPriceLabel;
        private System.Windows.Forms.Label lastItemCaptionLabel;
        private System.Windows.Forms.Label lastItemNameLabel;
        private System.Windows.Forms.Panel summaryPanel;
        private System.Windows.Forms.Label summaryValueLabel;
        private System.Windows.Forms.Label summaryCaptionLabel;
        private System.Windows.Forms.PictureBox barcodePictureBox;
        private System.Windows.Forms.Panel barcodePanel;
        private System.Windows.Forms.Label barcodePriceLabel;
        private System.Windows.Forms.Label barcodeIdLabel;
    }
}