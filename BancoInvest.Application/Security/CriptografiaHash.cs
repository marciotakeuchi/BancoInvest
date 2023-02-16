using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BancoInvest.Application.Security
{
    public static class CriptografiaHash
    {
        public static string GerarHash(this string valor)
        {
            byte[] salt = Encoding.ASCII.GetBytes("kL$j8h#iI6#FVdxO");

            var pbkdf2 = new Rfc2898DeriveBytes(valor, salt, 1000);

            byte[] hashBytes = pbkdf2.GetBytes(36);

            string hashSenha = Convert.ToBase64String(hashBytes);
            
            return hashSenha;
        }
    }
}
