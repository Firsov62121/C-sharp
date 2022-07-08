using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Recursion4
{
    public class Program
    {

        public static int[] mas;
        public static int k, n;
        public static bool isSumEqualK(int sum, int index)
        {
            sum += mas[index];
            if (sum == k) return true;
            if(index + 1 < n)
            {
                if (isSumEqualK(sum, index + 1)) return true;
            }
            if(index + 3 < n)
            {
                if (isSumEqualK(sum, index + 3)) return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            string[] inp = Console.ReadLine().Split();
            n = int.Parse(inp[0]);
            k = int.Parse(inp[0]);
            mas = new int[n];
            int i = 0;
            foreach (string s in Console.ReadLine().Split())
            {
                mas[i] = int.Parse(s);
                i++;
            }
            if (isSumEqualK(0, 0))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
