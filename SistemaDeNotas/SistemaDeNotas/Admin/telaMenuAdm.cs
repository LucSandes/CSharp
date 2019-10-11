using System;
using System.Windows.Forms;

namespace SistemaDeNotas
{
    public partial class telaMenuAdm : Form
    {
        public telaMenuAdm()
        {
            InitializeComponent();
        }

        private void BotaoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotaoMedia_Click(object sender, EventArgs e)
        {
            telaMedia telaMedia = new telaMedia();
            telaMedia.ShowDialog();
        }

        private void botaoTelaAlunos_Click(object sender, EventArgs e)
        {
            telaAlunos telaAlunos = new telaAlunos();
            telaAlunos.ShowDialog();
        }

        private void botaoTelaProfessores_Click(object sender, EventArgs e)
        {
            telaProfessores telaProfessores = new telaProfessores();
            telaProfessores.ShowDialog();
        }

        private void BotaoTelaDisciplinas_Click(object sender, EventArgs e)
        {
            telaDisciplinas telaDisciplinas = new telaDisciplinas();
            telaDisciplinas.ShowDialog();
        }

        private void BotaoTelaFuncionarios_Click(object sender, EventArgs e)
        {
            telaFuncionarios telaFuncionarios = new telaFuncionarios();
            telaFuncionarios.ShowDialog();
        }
    }
}
