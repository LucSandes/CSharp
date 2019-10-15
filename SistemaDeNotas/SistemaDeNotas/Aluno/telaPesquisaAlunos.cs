using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaDeNotas
{
    public partial class telaPesquisaAlunos : Form
    {
        List<Aluno.Aluno> listaAlunos = new List<Aluno.Aluno>();
        public telaPesquisaAlunos()
        {
            InitializeComponent();
            Aluno.Aluno a1 = new Aluno.Aluno();
            Aluno.Aluno a2 = new Aluno.Aluno();
            Aluno.Aluno a3 = new Aluno.Aluno();
            Aluno.Aluno a4 = new Aluno.Aluno();
            Aluno.Aluno a5 = new Aluno.Aluno();
        }

        public string Propriedade { get; set; }

        private void BotaoVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TelaPesquisaAlunos_Load(object sender, EventArgs e)
        {
            if (!this.Propriedade.Equals(""))
            {
                textoNomeAluno.Text = this.Propriedade;
            }
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TextoNomeAluno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
