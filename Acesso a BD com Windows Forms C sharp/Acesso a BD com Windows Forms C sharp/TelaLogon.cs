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
        public string strConn;
        public string consulta;
        public string sql;

        // Variável para armazenar a senha consultada do usuário:
        string senhaUser = "";

        public TelaLogon()
        {
            InitializeComponent();
            strConn = ("Data Source=" + variaveis.hostname + ";Initial Catalog=db_Biblioteca;Integrated Security=true");
        }

        /*
        Esta tela é a tela inicial do aplicativo. Essa
        configuração deve ser alterada no arquivo Program.cs,
        na linha "Application.Run(new TelaLogon());"
        */

        
        private void btnCadastraUser_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogon_Click(object sender, EventArgs e)
        {
            
            // Consultar a senha do usuário:
            string SQLsenha = "SELECT Senha FROM tbl_Logon WHERE Nome_user = '" + txtLogonUser.Text + "'";
            consultaSenha(SQLsenha);

            // Calcular o Hash da txtCadastraSenha fornecida:
            string senha = criptografar.HashMD5(txtLogonSenha.Text);
            // Criando o objeto StringComparer para comparar as strings:
            StringComparer comparar = StringComparer.OrdinalIgnoreCase;
            // Verificar se as senhas batem:
            if (comparar.Compare(senha, senhaUser) == 0)
            {
                this.Hide();
                Form1 TelaInicio = new Form1();
                TelaInicio.Show();
            }
            else
            {
                MessageBox.Show("Senha Inválida! Tente Novamente", "Senha Inválida");
            }
            
            /*
            // Permite efetuar logon sem verificar senha, para fins de teste
            this.Hide();
            Form1 TelaInicio = new Form1();
            TelaInicio.Show();*/
        }

        // Método para consultar a senha do usuário:
        public void consultaSenha(string sql)
        {            
            SqlConnection conn = new SqlConnection(strConn);          
            try
            {
                conn.Open();
                SqlCommand consulta = new SqlCommand(sql, conn);
                SqlDataReader drDados = null;
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
                // Bloco finally nada tem a executar. 
            }
        }

        
        }
   
    }


