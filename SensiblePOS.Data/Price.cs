using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class Price
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Value { get; set; }
        public bool FirstHalfSale { get; set; }
        public bool SecondHalfSale { get; set; }
        public bool WorkdaySale { get; set; }
        public bool NotWorkdaySale { get; set; }
        public bool Inactive { get; set; }
    }
}
