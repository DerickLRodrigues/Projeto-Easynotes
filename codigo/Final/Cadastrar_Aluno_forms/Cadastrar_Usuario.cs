using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastrar_Aluno_forms
{
    public partial class Cadastrar_Usuario : Form
    {
        Thread VoltarMenu;
        public Cadastrar_Usuario()
        {
            InitializeComponent();
        }

        public class Usuario
        {
            public string nome;
            public string cpf;
            public string materia;
            public string telefone;
            public DateTimePicker nascimento;
            public string sexo;
            public string login;
            public string senha;
        }

        private void nomeUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            StreamWriter sw = new StreamWriter("usuarios.txt", true);
            StreamWriter salvarLogins = new StreamWriter("acesso.txt", true);
            sw.WriteLine("#");
            usuario.nome = nomeUsuario.Text;
            sw.WriteLine(nomeUsuario.Text);
            usuario.cpf = cpf_usuario.Text;
            sw.WriteLine(cpf_usuario.Text);
            usuario.materia = materia_usuario.Text;
            sw.WriteLine(materia_usuario.Text);
            usuario.nascimento = nascUsuario;
            sw.WriteLine(nascUsuario.Value);
            usuario.sexo = sexoUsuario.Text;
            sw.WriteLine(sexoUsuario.Text);
            usuario.telefone = telefone_Usuario.Text;
            sw.WriteLine(telefone_Usuario.Text);
            salvarLogins.WriteLine("#");
            usuario.login = user_login.Text;
            sw.WriteLine(user_login.Text);
            salvarLogins.WriteLine(user_login.Text);
            usuario.senha = senha_usuario.Text;
            sw.WriteLine(senha_usuario.Text);
            salvarLogins.WriteLine(senha_usuario.Text);
            salvarLogins.WriteLine("#");
            salvarLogins.Close();
            sw.WriteLine("#");
            sw.Close();
            MessageBox.Show("Usuário cadastrado com sucesso!");
            this.Close();
            VoltarMenu = new Thread(voltarTelaMenu);
            VoltarMenu.SetApartmentState(ApartmentState.STA);
            VoltarMenu.Start();
        }

        public void voltarTelaMenu(object obj)
        {
            Application.Run(new Menu_Principal());
        }

        private void voltarMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
            VoltarMenu = new Thread(voltarTelaMenu);
            VoltarMenu.SetApartmentState(ApartmentState.STA);
            VoltarMenu.Start();
        }
    }
}
