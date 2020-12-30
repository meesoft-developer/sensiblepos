using System;
using System.Collections.Generic;
using System.Linq;

namespace SensiblePOS.Models
{
    public class CustomerInfo
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string DefaultTag { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string NickName { get; set; }
        public byte[] ImageData { get; set; }

        public string LastReceipt { get; set; } 

        public string IdCard { get; set; }
        public string Address { get; set; }
         
        public int Gender { get; set; } 

        public string Comment { get; set; } 
    }
}
