using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiblePOS.Backoffice.Models.Reports
{
    public class ReceiptDetailInfo
    {
        public DateTime EntryDate { get; set; }
        public string Invoice { get; set; }
        public string ProductSku { get; set; }
        public string ProductName { get; set; }
        public string CustomerName { get; set; }
        public string ZoneName { get; set; }
        public int Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public string Seller { get; set; }
        public string Station { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
