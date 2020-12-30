using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiblePOS.Backoffice.Models.Reports
{
    public class SaleItemInfo
    {
        public long Id { get; set; }
        public DateTime EntryDate { get; set; }
        public int ProductId { get; set; }
        public string Sku { get; set; }
        public string ItemName { get; set; } 
        public string ItemType { get; set; }
        public int ZoneId { get; set; }
        public string ZoneName { get; set; }
        public int Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total { get; set; }
        public string Seller { get; set; }
        public string Station { get; set; }
    }
}
