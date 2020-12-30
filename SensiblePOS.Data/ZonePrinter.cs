using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class ZonePrinter
    {
        public int Id { get; set; }
        public int ZoneId { get; set; }
        public string PrinterIp { get; set; }
        public bool Inactive { get; set; }
    }
}
