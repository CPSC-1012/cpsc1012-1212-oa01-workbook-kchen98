/*  Purpose:    To prompt user for a number and display if the number is positive, zero or negative.
 *  
 *  Input:  Any real number
 *  
 *  Output: positive, negative or zero indicator
 *  
 *  Algorithm:  Step 1: Prompt the user for any real number.
 *              Step 2: Use an if statement to find out whether the user's number is positive,
 *                          negative or zero
 **/
using System;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for any real number.
            Console.Write("Enter any real number: ");
            double userNumber = double.Parse(Console.ReadLine());

            /*  Use an if statement to find out whether the user's number is positive,
                    negative or zero. */
            if (userNumber > 0)
            {
                Console.WriteLine("Your number is positive");
            }
            else if (userNumber < 0)
            {
                Console.WriteLine("Your number is negative");
            }
            else
            {
                Console.WriteLine("Your number is zero");
            }
        }
    }
}
