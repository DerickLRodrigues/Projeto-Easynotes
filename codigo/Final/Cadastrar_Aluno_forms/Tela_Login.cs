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
    public partial class Tela_Login : Form
    {
        Thread TelaLogin;
        public Tela_Login()
        {
            InitializeComponent();
        }

        public class login
        {
            public string username;
            public string senha;
        }

        static int verificar(string login, string senha)
        {
            string linha;
            int cont = 0;
            StreamReader sr = new StreamReader("acesso.txt");
            linha = sr.ReadLine();

            while (linha != null)
            {
                linha = sr.ReadLine();
                if (linha == login)
                {
                    cont++;
                }
                else if (linha == senha)
                {
                    cont++;
                }
                else
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
        private void logar_Click(object sender, EventArgs e)
        {

             //          INICIALIZAÇÃO SEM VERIFICAÇÃO
           /* Menu_Principal tela = new Menu_Principal();
            this.Close();
            TelaLogin = new Thread(abrirMenu);
            TelaLogin.SetApartmentState(ApartmentState.STA);
            TelaLogin.Start();*/

            //            INICIALIZAÇÃO COM IMPLEMENTAÇÃO CORRETA
            login logar = new login();
            logar.username = usuario_login.Text;
            logar.senha = senha_login.Text;
            if (verificar(logar.username, logar.senha) == 2)
            {
                Menu_Principal tela = new Menu_Principal();
                this.Close();
                TelaLogin = new Thread(abrirMenu);
                TelaLogin.SetApartmentState(ApartmentState.STA);
                TelaLogin.Start();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos");
            }

        }

        private void abrirMenu(object obj)
        {
            Application.Run(new Menu_Principal());
        }
    }
}

