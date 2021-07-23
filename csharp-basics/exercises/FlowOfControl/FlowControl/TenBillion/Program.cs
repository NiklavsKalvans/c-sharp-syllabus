using System;

namespace TenBillion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");

            var input = Console.ReadLine();

            if (Convert.ToInt64(input) is long) 
            {
                if (Convert.ToInt64(input) < 0) 
                {
                    long negativeToPositive = Convert.ToInt64(input);
                    negativeToPositive *= -1;
                    input = Convert.ToString(negativeToPositive);
                }
                if (Convert.ToInt64(input) >= 10000000000) 
                {
                    Console.WriteLine("Number is greater or equals 10,000,000,000!");
                } 
                else 
                {
                    int digits = 1;
                    if (Convert.ToInt64(input) > 9) 
                    {
                        digits = 2;
                    } 
                    if (Convert.ToInt64(input) > 99) 
                    {
                        digits = 3;
                    } 
                    if (Convert.ToInt64(input) > 999) 
                    {
                        digits = 4;
                    } 
                    if (Convert.ToInt64(input) > 9999) 
                    {
                        digits = 5;
                    } 
                    if (Convert.ToInt64(input) > 99999) 
                    {
                        digits = 6;
                    } 
                    if (Convert.ToInt64(input) > 999999) 
                    {
                        digits = 7;
                    } 
                    if (Convert.ToInt64(input) > 9999999) 
                    {
                        digits = 8;
                    } 
                    if (Convert.ToInt64(input) > 999999999) 
                    {
                        digits = 9;
                    } 
                    if (Convert.ToInt64(input) > 9999999999) 
                    {
                        digits = 10;
                    }

                    Console.WriteLine("Number of digits in the number: " + digits);
                }
            } 
            else 
            {
                Console.WriteLine("The number is not a long");
            }
            Console.ReadLine();
        }
    }
}
