namespace ListBox_e_ComboBox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbAnimais = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstAnimais = new System.Windows.Forms.ListBox();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnRemoveSelecionado = new System.Windows.Forms.Button();
            this.btnClassifica = new System.Windows.Forms.Button();
            this.btnGeraNovaLista = new System.Windows.Forms.Button();
            this.txtItems = new System.Windows.Forms.TextBox();
            this.btnAdicionaItem = new System.Windows.Forms.Button();
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.btnGeraNumeros = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.lblNumeros = new System.Windows.Forms.Label();
            this.btnDeselecionar = new System.Windows.Forms.Button();
            this.btnSelecionaTudo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbAnimais
            // 
            this.cmbAnimais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnimais.FormattingEnabled = true;
            this.cmbAnimais.Location = new System.Drawing.Point(18, 46);
            this.cmbAnimais.Name = "cmbAnimais";
            this.cmbAnimais.Size = new System.Drawing.Size(189, 21);
            this.cmbAnimais.TabIndex = 0;
            this.cmbAnimais.SelectedIndexChanged += new System.EventHandler(this.cmbAnimais_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione Itens para adicionar ao ListBox:";
            // 
            // lstAnimais
            // 
            this.lstAnimais.FormattingEnabled = true;
            this.lstAnimais.Location = new System.Drawing.Point(282, 13);
            this.lstAnimais.Name = "lstAnimais";
            this.lstAnimais.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstAnimais.Size = new System.Drawing.Size(177, 329);
            this.lstAnimais.TabIndex = 2;
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(472, 15);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(91, 55);
            this.btnLimpa.TabIndex = 3;
            this.btnLimpa.Text = "Limpar Lista";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnRemoveSelecionado
            // 
            this.btnRemoveSelecionado.Location = new System.Drawing.Point(472, 106);
            this.btnRemoveSelecionado.Name = "btnRemoveSelecionado";
            this.btnRemoveSelecionado.Size = new System.Drawing.Size(96, 59);
            this.btnRemoveSelecionado.TabIndex = 4;
            this.btnRemoveSelecionado.Text = "Remover Selecionados";
            this.btnRemoveSelecionado.UseVisualStyleBackColor = true;
            this.btnRemoveSelecionado.Click += new System.EventHandler(this.btnRemoveSelecionado_Click);
            // 
            // btnClassifica
            // 
            this.btnClassifica.Location = new System.Drawing.Point(472, 200);
            this.btnClassifica.Name = "btnClassifica";
            this.btnClassifica.Size = new System.Drawing.Size(93, 55);
            this.btnClassifica.TabIndex = 5;
            this.btnClassifica.Text = "Classificar Lista";
            this.btnClassifica.UseVisualStyleBackColor = true;
            this.btnClassifica.Click += new System.EventHandler(this.btnClassifica_Click);
            // 
            // btnGeraNovaLista
            // 
            this.btnGeraNovaLista.Location = new System.Drawing.Point(60, 85);
            this.btnGeraNovaLista.Margin = new System.Windows.Forms.Padding(2);
            this.btnGeraNovaLista.Name = "btnGeraNovaLista";
            this.btnGeraNovaLista.Size = new System.Drawing.Size(105, 60);
            this.btnGeraNovaLista.TabIndex = 6;
            this.btnGeraNovaLista.Text = "Gerar nova listagem";
            this.btnGeraNovaLista.UseVisualStyleBackColor = true;
            this.btnGeraNovaLista.Click += new System.EventHandler(this.btnGeraNovaLista_Click);
            // 
            // txtItems
            // 
            this.txtItems.Location = new System.Drawing.Point(10, 185);
            this.txtItems.Margin = new System.Windows.Forms.Padding(2);
            this.txtItems.Name = "txtItems";
            this.txtItems.Size = new System.Drawing.Size(144, 20);
            this.txtItems.TabIndex = 7;
            // 
            // btnAdicionaItem
            // 
            this.btnAdicionaItem.Location = new System.Drawing.Point(158, 168);
            this.btnAdicionaItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionaItem.Name = "btnAdicionaItem";
            this.btnAdicionaItem.Size = new System.Drawing.Size(106, 53);
            this.btnAdicionaItem.TabIndex = 8;
            this.btnAdicionaItem.Text = "Adicionar item ao Combobox";
            this.btnAdicionaItem.UseVisualStyleBackColor = true;
            this.btnAdicionaItem.Click += new System.EventHandler(this.btnAdicionaItem_Click);
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.Location = new System.Drawing.Point(31, 107);
            this.lstNumeros.Margin = new System.Windows.Forms.Padding(2);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(91, 355);
            this.lstNumeros.TabIndex = 9;
            // 
            // btnGeraNumeros
            // 
            this.btnGeraNumeros.Location = new System.Drawing.Point(31, 54);
            this.btnGeraNumeros.Margin = new System.Windows.Forms.Padding(2);
            this.btnGeraNumeros.Name = "btnGeraNumeros";
            this.btnGeraNumeros.Size = new System.Drawing.Size(92, 46);
            this.btnGeraNumeros.TabIndex = 10;
            this.btnGeraNumeros.Text = "Gerar Números";
            this.btnGeraNumeros.UseVisualStyleBackColor = true;
            this.btnGeraNumeros.Click += new System.EventHandler(this.btnGeraNumeros_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNumeros);
            this.panel1.Controls.Add(this.lblNumeros);
            this.panel1.Controls.Add(this.btnGeraNumeros);
            this.panel1.Controls.Add(this.lstNumeros);
            this.panel1.Location = new System.Drawing.Point(611, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 473);
            this.panel1.TabIndex = 11;
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(64, 21);
            this.txtNumeros.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(80, 20);
            this.txtNumeros.TabIndex = 12;
            // 
            // lblNumeros
            // 
            this.lblNumeros.Location = new System.Drawing.Point(2, 13);
            this.lblNumeros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(58, 36);
            this.lblNumeros.TabIndex = 11;
            this.lblNumeros.Text = "Digite um número:";
            // 
            // btnDeselecionar
            // 
            this.btnDeselecionar.Location = new System.Drawing.Point(472, 287);
            this.btnDeselecionar.Name = "btnDeselecionar";
            this.btnDeselecionar.Size = new System.Drawing.Size(93, 55);
            this.btnDeselecionar.TabIndex = 12;
            this.btnDeselecionar.Text = "Deselecionar Itens";
            this.btnDeselecionar.UseVisualStyleBackColor = true;
            this.btnDeselecionar.Click += new System.EventHandler(this.btnDeselecionar_Click);
            // 
            // btnSelecionaTudo
            // 
            this.btnSelecionaTudo.Location = new System.Drawing.Point(325, 367);
            this.btnSelecionaTudo.Name = "btnSelecionaTudo";
            this.btnSelecionaTudo.Size = new System.Drawing.Size(93, 55);
            this.btnSelecionaTudo.TabIndex = 13;
            this.btnSelecionaTudo.Text = "Selecionar Tudo";
            this.btnSelecionaTudo.UseVisualStyleBackColor = true;
            this.btnSelecionaTudo.Click += new System.EventHandler(this.btnSelecionaTudo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 488);
            this.Controls.Add(this.btnSelecionaTudo);
            this.Controls.Add(this.btnDeselecionar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdicionaItem);
            this.Controls.Add(this.txtItems);
            this.Controls.Add(this.btnGeraNovaLista);
            this.Controls.Add(this.btnClassifica);
            this.Controls.Add(this.btnRemoveSelecionado);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.lstAnimais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAnimais);
            this.Name = "Form1";
            this.Text = "ListBox e ComboBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAnimais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAnimais;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnRemoveSelecionado;
        private System.Windows.Forms.Button btnClassifica;
        private System.Windows.Forms.Button btnGeraNovaLista;
        private System.Windows.Forms.TextBox txtItems;
        private System.Windows.Forms.Button btnAdicionaItem;
        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.Button btnGeraNumeros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.Button btnDeselecionar;
        private System.Windows.Forms.Button btnSelecionaTudo;
    }
}

