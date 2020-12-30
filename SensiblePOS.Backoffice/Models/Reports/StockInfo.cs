using System;

namespace SensiblePOS.Backoffice.Models.Reports
{
    public class StockInfo
    {
        public string ZoneName { get; set; }
        public string ProductName { get; set; }
        public string ProductSKU { get; set; }
        public int Qty { get; set; }
        public int LastQty { get; set; }
        public int MainQty { get; set; }
        public string Category { get; set; }
        public DateTime Update { get; set; }
    }
}
