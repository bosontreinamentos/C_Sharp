using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Acesso_a_BD_com_Windows_Forms_C_sharp
{
    public partial class Form1 : Form
    {
        public string strConn;
        public string consulta;
        public string sql;

        public Form1()
        {
            InitializeComponent();
            strConn = ("Data Source=VPR0576602W10-1;Initial Catalog=db_Biblioteca;Integrated Security=true");
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            consulta = "SELECT L.Nome_Livro, L.Preco_Livro, A.Nome_Autor FROM tbl_livros AS L INNER JOIN tbl_autores AS A ON L.ID_autor = A.ID_Autor WHERE ID_Livro = " + txtCodLivro.Text;
            // Passa a string SQL para p método stringConexão:
            fazerConsulta(consulta);
        }


        public void fazerConsulta(string consulta)
        {           
            SqlConnection conn = new SqlConnection(strConn);
            sql = consulta;
            try
            {
                conn.Open();
                // Criar comando de consulta:
                SqlCommand comando = new SqlCommand(sql, conn);
                // Criar o DataReader:
                SqlDataReader drDados = null;
                // Executar a consulta:
                drDados = comando.ExecuteReader();
                while (drDados.Read())
                {
                    // Obter os resultados das colunas
                    string NomeLivro = (string)drDados["Nome_Livro"];
                    string NomeAutor = (string)drDados["Nome_Autor"];
                    string PrecoLivro = drDados["Preco_Livro"].ToString();
                    // Preenchendo TextBoxes com os dados:
                    txtNomeLivro.Text = NomeLivro;
                    txtNomeAutor.Text = NomeAutor;
                    txtPrecoLivro.Text = PrecoLivro;
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
                MessageBox.Show("Consulta efetuada com sucesso!!!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            consulta = "SELECT Nome_Livro FROM tbl_livros";
            // Passa a string consulta para o método carregaComboBox:
            carregaComboBox(consulta);
        }


        // Preencher Combobox cmbLivros automaticamente ao carregar o programa:
        public void carregaComboBox(string sql)
        {          
            SqlConnection conn = new SqlConnection(strConn);
            try
            {
                conn.Open();
                // Criar comando de consulta:
                SqlCommand comando = new SqlCommand(sql, conn);
                // Criar o DataReader:
                SqlDataReader drDados = null;
                // Executar a consulta:
                drDados = comando.ExecuteReader();
                while (drDados.Read())
                {
                    // Obter o resultado da coluna Nome_Livro:
                    string NomeLivro = (string)drDados["Nome_Livro"];
                    // Preenchendo ComboBox com os dados:
                    cmbLivros.Items.Add(NomeLivro);
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
                txtCodLivro.Focus();
            }
        }

        private void cmbLivros_SelectedIndexChanged(object sender, EventArgs e)
        {
            consulta = "SELECT L.Nome_Livro, L.Preco_Livro, A.Nome_Autor FROM tbl_livros AS L INNER JOIN tbl_autores AS A ON L.ID_autor = A.ID_Autor WHERE L.Nome_Livro = '" + cmbLivros.SelectedItem.ToString() + "'";
            fazerConsulta(consulta);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastro CadastraAutores = new cadastro();
            CadastraAutores.Show();
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastraLivros cadastrodeLivros = new cadastraLivros();
            cadastrodeLivros.Show();
        }

        private void editorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastraEditoras CadastraEditoras = new cadastraEditoras();
            CadastraEditoras.Show();
        }

        private void editorasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaAutorEditora consultas = new ConsultaAutorEditora();
            variaveis.ConsultaSelecionada = "Editora";
            consultas.Show();
        }

        private void autoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaAutorEditora consultas = new ConsultaAutorEditora();
            variaveis.ConsultaSelecionada = "Autor";
            consultas.Show();
        }

        private void livrosEmGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridLivros consultalivros = new GridLivros();
            consultalivros.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void preçoTotalcomProceduresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaProcedure JanelaProcedure = new consultaProcedure();
            JanelaProcedure.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastraUser cadastro = new CadastraUser();
            cadastro.Show();
        }
        // -----------------------------------------------------------------------

    }
}