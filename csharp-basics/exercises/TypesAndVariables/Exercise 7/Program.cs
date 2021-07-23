using System;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("Enter a string of letters and we will count how many capital letters it contains!");
            var text = Console.ReadLine();
            

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i])) count++;
            }

            Console.WriteLine($"The number of capital letters in your string is: {count}");
        }
    }
}
