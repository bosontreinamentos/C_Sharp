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
    /*
     * Observações
    1. Para configurar o redimensionamento automático de largura das
    colunas do grid, ajuste a propriedade AutoSizeColumnsMode
    para AllCells.
    2. Para ocultar a primeira coluna do grid, que contém a seta
    e o asterisco (gerada automaticamente), ajuste a
    propriedade RowHeadersVisible para False.
    */
    public partial class GridLivros : Form
    {
        public string strConn;
        public string consulta;
        public string sql;
        public GridLivros()
        {
            InitializeComponent();                       
        }

        private void GridLivros_Load(object sender, EventArgs e)
        {
            carregaGrid();
        }
        //--------------------------------------------
        // Preencher o grid:
        public void carregaGrid() //Preenche um DataSet
        {
            SqlConnection conn = new SqlConnection(Variaveis.strConn);
            try
            {
                // Comando SQL a executar:
                sql = "SELECT * FROM tbl_livro";
                
                // Criar um DataSet vazio:
                DataSet dsTabelas = new DataSet();
                
                // Criar instância do DataAdapter:
                SqlDataAdapter datblLivro = new SqlDataAdapter(sql, conn);
                
                // Preencher o DataSet:
                datblLivro.Fill(dsTabelas);
                
                // Preencher o DataGridView com os dados do DataSet:
                dataGridView1.DataSource = new DataView(dsTabelas.Tables[0]);

                // Formatar coluna para apresentar valor no formato de moeda do S.O.
                this.dataGridView1.Columns["Preco_Livro"].DefaultCellStyle.Format = "c";
                
                // Remover última linha do grid (que aparece em branco):
                this.dataGridView1.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("Erro de Conexão");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string IDLivro = String.Empty;
            DataGridViewRow linha = dataGridView1.SelectedRows[0];
            IDLivro = linha.Cells[0].Value.ToString(); // [0] é o número da coluna desejada (no caso, ID_Livro); podemos usar também ["ID_Livro"].

            // Criar string SQL para excluir registro:
            string sql = "DELETE FROM tbl_livro WHERE ID_Livro = " + IDLivro;
            //MessageBox.Show(sql);

            // Instanciar objeto comandosDML (classe em arquivo á parte):
            ComandosDML excluir = new ComandosDML();
            
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
