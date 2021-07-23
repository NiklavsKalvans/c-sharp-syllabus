using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many minutes would you like to convert to years/days");
            var minutes = Console.ReadLine();

            int days = Convert.ToInt32(minutes) / 1440;
            int years = Convert.ToInt32(minutes) / 525600;

            Console.WriteLine($"The entered minutes amount to {years} years or {days} days.");
        }
    }
}
