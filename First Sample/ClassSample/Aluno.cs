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


        //Destructor
        ~Aluno()
        {
            Console.WriteLine("Aluno Destructor");
            Console.ReadKey();
        }
    }
}
