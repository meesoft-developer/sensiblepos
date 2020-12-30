using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class ZoneQueue
    {
        public int Id { get; set; }
        public int ZoneId { get; set; }
        public long CurrentQueue { get; set; }
        public bool Inactive { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
