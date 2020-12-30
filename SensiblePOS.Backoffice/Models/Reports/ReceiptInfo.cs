using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiblePOS.Backoffice.Models.Reports
{
    public class ReceiptInfo
    {
        public DateTime EntryDate { get; set; }
        public string Invoice { get; set; } 
        public string CustomerName { get; set; }
        public string ZoneName { get; set; }
        public string PaymentType { get; set; }
        public string Issuer { get; set; } 
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public string VatType { get; set; }
        public decimal ExcludeVat { get; set; }
        public decimal Vat { get; set; }
        public string Seller { get; set; }
        public string Station { get; set; }
        public bool IsVoid { get; set; }
        public string VoidAdmin { get; set; }
        public string Remarks { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
