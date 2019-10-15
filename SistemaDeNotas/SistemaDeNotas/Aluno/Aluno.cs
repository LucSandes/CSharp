using System;

namespace SistemaDeNotas.Aluno
{
    public class Aluno : Pessoa
    {

        public Curso Curso { get; set; }
        public DateTime dtMatricula;
        public int registroAluno;

        //private string Curso { get => curso; set => curso = value; }
        public DateTime DtMatricula { get => dtMatricula; set => dtMatricula = value; }
        public int RegistroAluno { get => registroAluno; set => registroAluno = value; }
    }
}
