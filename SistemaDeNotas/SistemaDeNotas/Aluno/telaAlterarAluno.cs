using System;
using System.Collections;
using System.Windows.Forms;

namespace SistemaDeNotas.Aluno
{
    public partial class telaAlterarAluno : Form
    {
        public telaAlterarAluno()
        {
            InitializeComponent();
        }

        private void TelsAlterarAluno_Load(object sender, EventArgs e)
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

        private void ComboCursos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
