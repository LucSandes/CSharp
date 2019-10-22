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
                telaPesquisaAlunos.TopLevel = false;
                telaPesquisaAlunos.Visible = true;
<<<<<<< HEAD
                panel1.Controls.Add(telaPesquisaAlunos);         
=======
                panel1.Controls.Add(telaPesquisaAlunos);
>>>>>>> 00974347022be3184679fc2b3cf6a3ff03e7937d
            }
            else
                MessageBox.Show("Digite o nome de algum aluno!");


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

        private void ComboAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
