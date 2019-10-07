using System;

namespace SistemaDeNotas
{
    public class Alunos : Alunos
    {
        Alunos[] ListaAlunos = new Alunos[5];

        public Alunos()
        {
        }

        public Alunos(string _nome)
        {
            this.Nome = _nome;
        }

        public Alunos(Alunos[] listaAlunos, string curso, string dataMatricula, int registroAluno, 
                      string text, string nome, string dataNascimento, string endereco, string telefone, 
                      string email, string cpf, string cidade, string estado)
        {
            ListaAlunos = listaAlunos;
            Curso = curso;
            DataMatricula = dataMatricula;
            RegistroAluno = registroAluno;
            this.text = text;
            Nome = nome;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            Cpf = cpf;
            Cidade = cidade;
            Estado = estado;
        }

        public string Curso { get; set; }
        public string DataMatricula { get; set; }
        public int RegistroAluno { get; set; }

        public static implicit operator string(Alunos v)
        {
            throw new NotImplementedException();
        }
        // public Pessoa pessoa { }

        //public Alunos(string nome, string DataNascimento, string Endereco, string telefone, string Email,
        //              string Cpf, string Cidade, string Estado, string Curso, string DataMatriula, int RegistroAluno)
        //{
        //    ListaAlunos[0] = new Pessoa();
        //    ListaAlunos[1] = new Pessoa();
        //    ListaAlunos[2] = new Pessoa();
        //    ListaAlunos[3] = new Pessoa();
        //    ListaAlunos[4] = new Pessoa();
        //    ListaAlunos[5] = new Pessoa();

        //    this.Nome = nome;
        //}      
    }
}
