using Microsoft.VisualBasic.CompilerServices;
using System;

namespace SpainTranslate2
{
    public class Program
    {
        private const int million = 1000000;
        public static int p;
        static string[] dictFromOneToTwenty =
        {
            "cero",
            "uno",
            "dos",
            "tres",
            "cuatro",
            "cinco",
            "sies",
            "siete",
            "ocho",
            "nueve",
            "diez",
            "once",
            "doce",
            "trece",
            "catorce",
            "quince",
            "dieciseis",
            "diecisiete",
            "dieciocho",
            "diecinueve",
            "viente"
        };

        static string[] dictFrom30To90 =
        {
            "",
            "",
            "vienti",
            "treinta",
            "cuarenta",
            "cincuenta",
            "sesenta",
            "setenta",
            "ochenta",
            "noventa"
        };

        static string[] dictFrom100To900 =
        {
            "cien",
            "ciento",
            "doscient",
            "trescient",
            "cuatrocient",
            "quinient",
            "seiscient",
            "setecient",
            "ochocient",
            "novecient",
            "mil",
            "un millon",
            "milliones"
        };

        static string Spain100(int n)
        {
            string one = p == 1 ? "un" : "una";
            if (n == 1)
                return one;
            if (n <= 20)
                return dictFromOneToTwenty[n];
            int tens = n / 10;
            int units = n % 10;
            if(units == 1)
            {
                if(tens == 2)
                {
                    return dictFrom30To90[tens] + one;
                }
                return dictFrom30To90[tens] + " y " + one;
            }
            if (tens == 2)
                return dictFrom30To90[tens] + dictFromOneToTwenty[units];
            if (units == 0)
                return dictFrom30To90[tens];
            return dictFrom30To90[tens] + " y " + dictFromOneToTwenty[units];
        }
        static string Spain1000(int n)
        {
            if (n > 100)
            {
                int i1 = n / 100;
                int i2 = n % 100;
                string lastLetters = i1 == 1 ? "" : (p == 1 ? "os" : "as");
                if (i2 == 0)
                    return dictFrom100To900[i1] + lastLetters ;
                return dictFrom100To900[i1] + lastLetters + " " + Spain100(i2);
            }
            if (n == 100)
                return dictFrom100To900[0];
            return Spain100(n);
        }

        static string Spain10_6(int n)
        {
            if (n < 1000)
                return Spain1000(n);
            if (n == 1000)
                return dictFrom100To900[10];
            return (Spain1000(n / 1000) + " " + dictFrom100To900[10] +
                ", " + Spain1000(n % 1000));
        }

        public static string Spain10_9(int n)
        {
            if (n < million)
                return Spain10_6(n);
            if (n == million)
                return dictFrom100To900[11];
            return Spain1000(n / million) + " " + dictFrom100To900[12] +
                ", " + Spain10_6(n % million);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите пол (1 - м, 0 - ж): ");
            p = Console.ReadLine() == "1" ? 1 : 0;
            Console.WriteLine("Введите число: ");
            Console.WriteLine(Spain10_9(int.Parse(Console.ReadLine())));
        }
    }
}
