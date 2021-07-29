using System;

namespace Exercise_10
{
    class NumberSquare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the minimum and maximum number!");
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            for (int i = min; i <= max; i++)
            {

                for (int j = i; j <= max; j++)
                {
                    Console.Write(j);
                }
                for (int j = min; j < i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine(); 
            }
        }

    }   
    
}
