using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Tetris
{
    public class Program
    {
        private enum ResultOfInitialize : byte { False, True, VeryNice};
        static bool[,] field;
        static int[] countOfTypes;
        static int[,] pField; // printable field

        static int maxX, maxY;
        static int cursX, cursY;

        public static bool CanPaveRec(int x, int y, int value)
        {
            for(int type = 0; type < FieldCalculator.countOftypes; type++)
            {
                if (countOfTypes[type] == 0)
                    continue;
                int maxRotaion = FieldCalculator.maxRotations[type];
                for(int rotation = 0; rotation < maxRotaion; rotation++)
                {
                    if(FieldCalculator.AddItemIfCan(field, maxX, maxY, x, y, type, rotation))
                    {
                        int x1 = x, y1 = y;
                        while (!(y1>=maxY) && field[x1, y1])
                        {
                            x1++;
                            if(x1 == maxX)
                            {
                                x1 = 0;
                                y1++;
                            }
                        }
                        if (y1 >= maxY)
                        {
                            FieldCalculator.AddIntItem(pField, maxX, maxY, x, y, type, rotation, value);
                            return true;
                        }
                        countOfTypes[type]--;
                        bool tmpRes = CanPaveRec(x1, y1, value + 1);
                        if (tmpRes)
                        {
                            FieldCalculator.AddIntItem(pField, maxX, maxY, x, y, type, rotation, value);
                            return true;
                        }
                        countOfTypes[type]++;
                        bool IsntFailed = FieldCalculator.DeleteItemIfCan(field, maxX, maxY, x, y, type, rotation);
                        if (!IsntFailed)
                            return false;
                    }
                }
            }
            return false;
        }
        public static bool CanPave(int n, int m, int[] typesCount)
        {
            switch (Initialize(n, m, typesCount)){
                case ResultOfInitialize.False:
                    return false;
                case ResultOfInitialize.VeryNice:
                    return true;
            }
            field = new bool[n, m];
            pField = new int[n, m];
            return CanPaveRec(0, 0, 1);
        }

        private static ResultOfInitialize Initialize(int n, int m, int[] typesCount)
        {
            if (typesCount == null || typesCount.Length != FieldCalculator.countOftypes)
                return ResultOfInitialize.False;
            int sum = 0;
            for (int type = 0; type < FieldCalculator.countOftypes; type++)
                sum += typesCount[type] * FieldCalculator.countOfBlocks[type];
            if (sum != n * m || typesCount[5] % 2 != sum % 2) //only for this configuration of figures
                return ResultOfInitialize.False;
            if (sum == 0)
                return ResultOfInitialize.VeryNice;
            countOfTypes = typesCount;
            maxX = n;
            maxY = m;
            return ResultOfInitialize.True;
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            try
            {
                Console.WriteLine("Введите n и m через пробел:");
                int n, m;
                var strs = Console.ReadLine().Split();
                n = int.Parse(strs[0]);
                m = int.Parse(strs[1]);
                Console.WriteLine("Введите количество элементов I, J, L, O, S, T, Z соответственно:");
                strs = Console.ReadLine().Split();
                if (strs.Length != 7)
                    throw new Exception();
                int[] typesCount = new int[strs.Length];
                for (int i = 0; i < 7; i++)
                    typesCount[i] = int.Parse(strs[i]);
                System.Diagnostics.Stopwatch sw = new Stopwatch();
                sw.Start();
                if (CanPaveWithPrint(n, m, typesCount))
                {
                    FieldCalculator.PrintField(pField, maxX, maxY, Console.CursorLeft, Console.CursorTop);
                    Console.WriteLine("Замостить можно.");
                }
                else
                    Console.WriteLine("Замостить нельзя.");
                Console.WriteLine("Прошло " + (sw.ElapsedMilliseconds / 1000.0).ToString() + " секунд.");
            }
            catch (Exception)
            {
                Console.WriteLine("Неверные входные данные или ошибка работы программы.");
            }
        }

        public static bool CanPaveWithPrint(int n, int m, int[] typesCount)
        {
            switch (Initialize(n, m, typesCount))
            {
                case ResultOfInitialize.False:
                    return false;
                case ResultOfInitialize.VeryNice:
                    return true;
            }
            pField = new int[n, m];
            field = new bool[n, m];
            cursX = Console.CursorLeft;
            cursY = Console.CursorTop;
            Console.CursorVisible = false;
            bool res = CanPaveRecWithPrint(0, 0, 1);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.CursorVisible = true;
            Console.SetCursorPosition(0, cursY + m);
            return res;
        }

        public static bool CanPaveRecWithPrint(int x, int y, int value)
        {
            for (int type = 0; type < FieldCalculator.countOftypes; type++)
            {
                if (countOfTypes[type] == 0)
                    continue;
                int maxRotaion = FieldCalculator.maxRotations[type];
                for (int rotation = 0; rotation < maxRotaion; rotation++)
                {
                    if (FieldCalculator.AddItemIfCan(field, maxX, maxY, x, y, type, rotation))
                    {
                        FieldCalculator.AddIntItemAndPrint(pField, maxX, maxY, x, y, type, rotation, value, cursX, cursY);
                        int x1 = x, y1 = y;
                        while (!(y1 >= maxY) && field[x1, y1])
                        {
                            x1++;
                            if (x1 == maxX)
                            {
                                x1 = 0;
                                y1++;
                            }
                        }
                        if (y1 >= maxY)
                        {
                            //FieldCalculator.PrintField(pField, maxX, maxY, cursX, cursY);
                            return true;
                        }
                        countOfTypes[type]--;
                        bool tmpRes = CanPaveRecWithPrint(x1, y1, value + 1);
                        if (tmpRes)
                            return true;
                        countOfTypes[type]++;
                        bool IsntFailed = FieldCalculator.DeleteItemIfCan(field, maxX, maxY, x, y, type, rotation);
                        if (!IsntFailed)
                            return false;
                        FieldCalculator.AddIntItemAndPrint(pField, maxX, maxY, x, y, type, rotation, 0, cursX, cursY);
                    }
                }
            }
            //FieldCalculator.PrintField(pField, maxX, maxY, cursX, cursY);
            return false;
        }
    }
}
