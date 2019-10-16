using System;

namespace _014_MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Somar(10, 1230)); //int, int
            Console.WriteLine(Somar(10, 12, 30)); //int int, int
            Console.WriteLine(Somar(10.1, 30.3)); //double, double

            Console.WriteLine(Somar(10, 102.30)); //int, double


            Console.ReadKey();
        }

        static int Somar(int x, int y)
        {
            return x + y;
        }
        static int Somar(int x, int y, int z)
        {
            return x + y + z;
        }
        static double Somar(double x, double y)
        {
            return x + y;
        }

        //Somar(int, int)
        //Somar(int, int, int)
        //Somar(double, double)
    }
}
