using System;
using System.Collections.Generic;
using System.Text;

namespace SensiblePOS.LogIn
{
    public class UserPasswordInfo
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool CanAccesBackOffice { get; set; }
        public bool CanVoidReceipt { get; set; }
        public bool CanModifyData { get; set; }
        public bool CanAccessClientSummary { get; set; }
    }
}
