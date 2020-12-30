using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class PromotionCondition
    {
        public int Id { get; set; }
        public int PromotionId { get; set; }
        public string Condition { get; set; }
        public int TargetId { get; set; }
        public decimal Qty { get; set; }
        public string Remarks { get; set; }
    }
}
