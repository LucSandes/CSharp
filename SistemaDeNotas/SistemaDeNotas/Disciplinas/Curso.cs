namespace SistemaDeNotas
{
    public class Curso
    {
        string _nome;
        int _valor;

        public string Nome { get => _nome; set => _nome = value; }
        public int Valor { get => _valor; set => _valor = value; }

        public Curso(string nome, int valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
