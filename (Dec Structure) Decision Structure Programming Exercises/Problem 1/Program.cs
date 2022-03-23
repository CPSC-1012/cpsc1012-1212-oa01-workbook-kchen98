/*  Purpose:    Ask the user to guess a coin flip and show whether they got it right or wrong
 *  
 *  Input:  heads or tails
 *  
 *  Output: correct or wrong
 *  
 *  Algorithm:  Step 1: Randomly generate an integer from 0 to 1.
 *              Step 2: Use if statement to assign heads and tails to 0 and 1 respectively.
 *              Step 3: Prompt the user to enter a guess
 *              Step 4: Display if they got it correctly or not or gave an invalid answer by using a
 *                          nested if statement.
 * */
using System;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Randomly generate an integer from 0 to 1.
            Random coin = new Random();
            int coinFlip = coin.Next(0,2);

            // Use if statement to assign heads and tails to 0 and 1 respectively.
            string flipResult;
            if(coinFlip == 0)
            {
                flipResult = "heads";
            }
            else
            {
                flipResult = "tails";
            }
            Console.WriteLine(flipResult);

            // Prompt the user to enter a guess
            Console.Write("Coin is flipped choose between heads or tails: ");
            string userAnswer = Console.ReadLine();

            /* Display if they got it correctly or not or gave an invalid answer by using a
 *                          nested if statement. */
            if (userAnswer == "heads" || userAnswer == "tails")
            {
                if (userAnswer == flipResult)
                {
                    Console.WriteLine("You guessed correctly");
                }
                else
                {
                    Console.WriteLine($"You guessed wrong, the coin was {flipResult}");
                }
            }
            else
            {
                Console.WriteLine("Invalid Answer");
            }
            
        }
    }
}
