using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class PromotionZone
    {
        public int Id { get; set; }
        public int PromotionId { get; set; }
        public int ZoneId { get; set; }
        public string Remarks { get; set; }
    }
}
