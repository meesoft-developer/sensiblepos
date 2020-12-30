using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiblePOS.Models
{
    public class ItemInfo
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal Qty { get; set; }
        public int ProductId { get; set; }
    }
}
