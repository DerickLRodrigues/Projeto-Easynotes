using System.Windows.Forms;

namespace Cadastrar_Aluno_forms
{
    partial class Tela_Login
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.logar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.senha_login = new System.Windows.Forms.TextBox();
            this.usuario_login = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.logar);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.senha_login);
            this.panel2.Controls.Add(this.usuario_login);
            this.panel2.Location = new System.Drawing.Point(357, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 545);
            this.panel2.TabIndex = 0;
            // 
            // logar
            // 
            this.logar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(108)))), ((int)(((byte)(229)))));
            this.logar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.logar.ForeColor = System.Drawing.Color.White;
            this.logar.Location = new System.Drawing.Point(119, 430);
            this.logar.Name = "logar";
            this.logar.Size = new System.Drawing.Size(250, 59);
            this.logar.TabIndex = 3;
            this.logar.Text = "Login";
            this.logar.UseVisualStyleBackColor = false;
            this.logar.Click += new System.EventHandler(this.logar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Usuário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 40F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(108)))), ((int)(((byte)(229)))));
            this.label4.Location = new System.Drawing.Point(104, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 89);
            this.label4.TabIndex = 2;
            this.label4.Text = "EasyNotes";
            // 
            // senha_login
            // 
            this.senha_login.Location = new System.Drawing.Point(119, 344);
            this.senha_login.Name = "senha_login";
            this.senha_login.Size = new System.Drawing.Size(250, 27);
            this.senha_login.TabIndex = 5;
            this.senha_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.senha_login.UseSystemPasswordChar = true;
            // 
            // usuario_login
            // 
            this.usuario_login.Location = new System.Drawing.Point(119, 244);
            this.usuario_login.Name = "usuario_login";
            this.usuario_login.Size = new System.Drawing.Size(250, 27);
            this.usuario_login.TabIndex = 0;
            this.usuario_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tela_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(108)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1194, 706);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1212, 753);
            this.Name = "Tela_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyNotes";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private TextBox senhaLogin;
        private Label label3;
        private Button acessar;
        private TextBox usuarioLogin;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button logar;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox senha_login;
        private TextBox usuario_login;
    }
}