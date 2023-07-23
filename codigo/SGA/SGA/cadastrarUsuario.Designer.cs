namespace SGA
{
    partial class cadastrarUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nomeUsuario = new System.Windows.Forms.TextBox();
            this.cpfUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.materiaUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.userLogin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.senhaUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.telefoneUsuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cadastrarUser = new System.Windows.Forms.Button();
            this.voltarMenuButton = new System.Windows.Forms.Button();
            this.nascUsuario = new System.Windows.Forms.DateTimePicker();
            this.sexoUsuario = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(108)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-9, -8);
            this.panel1.MaximumSize = new System.Drawing.Size(1232, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 97);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(480, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Usuário";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(108)))), ((int)(((byte)(229)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-21, 650);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1256, 67);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(459, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sistema de Gestão Acadêmica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(269, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome";
            // 
            // nomeUsuario
            // 
            this.nomeUsuario.BackColor = System.Drawing.Color.Silver;
            this.nomeUsuario.Location = new System.Drawing.Point(269, 181);
            this.nomeUsuario.Name = "nomeUsuario";
            this.nomeUsuario.Size = new System.Drawing.Size(261, 27);
            this.nomeUsuario.TabIndex = 4;
            this.nomeUsuario.TextChanged += new System.EventHandler(this.nomeUsuario_TextChanged);
            // 
            // cpfUsuario
            // 
            this.cpfUsuario.BackColor = System.Drawing.Color.Silver;
            this.cpfUsuario.Location = new System.Drawing.Point(269, 257);
            this.cpfUsuario.Name = "cpfUsuario";
            this.cpfUsuario.Size = new System.Drawing.Size(261, 27);
            this.cpfUsuario.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(269, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "CPF";
            // 
            // materiaUsuario
            // 
            this.materiaUsuario.BackColor = System.Drawing.Color.Silver;
            this.materiaUsuario.Location = new System.Drawing.Point(269, 333);
            this.materiaUsuario.Name = "materiaUsuario";
            this.materiaUsuario.Size = new System.Drawing.Size(261, 27);
            this.materiaUsuario.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(269, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Matéria";
            // 
            // userLogin
            // 
            this.userLogin.BackColor = System.Drawing.Color.Silver;
            this.userLogin.Location = new System.Drawing.Point(269, 414);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(261, 27);
            this.userLogin.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(269, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Usuário";
            // 
            // senhaUsuario
            // 
            this.senhaUsuario.BackColor = System.Drawing.Color.Silver;
            this.senhaUsuario.Location = new System.Drawing.Point(652, 414);
            this.senhaUsuario.Name = "senhaUsuario";
            this.senhaUsuario.Size = new System.Drawing.Size(261, 27);
            this.senhaUsuario.TabIndex = 18;
            this.senhaUsuario.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(108)))), ((int)(((byte)(229)))));
            this.label7.Location = new System.Drawing.Point(652, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Senha";
            // 
            // telefoneUsuario
            // 
            this.telefoneUsuario.BackColor = System.Drawing.Color.Silver;
            this.telefoneUsuario.Location = new System.Drawing.Point(652, 333);
            this.telefoneUsuario.Name = "telefoneUsuario";
            this.telefoneUsuario.Size = new System.Drawing.Size(261, 27);
            this.telefoneUsuario.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(108)))), ((int)(((byte)(229)))));
            this.label8.Location = new System.Drawing.Point(652, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Telefone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(108)))), ((int)(((byte)(229)))));
            this.label9.Location = new System.Drawing.Point(652, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "Sexo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(108)))), ((int)(((byte)(229)))));
            this.label10.Location = new System.Drawing.Point(652, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 23);
            this.label10.TabIndex = 11;
            this.label10.Text = "Dt.Nascimento";
            // 
            // cadastrarUser
            // 
            this.cadastrarUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(108)))), ((int)(((byte)(229)))));
            this.cadastrarUser.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cadastrarUser.ForeColor = System.Drawing.Color.White;
            this.cadastrarUser.Location = new System.Drawing.Point(471, 507);
            this.cadastrarUser.Name = "cadastrarUser";
            this.cadastrarUser.Size = new System.Drawing.Size(238, 71);
            this.cadastrarUser.TabIndex = 19;
            this.cadastrarUser.Text = "Cadastrar";
            this.cadastrarUser.UseVisualStyleBackColor = false;
            this.cadastrarUser.Click += new System.EventHandler(this.cadastrarUser_Click);
            // 
            // voltarMenuButton
            // 
            this.voltarMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(108)))), ((int)(((byte)(229)))));
            this.voltarMenuButton.ForeColor = System.Drawing.Color.White;
            this.voltarMenuButton.Location = new System.Drawing.Point(63, 549);
            this.voltarMenuButton.Name = "voltarMenuButton";
            this.voltarMenuButton.Size = new System.Drawing.Size(94, 29);
            this.voltarMenuButton.TabIndex = 20;
            this.voltarMenuButton.Text = "Voltar";
            this.voltarMenuButton.UseVisualStyleBackColor = false;
            this.voltarMenuButton.Click += new System.EventHandler(this.voltarMenuButton_Click);
            // 
            // nascUsuario
            // 
            this.nascUsuario.Location = new System.Drawing.Point(652, 181);
            this.nascUsuario.Name = "nascUsuario";
            this.nascUsuario.Size = new System.Drawing.Size(250, 27);
            this.nascUsuario.TabIndex = 23;
            // 
            // sexoUsuario
            // 
            this.sexoUsuario.AllowDrop = true;
            this.sexoUsuario.FormattingEnabled = true;
            this.sexoUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sexoUsuario.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.sexoUsuario.Location = new System.Drawing.Point(652, 257);
            this.sexoUsuario.Name = "sexoUsuario";
            this.sexoUsuario.Size = new System.Drawing.Size(151, 28);
            this.sexoUsuario.TabIndex = 25;
            // 
            // cadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1194, 706);
            this.Controls.Add(this.sexoUsuario);
            this.Controls.Add(this.nascUsuario);
            this.Controls.Add(this.voltarMenuButton);
            this.Controls.Add(this.cadastrarUser);
            this.Controls.Add(this.senhaUsuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.telefoneUsuario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.userLogin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.materiaUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cpfUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nomeUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(108)))), ((int)(((byte)(229)))));
            this.MaximumSize = new System.Drawing.Size(1212, 753);
            this.Name = "cadastrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGA - Sistema de Gestão Acadêmica";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private TextBox nomeUsuario;
        private TextBox cpfUsuario;
        private Label label4;
        private TextBox materiaUsuario;
        private Label label5;
        private TextBox userLogin;
        private Label label6;
        private TextBox senhaUsuario;
        private Label label7;
        private TextBox telefoneUsuario;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button cadastrarUser;
        private Button voltarMenuButton;
        private DateTimePicker nascUsuario;
        private ComboBox sexoUsuario;
    }
}