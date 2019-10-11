using System;

namespace DesvioDeFluxo
{
    class Program
    {
        static void Main(string[] args)
        {
            //if(condição) {true}
            //if(condição) {true} else {false}

            Sexo sexo = Sexo.Feminino;

            if (sexo == Sexo.Masculino)
            {
                Console.WriteLine("Você escolheu Masculino!");
            }
            else
                Console.WriteLine("Você escolheu Feminino");

            int x = 10;

            if (x % 2 == 0)
            {
                Console.Write(x);
                Console.WriteLine("-> Par");
            }
            else
                Console.Write(x);
                Console.WriteLine("-> Ímpar");
            Console.ReadKey();
        }
    }

    enum Sexo
    {
        Masculino,
        Feminino
    }
}
