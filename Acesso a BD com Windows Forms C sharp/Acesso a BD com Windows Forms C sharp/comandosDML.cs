using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Acesso_a_BD_com_Windows_Forms_C_sharp
{
    class comandosDML
    {
        // Método para inserir, atualizar ou excluir registros:
        public void iud(string sSql)
        {
            string strConn = ("Data Source=VPR0576602W10-1;Initial Catalog=db_Biblioteca;Integrated Security=true");
            SqlConnection conn = new SqlConnection(strConn);
            // cria objeto de conexão e comando
            SqlCommand cmd = new SqlCommand(sSql,conn);
            // abre conexão
            conn.Open();
            // executa comando de conexão
            cmd.ExecuteNonQuery();
            conn.Close();
        }
              
}
    }
