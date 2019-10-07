using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaDeNotas
{
    public partial class telaAlunos : Form
    {
        private Alunos[] novosAlunos;
        private int numeroDeAlunos;
        public telaAlunos()
        {
            InitializeComponent();
        }

        public void AdicionaAlunos(Alunos alunos)
        {
            this.novosAlunos[this.numeroDeAlunos] = alunos;
            this.numeroDeAlunos++;
            comboAlunos.Items.Add("nome: " + alunos.Nome);
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

            if (textoPesquisaAluno.Text != string.Empty)
            {
                telaPesquisaAlunos telaPesquisaAlunos = new telaPesquisaAlunos();
                telaPesquisaAlunos.Propriedade = textoPesquisaAluno.Text;
                telaPesquisaAlunos.Show();
            }
            else
                MessageBox.Show("Digite o nome de algum aluno!");


        }
        private void GrupoDados_Enter(object sender, EventArgs e)
        {

        }

        private void BotaoAdicionarAluno_Click(object sender, EventArgs e)
        {
            telaAdicionarAluno telaAdicionarAlunos = new telaAdicionarAluno();
            telaAdicionarAlunos.Show();
            //if (this.Controls.OfType<TextBox>().Any(f => string.IsNullOrEmpty(f.Text)))
            //{
            //    MessageBox.Show("É necessario preencher todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        private void BotaoAlterarAluno_Click(object sender, EventArgs e)
        {

        }

        private void BotaoLimparAluno_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                limparTextBoxes(Controls);
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
