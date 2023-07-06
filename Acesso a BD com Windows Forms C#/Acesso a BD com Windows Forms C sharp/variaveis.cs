using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acesso_a_BD_com_Windows_Forms_C_sharp
{
    public static class Variaveis
    {
        public static string ConsultaSelecionada { get; set; }
        public static string CaixaTxtNomeLivro { get; set; }
        public static string CaixaTxtNomeAutor { get; set; }
        public static string CaixaTxtPrecoLivro { get; set; }
        public static string CaixaTxtSobrenomeAutor { get; set; }
        public static DateTime CaixaTxtDataPub { get; set; }
        public static string DadoIDAutor { get; set; }
        

        // Se usar SQL Server Express:
        public static string strConn = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=db_Biblioteca;User ID=sa;Password=123456;";
       
    }
}
