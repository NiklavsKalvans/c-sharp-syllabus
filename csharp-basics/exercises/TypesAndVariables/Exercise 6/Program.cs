using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 single digit numbers!");
            var number1 = Console.ReadLine();
            var number2 = Console.ReadLine();
            var number3 = Console.ReadLine();
            var number4 = Console.ReadLine();
            var number5 = Console.ReadLine();

            var sumOfNumbers = Convert.ToInt32(number1) + Convert.ToInt32(number2) + Convert.ToInt32(number3) + Convert.ToInt32(number4) + Convert.ToInt32(number5);
            Console.WriteLine($"The sum of all the numbers you entered is:{sumOfNumbers}");
        }
    }
}
