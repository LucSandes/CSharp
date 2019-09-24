using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Estudo do IF e ELSE

            int a = 10;
            int c = (a < 10) ? 5 : 0;

            /*Caso as cláusulas seja de apenas 1 linha abaixo do if
            e do else pode colocar sem as chaves.
            if (a == 10)
                Console.WriteLine("a = 10");
            else
                Console.WriteLine("a <> 10!");*/

            if (a == 10)
            {
                Console.WriteLine("a = 10");
            }
            else
            {
                Console.WriteLine("a <> 10!");
            }

            bool ok = true;

            if (ok)
                Console.WriteLine("OK!");

            Console.ReadKey();
            #endregion

            #region Estudo do SWITCH e BREAK

            int b = 11;

            //if aninhado
            if (b == 5)
            {
                if (true)
                {
                    Console.WriteLine("b = 5");
                }
            }
            else if (b == 10)
            {
                Console.WriteLine("b <> 10!");
            }
            else if (b == 9)
            {
                Console.WriteLine("b < 10!");
            }
            else
            {
                Console.WriteLine("b = " + b.ToString());
            }

            //switch
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 0:
                    Console.WriteLine("x == 10!");
                    break;
                case 5:
                    Console.WriteLine("x <= 10!");
                    break;
                case 10:
                    Console.WriteLine("x >= 10!");
                    break;
                default:
                    Console.WriteLine("x = " + x.ToString());
                    break;
            }
            Console.ReadKey();

            #endregion
        }
    }
}
