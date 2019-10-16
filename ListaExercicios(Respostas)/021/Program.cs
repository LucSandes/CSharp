using System;

namespace _021
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Digite um número inteiro: 1
                o número 1 é hexagonal? True
                
                --------------------------------------
             
                Digite um número inteiro: 10
                o número 1 é hexagonal? False
                
                --------------------------------------
             
                Digite um número inteiro: 120
                o número 1 é hexagonal? True
                
                --------------------------------------
                             
                Digite um número inteiro: 561
                o número 1 é hexagonal? True
             */

            Console.Write("Digite um número inteiro: ");

            var x = Int32.Parse(Console.ReadLine());

            Console.WriteLine("o número {0} é hexagonal? {1}", x, ((Math.Sqrt(8 * x + 1) + 1) / 4) % 1 == 0);

            Console.ReadKey();
        }
    }
}
