using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 words!");
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            int count = word1.Length + word2.Length;
            string dots = "";
            for (int i = 0; i < 30-count; i++)
            {
                dots += ".";
            }
            Console.WriteLine(word1 + dots + word2);
        }
    }
}
