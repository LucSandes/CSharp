using System;
using System.Collections;
using System.Windows.Forms;

namespace SistemaDeNotas
{
    public partial class telaAdicionarAluno : Form
    {
        private ArrayList _listaCursos;

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
            _listaCursos = new ArrayList();
            _listaCursos.Add(new Curso("Ciências da Computação", 1));
            _listaCursos.Add(new Curso("Sistemas de Informação", 2));
            _listaCursos.Add(new Curso("Análise e Desenvolvimento de Sistemas", 3));
            _listaCursos.Add(new Curso("Engenharia da Computação", 4));
            _listaCursos.Add(new Curso("Engenharia de Controle e Automação", 5));
            _listaCursos.Add(new Curso("Engenharia de Software", 6));
            _listaCursos.Add(new Curso("Jogos Digitais", 7));
            _listaCursos.Add(new Curso("Sistemas para Internet", 8));

            comboCursos.DataSource = _listaCursos;

            comboCursos.DisplayMember = "nome";
            comboCursos.ValueMember = "valor";
        }
        private void BotaoAdicionarAluno_Click(object sender, EventArgs e)
        {
            Aluno.Aluno novoAluno = new Aluno.Aluno();
            novoAluno.Nome = textoNomeAluno.Text;
            //novoAluno.Nascimento = Convert.ToDateTime(textoDataNascimentoAluno.Text); -> funciona mas pode cair na exception 
            if (DateTime.TryParse(textoDataNascimentoAluno.Text, out var _auxNascimento))
            {
                novoAluno.Nascimento = _auxNascimento;
            }
            novoAluno.Endereco = textoEnderecoAluno.Text;
            novoAluno.Telefone = textoTelefoneAluno.Text;
            novoAluno.Email = textoEmailAluno.Text;
            novoAluno.Curso = (Curso)_listaCursos[comboCursos.SelectedIndex];
            novoAluno.Cpf = textoCpfAluno.Text;
            novoAluno.Cidade = textoCidadeAluno.Text;
            novoAluno.Estado = textoEstadoAluno.Text;
            if (DateTime.TryParse(textoDataMatriculaAluno.Text, out var _auxMatricula))
            {
                novoAluno.DtMatricula = _auxMatricula;
            };
            novoAluno.RegistroAluno = Convert.ToInt32(textoRegistroAluno.Text);

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
