using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCount
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = File.ReadAllText("../../lear.txt");
            string string1 = Regex.Replace(path, "[?!,.']", " ");
            string string2 = Regex.Replace(string1, @"\s+", " ");
            string2 = string2.Remove(string2.Length - 1, 1) + ".";

            Console.WriteLine(path);
            Console.WriteLine("Total lines: " + CountLines(path));
            Console.WriteLine("Total words: " + CountWords(string2));
            Console.WriteLine("Total chars: " + CountChars(path));
            Console.ReadKey();
        }

        public static int CountLines(string text)
        {
            return text.Split('\n').Length;
        }

        public static int CountWords(string text)
        {
            return text.Split(' ').Length;
        }

        public static int CountChars(string text)
        {
            return text.Length;
        }
    }
}
