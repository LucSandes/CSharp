using System;

namespace _009_Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculadora.Somar(10, 2));
            Console.WriteLine(Calculadora.Subtrair(10, 2));
            Console.WriteLine(Calculadora.Multiplicar(10, 2));
            Console.WriteLine(Calculadora.Dividir(10, 2));

            Console.WriteLine();

            var c = new OutraCalculadora
            {
                X = 10,
                Y = 20
            };

            Console.WriteLine(c.Somar());
            Console.WriteLine(c.Subtrair());
            Console.WriteLine(c.Multiplicar());
            Console.WriteLine(c.Dividir());

            Console.ReadKey();
        }
    }

    class Calculadora
    {
        //static significa que o método deve ser acessado a partir do tipo
        internal static double Somar(double x, double y) { return x + y; }
        internal static double Subtrair(double x, double y) { return x - y; }
        internal static double Multiplicar(double x, double y) { return x * y; }
        internal static double Dividir(double x, double y) { return x / y; }

    }

    class OutraCalculadora
    {
        public double X { get; set; }
        public double Y { get; set; }
        internal double Somar() { return X + Y; }
        internal double Subtrair() { return X - Y; }
        internal double Multiplicar() { return X * Y; }
        internal double Dividir() { return X / Y; }
    }
}
