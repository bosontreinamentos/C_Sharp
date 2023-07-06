using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Acesso_a_BD_com_Windows_Forms_C_sharp
{
    class ConsultarLivro
    {
        public void fazerConsulta(string consulta)
        {
            SqlConnection conn = new SqlConnection(Variaveis.strConn);
            try
            {
                // Abrir a conexão com o banco de dados:
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
                        Variaveis.CaixaTxtNomeLivro = (string)drDados["Nome_Livro"];
                        Variaveis.CaixaTxtNomeAutor = (string)drDados["Nome_Autor"];
                        //Preço do livro é tipo decimal, convertemos para string e arredondamos com string.Format().
                        Variaveis.CaixaTxtPrecoLivro = string.Format("{0:0.00}", drDados["Preco_Livro"]);
                        Variaveis.CaixaTxtDataPub = (DateTime)drDados["Data_Pub"];
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
