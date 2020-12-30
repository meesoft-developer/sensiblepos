using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class PrintLog
    {
        public long Id { get; set; }
        public string RefNo { get; set; }
        public string Seller { get; set; }
        public DateTime PrintDate { get; set; }
    }
}
