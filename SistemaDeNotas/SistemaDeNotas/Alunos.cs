using System;

namespace SistemaDeNotas
{
    public class Alunos : Pessoa
    { 

        public string Curso { get; set; }
        public string DataMatricula { get; set; }
        public int RegistroAluno { get; set; }

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
