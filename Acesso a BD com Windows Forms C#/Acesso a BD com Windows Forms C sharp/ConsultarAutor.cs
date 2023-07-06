using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Acesso_a_BD_com_Windows_Forms_C_sharp
{
    class ConsultarAutor
    {
        SqlConnection conn = new SqlConnection(Variaveis.strConn);
        public void fazerConsulta(string consulta)
        {
            try
            {
                conn.Open();
                // Criar comando de consulta:
                SqlCommand comando = new SqlCommand(consulta, conn);
                // Criar o DataReader:
                SqlDataReader drDados = null;
                // Executar a consulta:
                drDados = comando.ExecuteReader();
                if (drDados.HasRows) // Verificar se há linhas retornadas
                {
                    while (drDados.Read())
                    {
                        // Obter os resultados das colunas
                        Variaveis.CaixaTxtNomeAutor = (string)drDados["Nome_Autor"];
                        Variaveis.CaixaTxtSobrenomeAutor = (string)drDados["Sobrenome_Autor"];
                    }
                }
                else
                {
                    MessageBox.Show("Código não encontrado");
                }
                drDados.Close();
                conn.Close();
            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Source.ToString());
            }
        }

        // Consulta código autor
        public void consultaCodAutor(string consulta)
        {            
            try
            {
                conn.Open();
                // Criar comando de consulta:
                SqlCommand comando = new SqlCommand(consulta, conn);
                // Criar o DataReader:
                SqlDataReader drDados = null;
                // Executar a consulta:
                drDados = comando.ExecuteReader();
                if (drDados.HasRows) // Verificar se há linhas retornadas
                {
                    while (drDados.Read())
                    {
                        // Obter os resultados das colunas
                        Variaveis.DadoIDAutor = drDados["UltimoAutor"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Código não encontrado");
                }
                drDados.Close();
                conn.Close();
            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Source.ToString());
            }
        }
    }
}
