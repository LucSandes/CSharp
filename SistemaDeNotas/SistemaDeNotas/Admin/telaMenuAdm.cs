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

        public void ArredondaCantosdoForm()
        {

            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, this.Size.Width, this.Size.Height));

            //Arredondar canto superior esquerdo        
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(this.Width - 24, 1, 24, 26, 270, 90);

            //Arredondar canto inferior esquerdo
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, this.Height - 10, 10, 10));
            PastaGrafica.AddPie(1, this.Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, this.Height - 13, 13, 13));
            PastaGrafica.AddPie(this.Width - 24, this.Height - 26, 24, 26, 0, 90);

            PastaGrafica.SetMarkers();
            this.Region = new Region(PastaGrafica);
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
