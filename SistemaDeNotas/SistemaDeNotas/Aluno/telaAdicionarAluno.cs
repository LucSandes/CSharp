using System;
using System.Collections;
using System.Windows.Forms;

namespace SistemaDeNotas
{
    public partial class telaAdicionarAluno : Form
    {
        public telaAdicionarAluno()
        {
            InitializeComponent();
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

        private void TelaAdicionarAluno_Load(object sender, EventArgs e)
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
        private void BotaoAdicionarAluno_Click(object sender, EventArgs e)
        {
            alunos novoAluno = new alunos();
            novoAluno.Nome = textoNomeAluno.Text;
            //novoAluno.Nascimento = textoDataNascimentoAluno.Text;
            novoAluno.Endereco = textoEnderecoAluno.Text;
            novoAluno.Telefone = textoTelefoneAluno.Text;
            novoAluno.Email = textoEmailAluno.Text;
            //novoAluno.Curso = textoCursoAluno.Text;
            novoAluno.Cpf = textoCpfAluno.Text;
            novoAluno.Cidade = textoCidadeAluno.Text;
            novoAluno.Estado = textoEstadoAluno.Text;
            //novoAluno.DtMatricula = Convert.ToString(textoDataMatriculaAluno.Text);
            //novoAluno.RegistroAluno = textoRegistroAluno.Text;
            //this.telaAdicionarAlunos.AdicionaAlunos(novoAluno);
            foreach (Control dadoObrigatorio in this.Controls)
            {
                if (dadoObrigatorio is TextBox && String.IsNullOrWhiteSpace(dadoObrigatorio.Text))
                {

                    MessageBox.Show("Existe campo não preenchido!");
                }
            }
            MessageBox.Show("Adicionado com sucesso!");

        }

        private void BotaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotaoLimparAluno_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                limparTextBoxes(Controls);
            }
        }
    }
}
