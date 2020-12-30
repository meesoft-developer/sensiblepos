using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class Receipt
    {
        public long Id { get; set; }
        public DateTime EntryDate { get; set; }
        public string SerialNumber { get; set; }
        public string CustomerCode { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Vat { get; set; }
        public string VatType { get; set; }
        public decimal VatPercent { get; set; }
        public decimal Total { get; set; }
        public decimal Payment { get; set; }
        public decimal Change { get; set; }
        public string PaymentType { get; set; }
        public int CardIssuer { get; set; }
        public long QueueNumber { get; set; }
        public int ZoneId { get; set; }
        public string StationName { get; set; }
        public string Seller { get; set; }
        public bool IsVoid { get; set; }
        public string VoidAdmin { get; set; }
        public string Remarks { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
