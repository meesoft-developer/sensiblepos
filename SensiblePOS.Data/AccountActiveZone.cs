using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class AccountActiveZone
    {
        public int Id { get; set; }
        public DateTime EntryDate { get; set; }
        public int ZoneId { get; set; }
        public int AccountId { get; set; }
        public bool IsExpired { get; set; }
        public DateTime? ExpireDate { get; set; }
    }
}
