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
        public double precoLivro;
        public double precoTotal;
        public consultaProcedure()
        {
            InitializeComponent();
            strConn = ("Data Source=VPR0576602W10-1;Initial Catalog=db_Biblioteca;Integrated Security=true");
        }

        private void btnCalculaPreco_Click(object sender, EventArgs e)
        {
            precoTotal = precoLivro * Convert.ToInt32(numericUpDown1.Value);
            txtValorPagar.Text = precoTotal.ToString();
        }


       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void consultaProcedure_Load(object sender, EventArgs e)
        {
            consulta = "SELECT Id_Livro FROM tbl_livros";
            carregaComboBox(consulta);
        }

        public void carregaComboBox(string sql)
        {
            SqlConnection conn = new SqlConnection(strConn);
            try
            {
                conn.Open();
                SqlCommand comando = new SqlCommand(sql, conn);
                SqlDataReader drDados = null;
                drDados = comando.ExecuteReader();
                while (drDados.Read())
                {
                    string IdLivro = drDados["Id_Livro"].ToString();
                    cmbCodLivro.Items.Add(IdLivro);
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
                cmbCodLivro.Focus();
            }
        }

        // Consulta ao nome do livro
        public void consultaLivro(string consulta)
        {
            SqlConnection conn = new SqlConnection(strConn);
            sql = consulta;
            try
            {
                conn.Open();
                SqlCommand comando = new SqlCommand(sql, conn);
                SqlDataReader drDados = null;
                drDados = comando.ExecuteReader();
                while (drDados.Read())
                {
                    string NomeLivro = (string)drDados["Nome_Livro"];
                    precoLivro = Convert.ToDouble(drDados["Preco_Livro"]);
                    // Preenchendo TextBoxes com os dados:
                    lblLivroSelecionado.Text = NomeLivro;
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

            }
        }

        private void cmbCodLivro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT Nome_Livro, Preco_Livro FROM tbl_Livros WHERE Id_Livro = '" + cmbCodLivro.SelectedItem.ToString() + "'";
            consultaLivro(sql);
        }
    }
}
