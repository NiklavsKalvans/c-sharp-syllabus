using System;

namespace PositiveNegativeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number.");
            var input = Console.ReadLine();

            if (Convert.ToInt32(input) > 0)
            {
                Console.WriteLine("Number is positive");
            } 
            else if (Convert.ToInt32(input) < 0) 
            {
                Console.WriteLine("Number is negative");
            } 
            else 
            {
                Console.WriteLine("Number is zero");
            }
            Console.ReadLine();
        }
    }
}
