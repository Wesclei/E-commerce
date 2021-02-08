using System;
using System.Security.Cryptography;
using System.Text;

namespace BL.Store.Domain.Helpers
{
    public static class StringHelpers
    {
        public static string Encrypt(this string senha)
        {
            var salt = "|D95390E28D9B4D989006E8A05427FAA3BCA09B0B7CAF4D68A1D56A07BB7BA75A";

            var arrayBytes = Encoding.UTF8.GetBytes(senha + salt);

            byte[] hashBytes;
            using (var sha = SHA512.Create())
            {
                hashBytes = sha.ComputeHash(arrayBytes);
            }

            return Convert.ToBase64String(hashBytes);
        }
    }
}
