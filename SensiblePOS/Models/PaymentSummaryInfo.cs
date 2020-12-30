using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiblePOS.Models
{
    public class PaymentSummaryInfo
    {
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public decimal Payment { get; set; }
        public decimal Change { get; set; }
        public decimal Vat { get; set; }
        public decimal VatPercent { get; set; }
        public int FineCont { get; set; } 
        public int ItemCount { get; set; }
        public int ItemQty { get; set; }
    }
}
