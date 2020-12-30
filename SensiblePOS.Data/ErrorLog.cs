using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class ErrorLog
    {
        public long Id { get; set; }
        public DateTime EntryDate { get; set; }
        public string Reporter { get; set; }
        public string Location { get; set; }
        public string Subject { get; set; }
        public string Msg { get; set; }
    }
}
