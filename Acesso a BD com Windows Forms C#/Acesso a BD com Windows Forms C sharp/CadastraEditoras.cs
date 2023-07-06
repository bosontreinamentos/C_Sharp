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
    public partial class CadastraEditoras : Form
    {
        public string sql;
        public CadastraEditoras()
        {
            InitializeComponent();        
        }

        private void btnCadastraEditora_Click(object sender, EventArgs e)
        {
            // Criar string SQL:
            sql = "INSERT INTO tbl_editoras (Nome_Editora) VALUES ('" + txtEditora.Text + "')";
            
            // Instanciar objeto comandosDML (classe em arquivo próprio):
            ComandosDML inserir = new ComandosDML();
            
            // Executar a consulta:
            try
            {
                inserir.iud(sql);
                MessageBox.Show("Editora cadastrada!");
            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Source.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source.ToString());
            }
            finally
            {                
                this.Hide();
            }
        }

        private void CadastraEditoras_Load(object sender, EventArgs e)
        {

        }
    }
}
