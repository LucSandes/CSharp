namespace SistemaDeNotas
{
    public class Disciplinas
    {
        private string nome;
        private string descricao;
        private int codigoIdentificacao;
        private string curso;
        private string dataInclusao;
        private string dataExclusao;
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int CodigoIdentificacao { get => codigoIdentificacao; set => codigoIdentificacao = value; }
        public string Curso { get => curso; set => curso = value; }
        public string DataInclusao { get => dataInclusao; set => dataInclusao = value; }
        public string DataExclusao { get => dataExclusao; set => dataExclusao = value; }
    }
}
