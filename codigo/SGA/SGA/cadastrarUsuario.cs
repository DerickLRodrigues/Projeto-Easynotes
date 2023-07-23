using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic;

namespace SGA
{
    public partial class cadastrarUsuario : Form
    {
        Thread VoltarMenu;
        public cadastrarUsuario()
        {
            InitializeComponent();
        }

        private void voltarMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
            VoltarMenu = new Thread(voltarTelaMenu);
            VoltarMenu.SetApartmentState(ApartmentState.STA);
            VoltarMenu.Start();
        }

        public void voltarTelaMenu(object obj)
        {
            Application.Run(new telaMenuPrincipal());
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
        private void cadastrarUser_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            StreamWriter sw = new StreamWriter("C:\\\\Users\\\\vinic\\\\OneDrive\\\\Área de Trabalho\\\\FACULDADE\\\\Faculdade 2º periodo\\\\AED\\\\SGA\\\\dados\\\\usuarios.txt", true);
            StreamWriter salvarLogins = new StreamWriter("C:\\\\Users\\\\vinic\\\\OneDrive\\\\Área de Trabalho\\\\FACULDADE\\\\Faculdade 2º periodo\\\\AED\\\\SGA\\\\dados\\\\acesso.txt", true);
            sw.WriteLine("#");
            usuario.nome = nomeUsuario.Text;
            sw.WriteLine(nomeUsuario.Text);
            usuario.cpf = cpfUsuario.Text;
            sw.WriteLine(cpfUsuario.Text);
            usuario.materia = materiaUsuario.Text;
            sw.WriteLine(materiaUsuario.Text);
            usuario.nascimento = nascUsuario;
            sw.WriteLine(nascUsuario.Value);
            usuario.sexo = sexoUsuario.Text;
            sw.WriteLine(sexoUsuario.Text);
            usuario.telefone = telefoneUsuario.Text;
            sw.WriteLine(telefoneUsuario.Text);
            salvarLogins.WriteLine("#");
            usuario.login = userLogin.Text;
            sw.WriteLine(userLogin.Text);
            salvarLogins.WriteLine(userLogin.Text);
            usuario.senha = senhaUsuario.Text;
            sw.WriteLine(senhaUsuario.Text);
            salvarLogins.WriteLine(senhaUsuario.Text);
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

        private void nomeUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
