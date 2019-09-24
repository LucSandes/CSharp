using System;

namespace ForStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            //Primeiro declara a variavel, segundo a condição
            //e terceiro o incremento
            for (a = 10; a > 0; a--)
            {
                Console.WriteLine(a.ToString());
            }
            Console.ReadKey();
        }
    }
}
