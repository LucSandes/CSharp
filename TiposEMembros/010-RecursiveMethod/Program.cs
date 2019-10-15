using System;

namespace _010_RecursiveMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SomarIterativo(10));
            Console.WriteLine(SomarIterativo(100));
            Console.WriteLine(SomarIterativo(1000));
            Console.WriteLine(SomarIterativo(8));

            Console.WriteLine(SomarRecursivo(10));
            //Console.WriteLine(SomarRecursivo(100));
            //Console.WriteLine(SomarRecursivo(1000));
            //Console.WriteLine(SomarRecursivo(8));



            Console.ReadKey();
        }

        private static int SomarRecursivo(int x)
        {
            Console.WriteLine("*** Passei aqui! ***");

            if (x < 1)
                throw new Exception("Somente se pode somar a partir de 1!");
            return x == 1 ? 1 : x + SomarRecursivo(x - 1);
        }

        private static int SomarIterativo(int x)
        {
            int retorno = 0;

            if (x < 0) x = -x;

            for (int i = 1; i <= x; i++)
            {
                retorno += i;
            }

            return retorno;
        }
    }
}
