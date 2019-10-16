using System;

namespace SistemaDeNotas
{
    public class Disciplina
    {
        public string nome;
        public string descricao;
        public int codigoIdentificacao;
        public string curso;
        public DateTime inclusao;
        public DateTime exclusao;
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int CodigoIdentificacao { get => codigoIdentificacao; set => codigoIdentificacao = value; }
        public string Curso { get => curso; set => curso = value; }
        public DateTime Inclusao { get => inclusao; set => inclusao = value; }
        public DateTime Exclusao { get => exclusao; set => exclusao = value; }


    }
}
