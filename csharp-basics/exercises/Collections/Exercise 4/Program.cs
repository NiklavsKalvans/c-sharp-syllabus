using System;
using System.Collections.Generic;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number and find out if its happy!");
            int input = int.Parse(Console.ReadLine());
            if (isHappy(input))
                Console.WriteLine("Yes! This is a happy number!");
            else
                Console.WriteLine("No... Sadly this is not a happy number..");
        }
        static int sumDigitSquare(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }
            return sum;
        }

        static bool isHappy(int n)
        {
            HashSet<int> s = new HashSet<int>();
            s.Add(n);
            while (true)
            {
                if (n == 1)
                {
                    return true;
                }
                    
                n = sumDigitSquare(n);
                if (s.Contains(n))
                {
                    return false;
                } 
                s.Add(n);
            }
        }
    }
}
