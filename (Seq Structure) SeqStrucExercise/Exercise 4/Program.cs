/*  Purpose: Calculates and Displays the sum of all digits prompted from the user that ranges
 *              from 0 to 1000
 *              
 *  Input:  userInput
 *  
 *  Output: sumDigits
 *  
 *  Algorithm:  Step 1: Prompts the user for an integer value between 0 to 1000.
 *              Step 2: Calculates the sum of all digits prompted from the user using this formula:
 *                          sumDigits = (userInput % 10) + ((userInput / 10) % 10) + 
 *                          ((userInput / 100) % 10) + ((userInput / 1000) % 10)
 *              Step 3: Displays the value the added digits.
 **/
using System;

namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring the variables used for input and output
            int userInput,
                sumDigits;

            // Step 1: Prompts the user for an integer value between 0 to 1000.
            Console.WriteLine("Enter a number between 0 and 1000: ");
            userInput = int.Parse(Console.ReadLine());

            // Step 2: Calculates the sum of all digits prompted from the user using this formula:
            sumDigits = (userInput % 10) + ((userInput / 10) % 10) + ((userInput / 100) % 10) + 
                        ((userInput / 1000) % 10);

            // Step 3: Displays the value the added digits.
            Console.Write($"The sum of the digits is {sumDigits}");

        }
    }
}
