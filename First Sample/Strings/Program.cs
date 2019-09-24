using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "one, two, three.";

            string s2 = "one";
            s2 += ", two";
            s2 += ", three.";

            StringBuilder sb = new StringBuilder();
            sb.Append("one, ");
            sb.Append("two, ");
            sb.Append("Three.");

            //s2.EndsWith("ee")
            //s2.Equals("")
            //s2.IndexOf("two")
            //sb.ToString().IndexOf()
            //s2.Insert(4, "OK")
            //sb.Length
            //sb.Remove(4, 3)
            //sb.Replace("two", "one")
            string[] s3 = s2.Split(',');
                               
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(sb);
            Console.WriteLine(s2.Insert(4, "OK"));
            Console.ReadKey();
        }
    }
}
