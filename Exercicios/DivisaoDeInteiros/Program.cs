using System;

namespace DivisaoDeInteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Receba do usuário dois números inteiros e " +
                "imprima na tela o resultado da divisão de um pelo outro");

            int a, b, resultado;

            Console.Write("Dividendo: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Divisor: ");
            b = Convert.ToInt32(Console.ReadLine());

            resultado = a / b;

            Console.Write("O resultado da divisão é " + resultado);
            Console.ReadKey();
        }
    }
}
