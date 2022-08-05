namespace Acesso_a_BD_com_Windows_Forms_C_sharp
{
    partial class cadastraEditoras
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
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.btnCadastraEditora = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da Editora";
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(122, 72);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(171, 20);
            this.txtEditora.TabIndex = 1;
            // 
            // btnCadastraEditora
            // 
            this.btnCadastraEditora.Location = new System.Drawing.Point(109, 125);
            this.btnCadastraEditora.Name = "btnCadastraEditora";
            this.btnCadastraEditora.Size = new System.Drawing.Size(100, 50);
            this.btnCadastraEditora.TabIndex = 2;
            this.btnCadastraEditora.Text = "Cadastrar Editora";
            this.btnCadastraEditora.UseVisualStyleBackColor = true;
            this.btnCadastraEditora.Click += new System.EventHandler(this.btnCadastraEditora_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite abaixo o nome da Editora para cadastrar:";
            // 
            // cadastraEditoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 222);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCadastraEditora);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.label1);
            this.Name = "cadastraEditoras";
            this.Text = "Cadastrar Editoras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.Button btnCadastraEditora;
        private System.Windows.Forms.Label label2;
    }
}