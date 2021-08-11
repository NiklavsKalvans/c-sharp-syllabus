using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = File.ReadAllText("../../lear.txt");

            string string1 = Regex.Replace(path, "[?!,.']", " ");
            string string2 = Regex.Replace(string1, @"\s+", " ");
            string2 = string2.Remove(string2.Length - 1, 1) + ".";

            Console.WriteLine(path);
            Console.WriteLine("Total lines: " + path.Split('\r').Length);
            Console.WriteLine("Total words: " + string2.Split(' ').Length);
            Console.WriteLine("Total chars: " + path.Length);

            Console.ReadKey();
        }
    }
}
