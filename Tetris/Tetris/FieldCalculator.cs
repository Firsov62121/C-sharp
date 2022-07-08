using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
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

    static public class FieldCalculator
    {

        public static readonly int countOftypes = 7;

        public static int[] maxRotations = new int[] { 2, 4, 4, 1, 2, 4, 2 };
        public static int[] countOfBlocks = new int[] { 4, 4, 4, 4, 4, 4, 4 };


        //Figures by different rotations with respect to (x,y), first Pair is (0,0)
        //Pair[type][rotation][numOfPoint - 1]
        private static Pair[][][] types = new Pair[][][]
        {
            new Pair[][] // I
            {
                new Pair[] { new Pair(1,0), new Pair(2,0), new Pair(3,0) },
                new Pair[] { new Pair(0,1), new Pair(0,2), new Pair(0,3) }
            },
            new Pair[][] // J
            {
                new Pair[] { new Pair(0,1), new Pair(1,1), new Pair(2,1) },
                new Pair[] { new Pair(1,0), new Pair(0,1), new Pair(0,2) },
                new Pair[] { new Pair(1,0), new Pair(2,0), new Pair(2,1) },
                new Pair[] { new Pair(0,1), new Pair(0,2), new Pair(-1,2) }
            },
            new Pair[][] // L
            {
                new Pair[] { new Pair(0,1), new Pair(-1,1), new Pair(-2,1) },
                new Pair[] { new Pair(0,1), new Pair(0,2), new Pair(1,2) },
                new Pair[] { new Pair(1,0), new Pair(2,0), new Pair(0,1) },
                new Pair[] { new Pair(1,0), new Pair(1,1), new Pair(1,2) }
            },
            new Pair[][] // O
            {
                new Pair[] { new Pair(1,0), new Pair(1,1), new Pair(0,1) }
            },
            new Pair[][] // S
            {
                new Pair[] { new Pair(1,0), new Pair(0,1), new Pair(-1,1) },
                new Pair[] { new Pair(0,1), new Pair(1,1), new Pair(1,2) }
            },
            new Pair[][] // T
            {
                new Pair[] { new Pair(-1,1), new Pair(0,1), new Pair(1,1) },
                new Pair[] { new Pair(0,1), new Pair(1,1), new Pair(0,2) },
                new Pair[] { new Pair(1,0), new Pair(2,0), new Pair(1,1) },
                new Pair[] { new Pair(0,1), new Pair(-1,1), new Pair(0,2) }
            },
            new Pair[][] // Z
            {
                new Pair[] { new Pair(1,0), new Pair(1,1), new Pair(2,1) },
                new Pair[] { new Pair(0,1), new Pair(-1,1), new Pair(-1,2) }
            }
        };

        private static bool ChangeFieldIfCan(bool[,] field, int n, int m, int x, int y, int type, int rotation, bool value)
        {
            if (y < 0 || y >= m || x < 0 || x >= n)
                return false;
            type %= countOftypes;
            rotation %= maxRotations[type];
            Pair[] relations = types[type][rotation];
            if (field[x, y] == value)
                return false;
            foreach (var relation in relations)
            {
                int x1 = x + relation[0];
                int y1 = y + relation[1];
                if (x1 < 0 || y1 < 0 || x1 >= n || y1 >= m || field[x1, y1] == value)
                    return false;
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

        static public bool AddItemIfCan(bool[,] field, int n, int m, int x, int y, int type, int rotation)
        {
            return ChangeFieldIfCan(field, n, m, x, y, type, rotation, true);
        }
        static public bool DeleteItemIfCan(bool[,] field, int n, int m, int x, int y, int type, int rotation)
        {
            return ChangeFieldIfCan(field, n, m, x, y, type, rotation, false);
        }


        //additional functionality
        public static bool PrintField(int[,] field, int n, int m, int cursX, int cursY)
        {
            if (field == null)
                return false;
            Console.SetCursorPosition(cursX, cursY);
            Console.CursorVisible = false;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (field[j, i] == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("  ");
                        continue;
                    }
                    int value = 1 + field[j, i] % 15;
                    Console.BackgroundColor = (ConsoleColor)value;
                    Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.CursorVisible = true;
            return true;
        }

        public static bool AddIntItemAndPrint(int[,] field, int n, int m, int x, int y, int type, int rotation, int value, int cursX, int cursY)
        {
            type %= countOftypes;
            rotation %= maxRotations[type];
            Pair[] relations = types[type][rotation];
            field[x, y] = value;
            Console.SetCursorPosition(cursX + 2 * x, cursY + y);
            if (value == 0)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("  ");
            }
            else
            {
                int value2 = 1 + value % 15;
                Console.BackgroundColor = (ConsoleColor)value2;
                Console.Write("  ");
            }
            foreach (var relation in relations)
            {
                int x1 = x + relation[0];
                int y1 = y + relation[1];
                field[x1, y1] = value;
                Console.SetCursorPosition(cursX + 2 * x1, cursY + y1);
                if (value == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("  ");
                    continue;
                }
                int value2 = 1 + value % 15;
                Console.BackgroundColor = (ConsoleColor)value2;
                Console.Write("  ");
            }
            return true;
        }

        public static bool AddIntItem(int[,] field, int n, int m, int x, int y, int type, int rotation, int value)
        {
            type %= countOftypes;
            rotation %= maxRotations[type];
            Pair[] relations = types[type][rotation];
            field[x, y] = value;
            foreach (var relation in relations)
            {
                int x1 = x + relation[0];
                int y1 = y + relation[1];
                field[x1, y1] = value;
            }
            return true;
        }
    }
}
