using System;

namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a number guessing game.");
            const int minValue = 1;
            const int maxValue = 100;

            // Generate a random number to be guessed
            Random keygen = new Random();
            int number = keygen.Next(minValue, maxValue + 1);

            // Prompt the user to guess the number
            Console.Write($"Enter your guess between {minValue} and {maxValue}: ");
            int guess = int.Parse(Console.ReadLine());

            while (guess != number)
            { 
                if (guess > number)
                    Console.WriteLine("Your guess is too high");
                else
                    Console.WriteLine("Your guess is too low");

                Console.Write($"Enter your guess between {minValue} and {maxValue}: ");
                guess = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Yes, the number is " + number);
        }
    }
}
