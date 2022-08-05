namespace Acesso_a_BD_com_Windows_Forms_C_sharp
{
    partial class cadastro
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
            this.txtIDAutor = new System.Windows.Forms.TextBox();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.txtSobrenomeAutor = new System.Windows.Forms.TextBox();
            this.btnCadastraAutor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preencha os campos abaixo e clique em \"Cadastrar\" para inserir um novo autor.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID do Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome do Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sobrenome do Autor";
            // 
            // txtIDAutor
            // 
            this.txtIDAutor.Location = new System.Drawing.Point(159, 68);
            this.txtIDAutor.Name = "txtIDAutor";
            this.txtIDAutor.Size = new System.Drawing.Size(100, 20);
            this.txtIDAutor.TabIndex = 4;
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Location = new System.Drawing.Point(159, 113);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(100, 20);
            this.txtNomeAutor.TabIndex = 5;
            // 
            // txtSobrenomeAutor
            // 
            this.txtSobrenomeAutor.Location = new System.Drawing.Point(159, 159);
            this.txtSobrenomeAutor.Name = "txtSobrenomeAutor";
            this.txtSobrenomeAutor.Size = new System.Drawing.Size(100, 20);
            this.txtSobrenomeAutor.TabIndex = 6;
            // 
            // btnCadastraAutor
            // 
            this.btnCadastraAutor.Location = new System.Drawing.Point(98, 223);
            this.btnCadastraAutor.Name = "btnCadastraAutor";
            this.btnCadastraAutor.Size = new System.Drawing.Size(107, 34);
            this.btnCadastraAutor.TabIndex = 7;
            this.btnCadastraAutor.Text = "Cadastrar Autor";
            this.btnCadastraAutor.UseVisualStyleBackColor = true;
            this.btnCadastraAutor.Click += new System.EventHandler(this.btnCadastraAutor_Click);
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 345);
            this.Controls.Add(this.btnCadastraAutor);
            this.Controls.Add(this.txtSobrenomeAutor);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.txtIDAutor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "cadastro";
            this.Text = "Cadastro de Autores";
            this.Load += new System.EventHandler(this.cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDAutor;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.TextBox txtSobrenomeAutor;
        private System.Windows.Forms.Button btnCadastraAutor;
    }
}