using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Acesso_a_BD_com_Windows_Forms_C_sharp
{
    public partial class consultaProcedure : Form
    {
        public string strConn;
        public string consulta;
        public string sql;
        public consultaProcedure()
        {
            InitializeComponent();            
        }

        private void btnCalculaPreco_Click(object sender, EventArgs e)
        {
            // Criar a string SQL contendo o nome do procedimento e o local do parâmetro a ser passado a ele:
            sql = "sp_consulta_preco " + txtCodLivro.Text;
            // Passa a string SQL para o método stringConexão:
            stringConexao(sql);
        }


        public void stringConexao(string sql)
        {           
            SqlConnection conn = new SqlConnection(Variaveis.strConn);
            try
            {
                conn.Open();
                // Criar comando de consulta:
                SqlCommand consulta = new SqlCommand(sql, conn);
                // Criar o DataReader:
                SqlDataReader drDados = null;
                // Executar a consulta:
                drDados = consulta.ExecuteReader();
                while (drDados.Read())
                {
                    // Obter os resultados da coluna, e converter para tipo double
                    double PrecoLivro = Convert.ToDouble(drDados["Preco_Livro"]);
                    // Calculando o valor total e mostrando na caixa de texto:
                    txtValorPagar.Text = (PrecoLivro * Convert.ToDouble(txtQuantidade.Text)).ToString();
                }
                drDados.Close();
                conn.Close();
            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Source.ToString());
            }
            finally
            {
                // Nada aqui no bloco finally
            }
        }

        private void consultaProcedure_Load(object sender, EventArgs e)
        {

        }
    }
}
