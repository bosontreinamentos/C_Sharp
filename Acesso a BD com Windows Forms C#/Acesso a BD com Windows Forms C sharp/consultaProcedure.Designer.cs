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
            this.txtCodLivro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtValorPagar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculaPreco
            // 
            this.btnCalculaPreco.Location = new System.Drawing.Point(116, 174);
            this.btnCalculaPreco.Name = "btnCalculaPreco";
            this.btnCalculaPreco.Size = new System.Drawing.Size(89, 58);
            this.btnCalculaPreco.TabIndex = 0;
            this.btnCalculaPreco.Text = "Calcular Valor a Pagar";
            this.btnCalculaPreco.UseVisualStyleBackColor = true;
            this.btnCalculaPreco.Click += new System.EventHandler(this.btnCalculaPreco_Click);
            // 
            // txtCodLivro
            // 
            this.txtCodLivro.Location = new System.Drawing.Point(175, 71);
            this.txtCodLivro.Name = "txtCodLivro";
            this.txtCodLivro.Size = new System.Drawing.Size(110, 20);
            this.txtCodLivro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o código do Livro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite a Quantidade Adquirida:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(175, 114);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(98, 20);
            this.txtQuantidade.TabIndex = 4;
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.Location = new System.Drawing.Point(175, 273);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.Size = new System.Drawing.Size(110, 20);
            this.txtValorPagar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor a Pagar:";
            // 
            // consultaProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 387);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorPagar);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodLivro);
            this.Controls.Add(this.btnCalculaPreco);
            this.Name = "consultaProcedure";
            this.Text = "consultaProcedure";
            this.Load += new System.EventHandler(this.consultaProcedure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculaPreco;
        private System.Windows.Forms.TextBox txtCodLivro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtValorPagar;
        private System.Windows.Forms.Label label3;
    }
}