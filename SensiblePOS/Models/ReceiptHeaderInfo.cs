using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiblePOS.Models
{
    public class ReceiptHeaderInfo
    {
        public string SerialNumber { get; set; }
        public DateTime EntryDate { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Vat { get; set; }
        public string VatType { get; set; }
        public decimal Total { get; set; }
        public decimal Payment { get; set; }
        public decimal Change { get; set; }
        public string Seller { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerIdCard { get; set; }
        public string CustomerTAX { get; set; }
        public string CustomerTAXAddress { get; set; }
        public string PaymentType { get; set; }
        public string CardIssuer { get; set; }
        public string Remarks { get; set; }
        public bool IsVoid { get; set; }
        public string Station { get; set; } 
        public long QueueNumber { get; set; }
        public string Admin { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
