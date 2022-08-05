using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Classes referentes à criptografia de dados:
using System.Security.Cryptography;

namespace Acesso_a_BD_com_Windows_Forms_C_sharp
{
    public static class criptografar
    {
        public static string HashMD5(string texto)
            {
                MD5 md5 = new MD5CryptoServiceProvider();

                //Calcular o hash a partir da string de entrada:
                md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(texto));

                // Obter o resultado do hash em um array de bytes após computá-lo:
                byte[] resultado = md5.Hash;

                // Criar um novo objeto stringbuilder para coletar os bytes e criar uma string:
                StringBuilder strBuilder = new StringBuilder();
                for (int i = 0; i < resultado.Length; i++)
                {
                    //Tomar cada byte dos dados do hash e formatá-los como string hexadecimal:
                    strBuilder.Append(resultado[i].ToString("x2"));
                }

                return strBuilder.ToString();
            
        }
    }
}
