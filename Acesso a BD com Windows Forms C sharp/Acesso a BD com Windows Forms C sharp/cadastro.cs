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
    public partial class cadastro : Form
    {
        public string strConn;
        public string consulta;
        public string sql;
        public cadastro()
        {
            InitializeComponent();
            strConn = ("Data Source=TIT0522487W10-1\\SQLEXPRESS;Initial Catalog=db_Biblioteca;Integrated Security=true");
        }

        private void btnCadastraAutor_Click(object sender, EventArgs e)
        {
            // Criar string SQL:
            sql = "INSERT INTO tbl_Autores(ID_Autor, Nome_Autor, Sobrenome_Autor) VALUES (" + txtIDAutor.Text + ",'" + txtNomeAutor.Text + "','" + txtSobrenomeAutor.Text + "')";
            // Instanciar objeto comandosDML (classe em arquivo à parte):
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

        private void cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
