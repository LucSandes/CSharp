using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            while (x <= 3)
            {
                Console.WriteLine("Primeiro While: {0}", x, x++);
            }

            while (x <= 3)
            {
                Console.WriteLine("Segundo While: {0}", x, x++);
            }

            Console.ReadKey();
        }
    }
}
