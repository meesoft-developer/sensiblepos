using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class Zone
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ColorCode { get; set; }
        public bool Inactive { get; set; }
    }
}
