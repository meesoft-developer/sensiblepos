using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class SaleLog
    {
        public long Id { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int AccountId { get; set; }
        public decimal Cash { get; set; }
        public decimal Credit { get; set; }
        public decimal Promptpay { get; set; }
        public decimal Total { get; set; }
        public string Remarks { get; set; }
    }
}
