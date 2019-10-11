using System;

namespace CaixaEletronica
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = 188;

            Console.WriteLine("{0, 4} cédulas de R$100,00", v / 100);
            v %= 100;

            Console.WriteLine("{0, 4} cédulas de R$50,00", v / 50);
            v %= 50;

            Console.WriteLine("{0, 4} cédulas de R$20,00", v / 20);
            v %= 20;

            Console.WriteLine("{0, 4} cédulas de R$10,00", v / 10);
            v %= 10;

            Console.WriteLine("{0, 4} cédulas de R$5,00", v / 5);
            v %= 5;

            Console.WriteLine("{0, 4} cédulas de R$2,00", v / 2);

            Console.WriteLine("{0, 4} moedas de R$1,00", v % 2);

            Console.ReadKey();
        }
    }
}
