using System;

namespace Exercise_7
{
    class Piglet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piglet!");
            Random randNum = new Random();
            int sum = 0;
            bool isPlaying = true;
            while(isPlaying)
            {
                int roll = randNum.Next(1, 6);
                Console.WriteLine($"You rolled: {roll}");
                if (roll == 1)
                {
                    Console.WriteLine("You lose");
                    sum = 1;
                    isPlaying = false;
                    break;
                }   
                sum += roll;
                Console.WriteLine("Do you roll again? y/n");
                char input = char.Parse(Console.ReadLine());
                if (input == 'n')
                {
                    isPlaying = false;
                    Console.WriteLine($"Thanks for the game! Your score: {sum}");
                }
            }
        }
    }
}
