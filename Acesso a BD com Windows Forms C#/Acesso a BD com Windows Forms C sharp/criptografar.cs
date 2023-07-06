using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Classes referentes à criptografia de dados:
using System.Security.Cryptography;

namespace Acesso_a_BD_com_Windows_Forms_C_sharp
{
    public class Criptografar
    {
        public string HashSHA256(string texto)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(texto);
            SHA256Managed resultado = new SHA256Managed();
            byte[] hash = resultado.ComputeHash(bytes);

            StringBuilder strBuilder = new StringBuilder();
            foreach (byte item in hash)
            {
                strBuilder.Append(item.ToString("x2"));
            }
            return strBuilder.ToString();
        }
    }
}
