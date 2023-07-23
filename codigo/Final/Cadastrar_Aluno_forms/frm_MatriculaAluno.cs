using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastrar_Aluno_forms
{
    public partial class frm_MatriculaAluno : Form
    {
        public string matricula;
        public frm_MatriculaAluno()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void frm_MatriculaAluno_Load(object sender, EventArgs e)
        {
            string arquivo = "informacoes.txt";

            if (File.Exists(arquivo))
            {
                string[] linhas = File.ReadAllLines(arquivo);

                foreach (string linha in linhas)
                {

                    string[] parts = linha.Split(';');

                    if (parts[0].Trim().ToLower() == "aluno")
                    {
                        if (parts.Length >= 2)
                        {
                            comboBox1.Items.Add(parts[6].Trim()+"-" + parts[1].Trim());
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("O arquivo não existe!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lista = comboBox1.SelectedItem.ToString().Split('-');
            matricula = lista[0];
            this.Close();
        }
    }

}
    

