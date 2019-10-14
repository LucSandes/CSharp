using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine("Primeiro for: {0}", x);
            }

            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine("Segundo for: {0}", x);
            }

            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
