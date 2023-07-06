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
    public partial class CadastraAutor : Form
    {
        public string sql;
        public string consulta;
        public string ultimoAutor;
        public int proximoAutor;
        public CadastraAutor()
        {
            InitializeComponent();
        }

        private void btnCadastraAutor_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO tbl_Autores(ID_Autor, Nome_Autor, Sobrenome_Autor) VALUES (" + proximoAutor + ",'" + txtNomeAutor.Text + "','" + txtSobrenomeAutor.Text + "');";
            MessageBox.Show(sql);
            ComandosDML inserir = new ComandosDML();
            try {
                inserir.iud(sql);
                MessageBox.Show("Registro inserido");
            }
            catch (SqlException s) {
                MessageBox.Show(s.Source.ToString());
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Source.ToString());
            }
            finally {               
                this.Hide();
            }
        }

        private void cadastro_Load(object sender, EventArgs e)
        {
            
            string sql = "SELECT MAX(ID_Autor) AS UltimoAutor FROM tbl_autores";

            // Passa a string SQL para o método fazerConsulta:
            ConsultarAutor consultarAutores = new ConsultarAutor();
            consultarAutores.consultaCodAutor(sql);

            ultimoAutor = Variaveis.DadoIDAutor.ToString();
            proximoAutor = Convert.ToInt16(ultimoAutor);
            proximoAutor++;
            MessageBox.Show(proximoAutor.ToString());
        }
    }
}
