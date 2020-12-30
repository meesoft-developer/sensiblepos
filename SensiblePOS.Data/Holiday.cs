using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class Holiday
    {
        public int Id { get; set; }
        public DateTime Effective { get; set; }
        public DateTime Expire { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
