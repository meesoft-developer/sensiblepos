using System;
using System.Collections.Generic;

#nullable disable

namespace SensiblePOS.Data
{
    public partial class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Effective { get; set; }
        public DateTime Expire { get; set; }
        public int AccountType { get; set; }
        public bool Inactive { get; set; }
    }
}
