using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hangman!!!!!!!!!!");
            string[] listwords = new string[10];
            listwords[0] = "anxiety";
            listwords[1] = "nuclear";
            listwords[2] = "depression";
            listwords[3] = "extract";
            listwords[4] = "annihilation";
            listwords[5] = "productivity";
            listwords[6] = "south";
            listwords[7] = "dimensions";
            listwords[8] = "jackpot";
            listwords[9] = "succulent";

            Random randGen = new Random();
            var index = randGen.Next(0, 9);
            string mysteryWord = listwords[index];
            char[] guess = new char[mysteryWord.Length];
            Console.Write("Please enter your guess: ");
            int tries = 0;
            string allGuesses = "";
            for (int p = 0; p < mysteryWord.Length; p++)
                guess[p] = '_';
            bool isPlaying = true;

            while (isPlaying == true)
            {
                if (Convert.ToString(guess) == mysteryWord)
                {
                    Console.WriteLine("You won!");
                    isPlaying = false;
                }
                else if (tries > 15)
                {
                    Console.WriteLine("You lose! try again!");
                    isPlaying = false;
                }

                char playerGuess = char.Parse(Console.ReadLine());
                tries++;
                allGuesses += playerGuess;
                for (int i = 0; i < mysteryWord.Length; i++)
                {
                    if (playerGuess == mysteryWord[i])
                    {
                        guess[i] = playerGuess;
                    }

                }
                Console.WriteLine(guess);
                Console.WriteLine($"Letters you have tried - {allGuesses}");
                Console.WriteLine($"You have guessed {tries} times");
            }

        }
    }
}