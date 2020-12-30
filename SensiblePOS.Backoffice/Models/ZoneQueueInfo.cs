using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiblePOS.Backoffice.Models
{
    public class ZoneQueueInfo
    {
        public int Id { get; set; }
        public string ZoneName { get; set; }
        public long Current { get; set; }
    }
}