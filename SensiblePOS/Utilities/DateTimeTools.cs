using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiblePOS.Utilities
{
    public static class DateTimeTools
    {
        public static DateTime StringToTime(string timeString, DateTime targetDate)
        {
            var comps = timeString.Split(new char[] { ':' });
            if (comps.Length != 2) return targetDate;
            return targetDate.AddHours(Convert.ToDouble(comps[0])).AddMinutes(Convert.ToDouble(comps[1]));
        }
    }
}
