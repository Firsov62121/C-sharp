using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisQuiz
{
    public struct Pair
    {
        int x, y;
        public Pair(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int this[int index]
        {
            get
            {
                if (index == 0)
                    return x;
                return y;
            }
        }
    }

    public static class FieldCalculator
    {
        private static bool ChangeFieldIfCan(int x, int y, Pair[] relations, int value)
        {
            if (value != 0)
            {
                if (field[x, y] != 0)
                    return false;
                foreach (var relation in relations)
                {
                    int x1 = x + relation[0];
                    int y1 = y + relation[1];
                    if (x1 < 0 || y1 < 0 || x1 >= Form1.n || y1 >= Form1.n || field[x1, y1] != 0)
                        return false;
                }
            }
            
            field[x, y] = value;
            foreach (var relation in relations)
            {
                int x1 = x + relation[0];
                int y1 = y + relation[1];
                field[x1, y1] = value;
            }
            return true;
        }

        public static bool CanPaveRec(int x, int y, int value)
        {
            int k = 0;
            while (k != figures.Count)
            {
                var figure = figures[k];
                if (ChangeFieldIfCan(x, y, figure, value))
                {

                    int x1 = x, y1 = y;
                    while (!(x1 >= Form1.n) && field[x1, y1] != 0)
                    {
                        y1++;
                        if (y1 == Form1.n)
                        {
                            y1 = 0;
                            x1++;
                        }
                    }
                    if (x1 >= Form1.n)
                    {
                        return true;
                    }
                    figures.RemoveAt(k);
                    bool tmpRes = CanPaveRec(x1, y1, value + 1);
                    if (tmpRes)
                    {
                        return true;
                    }
                    figures.Insert(k, figure);
                    ChangeFieldIfCan(x, y, figure, 0);
                }
                k++;
            }
            return false;
        }
        public static bool CanPave(int[,] field2, List<Pair[]> figures2)
        {
            field = field2;
            figures = figures2;
            int sx = -1; int sy = -1;
            for(int i = 0; i < Form1.n; i++)
            {
                for (int j = 0; j < Form1.n; j++)
                {
                    if(field[i, j] == 0)
                    {
                        sx = i;
                        sy = j;
                        break;
                    }
                }
                if (sx != -1)
                    break;
            }
            if (sx == -1)
                return false;
            return CanPaveRec(sx, sy, 1);
        }

        static int[,] field;
        static List<Pair[]> figures;
        static int[][] directions = new int[][]
        {
            new int[]{ 1, 0},
            new int[]{ 0, 1},
            new int[]{ -1, 0},
            new int[]{ 0, -1}
        };
        static bool[,] visited;
        static List<Pair> curFigure;
        static int x1, y1;
        static bool[,] boolField;

        static void FindFigure(int x, int y)
        {
            for(int i = 0; i < 4; i++)
            {
                int[] direction = directions[i];
                int x2 = x + direction[0], y2 = y + direction[1];
                if (x2 >= Form1.n || x2 < 0 || y2 >= Form1.n || y2 < 0)
                    continue;
                if(boolField[x2, y2] && !visited[x2, y2])
                {
                    curFigure.Add(new Pair(x2 - x1, y2 - y1));
                    visited[x2, y2] = true;
                    FindFigure(x2, y2);
                }
            }
        }

        public static Pair[][] FindFigures(bool[,] field)
        {
            boolField = field;
            visited = new bool[Form1.n, Form1.n];
            var figures = new List<List<Pair>>();
            for(int i = 0; i < Form1.n; i++)
            {
                for(int j = 0; j < Form1.n; j++)
                {
                    if(field[i, j] && !visited[i, j])
                    {
                        x1 = i;
                        y1 = j;
                        curFigure = new List<Pair>() { new Pair(0, 0)};
                        visited[i, j] = true;
                        FindFigure(i, j);
                        figures.Add(curFigure);
                    }
                    visited[i, j] = true;
                }
            }
            var res = new Pair[figures.Count][];
            for(int i = 0; i < figures.Count; i++)
            {
                res[i] = new Pair[figures[i].Count];
                for(int j = 0; j < figures[i].Count; j++)
                {
                    res[i][j] = figures[i][j];
                }
            }
            return res;
        }
    }
}
