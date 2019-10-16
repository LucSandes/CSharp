using System;
using System.Linq;

namespace _015
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Digite um número: 123421
                123421
                124321
                False
            */

            Console.Write("Digite um número: ");

            var numero = Console.ReadLine();

            var tmp = new String(numero.Reverse().ToArray<char>());

            Console.WriteLine(numero);
            Console.WriteLine(tmp);

            Console.WriteLine(numero.Equals(tmp));

            Console.ReadKey();

        }
    }
}
