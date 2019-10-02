using System;
using System.Windows.Forms;

namespace SistemaDeNotas
{
    public partial class telaMenu : Form
    {
        public telaMenu()
        {
            InitializeComponent();
        }

        private void BotaoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BotaoMedia_Click(object sender, EventArgs e)
        {
            telaMedia telaMedia = new telaMedia();
            telaMedia.ShowDialog();
        }

        private void BotaoAlunos_Click(object sender, EventArgs e)
        {
            telaAlunos telaAlunos = new telaAlunos();
            telaAlunos.ShowDialog();
        }

        private void BotaoProfessores_Click(object sender, EventArgs e)
        {
            telaProfessores telaProfessores = new telaProfessores();
            telaProfessores.ShowDialog();
        }
    }
}
