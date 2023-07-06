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
    public partial class TelaLogon : Form
    {       
        public TelaLogon()
        {
            InitializeComponent();
        }

        public string sql;

        // Criar variável global para armazenar senha consultada do usuário:
        string senhaUser = String.Empty;
        private void btnCadastraUser_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogon_Click(object sender, EventArgs e)
        {
            Criptografar cripto = new Criptografar();
            
            // Consultar a senha do usuário:
            string SQLsenha = "SELECT senha FROM tbl_Logon WHERE Nome_user = '" + txtLogonUser.Text + "'";
            consultaSenha(SQLsenha);

            // Calcular o Hash da txtCadastraSenha fornecida:
            string senha = cripto.HashSHA256(txtLogonSenha.Text);
            
            // Criar objeto StringComparer para comparar as strings:
            StringComparer comparar = StringComparer.OrdinalIgnoreCase;
            
            // Verificar se as senhas coincidem:
            if (comparar.Compare(senha, senhaUser) == 0)
            {
                this.Hide();
                Form1 TelaInicial = new Form1();
                TelaInicial.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos! Tente Novamente", "Logon Inválido");
            }
        }

        // Método para consultar a senha do usuário:
        public void consultaSenha(string sql)
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
                    // Gravar o hash da senha consultada na variável senhaUser:
                    senhaUser = (string)drDados["Senha"];                   
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

        private void TelaLogon_Load(object sender, EventArgs e)
        {

        }
    }
   
    }


