using System;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            //unários, binários e ternário

            //unário: '-' / binário: '+' / ternário: '?' e ':'

            //MostrarOperadoresAritmeticos();
            //MostrarOperadoresDeAtribuicao();
            //MostrarOperadoresIncrementoDecremento();
            //MostrarOperadoresRelacionais();
            //MostrarOperadoresLogicos();

            Console.ReadKey();

        }

        private static void MostrarOperadoresLogicos()
        {
            //Operadores Logicos
            //&& || !

            Object o = null;

            Console.WriteLine(o != null && o.ToString().Equals("System.Objects")); //short circuit
            Console.WriteLine(o == null || o.ToString().Equals("System.Objects")); //short circuit
            Console.WriteLine(!(o == null)); //short circuit
        }

        private static void MostrarOperadoresRelacionais()
        {
            //operadores relacionais
            //== != > >= < <=
            int x = 10;
            int y = 3;

            Console.WriteLine("{0} == {1} = {2}", x, y, x == y);
            Console.WriteLine("{0} != {1} = {2}", x, y, x != y);
            Console.WriteLine("{0} > {1} = {2}", x, y * 3 + 1, x > y * 3 + 1);
            Console.WriteLine("{0} >= {1} = {2}", x, y * 3 + 1, x >= y * 3 + 1);
            Console.WriteLine("{0} < {1} = {2}", x, y, x < y);
            Console.WriteLine("{0} <= {1} = {2}", x, y, x <= y);
        }

        private static void MostrarOperadoresIncrementoDecremento()
        {
            //Operadores de Incremento e Decremento
            //++ e --

            int x = 1;

            Console.WriteLine(x++); //imprime 1 e x = 2 //x = x + 1 = 2
            Console.WriteLine(++x); //x = 3 e imprime 3
            Console.WriteLine(x--); //imprime 3 e x = 2 // x 
            Console.WriteLine(--x);
        }

        private static void MostrarOperadoresDeAtribuicao()
        {
            //operador de atribuição
            //= += -= *= /= %=
            int x = 10;

            Console.WriteLine(x += 10); //20
            Console.WriteLine(x -= 7); //13
            Console.WriteLine(x *= 2); //26
            Console.WriteLine(x /= 13); //2
            Console.WriteLine(x %= 2); //0
        }

        private static void MostrarOperadoresAritmeticos()
        {
            //operadores aritméticos: + - * / %
            int x = 10, y = 3;

            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            Console.WriteLine("{0} % {1} = {2}", x, y, x % y);
        }
    }
}
