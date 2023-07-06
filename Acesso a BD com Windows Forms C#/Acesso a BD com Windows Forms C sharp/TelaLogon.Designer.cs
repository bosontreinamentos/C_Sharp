namespace Acesso_a_BD_com_Windows_Forms_C_sharp
{
    partial class TelaLogon
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
            this.btnLogon = new System.Windows.Forms.Button();
            this.txtLogonSenha = new System.Windows.Forms.TextBox();
            this.txtLogonUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogon
            // 
            this.btnLogon.Location = new System.Drawing.Point(232, 185);
            this.btnLogon.Name = "btnLogon";
            this.btnLogon.Size = new System.Drawing.Size(82, 47);
            this.btnLogon.TabIndex = 5;
            this.btnLogon.Text = "Entrar";
            this.btnLogon.UseVisualStyleBackColor = true;
            this.btnLogon.Click += new System.EventHandler(this.btnLogon_Click);
            // 
            // txtLogonSenha
            // 
            this.txtLogonSenha.Location = new System.Drawing.Point(210, 126);
            this.txtLogonSenha.Name = "txtLogonSenha";
            this.txtLogonSenha.PasswordChar = '*';
            this.txtLogonSenha.Size = new System.Drawing.Size(124, 20);
            this.txtLogonSenha.TabIndex = 6;
            // 
            // txtLogonUser
            // 
            this.txtLogonUser.Location = new System.Drawing.Point(210, 54);
            this.txtLogonUser.Name = "txtLogonUser";
            this.txtLogonUser.Size = new System.Drawing.Size(124, 20);
            this.txtLogonUser.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Digite o Nome do Usuário para Logon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Digite a senha do usuário:";
            // 
            // TelaLogon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 317);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLogonUser);
            this.Controls.Add(this.txtLogonSenha);
            this.Controls.Add(this.btnLogon);
            this.Name = "TelaLogon";
            this.Text = "Efetuar Logon no Sistema";
            this.Load += new System.EventHandler(this.TelaLogon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogon;
        private System.Windows.Forms.TextBox txtLogonSenha;
        private System.Windows.Forms.TextBox txtLogonUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}