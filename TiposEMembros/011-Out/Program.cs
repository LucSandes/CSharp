using System;

namespace _011_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Somar(10, 29);

            int resultado;

            Somar(10, 10, out resultado);

            Console.WriteLine(resultado);

            double a, p;

            Calcular(1, out p, out a);

            Console.WriteLine(p);
            Console.WriteLine(a);

            Console.ReadKey();
        }

        private static int Somar(int x, int y)
        {
            return x + y;
        }

        private static void Somar(int x, int y, out int z)
        {
            z = x + y;
        }
        //out é usado com value type e indica que a var é de output(saída)
        //não lemos a var output

        static void Calcular(int raio, out double perimetro, out double area)
        {
            perimetro = 2 * Math.PI * raio;
            area = Math.Pow(raio, 2) * Math.PI;
        }
    }
}
