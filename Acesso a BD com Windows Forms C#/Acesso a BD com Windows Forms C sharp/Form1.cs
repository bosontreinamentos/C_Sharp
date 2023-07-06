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
    public partial class Form1 : Form
    {
        public string consulta;
        public string sql;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            // Consulta a ser realizada:
            consulta = "SELECT L.Nome_Livro, L.Preco_Livro, L.Data_Pub, A.Nome_Autor FROM tbl_livro AS L INNER JOIN tbl_autores AS A ON L.ID_autor = A.ID_Autor WHERE ID_Livro = " + txtCodLivro.Text;
            
            // Instanciar classe que realiza a consulta:
            ConsultarLivro consultarLivros = new ConsultarLivro();

            // Passar a string SQL para o método fazerConsulta()
            consultarLivros.fazerConsulta(consulta);

            // Mostrar os resultados nas caixas de texto.
            txtNomeLivro.Text = Variaveis.CaixaTxtNomeLivro;
            txtNomeAutor.Text = Variaveis.CaixaTxtNomeAutor;
            txtPrecoLivro.Text = Variaveis.CaixaTxtPrecoLivro;
            txtDataPub.Text = Variaveis.CaixaTxtDataPub.ToString("dd/MM/yyyy");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Carrega ComboBox com método da classe CarregaComboBox e Listas:
            consulta = "SELECT Nome_Livro FROM tbl_livro";
            CarregaComboBox carregaLivros = new CarregaComboBox();

            // Cria objeto de lista para armazenar os dados dos livros:
            List<string> Livros = new List<string>();
            Livros.AddRange(carregaLivros.carregaComboBox(consulta, "Nome_Livro"));
            
            // Copia dados da lista para o combobox:
            cmbLivros.Items.AddRange(Livros.ToArray());

        }

        private void cmbLivros_SelectedIndexChanged(object sender, EventArgs e)
        {
            consulta = "SELECT L.Nome_Livro, L.Preco_Livro, L.Data_Pub, A.Nome_Autor FROM tbl_livro AS L INNER JOIN tbl_autores AS A ON L.ID_autor = A.ID_Autor WHERE L.Nome_Livro = '" + cmbLivros.SelectedItem.ToString() + "'";
            // Passa a string SQL para o método fazerConsulta:
            ConsultarLivro consultarLivros = new ConsultarLivro();
            consultarLivros.fazerConsulta(consulta);
            txtNomeLivro.Text = Variaveis.CaixaTxtNomeLivro;
            txtNomeAutor.Text = Variaveis.CaixaTxtNomeAutor;
            txtPrecoLivro.Text = Variaveis.CaixaTxtPrecoLivro;
            txtDataPub.Text = Variaveis.CaixaTxtDataPub.ToString("dd/MM/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastraAutor CadastraAutores = new CadastraAutor();
            CadastraAutores.Show();
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastraLivros cadastrodeLivros = new CadastraLivros();
            cadastrodeLivros.Show();
        }

        private void editorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastraEditoras CadastraEditoras = new CadastraEditoras();
            CadastraEditoras.Show();
        }

        private void editorasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaAutorEditora consultas = new ConsultaAutorEditora();
            Variaveis.ConsultaSelecionada = "Editora";
            consultas.Show();
        }

        private void autoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaAutorEditora consultas = new ConsultaAutorEditora();
            Variaveis.ConsultaSelecionada = "Autor";
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre telaSobre = new Sobre();
            telaSobre.Show();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnConsulta_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.ToolTipTitle = "Consultar Livro";
            toolTip1.SetToolTip(btnConsulta, "Clique para consultar o livro");
        }
        // -----------------------------------------------------------------------

    }
}