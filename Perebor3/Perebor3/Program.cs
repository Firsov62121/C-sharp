using System;

namespace Perebor3
{
    public class Program
    {
        public static int MinDifference(int n, int[] a)
        {
            int sum = 0;
            foreach (int i in a)
                sum += i;
            int minabs = Math.Abs(sum);
            int[] great = new int[n];
            int[] matr = new int[n];
            for (int i = 0; i < n; i++)
                matr[i] = 0;
            for (int i = 0; i < Math.Pow(2, n); i++)
            {
                int s2 = 0;
                for (int j = 0; j < n; j++)
                {
                    if (matr[j] == 1)
                        s2 += a[j];
                }
                int absThis = Math.Abs(sum - 2 * s2);
                if (absThis < minabs)
                {
                    minabs = absThis;
                    for (int j = 0; j < n; j++)
                        great[j] = matr[j];
                }
                int k = 0;
                matr[0]++;
                while (matr[k] == 2)
                {
                    matr[k] = 0;
                    if (k + 1 != n)
                    {
                        matr[k + 1]++;
                        k++;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (great[i] == 1)
                    Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (great[i] == 0)
                    Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();
           return minabs;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int i = 0;
            foreach(string s in Console.ReadLine().Split())
            {
                a[i] = int.Parse(s);
                i++;
            }
            Console.WriteLine(MinDifference(n, a));
        }
    }
}
