
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace FindTypeOfPoint
{
    public class Program
    {
        public static bool IsContainPoint(Point mainPoint, Point[] pts)
        {
            int maxDelta = 0;
            foreach(Point p in pts)
            {
                maxDelta = Math.Max(maxDelta,
                    Math.Max(Math.Abs(mainPoint.X - p.X), Math.Abs(mainPoint.Y - p.Y)));
            }
            Point p2 = new Point(mainPoint.X + maxDelta + 1, mainPoint.Y + maxDelta + 1);
            bool res = false;
            for(int i = 0; i < pts.Length; i++)
            {
                int nextI = (i + 1) % pts.Length;
                if (Point.IsPointOnLineSegment(pts[i], pts[nextI], mainPoint))
                    return true;
                int posOfCurrPoint = Point.LeftOrRight(mainPoint, p2, pts[i]);
                int posOfNextPoint = Point.LeftOrRight(mainPoint, p2, pts[nextI]);
                int posOfMainPoint = Point.LeftOrRight(pts[i], pts[nextI], mainPoint);
                int posOfHelpPoint = Point.LeftOrRight(pts[i], pts[nextI], p2);
                if (posOfCurrPoint != 0 && posOfNextPoint == 0)
                {
                    if (posOfMainPoint == posOfHelpPoint)
                        continue;
                    int posOf2NextPoint = Point.LeftOrRight(mainPoint, p2, pts[(i + 2) % pts.Length]);
                    if (posOf2NextPoint == 0)
                    {
                        int posOf3NextPoint = Point.LeftOrRight(mainPoint, p2, pts[(i + 3) % pts.Length]);
                        if (posOf3NextPoint != posOfCurrPoint)
                            res = !res;
                    }
                    else if (posOfCurrPoint != posOf2NextPoint)
                        res = !res;
                    continue;
                }
                else if (posOfCurrPoint == 0 && posOfNextPoint == 0)
                    continue;
                else if (posOfCurrPoint == 0 && posOfNextPoint != 0)
                    continue;
                if (posOfCurrPoint != posOfNextPoint && posOfMainPoint != posOfHelpPoint)
                    res = !res;
            }
            return res;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число вершин многоугольника:");
                int n = int.Parse(Console.ReadLine());
                Point[] points = new Point[n];
                Console.WriteLine("Введите координаты вершин многоугольника" +
                    " по часовой стрелке по 2 целых числа через пробел в строке.");
                for(int i = 0; i < n; i++)
                {
                    string[] tmp = Console.ReadLine().Split();
                    points[i] = new Point(int.Parse(tmp[0]), int.Parse(tmp[1]));
                }
                Console.WriteLine("Введите координаты искомой точки");
                string[] tmp2 = Console.ReadLine().Split();
                Point mainPoint = new Point(int.Parse(tmp2[0]), int.Parse(tmp2[1]));
                if (IsContainPoint(mainPoint, points))
                    Console.WriteLine("Точка принадлежит многогольнику.");
                else
                    Console.WriteLine("Точка не принадлежит многогольнику.");
            }
            catch (Exception)
            {
                //
            }
        }
    }
}
