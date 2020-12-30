using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class ReceiptMemo
    {
        public long Id { get; set; }
        public DateTime EntryDate { get; set; }
        public string SerialNumber { get; set; }
        public string Scope { get; set; }
        public string Detail { get; set; }
        public string Writer { get; set; }
    }
}
