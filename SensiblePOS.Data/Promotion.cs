using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class Promotion
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime EntryDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Effective { get; set; }
        public DateTime Expire { get; set; }
        public decimal PercentDc { get; set; }
        public decimal ValueDc { get; set; }
        public decimal MaximumDc { get; set; }
        public int MaxUsagePerDay { get; set; }
        public bool HasCondition { get; set; }
        public bool HasSubSchedule { get; set; }
        public bool HasAttachItem { get; set; }
        public int TargetProductId { get; set; }
        public int LimitProductQty { get; set; }
        public bool ShowInList { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Inactive { get; set; }
    }
}
