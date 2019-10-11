using System;

namespace Cast
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 200;

            //conversão explícita
            //(tipo)var

            byte b = (byte)x;

            long l = x; //conversão implicita

            Console.WriteLine(b);
            Console.WriteLine(l);

            string s1 = "123";

            //int s2 = Convert.ToInt32(s1);
            int s2 = Int32.Parse(s1);

            Console.WriteLine(s2);

            int num = 10;

            string strNum = num.ToString();

            Console.WriteLine(strNum);

            object o = 1234; //boxing 

            int xpto = (int)o; //unboxing

            //Convert.To(string ou int e por ai vai)

            Console.WriteLine(xpto);
            
            Console.ReadKey();
        }
    }
}
