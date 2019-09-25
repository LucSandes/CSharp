using System;

namespace SomaDeInteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, soma;

            Console.WriteLine("Receba do usuário dois números " +
                "inteiros e imprima a tela a soma");

            Console.Write("Primeiro número: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Segundo número: ");
            b = Convert.ToInt32(Console.ReadLine());

            soma = a + b;

            Console.Write("O resultado da soma é " + soma);

            Console.ReadKey();
        }
    }
}
