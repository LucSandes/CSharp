using System;

namespace NullableType
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            int? y; //int anulável

            Nullable<int> z; //int anulável

            y = 10;

            z = null;

            x = y.HasValue ? y.Value : 0; // operador condicional -> expressão  ? true : false;

            Console.WriteLine(x);


            //? significa então e : significa então

            x = z.HasValue ? z.Value : 0;

            Console.WriteLine(x);
        }
    }
}
