using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class PromotionAttachment
    {
        public int Id { get; set; }
        public int PromotionId { get; set; }
        public int ProductId { get; set; }
        public int ProductQty { get; set; }
        public bool IsRedeemLater { get; set; }
    }
}
