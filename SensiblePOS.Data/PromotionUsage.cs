using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class PromotionUsage
    {
        public int Id { get; set; }
        public int PromotionId { get; set; }
        public int CustomerId { get; set; }
        public string Invoice { get; set; }
        public decimal TotalDc { get; set; }
        public string EffectInvoice { get; set; }
        public bool IsClose { get; set; }
    }
}
