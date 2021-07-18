using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers! I will tell you if either one of them is 15 or prehaps their sum or difference is 15!");
            var number1 = Console.ReadLine();
            var number2 = Console.ReadLine();

            if (Convert.ToInt32(number1) == 15 || Convert.ToInt32(number2) == 15)
            {
                Console.WriteLine(true);
            }
            else if (Convert.ToInt32(number1) + Convert.ToInt32(number2) == 15)
            {
                Console.WriteLine(true);
            }
            else if (Convert.ToInt32(number1) - Convert.ToInt32(number2) == 15)
            {
                Console.WriteLine(true);
            }
            else Console.WriteLine(false); ;
        }
    }
}
