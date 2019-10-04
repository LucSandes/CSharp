using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaDeNotas
{
    public partial class telaAlunos : Form
    {
        List<Alunos> listaAlunos = new List<Alunos>();
        public telaAlunos()
        {
            InitializeComponent();
        }

        private void limparTextBoxes(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
            }
        }

        private void BotaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoExcluirAluno_Click(object sender, EventArgs e)
        {

        }

        private void BotaoPesquisarAluno_Click(object sender, EventArgs e)
        {
            if (textoTelaAlunos.Text != string.Empty)
            {
                telaPesquisaAlunos telaPesquisaAlunos = new telaPesquisaAlunos();
                telaPesquisaAlunos.ShowDialog();
            }
            else
                MessageBox.Show("Digite o nome de algum aluno!");
        }

        private void BotaoAdicionarAluno_Click(object sender, EventArgs e)
        {
            if (grupoDados.)
            {

            }
        }

        private void BotaoAlterarAluno_Click(object sender, EventArgs e)
        {

        }

        private void BotaoLimparAluno_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                limparTextBoxes(this.Controls);
            }
        }

        private void TelaAlunos_Load(object sender, EventArgs e)
        {
            //listaAlunos  = new Alunos[];

            //listaAlunos.Add = new Alunos();
        }

        private void TextoTelaAlunos_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
