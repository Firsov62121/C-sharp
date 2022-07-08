using System;
using System.Text;

namespace Solyanka1
{
    public class Program
    {
        public static uint HashFromMorsaTue(int n)
        {
            int[] a = MorsaTueArray(n);
            uint powered3 = 1;
            uint res = 0;
            foreach(var el in a)
            {
                if(el == 1)
                    res += powered3;
                powered3 *= 3;
            }
            return res;
        }

        public static int[] MorsaTueArray(int n)
        {
            int[] a = new int[n];
            a[0] = 0;
            int firstCounter = 0;
            int binLenght = 1;
            while (firstCounter + binLenght < n)
            {
                if (firstCounter == binLenght)
                {
                    firstCounter = 0;
                    binLenght *= 2;
                }
                int tmp;
                if (a[firstCounter] == 0)
                    tmp = 1;
                else
                    tmp = 0;
                a[firstCounter + binLenght] = tmp;
                firstCounter++;
            }
            return a;
        }

        public static string MorsaTue(int n)
        {
            int[] a = MorsaTueArray(n);
            var res = new StringBuilder();
            foreach (int el in a)
                res.Append(String.Format("{0}", el));
            return res.ToString();
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(MorsaTue(n));
        }
    }
}
