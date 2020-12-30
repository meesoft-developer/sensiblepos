using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class ReceiptDetail
    {
        public long Id { get; set; }
        public string SerialNumber { get; set; }
        public int OrderIndex { get; set; }
        public string Sku { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public int PromotionId { get; set; }
        public bool IsDiscount { get; set; }
        public bool StockUpdated { get; set; }
        public string Remarks { get; set; }
    }
}
