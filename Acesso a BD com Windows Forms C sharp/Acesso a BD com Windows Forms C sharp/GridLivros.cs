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
    public partial class GridLivros : Form
    {
        public string strConn;
        public string consulta;
        public string sql;
        public GridLivros()
        {
            InitializeComponent();
            strConn = ("Data Source=VPR0576602W10-1;Initial Catalog=db_Biblioteca;Integrated Security=true");
        }

        private void GridLivros_Load(object sender, EventArgs e)
        {
            carregaGrid();
        }
        //-----------------------------------------------------------------------------------------------------------------
        // Preencher o grid:
        public void carregaGrid() //Preenche um DataSet
        {           
            SqlConnection conn = new SqlConnection(strConn);
            try
            {

                // Comando SQL a executar:
                string sSql = "SELECT * FROM tbl_livros";
                // Criando um DataSet:
                DataSet dsTabelas = new DataSet();
                // Criando uma instância do DataReader:
                SqlDataAdapter datblLivro = new SqlDataAdapter(sSql, conn);
                // Preenchendo o DataSet:
                datblLivro.Fill(dsTabelas);
                // Preenchendo agora o DataGridView:
                dataGridView1.DataSource = new DataView(dsTabelas.Tables[0]);

            }

            catch
            {
                MessageBox.Show("Erro de Conexão");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string IDLivro = "";

                 DataGridViewRow linha = dataGridView1.SelectedRows[0];
                 IDLivro = linha.Cells[0].Value.ToString(); // [0] é o número da coluna desejada (no caso, ID_Livro); podemos usar também ["ID_Livro"].

            // Criar string SQL para excluir registro:
            string sql = "DELETE FROM tbl_livros WHERE ID_Livro = " + IDLivro;
            MessageBox.Show(sql);
            // Instanciar objeto comandosDML (classe em arquivo á parte):
            comandosDML excluir = new comandosDML();
            // Executar a exclusão:
            try
            {
                excluir.iud(sql);
            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Source.ToString());
            }
            finally
            {
                MessageBox.Show("Livro Excluído!");
                carregaGrid(); //Recarrega o grid (atualiza).
            }
        }

    }
}
