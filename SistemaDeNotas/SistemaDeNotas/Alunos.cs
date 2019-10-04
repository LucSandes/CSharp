using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeNotas
{
    class Alunos : Pessoa
    {
        public string Curso { get; set; }
        public string DataMatricula { get; set; }
        public int RegistroAluno { get; set; }
        // public Pessoa pessoa { }
    }
}
