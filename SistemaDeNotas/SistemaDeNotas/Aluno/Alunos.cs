using System;
using System.Windows.Forms;

namespace SistemaDeNotas
{
    public class alunos : Pessoa
    {

        //private Cursos curso;
        private DateTime dtMatricula;
        private int registroAluno;

        //private string Curso { get => curso; set => curso = value; }
        private DateTime DtMatricula { get => dtMatricula; set => dtMatricula = value; }
        private int RegistroAluno { get => registroAluno; set => registroAluno = value; }   
    }
}
