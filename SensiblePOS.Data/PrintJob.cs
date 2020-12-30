using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class PrintJob
    {
        public long Id { get; set; }
        public string RefNo { get; set; }
        public string Text { get; set; }
        public bool IsSuccess { get; set; }
        public int SuccessCount { get; set; }
        public DateTime LastPrintDate { get; set; }
        public int NumberOfCopy { get; set; }
        public string IpAddress { get; set; }
    }
}
