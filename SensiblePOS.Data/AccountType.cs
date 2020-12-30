using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class AccountType
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public bool AccessPortal { get; set; }
        public bool AccessReport { get; set; }
        public bool AccessClient { get; set; }
        public bool AccessAccountReport { get; set; }
        public bool AccessClientSummary { get; set; }
        public bool CanVoidReceipt { get; set; }
        public bool CanModifyData { get; set; }
        public bool CanModifyStock { get; set; }
        public bool Inactive { get; set; }
    }
}
