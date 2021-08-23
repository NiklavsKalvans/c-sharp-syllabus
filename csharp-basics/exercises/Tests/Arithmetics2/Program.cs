using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CheckOddEven! Enter a number and find out is it odd or even!");
            int number = int.Parse(Console.ReadLine());
            if (IsEvenNumber(number))
            {
                Console.WriteLine("Even number");
            }
            else Console.WriteLine("Odd Number");

            Console.WriteLine("Bye!");
            Console.ReadKey();
        }

        public static bool IsEvenNumber(int num)
        {
            if (num % 2 == 0) return true;
            else return false;
        }
    }
}
