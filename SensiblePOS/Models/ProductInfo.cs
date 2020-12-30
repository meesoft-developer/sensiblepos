using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiblePOS.Models
{
    public class ProductInfo
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string SKU { get; set; }
        public string Title { get; set; }
        public string Desctription { get; set; }
        public string Category { get; set; }
        public byte[] ImageData { get; set; }
        public decimal Price { get; set; }
        public int ReferenceId { get; set; } // for reference (e.g. eventProduct use this as EventTicketId)
        public int Remaining { get; set; }
        public string UnitName { get; set; }
        public bool PromotionEffect { get; set; }
        public bool ServiceChargeSupported { get; set; }
        public int SortIndex { get; set; } // for sorting in menu only (favorite tab.) 
    }
}
