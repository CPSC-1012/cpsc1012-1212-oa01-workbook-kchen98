using System;

namespace GuessNumberVER4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a number guessing game.");
            int minValue = 1;
            int maxValue = 100;
            const int MaxAttempts = 5;
            int attempt = MaxAttempts - 1;

            // Generate a random number to be guessed
            Random keygen = new Random();
            bool playAgain = true;

            while (playAgain)
            {
                int number = keygen.Next(minValue, maxValue + 1);
                Console.WriteLine(number);

                // Prompt the user to guess the number
                Console.WriteLine($"You have {MaxAttempts} attempts left.");
                Console.Write($"Enter your guess between {minValue} and {maxValue}: ");
                int guess = int.Parse(Console.ReadLine());

                while (guess != number && attempt > 0)
                {
                    if (guess > number)
                    {
                        Console.WriteLine("Your guess is too high");
                        maxValue = guess;
                    }
                    else
                    {
                        Console.WriteLine("Your guess is too low");
                        minValue = guess;
                    }

                    Console.WriteLine();
                    Console.WriteLine($"You have {attempt} attempts left.");
                    Console.Write($"Enter your guess between {minValue} and {maxValue}: ");
                    guess = int.Parse(Console.ReadLine());

                    attempt--;
                }
                if (guess == number)
                {
                    Console.WriteLine();
                    Console.WriteLine("Yes, the number is " + number);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"You have used all your attempts.");
                }

                minValue = 1;
                maxValue = 100;
                Console.WriteLine();
                Console.Write("Do you want to play again (y): ");
                playAgain = Console.ReadLine().ToLower() == "y";
            }
        }
    }
}
