using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

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
            this.Visible = false;
            telaMedia telaMedia = new telaMedia();
            telaMedia.ShowDialog();
            this.Visible = true;
        }

        private void botaoTelaAlunos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            telaAlunos telaAlunos = new telaAlunos();
            telaAlunos.ShowDialog();
            this.Visible = true;
        }

        private void botaoTelaProfessores_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            telaProfessores telaProfessores = new telaProfessores();
            telaProfessores.ShowDialog();
            this.Visible = true;
        }

        private void BotaoTelaDisciplinas_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            telaDisciplinas telaDisciplinas = new telaDisciplinas();
            telaDisciplinas.ShowDialog();
            this.Visible = true;
        }

        private void BotaoTelaFuncionarios_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            telaFuncionarios telaFuncionarios = new telaFuncionarios();
            telaFuncionarios.ShowDialog();
            this.Visible = true;
        }

        private void TelaMenuAdm_Load(object sender, EventArgs e)
        {
        }
    }
}
