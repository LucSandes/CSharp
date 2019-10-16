using System;

namespace _012_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 3;
            Swap(ref x, ref y);

            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.ReadKey();
        }


        //ref -> é usado com value type e indica que o parâmetro é input/output
        static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
    }
}
