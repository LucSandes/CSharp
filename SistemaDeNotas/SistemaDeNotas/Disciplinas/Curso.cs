namespace SistemaDeNotas
{
    public class Curso
    {
        public string _nome;
        public int _valor;

        public string Nome { get => _nome; set => _nome = value; }
        public int Valor { get => _valor; set => _valor = value; }

        public Curso(string nome, int valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
