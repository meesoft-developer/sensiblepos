using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiblePOS.Models
{
    public class CartItemInfo
    {
        public int ProductId { get; set; } 
        public string SKU { get; set; }
        public string Title { get; set; }
        public string UnitName { get; set; }
        public decimal Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SubTotalPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; } 

        public bool IsMoneyCollect { get; set; } 
        public bool IsFine { get; set; }
        public bool IsDC { get; set; } 
        public bool IsServiceCharge { get; set; }
        public decimal MaxQty { get; set; } // 0 = unlimit
        public bool IsPaid { get; set; }
        public string ItemType { get; set; }
        public long ReferenceId { get; set; }
        public bool Removable { get; set; }
        public string Remarks { get; set; }
        public bool PromotionEffect { get; set; }
        public int EffectPromotionId { get; set; }
        public decimal EffectByPromotionQty { get; set; }
        public string ColorCode { get; set; } // for ticket.
        public bool IsStockUpdated { get; set; }
        public int OpenZoneId { get; set; }
        public string StationName { get; set; }
        public string ZoneName { get; set; }
        public int PrintOrder { get; set; }

        public bool ServiceChargeSupported { get; set; }

        public decimal DepositValue { get; set; }
        public decimal TotalDeposit { get; set; }

        public bool IsFromTempPromotion { get; set; }
        
        public DateTime ExpireDate { get; set; } 
        public string Status { get; set; }
    }
}
