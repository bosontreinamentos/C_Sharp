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
    public partial class ConsultaAutorEditora : Form
    {
        public string consulta;
        public string sql;
        public ConsultaAutorEditora()
        {
            InitializeComponent();            
        }

        private void ConsultaAutorEditora_Load(object sender, EventArgs e)
        {
            if (Variaveis.ConsultaSelecionada == "Autor") //Verifica qual consulta foi selecionada (item de menu)
            {
                tabCadastraAutoresEditoras.SelectedTab = tabAutores; // Configura aba tabAutores
            }
            else if (Variaveis.ConsultaSelecionada == "Editora")
            {
                tabCadastraAutoresEditoras.SelectedTab = tabEditoras; // Configura aba tabEditoras
            }
            else
            {
                MessageBox.Show("Consulta Não Selecionada");
            }

            // Carregar o combobox de Editoras:
            sql = "SELECT ID_Editora FROM tbl_editoras";
            CarregaComboBox carregaEditoras = new CarregaComboBox();
            List<string> Editoras = new List<string>();
            Editoras.AddRange(carregaEditoras.carregaComboBoxEditoras(sql, "ID_Editora"));
            cmbCodEditora.Items.AddRange(Editoras.ToArray());

            // carregar combobox autores:
            consulta = "SELECT Nome_Autor FROM tbl_autores";
            CarregaComboBox carregaAutores = new CarregaComboBox();
            List<string> Autores = new List<string>();
            Autores.AddRange(carregaAutores.carregaComboBox(consulta, "Nome_Autor"));
            cmbListaAutores.Items.AddRange(Autores.ToArray());
        }

        private void btnConsultaAutor_Click(object sender, EventArgs e)
        {
            sql = "SELECT Nome_Autor, Sobrenome_Autor FROM tbl_autores WHERE ID_Autor = " + txtCodAutor.Text;
            // Passa a string SQL para o método fazerConsulta:
            ConsultarAutor consultarAutores = new ConsultarAutor();
            consultarAutores.fazerConsulta(sql);
            txtNomeAutor.Text = Variaveis.CaixaTxtNomeAutor;
            txtSobrenomeAutor.Text = Variaveis.CaixaTxtSobrenomeAutor;
        }

        //----------------------------------------------------------------------------------------------------

        public void consultaEditora(string sql)
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
                    // Obter os resultados das colunas
                    string NomeEditora = (string)drDados["Nome_Editora"];
                    // Preenchendo ComboBoxes com os dados:
                    txtNomeEditora.Text = NomeEditora;
                }
                drDados.Close();
                conn.Close();
            }
            finally
            {
                MessageBox.Show("Consulta efetuada com sucesso!!!");
            }
        }

        private void btnConsultaEditoras_Click(object sender, EventArgs e)
        {
            sql = "SELECT Nome_Editora FROM tbl_editoras WHERE ID_Editora = " + cmbCodEditora.SelectedItem.ToString();
            // Passa a string SQL para o método stringConexão:
            consultaEditora(sql);
        }

        private void cmbListaAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "SELECT Nome_Autor, Sobrenome_Autor FROM tbl_autores WHERE Nome_Autor = '" + cmbListaAutores.SelectedItem.ToString() + "'";
            MessageBox.Show(sql);
            // Passa a string SQL para o método fazerConsulta:
            ConsultarAutor consultarAutores = new ConsultarAutor();
            consultarAutores.fazerConsulta(sql);
            txtNomeAutor.Text = Variaveis.CaixaTxtNomeAutor;
            txtSobrenomeAutor.Text = Variaveis.CaixaTxtSobrenomeAutor;
        }
    }
    }
        


