namespace Acesso_a_BD_com_Windows_Forms_C_sharp
{
    partial class ConsultaAutorEditora
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
            this.tabCadastraAutoresEditoras = new System.Windows.Forms.TabControl();
            this.tabAutores = new System.Windows.Forms.TabPage();
            this.tabEditoras = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodAutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.txtSobrenomeAutor = new System.Windows.Forms.TextBox();
            this.btnConsultaAutor = new System.Windows.Forms.Button();
            this.btnConsultaEditoras = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeEditora = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCodEditora = new System.Windows.Forms.ComboBox();
            this.tabCadastraAutoresEditoras.SuspendLayout();
            this.tabAutores.SuspendLayout();
            this.tabEditoras.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCadastraAutoresEditoras
            // 
            this.tabCadastraAutoresEditoras.Controls.Add(this.tabAutores);
            this.tabCadastraAutoresEditoras.Controls.Add(this.tabEditoras);
            this.tabCadastraAutoresEditoras.Location = new System.Drawing.Point(27, 28);
            this.tabCadastraAutoresEditoras.Name = "tabCadastraAutoresEditoras";
            this.tabCadastraAutoresEditoras.SelectedIndex = 0;
            this.tabCadastraAutoresEditoras.Size = new System.Drawing.Size(324, 361);
            this.tabCadastraAutoresEditoras.TabIndex = 0;
            // 
            // tabAutores
            // 
            this.tabAutores.Controls.Add(this.btnConsultaAutor);
            this.tabAutores.Controls.Add(this.txtSobrenomeAutor);
            this.tabAutores.Controls.Add(this.txtNomeAutor);
            this.tabAutores.Controls.Add(this.label3);
            this.tabAutores.Controls.Add(this.label2);
            this.tabAutores.Controls.Add(this.txtCodAutor);
            this.tabAutores.Controls.Add(this.label1);
            this.tabAutores.Location = new System.Drawing.Point(4, 22);
            this.tabAutores.Name = "tabAutores";
            this.tabAutores.Padding = new System.Windows.Forms.Padding(3);
            this.tabAutores.Size = new System.Drawing.Size(316, 335);
            this.tabAutores.TabIndex = 0;
            this.tabAutores.Text = "Autores";
            this.tabAutores.UseVisualStyleBackColor = true;
            // 
            // tabEditoras
            // 
            this.tabEditoras.Controls.Add(this.cmbCodEditora);
            this.tabEditoras.Controls.Add(this.label5);
            this.tabEditoras.Controls.Add(this.txtNomeEditora);
            this.tabEditoras.Controls.Add(this.label4);
            this.tabEditoras.Controls.Add(this.btnConsultaEditoras);
            this.tabEditoras.Location = new System.Drawing.Point(4, 22);
            this.tabEditoras.Name = "tabEditoras";
            this.tabEditoras.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditoras.Size = new System.Drawing.Size(316, 335);
            this.tabEditoras.TabIndex = 1;
            this.tabEditoras.Text = "Editoras";
            this.tabEditoras.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Código do Autor";
            // 
            // txtCodAutor
            // 
            this.txtCodAutor.Location = new System.Drawing.Point(162, 21);
            this.txtCodAutor.Name = "txtCodAutor";
            this.txtCodAutor.Size = new System.Drawing.Size(100, 20);
            this.txtCodAutor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sobrenome do Autor";
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Location = new System.Drawing.Point(162, 133);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(100, 20);
            this.txtNomeAutor.TabIndex = 4;
            // 
            // txtSobrenomeAutor
            // 
            this.txtSobrenomeAutor.Location = new System.Drawing.Point(162, 168);
            this.txtSobrenomeAutor.Name = "txtSobrenomeAutor";
            this.txtSobrenomeAutor.Size = new System.Drawing.Size(100, 20);
            this.txtSobrenomeAutor.TabIndex = 5;
            // 
            // btnConsultaAutor
            // 
            this.btnConsultaAutor.Location = new System.Drawing.Point(110, 73);
            this.btnConsultaAutor.Name = "btnConsultaAutor";
            this.btnConsultaAutor.Size = new System.Drawing.Size(86, 38);
            this.btnConsultaAutor.TabIndex = 6;
            this.btnConsultaAutor.Text = "Consultar";
            this.btnConsultaAutor.UseVisualStyleBackColor = true;
            this.btnConsultaAutor.Click += new System.EventHandler(this.btnConsultaAutor_Click);
            // 
            // btnConsultaEditoras
            // 
            this.btnConsultaEditoras.Location = new System.Drawing.Point(108, 163);
            this.btnConsultaEditoras.Name = "btnConsultaEditoras";
            this.btnConsultaEditoras.Size = new System.Drawing.Size(90, 41);
            this.btnConsultaEditoras.TabIndex = 0;
            this.btnConsultaEditoras.Text = "Consultar";
            this.btnConsultaEditoras.UseVisualStyleBackColor = true;
            this.btnConsultaEditoras.Click += new System.EventHandler(this.btnConsultaEditoras_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Selecione o Código da Editora para Consulta:";
            // 
            // txtNomeEditora
            // 
            this.txtNomeEditora.Location = new System.Drawing.Point(153, 247);
            this.txtNomeEditora.Name = "txtNomeEditora";
            this.txtNomeEditora.Size = new System.Drawing.Size(137, 20);
            this.txtNomeEditora.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nome da Editora:";
            // 
            // cmbCodEditora
            // 
            this.cmbCodEditora.FormattingEnabled = true;
            this.cmbCodEditora.Location = new System.Drawing.Point(106, 44);
            this.cmbCodEditora.Name = "cmbCodEditora";
            this.cmbCodEditora.Size = new System.Drawing.Size(121, 21);
            this.cmbCodEditora.TabIndex = 5;
            // 
            // ConsultaAutorEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 471);
            this.Controls.Add(this.tabCadastraAutoresEditoras);
            this.Name = "ConsultaAutorEditora";
            this.Text = "ConsultaAutorEditora";
            this.Load += new System.EventHandler(this.ConsultaAutorEditora_Load);
            this.tabCadastraAutoresEditoras.ResumeLayout(false);
            this.tabAutores.ResumeLayout(false);
            this.tabAutores.PerformLayout();
            this.tabEditoras.ResumeLayout(false);
            this.tabEditoras.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCadastraAutoresEditoras;
        private System.Windows.Forms.TabPage tabAutores;
        private System.Windows.Forms.TabPage tabEditoras;
        private System.Windows.Forms.Button btnConsultaAutor;
        private System.Windows.Forms.TextBox txtSobrenomeAutor;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultaEditoras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCodEditora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeEditora;
    }
}