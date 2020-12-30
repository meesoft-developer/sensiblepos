using System;

namespace SensiblePOS.Backoffice.Models
{
    public class ProductZoneInfo
    {
        public int Id { get; set; }
        public int ZoneId { get; set; }
        public int ProductId { get; set; }
        public string ZoneName { get; set; }
        public string Category { get; set; }
        public int Qty { get; set; }
        public int LastQty { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool TagRequire { get; set; }
    }
}
