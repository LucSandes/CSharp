using System;

namespace MaximoDivisorComum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados dois números quaisquer, ache seu MDC");
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- ---");

            int n1, n2, r1, r2, limite;
            int p;
            int primo = 2;
            int res = 1;

            Console.Write("Digite o primeiro número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segunto número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            r1 = n1;
            r2 = n2;

            //while (!(r1 == r2))
            //{
            //    do
            //    {
            //        if (n1 % r1 == 0)
            //        {
            //            Console.WriteLine("| " + r1 + " |");
            //        }
            //        r1 = r1 - 1;
            //    } while (r1 != 0);
            //    Console.WriteLine("--- --- --- --- --- --- --- --- --- --- ---");
            //    do
            //    {
            //        if (n2 % r2 == 0)
            //        {
            //            Console.WriteLine("| " + r2 + " |");
            //        }
            //        r2 = r2 - 1;
            //    } while (r2 != 0);
            //}

            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- ---");

            while (!(r1 == 1) && !(r2 == 1))
            {
                if (r1 % primo == 0)
                {
                    r1 = r1 / primo;
                    if (r2 % primo == 0)
                    {
                        r2 = r2 / primo;
                        res = res * primo;
                    }
                }
                else if (r2 % primo == 0)
                {
                    r2 = r2 / primo;

                }
                else if (primo == 2)
                    primo = 3;
                else
                    do
                    {
                        primo = primo + 2;
                        p = 1;
                        limite = primo / 2;
                        do
                        {
                            primo = primo + 2;
                        } while (primo % p != 0 && primo < limite);
                    } while (primo % primo == 0);
            }
            Console.WriteLine("teste: " + res);
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- ---");
            Console.ReadKey();
        }
    }
}
