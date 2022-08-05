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
        public string strConn;
        public string consulta;
        public string sql;
        public ConsultaAutorEditora()
        {
            InitializeComponent();
            strConn = ("Data Source=VPR0576602W10-1;Initial Catalog=db_Biblioteca;Integrated Security=true");
        }

        private void ConsultaAutorEditora_Load(object sender, EventArgs e)
        {
            if (variaveis.ConsultaSelecionada == "Autor") //Verifica qual consulta foi selecionada (item de menu)
            {
                tabCadastraAutoresEditoras.SelectedTab = tabAutores; // Configura aba tabAutores
            }
            else if (variaveis.ConsultaSelecionada == "Editora")
            {
                tabCadastraAutoresEditoras.SelectedTab = tabEditoras; // Configura aba tabEditoras
            }
            else
            {
                MessageBox.Show("Consulta Não Selecionada");
            }

            // Carregar o combobox de Editoras:
            sql = "SELECT ID_Editora FROM tbl_editoras";
            // Passa a string SQL para p método stringConexão:
            carregaComboBoxEditoras(sql);

            
        }

        private void btnConsultaAutor_Click(object sender, EventArgs e)
        {
            sql = "SELECT Nome_Autor, Sobrenome_Autor FROM tbl_autores WHERE ID_Autor = " + txtCodAutor.Text;
            // Passa a string SQL para p método stringConexão:
            stringConexaoAutor(sql);
        }

            public void stringConexaoAutor(string sql)
        {            
            SqlConnection conn = new SqlConnection(strConn);       
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
                    string NomeAutor = (string)drDados["Nome_Autor"]; //Nome_Autor é a coluna no BD.
                    string SobrenomeAutor = (string)drDados["Sobrenome_Autor"];
                    // Preenchendo ComboBoxes com os dados:
                    txtNomeAutor.Text = NomeAutor;
                    txtSobrenomeAutor.Text = SobrenomeAutor;
                }
                drDados.Close();
                conn.Close();
            }
            finally
            {
                MessageBox.Show("Consulta efetuada com sucesso!!!");
            }
        }

        //----------------------------------------------------------------------------------------------------
        // Método para preencher Combobox cmbCodEditora automaticamente ao carregar o formulário:
        public void carregaComboBoxEditoras(string sql)
        {        
            SqlConnection conn = new SqlConnection(strConn);
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
                    string IDEditora = (drDados["ID_Editora"]).ToString(); //ID_Editora é a coluna no BD.
                    // Preenchendo ComboBox com os dados:
                    cmbCodEditora.Items.Add(IDEditora);
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
                txtNomeEditora.Focus();
            }
        }
        //-------------------------------------------------------------------------------------------------

        public void consultaEditora(string sql)
        {
            SqlConnection conn = new SqlConnection(strConn);
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

          
            }
        }


