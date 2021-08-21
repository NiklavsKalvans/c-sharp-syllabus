using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CheckOddEven! Enter a number and find out is it odd or even!");
            var number = Console.ReadLine();

            if (Convert.ToInt32(number) % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else Console.WriteLine("Odd Number");
            Console.WriteLine("Bye!");
        }
    }
}
