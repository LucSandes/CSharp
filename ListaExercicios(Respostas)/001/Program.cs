using System;

namespace _001
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Digite um número: 10
                Digite outro número: 3
                13
             */

            Console.Write("Digite um número: ");
            int x = Int32.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            int y = Int32.Parse(Console.ReadLine());

            Console.WriteLine(x + y);

            Console.ReadKey();
        }
    }
}
