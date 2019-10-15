using System;
using System.Windows.Forms;

namespace SistemaDeNotas
{
    public partial class telaAlunos : Form
    {
        private Aluno.Aluno[] novosAlunos;
        private int numeroDeAlunos;
        public telaAlunos()
        {
            InitializeComponent();
        }

        public void AdicionaAlunos(Aluno.Aluno alunos)
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
            if (MessageBox.Show("Deseja excluir o Aluno?", "Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Rotina para exclusão
                MessageBox.Show("Aluno excluído com sucesso!", "Sucesso");
            }
        }

        private void BotaoPesquisarAluno_Click(object sender, EventArgs e)
        {

            if (comboAlunos.Text != string.Empty)
            {
                telaPesquisaAlunos telaPesquisaAlunos = new telaPesquisaAlunos();
                telaPesquisaAlunos.Propriedade = comboAlunos.Text;
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
            Aluno.telaAlterarAluno telaAlterarAluno = new Aluno.telaAlterarAluno();
            telaAlterarAluno.Show();
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

        }

        private void TextoTelaAlunos_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
