using System;
using System.Windows.Forms;

namespace SistemaDeNotas
{
    public partial class telaAdicionarAluno : Form
    {
        private telaAlunos telaAdicionarAlunos;
        public telaAdicionarAluno(telaAlunos telaAdicionarAlunos)
        {
            this.telaAdicionarAlunos = telaAdicionarAlunos;
            InitializeComponent();
        }


        private void TelaAdicionarAluno_Load(object sender, EventArgs e)
        {

        }
        private void BotaoAdicionarAluno_Click(object sender, EventArgs e)
        {
            Alunos novoAluno = new Alunos();
            novoAluno.Nome = new Alunos(textoNomeAluno.Text);
            //novoAluno.DataNascimento = new Alunos(textoDataNascimentoAluno.Text);
            //novoAluno.Endereco = new Alunos(textoEnderecoAluno.Text);
            //novoAluno.Telefone = new Alunos(textoTelefoneAluno.Text);
            //novoAluno.Email = new Alunos(textoEmailAluno.Text);
            //novoAluno.Curso = new Alunos(textoCursoAluno.Text);
            //novoAluno.Cpf = new Alunos(textoCpfAluno.Text);
            //novoAluno.Cidade = new Alunos(textoCidadeAluno.Text);
            //novoAluno.Estado = new Alunos(textoEstadoAluno.Text);
            //novoAluno.DataMatricula = new Alunos(textoDataMatriculaAluno.Text);
            //novoAluno.RegistroAluno = new Alunos(textoRegistroAluno.Text);
            this.telaAdicionarAlunos.AdicionaAlunos(novoAluno);
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
    }
}
