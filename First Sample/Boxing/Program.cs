using System;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            object o = (Object)a;

            Console.WriteLine(o.GetType().ToString());

            int b = (int)o;

            System.Type t = b.GetType();
           
            //((int)o).

            Console.WriteLine(b);

            

            Console.ReadKey();
        }
    }
}
