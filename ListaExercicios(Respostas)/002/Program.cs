using System;

namespace _002
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Digite um número: 10
                Digite outro número: 3
                3
                3,333333
                3,33333333333333
                3,3333333333333333333333333333
             */

            Console.Write("Digite um número: ");
            int x = Int32.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            int y = Int32.Parse(Console.ReadLine());

            Console.WriteLine(x / y); 
            Console.WriteLine((float)x / y); 
            Console.WriteLine((double)x / y); 
            Console.WriteLine((decimal)x / y); 

            Console.ReadKey();
        }
    }
}
