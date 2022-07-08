using System;
using System.Collections.Generic;
using System.Text;

namespace FindNumber2
{
    sealed public class MainLogic
    {
        public const int EQUAL = 0;
        public const int LESS = 1;
        public const int MORE = 2;
        public const int OUT_OF_RANGE = 3;
        public const int REPEAT_OF_NUMBER = 4;
        public const int FAIL = 5;
        public const int BAD_ANSWER = 6;
        private int[] was;
        private int maxTrying, maxNumber, minNumber, num, tryingCount;

        public int TryingCount
        {
            get
            {
                return maxTrying - this.tryingCount;
            }
        }

        public MainLogic(int maxNumber = 9, int minNumber = 0, int maxTrying = 3)
        {
            this.tryingCount = 0;
            this.maxNumber = maxNumber;
            this.minNumber = minNumber;
            this.num = new Random().Next(minNumber, maxNumber);
            this.maxTrying = maxTrying;
            this.was = new int[maxTrying];
            for (int i = 0; i < maxTrying; i++)
            {
                was[i] = minNumber - 1;
            }
        }

        public string getPrevNumbers()
        {
            if (tryingCount == 0)
                return "Вы ещё не вводили ни одного числа!";
            StringBuilder res = new StringBuilder();
            res.Append("Вы уже вводили: ");
            for (int i = 0; i < tryingCount; i++)
            {
                if(i != 0)
                {
                    res.Append(", " + String.Format("{0}", was[i]));
                }
                else
                {
                    res.Append(String.Format("{0}", was[i]));
                }
            }
            return res.ToString();
        }

        public int checkNum(int n)
        {
            bool isBadAnswer = false;
            if (n != minNumber - 1)
            {
                foreach (int prev in was)
                {
                    if (prev == minNumber - 1)
                        break;
                    if (prev == n)
                        return REPEAT_OF_NUMBER;
                    if (prev > n && prev < num)
                        isBadAnswer = true;
                    if(prev > num && n > prev)
                        isBadAnswer = true;
                }
            }
            if (num > maxNumber || num < minNumber)
                return OUT_OF_RANGE;
            if (isBadAnswer)
                return BAD_ANSWER;
            was[tryingCount] = n;
            tryingCount++;
            if (n == num)
                return EQUAL;
            if (tryingCount == maxTrying)
                return FAIL;
            if (n < num)
                return LESS;
            return MORE;
        }
    }
}
