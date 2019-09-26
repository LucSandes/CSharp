using System;

namespace NumeroTriangular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dado um valor inteiro n, calcule o número triangular para esse valor");
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- ---");
            int n, tr;

            Console.Write("Digite o valor a ser calculado: ");            
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- ---");

            tr = n * (n + 1) / 2;

            Console.Write("O valor triangular é " + tr);

            Console.ReadKey();
        }
    }
}
