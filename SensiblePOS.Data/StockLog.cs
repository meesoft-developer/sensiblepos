using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class StockLog
    {
        public int Id { get; set; }
        public DateTime EntryDate { get; set; }
        public int ProductId { get; set; }
        public string Sku { get; set; }
        public string Action { get; set; }
        public int Qty { get; set; }
        public int AdjustQty { get; set; }
        public string StockKey { get; set; }
        public string Remarks { get; set; }
    }
}
