namespace Aula_02_GUI
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
            this.button1 = new System.Windows.Forms.Button();
            this.lstNomes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnApagaItem = new System.Windows.Forms.Button();
            this.cmbNumeros = new System.Windows.Forms.ComboBox();
            this.btnPreencher = new System.Windows.Forms.Button();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpAnimal = new System.Windows.Forms.GroupBox();
            this.radioTigre = new System.Windows.Forms.RadioButton();
            this.radioLeao = new System.Windows.Forms.RadioButton();
            this.radioGirafa = new System.Windows.Forms.RadioButton();
            this.btnAnimal = new System.Windows.Forms.Button();
            this.picAnimal = new System.Windows.Forms.PictureBox();
            this.btnDesmarca = new System.Windows.Forms.Button();
            this.btnLimpaImagem = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnProcuraImagem = new System.Windows.Forms.Button();
            this.grpAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstNomes
            // 
            this.lstNomes.FormattingEnabled = true;
            this.lstNomes.Location = new System.Drawing.Point(94, 125);
            this.lstNomes.Name = "lstNomes";
            this.lstNomes.Size = new System.Drawing.Size(118, 108);
            this.lstNomes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite um nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(94, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(150, 20);
            this.txtNome.TabIndex = 3;
            // 
            // btnVerifica
            // 
            this.btnVerifica.Location = new System.Drawing.Point(243, 155);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(102, 38);
            this.btnVerifica.TabIndex = 4;
            this.btnVerifica.Text = "Verificar";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(94, 254);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(112, 45);
            this.btnLimpa.TabIndex = 5;
            this.btnLimpa.Text = "Limpar";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnApagaItem
            // 
            this.btnApagaItem.Location = new System.Drawing.Point(94, 326);
            this.btnApagaItem.Name = "btnApagaItem";
            this.btnApagaItem.Size = new System.Drawing.Size(111, 48);
            this.btnApagaItem.TabIndex = 6;
            this.btnApagaItem.Text = "Apaga Item";
            this.btnApagaItem.UseVisualStyleBackColor = true;
            this.btnApagaItem.Click += new System.EventHandler(this.btnApagaItem_Click);
            // 
            // cmbNumeros
            // 
            this.cmbNumeros.FormattingEnabled = true;
            this.cmbNumeros.Location = new System.Drawing.Point(420, 58);
            this.cmbNumeros.Name = "cmbNumeros";
            this.cmbNumeros.Size = new System.Drawing.Size(104, 21);
            this.cmbNumeros.TabIndex = 7;
            this.cmbNumeros.SelectedIndexChanged += new System.EventHandler(this.cmbNumeros_SelectedIndexChanged);
            // 
            // btnPreencher
            // 
            this.btnPreencher.Location = new System.Drawing.Point(420, 12);
            this.btnPreencher.Name = "btnPreencher";
            this.btnPreencher.Size = new System.Drawing.Size(104, 37);
            this.btnPreencher.TabIndex = 8;
            this.btnPreencher.Text = "Preenche ComboBox";
            this.btnPreencher.UseVisualStyleBackColor = true;
            this.btnPreencher.Click += new System.EventHandler(this.btnPreencher_Click);
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(581, 46);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(106, 20);
            this.txtNumeros.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Número Selecionado:";
            // 
            // grpAnimal
            // 
            this.grpAnimal.Controls.Add(this.radioTigre);
            this.grpAnimal.Controls.Add(this.radioLeao);
            this.grpAnimal.Controls.Add(this.radioGirafa);
            this.grpAnimal.Location = new System.Drawing.Point(451, 116);
            this.grpAnimal.Name = "grpAnimal";
            this.grpAnimal.Size = new System.Drawing.Size(117, 157);
            this.grpAnimal.TabIndex = 11;
            this.grpAnimal.TabStop = false;
            this.grpAnimal.Text = "Animal";
            // 
            // radioTigre
            // 
            this.radioTigre.AutoSize = true;
            this.radioTigre.Location = new System.Drawing.Point(26, 111);
            this.radioTigre.Name = "radioTigre";
            this.radioTigre.Size = new System.Drawing.Size(49, 17);
            this.radioTigre.TabIndex = 2;
            this.radioTigre.TabStop = true;
            this.radioTigre.Text = "Tigre";
            this.radioTigre.UseVisualStyleBackColor = true;
            // 
            // radioLeao
            // 
            this.radioLeao.AutoSize = true;
            this.radioLeao.Location = new System.Drawing.Point(26, 71);
            this.radioLeao.Name = "radioLeao";
            this.radioLeao.Size = new System.Drawing.Size(49, 17);
            this.radioLeao.TabIndex = 1;
            this.radioLeao.TabStop = true;
            this.radioLeao.Text = "Leão";
            this.radioLeao.UseVisualStyleBackColor = true;
            // 
            // radioGirafa
            // 
            this.radioGirafa.AutoSize = true;
            this.radioGirafa.Location = new System.Drawing.Point(26, 32);
            this.radioGirafa.Name = "radioGirafa";
            this.radioGirafa.Size = new System.Drawing.Size(53, 17);
            this.radioGirafa.TabIndex = 0;
            this.radioGirafa.TabStop = true;
            this.radioGirafa.Text = "Girafa";
            this.radioGirafa.UseVisualStyleBackColor = true;
            // 
            // btnAnimal
            // 
            this.btnAnimal.Location = new System.Drawing.Point(581, 122);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Size = new System.Drawing.Size(97, 43);
            this.btnAnimal.TabIndex = 12;
            this.btnAnimal.Text = "Escolha Animal";
            this.btnAnimal.UseVisualStyleBackColor = true;
            this.btnAnimal.Click += new System.EventHandler(this.btnAnimal_Click);
            // 
            // picAnimal
            // 
            this.picAnimal.Location = new System.Drawing.Point(451, 290);
            this.picAnimal.Name = "picAnimal";
            this.picAnimal.Size = new System.Drawing.Size(252, 212);
            this.picAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnimal.TabIndex = 13;
            this.picAnimal.TabStop = false;
            this.picAnimal.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnDesmarca
            // 
            this.btnDesmarca.Location = new System.Drawing.Point(584, 227);
            this.btnDesmarca.Name = "btnDesmarca";
            this.btnDesmarca.Size = new System.Drawing.Size(94, 43);
            this.btnDesmarca.TabIndex = 14;
            this.btnDesmarca.Text = "Desmarcar Opções";
            this.btnDesmarca.UseVisualStyleBackColor = true;
            this.btnDesmarca.Click += new System.EventHandler(this.btnDesmarca_Click);
            // 
            // btnLimpaImagem
            // 
            this.btnLimpaImagem.Location = new System.Drawing.Point(595, 177);
            this.btnLimpaImagem.Name = "btnLimpaImagem";
            this.btnLimpaImagem.Size = new System.Drawing.Size(73, 36);
            this.btnLimpaImagem.TabIndex = 15;
            this.btnLimpaImagem.Text = "Limpar Imagem";
            this.btnLimpaImagem.UseVisualStyleBackColor = true;
            this.btnLimpaImagem.Click += new System.EventHandler(this.btnLimpaImagem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnProcuraImagem
            // 
            this.btnProcuraImagem.Location = new System.Drawing.Point(733, 116);
            this.btnProcuraImagem.Name = "btnProcuraImagem";
            this.btnProcuraImagem.Size = new System.Drawing.Size(107, 54);
            this.btnProcuraImagem.TabIndex = 16;
            this.btnProcuraImagem.Text = "Selecionar Imagem do PC...";
            this.btnProcuraImagem.UseVisualStyleBackColor = true;
            this.btnProcuraImagem.Click += new System.EventHandler(this.btnProcuraImagem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 514);
            this.Controls.Add(this.btnProcuraImagem);
            this.Controls.Add(this.btnLimpaImagem);
            this.Controls.Add(this.btnDesmarca);
            this.Controls.Add(this.picAnimal);
            this.Controls.Add(this.btnAnimal);
            this.Controls.Add(this.grpAnimal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.btnPreencher);
            this.Controls.Add(this.cmbNumeros);
            this.Controls.Add(this.btnApagaItem);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstNomes);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpAnimal.ResumeLayout(false);
            this.grpAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstNomes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnApagaItem;
        private System.Windows.Forms.ComboBox cmbNumeros;
        private System.Windows.Forms.Button btnPreencher;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpAnimal;
        private System.Windows.Forms.RadioButton radioTigre;
        private System.Windows.Forms.RadioButton radioLeao;
        private System.Windows.Forms.RadioButton radioGirafa;
        private System.Windows.Forms.Button btnAnimal;
        private System.Windows.Forms.PictureBox picAnimal;
        private System.Windows.Forms.Button btnDesmarca;
        private System.Windows.Forms.Button btnLimpaImagem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnProcuraImagem;
    }
}

