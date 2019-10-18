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
            telaMedia telaMedia = new telaMedia();
            telaMedia.TopLevel = false;
            telaMedia.Visible = true;
            painelMenuAdm.Controls.Add(telaMedia);
        }

        private void botaoTelaAlunos_Click(object sender, EventArgs e)
        {
            telaAlunos telaAlunos = new telaAlunos();
            telaAlunos.TopLevel = false;
            telaAlunos.Visible = true;
            painelMenuAdm.Controls.Add(telaAlunos);
            //telaAlunos.ShowDialog();
        }

        private void botaoTelaProfessores_Click(object sender, EventArgs e)
        {
            telaProfessores telaProfessores = new telaProfessores();
            telaProfessores.TopLevel = false;
            telaProfessores.Visible = true;
            painelMenuAdm.Controls.Add(telaProfessores);
            //telaProfessores.ShowDialog();
        }

        private void BotaoTelaDisciplinas_Click(object sender, EventArgs e)
        {
            telaDisciplinas telaDisciplinas = new telaDisciplinas();
            telaDisciplinas.TopLevel = false;
            telaDisciplinas.Visible = true;
            painelMenuAdm.Controls.Add(telaDisciplinas);
            //telaDisciplinas.ShowDialog();
        }

        private void BotaoTelaFuncionarios_Click(object sender, EventArgs e)
        {
            telaFuncionarios telaFuncionarios = new telaFuncionarios();
            telaFuncionarios.TopLevel = false;
            telaFuncionarios.Visible = true;
            painelMenuAdm.Controls.Add(telaFuncionarios);
            //telaFuncionarios.ShowDialog();
        }

        private void TelaMenuAdm_Load(object sender, EventArgs e)
        {
        }

        private void PainelMenuAdm_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
