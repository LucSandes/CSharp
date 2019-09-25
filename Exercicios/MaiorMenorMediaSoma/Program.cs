using System;

namespace MaiorMenorMediaSoma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Receba do usuário três números inteiros e " +
                "imprima na tela o maior, o menor, a sua média e a sua soma");
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- ---");

            int a, b, c;
            int media, soma;

            Console.Write("Digite o primeiro número: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o terceiro número: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- ---");

            if (a > b)
                Console.WriteLine("O " + a + " é o maior!");
            else if (a > c)
                Console.WriteLine("O " + b + " é o maior!");
            else
                Console.WriteLine("O " + c + " é o maior!");

            if (a < b)
                Console.WriteLine("O " + a + " é o menor!");
            else if (a < c)
                Console.WriteLine("O " + b + " é o menor!");
            else
                Console.WriteLine("O " + c + " é o menor!");


            soma = a + b + c;

            media = soma / 3;

            Console.WriteLine("A soma dos números é " + soma);
            Console.WriteLine("A média dos números é " + media);


            Console.ReadKey();
        }
    }
}
