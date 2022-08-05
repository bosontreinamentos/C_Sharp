namespace Acesso_a_BD_com_Windows_Forms_C_sharp
{
    partial class consultaProcedure
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
            this.btnCalculaPreco = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorPagar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLivroSelecionado = new System.Windows.Forms.Label();
            this.cmbCodLivro = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculaPreco
            // 
            this.btnCalculaPreco.Location = new System.Drawing.Point(116, 225);
            this.btnCalculaPreco.Name = "btnCalculaPreco";
            this.btnCalculaPreco.Size = new System.Drawing.Size(89, 58);
            this.btnCalculaPreco.TabIndex = 0;
            this.btnCalculaPreco.Text = "Calcular Valor a Pagar";
            this.btnCalculaPreco.UseVisualStyleBackColor = true;
            this.btnCalculaPreco.Click += new System.EventHandler(this.btnCalculaPreco_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione o código do Livro:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantidade Adquirida:";
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPagar.Location = new System.Drawing.Point(158, 319);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.Size = new System.Drawing.Size(110, 26);
            this.txtValorPagar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor a Pagar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Livro selecionado:";
            // 
            // lblLivroSelecionado
            // 
            this.lblLivroSelecionado.AutoSize = true;
            this.lblLivroSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivroSelecionado.ForeColor = System.Drawing.Color.Red;
            this.lblLivroSelecionado.Location = new System.Drawing.Point(172, 117);
            this.lblLivroSelecionado.Name = "lblLivroSelecionado";
            this.lblLivroSelecionado.Size = new System.Drawing.Size(57, 20);
            this.lblLivroSelecionado.TabIndex = 8;
            this.lblLivroSelecionado.Text = "label5";
            // 
            // cmbCodLivro
            // 
            this.cmbCodLivro.FormattingEnabled = true;
            this.cmbCodLivro.Location = new System.Drawing.Point(175, 68);
            this.cmbCodLivro.Name = "cmbCodLivro";
            this.cmbCodLivro.Size = new System.Drawing.Size(121, 21);
            this.cmbCodLivro.TabIndex = 9;
            this.cmbCodLivro.SelectedIndexChanged += new System.EventHandler(this.cmbCodLivro_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(94, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Compra de Livros";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(175, 159);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(79, 26);
            this.numericUpDown1.TabIndex = 11;
            // 
            // consultaProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 400);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCodLivro);
            this.Controls.Add(this.lblLivroSelecionado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorPagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculaPreco);
            this.Name = "consultaProcedure";
            this.Text = "consultaProcedure";
            this.Load += new System.EventHandler(this.consultaProcedure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculaPreco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorPagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLivroSelecionado;
        private System.Windows.Forms.ComboBox cmbCodLivro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}