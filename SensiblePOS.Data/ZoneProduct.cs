using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class ZoneProduct
    {
        public int Id { get; set; }
        public int ZoneId { get; set; }
        public int ProductId { get; set; }
        public string Category { get; set; }
        public int Qty { get; set; }
        public int LastQty { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool Inactive { get; set; }
    }
}
