using System;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sintaxe
            int a = 10;
            int b = 2;
            int c = 30;

            //Adição
            int add = a + b;

            //Subtração
            int subt = a - b;

            //Multiplicação
            int mult = a * b;

            //Divisão
            int div = a / b;

            //Resto
            int rest = a % b;

            //Primários
            //x++ (incremento) ou x-- (decremento)

            //Comparativos
            if (a > b)
            {
                //Console.WriteLine("a > b");
            }
            if (a < b)
            {
                //Console.WriteLine("a < b");
            }
            if (a >= b)// => expressão lambda
            {
                // Console.WriteLine("a >= b");
            }
            if (a <= b)
            {
                // Console.WriteLine("a <= b");
            }
            if (a == b)
            {
                //Console.WriteLine("a == b");
            }
            if (a != b)
            {
                //Console.WriteLine("a != b");
            }

            //Logicos
            //XOR - logico exclusivo(um ou outro)
            if (true ^ false)
                //Console.WriteLine("True")

                //Condicionais
                //AND(duas condições verdadeiras)
                if (a > b && true)
                    // Console.WriteLine("true");

                    //OR(uma condição ou outra verdadeira)
                    if (false || true)
                        // Console.WriteLine("True");
                        #endregion

           Console.Write("Valor 1: ");
           int v1 = int.Parse(Console.ReadLine());
           Console.Write("Valor 2: ");
           int v2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Soma: " + Convert.ToString(v1 + v2));
            Console.WriteLine("Subtração: " + (v1 - v2));
            Console.WriteLine("Multiplicação: " + (v1 * v2));
            Console.WriteLine("Divisão: " + (v1 / v2));
            Console.WriteLine();

            if (v1 > 0 && v2 > 0)
            {
                Console.WriteLine("Valores v1 e v2 são maiores que zero!");
            }

            if (v1 + v2 <= 0 || v1 - v2 <= 0 || v1 * v2 <= 0 || v1 / v2 <= 0)
            {
                Console.WriteLine("Uma ou mais operações posúi valor menor ou igual a zero!");
            }

            
            Console.ReadKey();
        }
    }
}
