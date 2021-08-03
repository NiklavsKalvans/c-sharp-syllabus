using System;

namespace Exercise_9
{
    class RollTwoDice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sum of 2 dices you want to roll! (2-12)");
            int input = int.Parse(Console.ReadLine());
            bool isEqual = false;
            Random randNum = new Random();
            Console.WriteLine($"Desired sum {input}");
            while (isEqual == false)
            {
                int dice1 = randNum.Next(1, 6);
                int dice2 = randNum.Next(1, 6);
                int sum = dice1 + dice2;
                Console.WriteLine($"{dice1} + {dice2} = {sum}");
                if (sum == input)
                {
                    isEqual = true;
                }
            }
        }
    }
}
