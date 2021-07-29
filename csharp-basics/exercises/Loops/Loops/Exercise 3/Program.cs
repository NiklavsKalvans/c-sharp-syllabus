using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the position of the number you want to find out of 20(0-19) numbers!");
            int position = int.Parse(Console.ReadLine());
            int[] nums = new int[20];
            Random randNum = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = randNum.Next();
            }
            Console.WriteLine($"Number in the position {position} is {nums[position]}");
            Console.ReadKey();
        }
    }
}
