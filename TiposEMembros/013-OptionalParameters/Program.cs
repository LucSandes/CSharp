using System;

namespace _013_OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalcularRaiz(9));
            Console.WriteLine(CalcularRaiz(27, 3));
            //Console.WriteLine(CalcularRaiz(-27, 3));

            Console.ReadKey();
        }

        static double CalcularRaiz(double x, int y = 2)
        {
            //validar y ímpar para x < 0
            return Math.Sign(x) * Math.Pow(Math.Abs(x), 1.0 / y);
        }
    }
}
