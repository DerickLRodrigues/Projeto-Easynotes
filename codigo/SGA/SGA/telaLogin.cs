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

namespace SGA
{
    
    public partial class telaLogin : Form
    {
        Thread TelaLogin;
        public telaLogin()
        {
            InitializeComponent();
        }

        public class login
        {
            public string username;
            public string senha;
        }

        static int verificar(string login,string senha)
        {
            string linha;
            int cont = 0;
            StreamReader sr = new StreamReader("C:\\\\Users\\\\vinic\\\\OneDrive\\\\Área de Trabalho\\\\FACULDADE\\\\Faculdade 2º periodo\\\\AED\\\\SGA\\\\dados\\\\usuarios.txt");
            linha = sr.ReadLine();

            while (linha != null)
            {
                linha = sr.ReadLine();
                if (linha == login)
                {
                    cont++;
                }
                else if(linha == senha)
                {
                    cont++;
                } else
                {
                    cont = 0;
                }
                if (cont == 2)
                {
                    break;
                }
            }

            sr.Close();
            return cont;
        }
        private void acessar_Click(object sender, EventArgs e)
        {

            //            INICIALIZAÇÃO SEM VERIFICAÇÃO
            telaMenuPrincipal tela = new telaMenuPrincipal();
            this.Close();
            TelaLogin = new Thread(abrirMenu);
            TelaLogin.SetApartmentState(ApartmentState.STA);
            TelaLogin.Start();

            //            INICIALIZAÇÃO COM VERIFICAÇÃO SIMPLES
            //login logar = new login();
            //logar.username = usuarioLogin.Text;
            //logar.senha = senhaLogin.Text;
            //if (logar.username == "admin" && logar.senha == "1234")
            //{
            //    telaMenuPrincipal tela = new telaMenuPrincipal();
            //    this.Close();
            //    TelaLogin = new Thread(abrirMenu);
            //    TelaLogin.SetApartmentState(ApartmentState.STA);
            //    TelaLogin.Start();
            //}
            //else
            //{
            //    MessageBox.Show("Usuário ou senha incorretos");
            //}

            //            INICIALIZAÇÃO COM IMPLEMENTAÇÃO CORRETA
            //login logar = new login();
            //logar.username = usuarioLogin.Text;
            //logar.senha = senhaLogin.Text;
            //if (verificar(logar.username, logar.senha) == 2)
            //{
            //    telaMenuPrincipal tela = new telaMenuPrincipal();
            //    this.Close();
            //    TelaLogin = new Thread(abrirMenu);
            //    TelaLogin.SetApartmentState(ApartmentState.STA);
            //    TelaLogin.Start();
            //}
            //else
            //{
            //    MessageBox.Show("Usuário ou senha incorretos");
            //}

        }

        private void abrirMenu(object obj)
        {
            Application.Run(new telaMenuPrincipal());
        }
    }
}
