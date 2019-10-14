using System;

namespace Do
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            do
            {
                Console.WriteLine("Primeiro Do {0}, x++");
            } while (x <= 3);
            do
            {
                Console.WriteLine("Segundo Do {0}, x++");
            } while (x <= 3);

            Console.ReadKey();
        }
    }
}
