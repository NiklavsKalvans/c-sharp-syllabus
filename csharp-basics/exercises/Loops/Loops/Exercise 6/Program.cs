using System;

namespace Exercise_6
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number!");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if ((i-1) % 20 == 0 && i-1 !=0)
                {
                    Console.WriteLine();
                    if(i % 3 == 0 && i % 5 == 0)
                        Console.Write("FizzBuzz ");
                    else if (i % 5 == 0)
                        Console.Write("Buzz ");
                    else if (i % 3 == 0)
                        Console.Write("Fizz ");
                    else Console.Write($"{i} ");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                    Console.Write("FizzBuzz ");
                else if (i % 5 == 0)
                    Console.Write("Buzz ");
                else if (i % 3 == 0)
                    Console.Write("Fizz ");
                else Console.Write($"{i} ");
            }
        }
    }
}
