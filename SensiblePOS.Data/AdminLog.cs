using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class AdminLog
    {
        public long Id { get; set; }
        public DateTime EntryDate { get; set; }
        public string UserName { get; set; }
        public string Action { get; set; }
        public string Detail { get; set; }
    }
}
