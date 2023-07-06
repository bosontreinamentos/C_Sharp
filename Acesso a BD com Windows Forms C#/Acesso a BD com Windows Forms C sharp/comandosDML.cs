using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Acesso_a_BD_com_Windows_Forms_C_sharp
{
    class ComandosDML
    {
        // Método para inserir, atualizar ou excluir registros:
        public void iud(string sql)
        {         
            SqlConnection conn = new SqlConnection(Variaveis.strConn);
            SqlCommand cmd = new SqlCommand(sql,conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }           
    }
}
