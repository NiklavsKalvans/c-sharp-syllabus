using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
            var inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber < randomNumber)
            {
                Console.WriteLine($"Sorry, you are too low.  I was thinking of {randomNumber}.");
            }
            if (inputNumber > randomNumber)
            {
                Console.WriteLine($"Sorry, you are too high.  I was thinking of {randomNumber}.");
            } 
            if (inputNumber == randomNumber)
            {
                Console.WriteLine("You guessed it!  What are the odds?!?");
            }  
        }
    }
}
