using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeNotas.Aluno
{
    public partial class telaMenuAluno : Form
    {
        public telaMenuAluno()
        {
            InitializeComponent();
        }

        private void BotaoMedia_Click(object sender, EventArgs e)
        {
            telaMedia telaMedia = new telaMedia();
            telaMedia.ShowDialog();
        }

        private void TelaMenuAluno_Load(object sender, EventArgs e)
        {
            ArrayList listaCursos = new ArrayList();

            listaCursos.Add(new Cursos("Ciências da Computação", 1));
            listaCursos.Add(new Cursos("Sistemas de Informação", 2));
            listaCursos.Add(new Cursos("Análise e Desenvolvimento de Sistemas", 3));
            listaCursos.Add(new Cursos("Engenharia da Computação", 4));
            listaCursos.Add(new Cursos("Engenharia de Controle e Automação", 5));
            listaCursos.Add(new Cursos("Engenharia de Software", 6));
            listaCursos.Add(new Cursos("Jogos Digitais", 7));
            listaCursos.Add(new Cursos("Sistemas para Internet", 8));

            comboCursos.DataSource = listaCursos;

            comboCursos.DisplayMember = "nome";
            comboCursos.ValueMember = "valor";
        }
    }
}
