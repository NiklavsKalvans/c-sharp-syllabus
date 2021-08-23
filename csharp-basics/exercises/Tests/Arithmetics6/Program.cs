using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class Program
    {
        static void Main(string[] args)
        {
            int lenght = 110;
            string result = CozaLozaWoza(lenght);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static string CozaLozaWoza(int num)
        {
            string result = "";
            for (int i = 1; i <= num; i++)
            {
                if ((i - 1) % 11 == 0)
                    result += "\n";
                if (i % 105 == 0)
                    result += "CozaLozaWoza ";
                else if (i % 35 == 0)
                    result += "LozaWoza ";
                else if (i % 21 == 0)
                    result += "CozaWoza ";
                else if (i % 15 == 0)
                    result += "CozaLoza ";
                else if (i % 7 == 0)
                    result += "Woza ";
                else if (i % 5 == 0)
                    result += "Loza ";
                else if (i % 3 == 0)
                    result += "Coza ";
                else
                    result += $"{i} ";
            }
            return result;
        }
    }
}
