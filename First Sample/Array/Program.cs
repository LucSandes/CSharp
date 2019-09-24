using System.Collections;
using System.Collections.Generic;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Single Dimensional
            int[] a1 = new int[3];
            a1[0] = 10;
            a1[1] = 20;
            a1[2] = 30;
            //a1[4] = 40; Erro, pois o tamanho do array é apenas 3

            bool[] a2 = new bool[] { true, false, false };

            string[] a3 = { "one", "two", "three" };

            //Array MultiDimensional
            int[,] ma1 = new int[5, 10];
            ma1[0, 0] = 1;

            //(a3.Length) Ver o tamanho do array

            //ArrayList
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add("teste");
            al.Add(true);

            string als = (string)al[1];

            //Generics C# List<T>
            List<int> l1 = new List<int>();
            l1.Add(10);
            l1.Add(20);
            l1.Add(30);

            List<bool> l2 = new List<bool>();
            
        }
    }
}
