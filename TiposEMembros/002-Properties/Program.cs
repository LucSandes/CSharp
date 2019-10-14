using System;

namespace _002_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Fracao fracao = new Fracao(); ;
            fracao.Numerador = 1;
            fracao.Denominador = 2;

            Ponto ponto = new Ponto();


            Console.ReadKey();
        }
    }

    /*por padrão se não escreve vem como internal*/
    struct Fracao
    {
        //private indica que o membro(field) só pode ser acessado por código do tipo
        //todos são privates
        int numerador;
        int denominador;

        //Tudo o que for privado é com letra minúscula e o que tiver letra maiúscula public

        internal int Numerador
        {
            get { return numerador; }
            set { numerador = value; }
        }
        public int Denominador
        {
            get
            {
                return denominador;
            }
            set
            {
                if (value == 0)
                    throw new Exception("O denominador deve ser diferente de zero!");

                denominador = value;
            }
        }
    }

    /*por padrão se não escreve vem como internal*/
    class Ponto
    {
        int x;
        int y;
    }
}
