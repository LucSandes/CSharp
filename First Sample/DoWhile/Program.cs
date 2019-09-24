using System;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            do
            {
                Console.WriteLine(a.ToString());
                a++;
            }
            while (a < 10);

            Console.WriteLine("");

            int b = 10;
            while (b > 0)
            {
                Console.WriteLine(b.ToString());
                b--;
            }

            Console.ReadKey();
        }
    }
}
