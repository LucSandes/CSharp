using System;

namespace ClassSample
{
    public class Aluno
    {
        //Construtor
        public Aluno()
        {
            Console.WriteLine("Aluno Constructor");
        }

        public Aluno(string _nome, int _idade)
        {
            this.nome = _nome;
            this.idade = _idade;
        }

        //Fields
        private string nome;
        private int idade;

        //Properties
        public string Nome { get; set; }

        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                if (value >= 18)
                    idade = value;
            }
        }

        public int GetIdadeTwice()
        {
            int twice = this.idade * 2;
            return twice;
        }

        //Metodo (void = chamar)
        public void Limpar()
        {
            this.idade = 0;
            this.nome = string.Empty;
        }

        private void GoAge()
        {
            this.idade = 21;
        }

        //Destructor
        ~Aluno()
        {
            Console.WriteLine("Aluno Destructor");
            Console.ReadKey();
        }
    }
}
