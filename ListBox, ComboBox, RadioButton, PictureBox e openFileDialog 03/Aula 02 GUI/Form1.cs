using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_02_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string nome;
        private void button1_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            lstNomes.Items.Add(nome);
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            if (lstNomes.SelectedIndex == -1) // Verifica se um item foi selecionado
            {
                MessageBox.Show("Selecione um nome da lista", "Nome não selecionado");
            }
            else
            {
                nome = lstNomes.SelectedItem.ToString();
                MessageBox.Show("O nome selecionado é " + nome);
            }
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            lstNomes.Items.Clear();
        }

        private void btnApagaItem_Click(object sender, EventArgs e)
        {
            // Apagar item selecionado
            if (lstNomes.SelectedIndex == -1) // Verifica se um item foi selecionado
            {
                MessageBox.Show("Selecione um nome da lista", "Nome não selecionado");
            }
            else
            {
                string item = lstNomes.SelectedItem.ToString();
                lstNomes.Items.Remove(item);
            }
        }

        private void btnPreencher_Click(object sender, EventArgs e)
        {
            int i;
            for (i=1; i <=10; i++)
            {
                cmbNumeros.Items.Add(i);
            }
        }

        private void cmbNumeros_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNumeros.Text = cmbNumeros.SelectedItem.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            string animal = "";
            if (radioGirafa.Checked == true)
                animal = "Girafa";
            else if (radioLeao.Checked == true)
                animal = "Leão";
            else if (radioTigre.Checked == true)
                animal = "Tigre";
            else
            {
                animal = "Burro";
                MessageBox.Show("Selecione um animal!!!","Erro de Seleção");
            }
                
            string imagem = "C:\\imagens\\" + animal + ".jpg";
            picAnimal.ImageLocation = imagem;
        }

        private void btnDesmarca_Click(object sender, EventArgs e)
        {
            radioGirafa.Checked = false;
            radioLeao.Checked = false;
            radioTigre.Checked = false;
        }

        private void btnLimpaImagem_Click(object sender, EventArgs e)
        {
            picAnimal.Image = null;
        }

        private void btnProcuraImagem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string caminhoImagem = openFileDialog1.FileName;
            picAnimal.ImageLocation = caminhoImagem;
        }
    }
}
