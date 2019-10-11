using System;

namespace SistemaDeNotas
{
    public class Disciplinas
    {
        private string nome;
        private string descricao;
        private int codigoIdentificacao;
        private string curso;
        private DateTime inclusao;
        private DateTime exclusao;
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int CodigoIdentificacao { get => codigoIdentificacao; set => codigoIdentificacao = value; }
        public string Curso { get => curso; set => curso = value; }
        public DateTime Inclusao { get => inclusao; set => inclusao = value; }
        public DateTime Exclusao { get => exclusao; set => exclusao = value; }


    }
}
