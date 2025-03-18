using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge.challengesClass
{
    class GuessNumber
    {
        public static void Play()
        {
            Random random = new Random();
            int targetNumber = random.Next(0, 101);
            int attempts = 10;
            bool guessedCorrectly = false;

            Console.WriteLine("You have 10 chances to guess the number between 0 and 100.");

            for (int i = 1; i <= attempts; i++)
            {
                Console.Write($"\nAttempt {i}/{attempts}: Enter your guess: ");
                if (!int.TryParse(Console.ReadLine(), out int userGuess) || userGuess < 0 || userGuess > 100)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                    continue;
                }

                if (userGuess == targetNumber)
                {
                    Console.WriteLine($"Congratulations! You guessed the number {targetNumber} correctly in {i} attempts.");
                    guessedCorrectly = true;
                    break;
                }
                else if (userGuess < targetNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else
                {
                    Console.WriteLine("Too high! Try again.");
                }
            }

            if (!guessedCorrectly)
            {
                Console.WriteLine($"\nGame over! The correct number was {targetNumber}.");
            }
        }
    }
}
