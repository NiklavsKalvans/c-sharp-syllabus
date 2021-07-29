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
            int[] arr = new int[max];
            int index = 0;
            for (int i = min; i <= max; i++)
            {
                arr[index++] = i;
            }
            foreach (int num in arr)
            {
                Console.Write(num);
            }
            Console.WriteLine();
            while (min < max)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = min + ++i;
                    if (min + ++i > max)
                    {
                        arr[i] = min++;
                    }
                }
                foreach (int num in arr)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
            }
        }   
    }
}
