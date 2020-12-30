using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Sku { get; set; }
        public string Title { get; set; }
        public byte[] ImageData { get; set; }
        public bool Salable { get; set; }
        public string UnitName { get; set; }
        public bool PromotionEffect { get; set; }
        public bool ServiceChargeSupport { get; set; }
        public string Remarks { get; set; }
        public int UseQty { get; set; }
        public int Qty { get; set; }
        public bool Inactive { get; set; }
    }
}
