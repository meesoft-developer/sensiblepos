using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using SensiblePOS.Utilities;
namespace SensiblePOS
{
    public partial class ExtendForm : Form
    {
        public ExtendForm()
        {
            InitializeComponent();
        }

        private void ExtendForm_Load(object sender, EventArgs e)
        {
            ClearScreen();
        }

        public void UpdateCart(string title, decimal price)
        {
            lastItemNameLabel.Text = title;
            lastItemPriceLabel.Text = string.Format("{0:N2} บาท", price);
        }

        public void UpdateSummary(int totalQty, decimal totalPrice, bool clearProduct = false)
        {
            // Destruction will call when end of job.
            bool isDestruction = totalQty == 0 && totalPrice == 0;
            if (isDestruction)
            {
                ClearScreen();
            }
            else
            {
                lastItemCaptionLabel.Text = string.Format("จำนวนทั้งหมด {0:N0} ชิ้น", totalQty);
                if (clearProduct)
                {
                    lastItemNameLabel.Text = "";
                    lastItemPriceLabel.Text = "";
                }

                summaryCaptionLabel.Text = "ราคารวม";
                summaryValueLabel.Text = string.Format("{0:N2} บาท", totalPrice);
            }
        }

        public void ShowPromptpayBarcode(string id, decimal amount)
        {
            var promptpayString = PromptPayTools.GetString(id, amount);
            barcodeIdLabel.Text = string.Format("โอนไปยัง {0}", id);
            barcodePriceLabel.Text = string.Format("จำนวน {0:N2} บาท", amount);
            barcodePanel.Show();
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(promptpayString, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            barcodePictureBox.Image = qrCodeImage; 
        }

        public void CancelPromptpayBarcode()
        {
            barcodePictureBox.Image = null;
            barcodePanel.Hide();
        }

        public void ShowPaidbill(string method, decimal payment, decimal change)
        {
            lastItemNameLabel.Text = "ชำระ";
            lastItemPriceLabel.Text = string.Format("{0:N2} บาท", payment);

            if (method == "cash")
            {
                summaryCaptionLabel.Text = "เงินทอน";
                summaryValueLabel.Text = string.Format("{0:N2} บาท", change);
                //summaryCaptionLabel.Invoke(new EventHandler(delegate
                //{
                    
                //}));
                
                //summaryValueLabel.Invoke(new EventHandler(delegate
                //{
                    
                //}));
            }
            else
            {
                summaryCaptionLabel.Text = "ชำระแล้ว";
                summaryValueLabel.Text = method;
            }

            barcodePictureBox.Image = null;
            barcodePanel.Hide();
        }

        void ClearScreen()
        {
            lastItemCaptionLabel.Text = "รายการสินค้า";
            lastItemNameLabel.Text = "";
            lastItemPriceLabel.Text = "";
            summaryCaptionLabel.Text = "ราคารวม";
            summaryValueLabel.Text = "";

            barcodePictureBox.Image = null;
            barcodePanel.Hide();
        }
    }
}
