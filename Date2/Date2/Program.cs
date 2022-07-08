using System;
using System.Numerics;

namespace Date2
{
    public class Program
    {
        static int[] a = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        static int GetDaysBetweenTwoDatesOfYear(int d1, int m1, int d2, int m2, int y)
        {
            if (m1 == m2)
            {
                return d2 - d1;
            }
            else
            {
                int st = 0;
                bool isVisokos = IsVisokos(y);
                if (m1 == 2)
                {
                    st += isVisokos ? 29 - d1 : 28 - d1;
                }
                else
                {
                    st += a[m1] - d1;
                }
                for (int i = m1 + 1; i < m2; i++)
                    st += i == 2 ? (isVisokos ? 29 : 28) : a[i];
                st += d2;
                return st;
            }
        }

        static int GetDaysBetweenTwoDates(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            int res = 0;
            if(y1 == y2)
            {
                res = GetDaysBetweenTwoDatesOfYear(d1, m1, d2, m2, y1);
            }
            else
            {
                res = GetDaysBetweenTwoDatesOfYear(d1, m1, 31, 12, y1);
                for(int i = y1 + 1; i < y2; i++)
                {
                    res += IsVisokos(i) ? 366 : 365;
                }
                res += GetDaysBetweenTwoDatesOfYear(1, 1, d2, m2, y2) + 1;
            }
            return res;
        }

        static int GetCountOfFullWeeks(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            int dist1, dist2;
            if(IsFirstlyFirst(d1, m1, y1, 31 , 8, 2020))
            {
                dist1 = GetDaysBetweenTwoDates(d1, m1, y1, 31, 8, 2020) % 7;
            }
            else
            {
                dist1 = GetDaysBetweenTwoDates(31, 8, 2020, d1, m1, y1) % 7;
                if (dist1 != 0)
                {
                    dist1 = 7 - dist1;
                }
            }
            dist2 = GetDaysBetweenTwoDates(d1, m1, y1, d2, m2, y2);
            return (dist2 - dist1) / 7;
        }

        static bool IsFirstlyFirst(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            return y1 < y2 || (y1 == y2 && (m1 < m2 || ( m1 == m2 && d1 <= d2)));
        }

        static bool IsVisokos(int y)
        {
            return (y % 4 == 0 && y % 100 != 0) || y % 400 == 0;
        }

        static bool IsCorrectDate(int d, int m, int y)
        {
            if (m < 1 || m > 12 || y < 1 || d < 1)
                return false;
            if(m != 2)
            {
                if (a[m] < d)
                    return false;
            }
            else
            {
                if (IsVisokos(y))
                {
                    if (d > 29)
                        return false;
                }
                else
                {
                    if (d > 28)
                        return false;
                }
            }

            return true;
        }

        public static int GetNumOfFullWeeks(string date1, string date2)
        {
            string[] inp = date1.Split(":");//dd:mm:yyyy
            string[] inp2 = date2.Split(":");
            if (inp.Length == 3 && inp2.Length == 3)
            {
                try
                {
                    int d1 = int.Parse(inp[0]);
                    int m1 = int.Parse(inp[1]);
                    int y1 = int.Parse(inp[2]);
                    int d2 = int.Parse(inp2[0]);
                    int m2 = int.Parse(inp2[1]);
                    int y2 = int.Parse(inp2[2]);
                    bool b1 = IsFirstlyFirst(d1, m1, y1, d2, m2, y2);
                    if (!b1 || !IsCorrectDate(d1, m1, y1) || !IsCorrectDate(d2, m2, y2))
                        throw new Exception();
                    return GetCountOfFullWeeks(d1, m1, y1, d2, m2, y2);
                }
                catch (Exception)
                {
                    return -1;
                }
            }
            return -1;
        }
            
        static void Main(string[] args)
        {
            Console.WriteLine("Введите две последовательные даты в виде дд:мм:гггг в две строки.");
            Console.WriteLine(GetNumOfFullWeeks(Console.ReadLine(), Console.ReadLine()));
        }
    }
}
