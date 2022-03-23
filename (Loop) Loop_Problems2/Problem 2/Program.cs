using System;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int number = randomNumber.Next(1,101);
            Console.WriteLine(number);
            int userGuess,
                guessCounter = 1,
                minNumber = 1,
                maxNumber = 100;
            bool validGuess = false;
            Console.WriteLine("This is a number guessing game.");

            do
            {
                Console.Write($"Enter your guess({minNumber}-{maxNumber}): ");
                validGuess = int.TryParse(Console.ReadLine(), out userGuess);

                if (validGuess && (userGuess >= 1 && userGuess <= 100))
                {
                    if (userGuess < number)
                    {
                        Console.WriteLine("Your guess is too low.\n");
                        minNumber = userGuess;
                        guessCounter++;
                    }
                    else if (userGuess > number)
                    {
                        Console.WriteLine("Your guess is too high.\n");
                        maxNumber = userGuess;
                        guessCounter++;
                    }
                    else
                    {
                        Console.WriteLine("Your guess is correct.\n");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid guess, Try again.\n");
                }
            }while (userGuess != number);

            Console.WriteLine($"Your total number of guesses is {guessCounter}");
        }
    }
}
