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
    public partial class CadastraUser : Form
    {
        public CadastraUser()
        {
            InitializeComponent();
        }

        private void btnCadastraUser_Click(object sender, EventArgs e)
        {
            // Verificar se senhas conferem:
            if (txtCadastraSenha.Text == txtRepeteSenha.Text)
            {
                // Criptografar senha fornecida com algoritmo MD5 - ver arquivo criptografar.cs:
                string senha = criptografar.HashMD5(txtCadastraSenha.Text);

                // Criar string SQL:
                string sql = "INSERT INTO tbl_logon(Nome_user, Senha) VALUES ('" + txtCadastraNome.Text + "','" + senha + "')";
                MessageBox.Show(sql); // Para testes - eliminar qando OK
                comandosDML inserir = new comandosDML();
                try
                {
                    inserir.iud(sql);
                    MessageBox.Show("Usuário Cadastrado", "Sucesso");
                }
                catch (SqlException s)
                {
                    MessageBox.Show(s.Source.ToString());
                }
                finally
                {
                    // Aqui não vai nada
                }
            }
            else
            {
                MessageBox.Show("Senhas Não conferem. Tente novamente", "Senhas não conferem");
            }
        }
    }
}
