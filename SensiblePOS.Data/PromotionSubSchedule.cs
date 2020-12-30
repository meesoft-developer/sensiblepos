using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class PromotionSubSchedule
    {
        public int Id { get; set; }
        public int PromotionId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
