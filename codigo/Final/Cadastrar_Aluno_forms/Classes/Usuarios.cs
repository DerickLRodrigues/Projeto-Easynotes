using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastrar_Aluno_forms.Classes
{
    internal class Usuarios
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string Materia { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public string Matricula { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        static List<Usuarios> usuarios = new List<Usuarios>();

        public Usuarios(string nome, string cpf, string materia, DateTime dataNascimento, string sexo, string telefone, string login, string senha)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            CPF = cpf;
            Sexo = sexo;
            Telefone = telefone;
            Materia = materia;
            Login = login;
            Senha = senha;
        }
        public void AdicionarAluno(Usuarios usuario)
        {
            usuarios.Add(usuario);
        }
    }
}
