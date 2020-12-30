using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiblePOS.Models
{
    public class PromotionInfo
    {
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal PercentDC { get; set; }
        public decimal ValueDC { get; set; }
        public decimal MaximumDC { get; set; }
        public bool HasAttachProduct { get; set; }
        public int EffectProductId { get; set; }
        public int LimitedProductQty { get; set; }
        public bool HasCondition { get; set; }
        public bool MeetCondition { get; set; }
        public int Index { get; set; }
        public decimal ExactDC { get; set; }
        public int ReferenceId { get; set; }
        public bool NeedDeductSubscription { get; set; }
        public int CustomerSubscriptionId { get; set; }
        public bool IsFromExternalSource { get; set; }
    }
}
