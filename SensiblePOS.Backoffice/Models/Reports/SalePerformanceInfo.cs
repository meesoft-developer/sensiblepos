using System;

namespace SensiblePOS.Backoffice.Models.Reports
{
    public class SalePerformanceInfo
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Seller { get; set; }
        public string ZoneName { get; set; }
        public decimal Total { get; set; }
        public int Qty { get; set; }
    }
}
