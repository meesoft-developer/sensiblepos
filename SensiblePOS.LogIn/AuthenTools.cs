using System;
using System.Text;
using System.Security.Cryptography;

namespace SensiblePOS.LogIn
{
    public class AuthenTools
    {
        public static string GetPasswordHash(string userName, string plainPassword, string salt)
        {
            if (string.IsNullOrEmpty(salt)) salt = "[SALT]";
            string complexPassword = plainPassword + salt + userName;

            SHA256Managed sha = new SHA256Managed();
            byte[] passwordByte = Encoding.UTF8.GetBytes(complexPassword);
            byte[] firstHash = sha.ComputeHash(passwordByte);
            string firstHashStr = Convert.ToBase64String(firstHash);
            return firstHashStr;
        }
    }
}
