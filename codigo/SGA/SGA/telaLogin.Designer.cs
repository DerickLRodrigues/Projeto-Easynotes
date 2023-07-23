namespace SGA
{
    partial class telaLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.senhaLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.acessar = new System.Windows.Forms.Button();
            this.usuarioLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.senhaLogin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.acessar);
            this.panel1.Controls.Add(this.usuarioLogin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(357, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 545);
            this.panel1.TabIndex = 0;
            // 
            // senhaLogin
            // 
            this.senhaLogin.Location = new System.Drawing.Point(119, 344);
            this.senhaLogin.Name = "senhaLogin";
            this.senhaLogin.Size = new System.Drawing.Size(250, 27);
            this.senhaLogin.TabIndex = 5;
            this.senhaLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.senhaLogin.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha";
            // 
            // acessar
            // 
            this.acessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(108)))), ((int)(((byte)(229)))));
            this.acessar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.acessar.ForeColor = System.Drawing.Color.White;
            this.acessar.Location = new System.Drawing.Point(119, 430);
            this.acessar.Name = "acessar";
            this.acessar.Size = new System.Drawing.Size(250, 59);
            this.acessar.TabIndex = 3;
            this.acessar.Text = "Acessar";
            this.acessar.UseVisualStyleBackColor = false;
            this.acessar.Click += new System.EventHandler(this.acessar_Click);
            // 
            // usuarioLogin
            // 
            this.usuarioLogin.Location = new System.Drawing.Point(119, 244);
            this.usuarioLogin.Name = "usuarioLogin";
            this.usuarioLogin.Size = new System.Drawing.Size(250, 27);
            this.usuarioLogin.TabIndex = 2;
            this.usuarioLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(108)))), ((int)(((byte)(229)))));
            this.label1.Location = new System.Drawing.Point(159, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "S.G.A";
            // 
            // telaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(108)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1194, 706);
            this.Controls.Add(this.panel1);
            this.Name = "telaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGA - Sistema de Gestão Acadêmica";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}