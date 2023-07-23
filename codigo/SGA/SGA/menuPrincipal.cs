using System.Threading;

namespace SGA
{
    public partial class telaMenuPrincipal : Form
    {
        Thread CadastrarUsuario;
        public telaMenuPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarUsuário_Click(object sender, EventArgs e)
        {
            this.Close();
            CadastrarUsuario = new Thread(abrirCadastrarUsuario);
            CadastrarUsuario.SetApartmentState(ApartmentState.STA);
            CadastrarUsuario.Start();
        }

        private void abrirCadastrarUsuario(object obj)
        {
            Application.Run(new cadastrarUsuario());
        }

        private void cadastrarTurmas_Click(object sender, EventArgs e)
        {

        }

        private void visualizarTurmas_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarTurma_Click(object sender, EventArgs e)
        {

        }
    }
}