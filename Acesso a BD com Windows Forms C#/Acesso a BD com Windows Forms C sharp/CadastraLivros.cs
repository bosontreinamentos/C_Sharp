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
    public partial class CadastraLivros : Form
    {
        public string sql;
        public string IDEditora;
        public string IDAutor;
        public string NomeAutor;
        public string consultaAutor;
        public string consultaEditora;
        string SQLAutor = "SELECT Nome_Autor, Sobrenome_Autor FROM tbl_autores";
        string SQLEditora = "SELECT Nome_Editora FROM tbl_editoras";
        public CadastraLivros()
        {
            InitializeComponent();
        }

        private void cadastraLivros_Load(object sender, EventArgs e)
        {
            // Carregar ComboBox de Autores
            CarregaComboBox carregaAutores = new CarregaComboBox();
            List<string> Autores = new List<string>();
            Autores.AddRange(carregaAutores.carregaComboBoxAutores(SQLAutor, "Nome_Autor", "Sobrenome_Autor"));
            cmbIDAutor.Items.AddRange(Autores.ToArray());

            // Carregar ComboBox de Editoras
            CarregaComboBox carregaEditoras = new CarregaComboBox();
            List<string> Editoras = new List<string>();
            Editoras.AddRange(carregaEditoras.carregaComboBoxEditoras(SQLEditora, "Nome_Editora"));
            cmbIDEditora.Items.AddRange(Editoras.ToArray());
        }

        //----------------------------------------------------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            string DataPub = dtpDataPub.Value.ToString("dd/MM/yyyy");
            // Criar string SQL:
            sql = "INSERT INTO tbl_livro(Nome_livro, ISBN, ID_Autor, Data_Pub, Preco_Livro, ID_Editora) VALUES ('" + txtNomeLivro.Text + "','" + txtISBN.Text + "'," + IDAutor + ",'" + DataPub + "'," + txtPrecoLivro.Text.Replace(',','.') + "," + IDEditora + ")";
            MessageBox.Show(sql);
            // Instanciar objeto comandosDML (classe em arquivo á parte):
            ComandosDML inserir = new ComandosDML();
            // Executar a consulta:
            try
            {
                inserir.iud(sql);
                MessageBox.Show("Registro inserido", "Sucesso!");
            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Source.ToString());
            }
            finally
            {
                this.Hide();
            }

        }

        private void txtNomeLivro_Click(object sender, EventArgs e)
        {

        }

        private void cmbIDAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica Autor selecionado:
            string nomeCompletoAutor = cmbIDAutor.SelectedItem.ToString();
            string[] partesNomeAutor = nomeCompletoAutor.Split(' ');
            string nomeAutor = partesNomeAutor[0];
            string sobrenomeAutor = partesNomeAutor[1];
            string consultaAutor = "SELECT ID_Autor FROM tbl_autores WHERE Nome_Autor = '" + nomeAutor + "' AND Sobrenome_Autor = '" + sobrenomeAutor + "'";
            MessageBox.Show(consultaAutor); 
            verificaAutorSelecionado(consultaAutor);
        }

        private void cmbIDEditora_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica Editora selecionada:
            consultaEditora = "SELECT ID_Editora FROM tbl_editoras WHERE Nome_Editora = " + "'" + cmbIDEditora.SelectedItem.ToString() + "'";
            verificaEditoraSelecionada(consultaEditora);
        }

        public void verificaAutorSelecionado(string SQLconsultaAutor)
        {
            SqlConnection conn = new SqlConnection(Variaveis.strConn);
            conn.Open();
            SqlCommand comando = new SqlCommand(SQLconsultaAutor, conn);
            SqlDataReader drDados = null;
            drDados = comando.ExecuteReader();
            if (drDados.HasRows) // Verificar se há linhas retornadas
            {
                while (drDados.Read())
                {
                    IDAutor = drDados["ID_Autor"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Código não encontrado");
            }
            drDados.Close();
            conn.Close();
        }

        public void verificaEditoraSelecionada(string SQLconsultaEditora)
        {
            SqlConnection conn = new SqlConnection(Variaveis.strConn);
            conn.Open();
            SqlCommand comando = new SqlCommand(SQLconsultaEditora, conn);
            SqlDataReader drDados = null;
            drDados = comando.ExecuteReader();
            if (drDados.HasRows) // Verificar se há linhas retornadas
            {
                while (drDados.Read())
            {
                IDEditora = drDados["ID_Editora"].ToString();
            }
        }
            else
            {
                MessageBox.Show("Código não encontrado");
            }
    drDados.Close();
            conn.Close();
        }
    }
}