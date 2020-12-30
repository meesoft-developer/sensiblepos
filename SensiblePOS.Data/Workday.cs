using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class Workday
    {
        public int Id { get; set; }
        public int DayNumber { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string HalfTime { get; set; }
        public bool IsWeekend { get; set; }
    }
}
