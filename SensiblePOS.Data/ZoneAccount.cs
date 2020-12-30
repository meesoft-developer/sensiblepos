using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class ZoneAccount
    {
        public int Id { get; set; }
        public int ZoneId { get; set; }
        public int AccountId { get; set; }
        public DateTime Effective { get; set; }
        public DateTime? Expire { get; set; }
        public bool Inactive { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
