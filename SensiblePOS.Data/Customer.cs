using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime EntryDate { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string IdCard { get; set; }
        public DateTime? BirthDate { get; set; }
        public int Gender { get; set; }
        public string RegisterAddress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public byte[] ImageData { get; set; }
        public string LastReceipt { get; set; }
        public string Comment { get; set; }
    }
}
