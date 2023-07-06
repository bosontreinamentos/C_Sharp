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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Acesso_a_BD_com_Windows_Forms_C_sharp
{
    public partial class CadastraUser : Form
    {
        public CadastraUser()
        {
            InitializeComponent();
        }

        private void btnCadastraUser_Click(object sender, EventArgs e)
        {
            if (txtCadastraSenha.Text.Equals(txtConfirmaSenha.Text))
            {
                // Criptografar senha fornecida com algoritmo MD5 - ver arquivo criptografar.cs:
                Criptografar cripto = new Criptografar();
                string senha = cripto.HashSHA256(txtCadastraSenha.Text);

                // Criar string SQL:
                string sql = "INSERT INTO tbl_logon(Nome_user, Senha) VALUES ('" + txtCadastraNome.Text + "','" + senha + "')";
                MessageBox.Show(sql);
                // Instanciar objeto comandosDML (classe em arquivo à parte):
                ComandosDML inserir = new ComandosDML();
                // Executar a consulta:
                try
                {
                    inserir.iud(sql);
                }
                finally
                {
                    MessageBox.Show("Usuário Cadastrado");
                }
            }
            else
            {
                MessageBox.Show("As senhas digitadas não correspondem", "Senha inválida");
            }
        }

        private void btnExibeOcultaSenha_Click(object sender, EventArgs e)
        {
            if (txtCadastraSenha.PasswordChar == '*')
            {

                txtCadastraSenha.PasswordChar = '\0';
                btnExibeOcultaSenha.Text = "Oculta Senha";
            }
            else
            {
                txtCadastraSenha.PasswordChar = '*';
                btnExibeOcultaSenha.Text = "Exibe Senha";
            }
        }
    }
}
