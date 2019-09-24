using System;

namespace ValueTypes
{
    class Program
    {
        enum acessorio { sapato=10, bolsa, cinto, carteira, colar }
        static void Main(string[] args)
        {
            int i = 10;
            string a = "ok";
            char c = 'X';

            float f = 10.00F;
            double d = 16.666;

            decimal dec = 10.50M;

            bool bl = true;

            int item = (int)acessorio.cinto;

            //Conversão Implicita
            int i1 = 10;
            long i2 = i1;

            //Conversão Explicita
            double d1 = 10.0;
            int d2 = (int)d1;

            //int.TryParse();
            //int.Parse();

            Console.WriteLine(i);
            Console.WriteLine(a);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(dec);
            Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
