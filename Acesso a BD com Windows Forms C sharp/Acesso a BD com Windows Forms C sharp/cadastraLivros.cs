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
    public partial class cadastraLivros : Form
    {
        public string strConn;
        public string consulta;
        public string sql;
        public cadastraLivros()
        {
            InitializeComponent();
            strConn = ("Data Source=VPR0576602W10-1;Initial Catalog=db_Biblioteca;Integrated Security=true");
        }

        private void cadastraLivros_Load(object sender, EventArgs e)
        {
            string SQLAutor = "SELECT ID_Autor FROM tbl_autores";
            carregaComboBoxAutores(SQLAutor);
            string SQLEditora = "SELECT ID_Editora FROM tbl_editoras";
            carregaComboBoxEditoras(SQLEditora);
        }
        
        //--------------------------------------------------------------------------
        // Carrega combobox de Autores:
        public void carregaComboBoxAutores(string SQLAutores)
        {
            
        SqlConnection conn = new SqlConnection(strConn);
            sql = SQLAutores;

                conn.Open();
                // Criar comando de consulta:
                SqlCommand consultaAutores = new SqlCommand(sql, conn);
                // Criar o DataReader:
                SqlDataReader drDadosAutores = null;
                // Executar a consulta:
                drDadosAutores = consultaAutores.ExecuteReader();
                while (drDadosAutores.Read())
                {
                    // Obter os resultados das colunas
                    string IDAutor = drDadosAutores["ID_Autor"].ToString(); //ID_Autor é a coluna no BD.
                    // Preenchendo ComboBox com os dados:
                    cmbIDAutor.Items.Add(IDAutor);
                }
                drDadosAutores.Close();
                conn.Close();

        }
        //----------------------------------------------------------------------------

        //----------------------------------------------------------------------------
        //Carregar combobox de Editoras

        public void carregaComboBoxEditoras(string SQLEditoras)
        {          
            SqlConnection conn = new SqlConnection(strConn);
            sql = SQLEditoras;

                conn.Open();
                // Criar comando de consulta:
                SqlCommand consultaEditoras = new SqlCommand(sql, conn);
                // Criar o DataReader:
                SqlDataReader drDadosEditoras = null;
                // Executar a consulta:
                drDadosEditoras = consultaEditoras.ExecuteReader();
                while (drDadosEditoras.Read())
                {
                    // Obter os resultados das colunas
                    string IDEditora = drDadosEditoras["ID_Editora"].ToString(); //ID_Editora é a coluna no BD.
                    // Preenchendo ComboBox com os dados:
                    cmbIDEditora.Items.Add(IDEditora);
                }
                drDadosEditoras.Close();
                conn.Close();
        }
        //----------------------------------------------------------------------------------
        


        private void button1_Click(object sender, EventArgs e)
        {
            // Criar string SQL:
            string DataPub = dtpDataPub.Value.ToString("dd/MM/yyyy");
            sql = "INSERT INTO tbl_Livro(Nome_livro, ISBN, ID_Autor, Data_Pub, Preco_Livro, ID_Editora) VALUES ('" + txtNomeLivro.Text + "','" + txtISBN.Text + "'," + cmbIDAutor.SelectedItem.ToString() + ",'" + DataPub + "'," + txtPrecoLivro.Text + "," + cmbIDEditora.SelectedItem.ToString() + ")";
            // Instanciar objeto comandosDML (classe em arquivo á parte):
            comandosDML inserir = new comandosDML();
            // Executar a consulta:
            try
            {
                inserir.iud(sql);
            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Source.ToString());
            }
            finally
            {
                MessageBox.Show("Registro inserido");
                this.Hide();
            }
        }

        private void txtNomeLivro_Click(object sender, EventArgs e)
        {

        }
    }
}
