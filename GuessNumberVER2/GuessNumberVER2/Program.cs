using System;

namespace GuessNumberVER2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a number guessing game.");
            const int MinValue = 1;
            const int MaxValue = 100;
            const int MaxAttempts = 5;
            int attempt = MaxAttempts - 1;
            // Generate a random number to be guessed
            Random keygen = new Random();
            int number = keygen.Next(MinValue, MaxValue + 1);
            Console.WriteLine(number);

            // Prompt the user to guess the number
            Console.WriteLine($"You have {MaxAttempts} attempts left.");
            Console.Write($"Enter your guess between {MinValue} and {MaxValue}: ");
            int guess = int.Parse(Console.ReadLine());

            while (guess != number && attempt > 0)
            {
                if (guess > number)
                    Console.WriteLine("Your guess is too high");
                else
                    Console.WriteLine("Your guess is too low");

                Console.WriteLine();
                Console.WriteLine($"You have {attempt} attempts left.");
                Console.Write($"Enter your guess between {MinValue} and {MaxValue}: ");
                guess = int.Parse(Console.ReadLine());

                attempt--;
            }
            if (guess == number)
                Console.WriteLine("Yes, the number is " + number);
            else
                Console.WriteLine($"You have used all your attempts.");

        }
    }
}
