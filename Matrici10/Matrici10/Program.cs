using Microsoft.VisualBasic.FileIO;
using System;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Matrici10
{
    public class Program
    {
        public static int[,] a;
        public static int n;

        public static void RotateA()
        {
            int[,] b = new int[n, n];
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    b[j, n - i - 1] = a[i, j];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(j != i && j != n - i - 1)
                    {
                        a[i, j] = b[i, j];
                    }
                }
            }
        }

        static void RotateMainTriangle()
        {
            for (int i = 0; i < 4; i++)
            {
                int max = (n - 3) / 2, min = 0;
                while (max > min)
                {
                    RotateOneOfManyTriangles(max, min);
                    max -= 1;
                    min += 1;
                }
                RotateA();
            }
        }

        static void RotateOneOfManyTriangles(int max, int min)
        {
            int i = max, j = (n - 1) / 2;
            int tmp = a[i, j];
            while(i > min)
            {
                i--;
                j--;
                int tmp2 = a[i, j];
                a[i, j] = tmp;
                tmp = tmp2;
            }
            int j3 = j;
            while(j < n - 1 - j3)
            {
                j++;
                int tmp2 = a[i, j];
                a[i, j] = tmp;
                tmp = tmp2;
            }
            while(i < max)
            {
                i++;
                j--;
                int tmp2 = a[i, j];
                a[i, j] = tmp;
                tmp = tmp2;
            }
        }

        static void PrintA()
        {
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            a = new int[n, n];
            for(int i = 0; i < n; i++)
            {
                string[] inp = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                    a[i, j] = int.Parse(inp[j]);
            }
            RotateA();
            PrintA();
        }
    }
}
