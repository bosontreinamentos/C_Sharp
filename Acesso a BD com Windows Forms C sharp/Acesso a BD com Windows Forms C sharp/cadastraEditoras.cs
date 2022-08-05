using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Acesso_a_BD_com_Windows_Forms_C_sharp
{
    public partial class cadastraEditoras : Form
    {
        public string strConn;
        public string consulta;
        public string sql;
        public cadastraEditoras()
        {
            InitializeComponent();
        }

        private void btnCadastraEditora_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO tbl_editoras (Nome_Editora) VALUES ('" + txtEditora.Text + "')";
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
                MessageBox.Show("Editora cadastrada!");
                this.Hide();
            }
        }
    }
}
