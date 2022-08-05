using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_e_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // flag para botão que adiciona items inseridos pelo usuário
        int flag = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] bichos = new string[7] { "Gato", "Cão", "Papagaio", "Lontra", "Golfinho", "Foca", "Tatu" };
            cmbAnimais.Items.Add("Águia");
            cmbAnimais.Items.Add("Baleia");
            cmbAnimais.Items.Add("Tamanduá");
            cmbAnimais.Items.Add("Carpa");
            cmbAnimais.Items.AddRange(bichos);           
        }

        private void cmbAnimais_SelectedIndexChanged(object sender, EventArgs e)
        {          
                lstAnimais.Items.Add(cmbAnimais.SelectedItem);
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            lstAnimais.Items.Clear();
        }

        private void btnRemoveSelecionado_Click(object sender, EventArgs e)
        {
            for (int i = lstAnimais.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lstAnimais.Items.RemoveAt(lstAnimais.SelectedIndices[i]);
            }

            /*
            É possível selecionar vários itens de uma vez ajustando a propriedade SelectionMode da caixa de listagem.
            Valores possíveis:
            None - Não é possível selecionar nenhum item
            One - É possível selecionar apenas um item
            MultiSimple - É possível selecionar vários itens (CTRL)
            MultiExtended - É possível selecionar vários itens e o usuário pode usar SHIFT, CTRL e as teclas de seta para fazer seleções
            */
        }

        private void btnClassifica_Click(object sender, EventArgs e)
        {
            lstAnimais.Sorted = true;
            /* podemos classificar automaticamente a lista ajustando a 
            propriedade Sorted do ControlEventArgs ListBox. */
        }

        private void btnGeraNovaLista_Click(object sender, EventArgs e)
        {
            cmbAnimais.Items.Clear();
            cmbAnimais.Text = String.Empty; //Limpa item que resta exibido no combobox
            string[] lugares = new string[7] { "São Paulo", "Londres", "Montreal", "Roma", "Buenos Aires", "Berlim", "Amsterdam" };
            cmbAnimais.Items.AddRange(lugares);
            flag = 0;
        }

        private void btnAdicionaItem_Click(object sender, EventArgs e)
        {

            if (flag == 0)
            {
                cmbAnimais.Items.Clear();
                cmbAnimais.Text = String.Empty;
                flag = 1;
                cmbAnimais.Items.Add(txtItems.Text);
                txtItems.Text = String.Empty;
                txtItems.Focus();
            }
            else
            {
                cmbAnimais.Items.Add(txtItems.Text);
                txtItems.Text = String.Empty;
                txtItems.Focus();
            }
        }

        private void btnGeraNumeros_Click(object sender, EventArgs e)
        {
            int limite;
            bool eNumero = int.TryParse(txtNumeros.Text.Trim(), out limite);
            if (eNumero) {
                lstNumeros.Items.Clear();
                for (int a = 1; a <= limite; a++)
                {
                    lstNumeros.Items.Add(a);
                }
            }
            else {
                MessageBox.Show("Digite um número!", "Valor inválido");
                txtNumeros.Focus();
            }
        }

        private void btnDeselecionar_Click(object sender, EventArgs e)
        {
            // Deselecionar todos os itens da ListBox de uma vez:
            for (int x = 0; x < lstAnimais.Items.Count; x++)
            {
                lstAnimais.SetSelected(x, false);
            }

            // Ou simplesmente:
            // lstAnimais.ClearSelected();
        }

        private void btnSelecionaTudo_Click(object sender, EventArgs e)
        {
            // Selecionar todos os itens da ListBox de uma vez:
            lstAnimais.BeginUpdate();
            for (int x = 0; x < lstAnimais.Items.Count; x++)
            {
                lstAnimais.SetSelected(x, true);
            }
            lstAnimais.EndUpdate();

            /*
             Obs. 01: A propriedade SelectionMode deve estar configurada
             como MultiSimple ou MultiExtended.

             Obs. 02: O método BeginUpdate() mantém o desempenho enquanto
             itens são adicionados ou selecionados no ListBox um de cada
             vez evitando que o controle repinte a listbox até que o
             método EndUpdate() seja chamado.
            */

        }
    }
}
