using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers! I will tell you if either one of them is 15 or prehaps their sum or difference is 15!");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            bool result = IsEitherNumFifteenOrIsSumOrDiffFifteen(number1, number2);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        
        public static bool IsEitherNumFifteenOrIsSumOrDiffFifteen(int num1, int num2)
        {
            if (num1 == 15 || num2 == 15 || num1 + num2 == 15 || num1 - num2 == 15 || num2 - num1 == 15) return true;
            else return false;
        }
    }
}
