using System;

namespace MaximoDivisorComum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados dois números quaisquer, ache seu MDC");
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- ---");

            int n1, n2, r1, r2;
            int teste;

            Console.Write("Digite o primeiro número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segunto número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            r1 = n1;
            r2 = n2;

            while (!(r1 == r2))
            {
                do
                {
                    if (n1 % r1 == 0)
                    {
                        Console.WriteLine("| " + r1 + " |");
                    }
                    r1 = r1 - 1;
                } while (r1 != 0);
                Console.WriteLine("--- --- --- --- --- --- --- --- --- --- ---");
                do
                {
                    if (n2 % r2 == 0)
                    {
                        Console.WriteLine("| " + r2 + " |");
                    }
                    r2 = r2 - 1;
                } while (r2 != 0);
            }
            if (r1 == r2)
            {
                teste = r1 * r2;
                Console.WriteLine(teste);
            }
            


            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- ---");
            Console.ReadKey();
        }
    }
}
