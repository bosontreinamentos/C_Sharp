namespace Acesso_a_BD_com_Windows_Forms_C_sharp
{
    partial class CadastraLivros
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtPrecoLivro = new System.Windows.Forms.TextBox();
            this.cmbIDAutor = new System.Windows.Forms.ComboBox();
            this.cmbIDEditora = new System.Windows.Forms.ComboBox();
            this.dtpDataPub = new System.Windows.Forms.DateTimePicker();
            this.btnCadastraLivro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preencha os campos abaixo para cadastrar um livro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Livro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome do Autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de Publicação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Preço do Livro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nome da Editora";
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.Location = new System.Drawing.Point(144, 62);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(170, 20);
            this.txtNomeLivro.TabIndex = 7;
            this.txtNomeLivro.Click += new System.EventHandler(this.txtNomeLivro_Click);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(144, 96);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(122, 20);
            this.txtISBN.TabIndex = 8;
            // 
            // txtPrecoLivro
            // 
            this.txtPrecoLivro.Location = new System.Drawing.Point(144, 188);
            this.txtPrecoLivro.Name = "txtPrecoLivro";
            this.txtPrecoLivro.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoLivro.TabIndex = 11;
            // 
            // cmbIDAutor
            // 
            this.cmbIDAutor.FormattingEnabled = true;
            this.cmbIDAutor.Location = new System.Drawing.Point(144, 126);
            this.cmbIDAutor.Name = "cmbIDAutor";
            this.cmbIDAutor.Size = new System.Drawing.Size(121, 21);
            this.cmbIDAutor.TabIndex = 12;
            this.cmbIDAutor.SelectedIndexChanged += new System.EventHandler(this.cmbIDAutor_SelectedIndexChanged);
            // 
            // cmbIDEditora
            // 
            this.cmbIDEditora.FormattingEnabled = true;
            this.cmbIDEditora.Location = new System.Drawing.Point(144, 225);
            this.cmbIDEditora.Name = "cmbIDEditora";
            this.cmbIDEditora.Size = new System.Drawing.Size(121, 21);
            this.cmbIDEditora.TabIndex = 13;
            this.cmbIDEditora.SelectedIndexChanged += new System.EventHandler(this.cmbIDEditora_SelectedIndexChanged);
            // 
            // dtpDataPub
            // 
            this.dtpDataPub.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPub.Location = new System.Drawing.Point(144, 159);
            this.dtpDataPub.Name = "dtpDataPub";
            this.dtpDataPub.Size = new System.Drawing.Size(122, 20);
            this.dtpDataPub.TabIndex = 14;
            // 
            // btnCadastraLivro
            // 
            this.btnCadastraLivro.Location = new System.Drawing.Point(122, 296);
            this.btnCadastraLivro.Name = "btnCadastraLivro";
            this.btnCadastraLivro.Size = new System.Drawing.Size(104, 38);
            this.btnCadastraLivro.TabIndex = 15;
            this.btnCadastraLivro.Text = "Cadastrar Livro";
            this.btnCadastraLivro.UseVisualStyleBackColor = true;
            this.btnCadastraLivro.Click += new System.EventHandler(this.button1_Click);
            // 
            // cadastraLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 374);
            this.Controls.Add(this.btnCadastraLivro);
            this.Controls.Add(this.dtpDataPub);
            this.Controls.Add(this.cmbIDEditora);
            this.Controls.Add(this.cmbIDAutor);
            this.Controls.Add(this.txtPrecoLivro);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtNomeLivro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "cadastraLivros";
            this.Text = "cadastraLivros";
            this.Load += new System.EventHandler(this.cadastraLivros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtPrecoLivro;
        private System.Windows.Forms.ComboBox cmbIDAutor;
        private System.Windows.Forms.ComboBox cmbIDEditora;
        private System.Windows.Forms.DateTimePicker dtpDataPub;
        private System.Windows.Forms.Button btnCadastraLivro;
    }
}