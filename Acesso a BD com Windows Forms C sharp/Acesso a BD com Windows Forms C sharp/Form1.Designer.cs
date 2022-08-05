namespace Acesso_a_BD_com_Windows_Forms_C_sharp
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
            this.btnConsulta = new System.Windows.Forms.Button();
            this.txtCodLivro = new System.Windows.Forms.TextBox();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.txtPrecoLivro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLivros = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editorasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosEmGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preçoTotalcomProceduresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(130, 85);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(90, 47);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // txtCodLivro
            // 
            this.txtCodLivro.Location = new System.Drawing.Point(130, 36);
            this.txtCodLivro.Name = "txtCodLivro";
            this.txtCodLivro.Size = new System.Drawing.Size(100, 20);
            this.txtCodLivro.TabIndex = 1;
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Location = new System.Drawing.Point(130, 212);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(133, 20);
            this.txtNomeAutor.TabIndex = 2;
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.Location = new System.Drawing.Point(130, 172);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(133, 20);
            this.txtNomeLivro.TabIndex = 3;
            // 
            // txtPrecoLivro
            // 
            this.txtPrecoLivro.Location = new System.Drawing.Point(130, 256);
            this.txtPrecoLivro.Name = "txtPrecoLivro";
            this.txtPrecoLivro.Size = new System.Drawing.Size(133, 20);
            this.txtPrecoLivro.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite o código do Livro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome do Livro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome do Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Preço do Livro:";
            // 
            // cmbLivros
            // 
            this.cmbLivros.FormattingEnabled = true;
            this.cmbLivros.Location = new System.Drawing.Point(371, 52);
            this.cmbLivros.Name = "cmbLivros";
            this.cmbLivros.Size = new System.Drawing.Size(247, 21);
            this.cmbLivros.TabIndex = 9;
            this.cmbLivros.SelectedIndexChanged += new System.EventHandler(this.cmbLivros_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Livros Disponíveis:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Escolha um livro no combobox para consultá-lo.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoresToolStripMenuItem,
            this.editorasToolStripMenuItem,
            this.livrosToolStripMenuItem,
            this.usuáriosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.autoresToolStripMenuItem.Text = "Autores";
            this.autoresToolStripMenuItem.Click += new System.EventHandler(this.autoresToolStripMenuItem_Click);
            // 
            // editorasToolStripMenuItem
            // 
            this.editorasToolStripMenuItem.Name = "editorasToolStripMenuItem";
            this.editorasToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.editorasToolStripMenuItem.Text = "Editoras";
            this.editorasToolStripMenuItem.Click += new System.EventHandler(this.editorasToolStripMenuItem_Click);
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.livrosToolStripMenuItem.Text = "Livros";
            this.livrosToolStripMenuItem.Click += new System.EventHandler(this.livrosToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoresToolStripMenuItem1,
            this.editorasToolStripMenuItem1,
            this.livrosEmGridToolStripMenuItem,
            this.preçoTotalcomProceduresToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // autoresToolStripMenuItem1
            // 
            this.autoresToolStripMenuItem1.Name = "autoresToolStripMenuItem1";
            this.autoresToolStripMenuItem1.Size = new System.Drawing.Size(229, 22);
            this.autoresToolStripMenuItem1.Text = "Autores";
            this.autoresToolStripMenuItem1.Click += new System.EventHandler(this.autoresToolStripMenuItem1_Click);
            // 
            // editorasToolStripMenuItem1
            // 
            this.editorasToolStripMenuItem1.Name = "editorasToolStripMenuItem1";
            this.editorasToolStripMenuItem1.Size = new System.Drawing.Size(229, 22);
            this.editorasToolStripMenuItem1.Text = "Editoras";
            this.editorasToolStripMenuItem1.Click += new System.EventHandler(this.editorasToolStripMenuItem1_Click);
            // 
            // livrosEmGridToolStripMenuItem
            // 
            this.livrosEmGridToolStripMenuItem.Name = "livrosEmGridToolStripMenuItem";
            this.livrosEmGridToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.livrosEmGridToolStripMenuItem.Text = "Livros em Grid";
            this.livrosEmGridToolStripMenuItem.Click += new System.EventHandler(this.livrosEmGridToolStripMenuItem_Click);
            // 
            // preçoTotalcomProceduresToolStripMenuItem
            // 
            this.preçoTotalcomProceduresToolStripMenuItem.Name = "preçoTotalcomProceduresToolStripMenuItem";
            this.preçoTotalcomProceduresToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.preçoTotalcomProceduresToolStripMenuItem.Text = "Preço Total (com Procedures)";
            this.preçoTotalcomProceduresToolStripMenuItem.Click += new System.EventHandler(this.preçoTotalcomProceduresToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 367);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbLivros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecoLivro);
            this.Controls.Add(this.txtNomeLivro);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.txtCodLivro);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.TextBox txtCodLivro;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.TextBox txtPrecoLivro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLivros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editorasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem livrosEmGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preçoTotalcomProceduresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
    }
}

