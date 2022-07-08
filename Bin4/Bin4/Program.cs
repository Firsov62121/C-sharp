using System;
using System.Text;

namespace Bin4
{
    public class Program
    {
        static bool HasOneOneBetweenTwoZero(int n)
        {
            int last = -1;
            int beforeLast = -1;
            while(n != 0)
            {
                int tmp = n % 2;
                if (tmp == 0 && last == 1 && beforeLast == 0)
                    return true;
                beforeLast = last;
                last = tmp;
                n /= 2;
            }
            if (last == 1 && beforeLast == 0)
                return true;
            return false;
        }
        static string GetBinView(int n)
        {
            int[] tmp = new int[64];
            int i = 0;
            while(n > 0)
            {
                tmp[i] = n % 2;
                n /= 2;
                i++;
            }
            StringBuilder sb = new StringBuilder();
            for (int j = i - 1; j > -1; j--)
                sb.Append(tmp[j]);
            return sb.ToString();
        }
        public static int[] GetAllGoodNums(int n)
        {
            int[] a = new int[n];
            int j = 0;
            for(int i = 0; i < n; i++)
            {
                if (HasOneOneBetweenTwoZero(i))
                {
                    a[j] = i;
                    j++;
                }
            }
            int[] b = new int[j];
            for (int i = 0; i < j; i++)
                b[i] = a[i];
            return b;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            foreach(int i in GetAllGoodNums(n))
                Console.WriteLine("{0} : {1}", i, GetBinView(i));
        }
    }
}
