﻿using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            var input1 = Console.ReadLine();

            Console.WriteLine("Input the 2nd number: ");
            var input2 = Console.ReadLine();

            Console.WriteLine("Input the 3rd number: ");
            var input3 = Console.ReadLine();
         
            if (Convert.ToInt32(input1) > Convert.ToInt32(input2) && Convert.ToInt32(input1) > Convert.ToInt32(input3))
            {
                Console.WriteLine($"The largest number you entered is: {input1}");
            }
            else if (Convert.ToInt32(input2) > Convert.ToInt32(input1) && Convert.ToInt32(input2) > Convert.ToInt32(input3))
            {
                Console.WriteLine($"The largest number you entered is: {input2}");
            }
            else if (Convert.ToInt32(input3) > Convert.ToInt32(input1) && Convert.ToInt32(input3) > Convert.ToInt32(input2))
            {
                Console.WriteLine($"The largest number you entered is: {input3}");
            }
            Console.ReadLine();
        }
    }
}
