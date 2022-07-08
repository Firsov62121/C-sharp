using System;
using System.IO;


namespace Files2
{
    public class Program
    {
        public static string Replace(string fileNameToRead, string fileNameToWrite, string from, string to)
        {
            char[] buffer;
            using (var sr = new StreamReader(fileNameToRead))
            {
                buffer = new Char[(int)sr.BaseStream.Length];
                sr.Read(buffer);
            }
            string text2 = new string(buffer);
            Console.WriteLine("Previous String: " + text2);
            text2 = text2.Replace(from, to);
            Console.WriteLine("New String: " + text2);
            using (var sw = new StreamWriter(fileNameToWrite))
            {
                sw.Write(text2);
                sw.Close();
            }
            return text2;
        }
        static void Main(string[] args)
        {
            string from = Console.ReadLine();
            string to = Console.ReadLine();
            string fileNameToRead = @"D:\основное\учеба\программирование Чернышев\задания\Files2\FileForFiles2.txt";
            string fileNameToWrite = @"D:\основное\учеба\программирование Чернышев\задания\Files2\FileFromFiles2.txt";
            Replace(fileNameToRead, fileNameToWrite, from, to);
        }
    }
}
