using System;

namespace _003
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Digite um número: 10
                Digite outro número: -10
                Digite mais um número: 5
                menor: -10
                maior: 10
                soma: 5
                média: 1,66666666666667
             */

            Console.Write("Digite um número: ");
            int x = Int32.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            int y = Int32.Parse(Console.ReadLine());

            Console.Write("Digite mais um número: ");
            int z = Int32.Parse(Console.ReadLine());

            Console.WriteLine("menor: {0}", x < y ? x : y < z ? y : z);
            Console.WriteLine("maior: {0}", x > y ? x : y > z ? y : z);
            Console.WriteLine("soma: {0}", x + y + z);
            Console.WriteLine("média: {0}", (x + y + z) / 3.0);

            Console.ReadKey();
        }
    }
}
