using System;

namespace _005
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                a: 0
                b: 1
                c: 2
                não é uma equação do 2º grau

                ------------------------------

                a: 1
                b: 1
                c: 1
                não existem raízes em R

                ------------------------------

                a: 1
                b: 2
                c: 1
                x' = -1

                ------------------------------

                a: 1
                b: 0
                c: -1
                x' = 1
                x'' = -1
            */

            Console.Write("a: ");
            var a = Double.Parse(Console.ReadLine());

            Console.Write("b: ");
            var b = Double.Parse(Console.ReadLine());

            Console.Write("c: ");
            var c = Double.Parse(Console.ReadLine());

            String msg;

            if (a == 0)
            {
                msg = "não é uma equação do 2º grau";
            }
            else
            {
                var d = Math.Pow(b, 2) - 4 * a * c; 

                if (d < 0)
                {
                    msg = "não existem raízes em R";
                }
                else
                {
                    if (d == 0)
                    {
                        msg = String.Format("x' = {0}", (-b + Math.Sqrt(d)) / (2 * a));
                    }
                    else
                    {
                        msg = String.Format("x' = {0}\nx'' = {1}", (-b + Math.Sqrt(d)) / (2 * a), (-b - Math.Sqrt(d)) / (2 * a));
                    }
                }
            }

            Console.WriteLine(msg);

            Console.ReadKey();
        }
    }
}
