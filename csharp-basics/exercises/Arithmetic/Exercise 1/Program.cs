using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers! I will tell you if either one of them is 15 or prehaps their sum or difference is 15!");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            if (number1 == 15 ||number2 == 15 || number1 + number2 == 15 || number1 - number2 == 15)
            {
                Console.WriteLine(true);
            }
            else Console.WriteLine(false); ;
        }
    }
}
