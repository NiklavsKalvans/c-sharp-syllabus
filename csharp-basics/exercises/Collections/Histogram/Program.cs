using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        private const string Path = "../../midtermscores.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);
            foreach (var s in readText)
            {
                Console.WriteLine(s);
            }

            var grades = new List<string> { "00-09: ", "10-19: ", "20-29: ", "30-39: ", "40-49: ", "50-59: ", "60-69: ", "70-79: ", "80-89: ", "90-99: ", "  100: " };
            var splitText = string.Join(" ", readText).Split(' ');
            for (int i = 0; i < splitText.Length; i++)
            {
                var num = Convert.ToInt32(splitText[i]);
                if (num >= 0 && num <= 9) grades[0] += "*";
                else if (num >= 10 && num <= 19) grades[1] += "*";
                else if (num >= 20 && num <= 29) grades[2] += "*";
                else if (num >= 30 && num <= 39) grades[3] += "*";
                else if (num >= 40 && num <= 49) grades[4] += "*";
                else if (num >= 50 && num <= 59) grades[5] += "*";
                else if (num >= 60 && num <= 69) grades[6] += "*";
                else if (num >= 70 && num <= 79) grades[7] += "*";
                else if (num >= 80 && num <= 89) grades[8] += "*";
                else if (num >= 90 && num <= 99) grades[9] += "*";
                else if (num == 100) grades[10] += "*";
            }

            foreach (string grade in grades)
            {
                Console.WriteLine(grade);
            }
            
            Console.ReadKey();
        }
    }
}
