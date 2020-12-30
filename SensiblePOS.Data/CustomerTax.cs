using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class CustomerTax
    {
        public int Id { get; set; }
        public DateTime EntryDate { get; set; }
        public string CustomerCode { get; set; }
        public string TaxName { get; set; }
        public string TaxId { get; set; }
        public string TaxAddress { get; set; }
        public string Remarks { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
