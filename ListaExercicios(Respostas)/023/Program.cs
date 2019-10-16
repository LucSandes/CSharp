using System;

namespace _023
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Digite um número inteiro: 1
                Digite outro número inteiro: 10
                1 e 10 são amigáveis? False

                ---------------------------------------------

                Digite um número inteiro: 220
                Digite outro número inteiro: 284
                220 e 284 são amigáveis? True
             */

            Console.Write("Digite um número inteiro: ");
            var a = Int32.Parse(Console.ReadLine());

            Console.Write("Digite outro número inteiro: ");
            var b = Int32.Parse(Console.ReadLine());

            var sda = 0;
            var sdb = 0;

            for (int i = 1; i <= a / 2; i++)
            {
                if (a % i == 0) sda += i;
            }

            for (int i = 1; i <= b / 2; i++)
            {
                if (b % i == 0) sdb += i;
            }

            Console.WriteLine("{0} e {1} são amigáveis? {2}", a, b, sda == b && sdb == a);

            Console.ReadKey();
        }
    }
}
