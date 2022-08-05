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
            this.lblRepeteSenha = new System.Windows.Forms.Label();
            this.txtRepeteSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 95);
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
            this.btnCadastraUser.Location = new System.Drawing.Point(104, 230);
            this.btnCadastraUser.Name = "btnCadastraUser";
            this.btnCadastraUser.Size = new System.Drawing.Size(74, 47);
            this.btnCadastraUser.TabIndex = 7;
            this.btnCadastraUser.Text = "Cadastrar Usuário";
            this.btnCadastraUser.UseVisualStyleBackColor = true;
            this.btnCadastraUser.Click += new System.EventHandler(this.btnCadastraUser_Click);
            // 
            // txtCadastraSenha
            // 
            this.txtCadastraSenha.Location = new System.Drawing.Point(57, 111);
            this.txtCadastraSenha.Name = "txtCadastraSenha";
            this.txtCadastraSenha.PasswordChar = '*';
            this.txtCadastraSenha.Size = new System.Drawing.Size(174, 20);
            this.txtCadastraSenha.TabIndex = 6;
            // 
            // txtCadastraNome
            // 
            this.txtCadastraNome.Location = new System.Drawing.Point(57, 49);
            this.txtCadastraNome.Name = "txtCadastraNome";
            this.txtCadastraNome.Size = new System.Drawing.Size(174, 20);
            this.txtCadastraNome.TabIndex = 5;
            // 
            // lblRepeteSenha
            // 
            this.lblRepeteSenha.AutoSize = true;
            this.lblRepeteSenha.Location = new System.Drawing.Point(57, 158);
            this.lblRepeteSenha.Name = "lblRepeteSenha";
            this.lblRepeteSenha.Size = new System.Drawing.Size(82, 13);
            this.lblRepeteSenha.TabIndex = 10;
            this.lblRepeteSenha.Text = "Repita a senha:";
            // 
            // txtRepeteSenha
            // 
            this.txtRepeteSenha.Location = new System.Drawing.Point(57, 174);
            this.txtRepeteSenha.Name = "txtRepeteSenha";
            this.txtRepeteSenha.PasswordChar = '*';
            this.txtRepeteSenha.Size = new System.Drawing.Size(174, 20);
            this.txtRepeteSenha.TabIndex = 11;
            // 
            // CadastraUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 301);
            this.Controls.Add(this.txtRepeteSenha);
            this.Controls.Add(this.lblRepeteSenha);
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
        private System.Windows.Forms.Label lblRepeteSenha;
        private System.Windows.Forms.TextBox txtRepeteSenha;
    }
}