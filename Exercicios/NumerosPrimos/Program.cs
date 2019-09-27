using System;

namespace NumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dado um número qualquer, verifique se ele é primo");
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- ---");

            int n;
            int contador = 0;

            Console.Write("Digite o número: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (!(n % i == 0))
                    contador++;
            }
            if (contador > 0)
                Console.WriteLine("O número '" + n + "' é primo!");

            Console.ReadKey();
        }
    }
}
//for (int i = 0; i<n; i++)
//            {
//                if (n == 0)
//                {
//                    Console.WriteLine("O número digitado é zero!");
//                }
//                else if (n % n == 0)
//                {
//                    Console.WriteLine("O número é primo!");
//                }
//                else
//                    Console.WriteLine("O numero não é primo");
//                contador++;
//            }
