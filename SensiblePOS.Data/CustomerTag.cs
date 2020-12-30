using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class CustomerTag
    {
        public int Id { get; set; }
        public DateTime EntryDate { get; set; }
        public string CallerNumber { get; set; }
        public string TagType { get; set; }
        public string CustomerCode { get; set; }
        public bool Inactive { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
