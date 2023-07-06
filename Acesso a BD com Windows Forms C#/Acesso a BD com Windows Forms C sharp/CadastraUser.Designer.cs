namespace Acesso_a_BD_com_Windows_Forms_C_sharp
{
    partial class CadastraUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastraUser = new System.Windows.Forms.Button();
            this.txtCadastraSenha = new System.Windows.Forms.TextBox();
            this.txtCadastraNome = new System.Windows.Forms.TextBox();
            this.lblConfirmaSenha = new System.Windows.Forms.Label();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.btnExibeOcultaSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Digite a senha desejada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Digite o Nome de Usuário desejado:";
            // 
            // btnCadastraUser
            // 
            this.btnCadastraUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastraUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCadastraUser.Location = new System.Drawing.Point(79, 221);
            this.btnCadastraUser.Name = "btnCadastraUser";
            this.btnCadastraUser.Size = new System.Drawing.Size(99, 63);
            this.btnCadastraUser.TabIndex = 7;
            this.btnCadastraUser.Text = "Cadastrar Usuário";
            this.btnCadastraUser.UseVisualStyleBackColor = true;
            this.btnCadastraUser.Click += new System.EventHandler(this.btnCadastraUser_Click);
            // 
            // txtCadastraSenha
            // 
            this.txtCadastraSenha.Location = new System.Drawing.Point(57, 108);
            this.txtCadastraSenha.Name = "txtCadastraSenha";
            this.txtCadastraSenha.PasswordChar = '*';
            this.txtCadastraSenha.Size = new System.Drawing.Size(139, 20);
            this.txtCadastraSenha.TabIndex = 6;
            // 
            // txtCadastraNome
            // 
            this.txtCadastraNome.Location = new System.Drawing.Point(57, 49);
            this.txtCadastraNome.Name = "txtCadastraNome";
            this.txtCadastraNome.Size = new System.Drawing.Size(139, 20);
            this.txtCadastraNome.TabIndex = 5;
            // 
            // lblConfirmaSenha
            // 
            this.lblConfirmaSenha.AutoSize = true;
            this.lblConfirmaSenha.Location = new System.Drawing.Point(54, 154);
            this.lblConfirmaSenha.Name = "lblConfirmaSenha";
            this.lblConfirmaSenha.Size = new System.Drawing.Size(152, 13);
            this.lblConfirmaSenha.TabIndex = 10;
            this.lblConfirmaSenha.Text = "Repita a senha para confirmar:";
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Location = new System.Drawing.Point(57, 170);
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.PasswordChar = '*';
            this.txtConfirmaSenha.Size = new System.Drawing.Size(139, 20);
            this.txtConfirmaSenha.TabIndex = 11;
            // 
            // btnExibeOcultaSenha
            // 
            this.btnExibeOcultaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibeOcultaSenha.Location = new System.Drawing.Point(231, 95);
            this.btnExibeOcultaSenha.Name = "btnExibeOcultaSenha";
            this.btnExibeOcultaSenha.Size = new System.Drawing.Size(104, 44);
            this.btnExibeOcultaSenha.TabIndex = 12;
            this.btnExibeOcultaSenha.Text = "Exibir Senha";
            this.btnExibeOcultaSenha.UseVisualStyleBackColor = true;
            this.btnExibeOcultaSenha.Click += new System.EventHandler(this.btnExibeOcultaSenha_Click);
            // 
            // CadastraUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 325);
            this.Controls.Add(this.btnExibeOcultaSenha);
            this.Controls.Add(this.txtConfirmaSenha);
            this.Controls.Add(this.lblConfirmaSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastraUser);
            this.Controls.Add(this.txtCadastraSenha);
            this.Controls.Add(this.txtCadastraNome);
            this.Name = "CadastraUser";
            this.Text = "CadastraUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastraUser;
        private System.Windows.Forms.TextBox txtCadastraSenha;
        private System.Windows.Forms.TextBox txtCadastraNome;
        private System.Windows.Forms.Label lblConfirmaSenha;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.Button btnExibeOcultaSenha;
    }
}