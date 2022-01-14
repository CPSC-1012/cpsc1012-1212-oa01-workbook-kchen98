/*  Purpose: To display the three digit number prompted from the user 
 *              and the sum of it's digits.
 *              
 *  Input: whole number
 *  
 *  Output: whole number
 *          sum of digits
 *          
 *  Algorithm: Step 1: Prompt the user for a three digit whole number.
 *             Step 2: Calculate the sum of digits using the following formula:
 *                          sumOfDigits = (wholeNumber % 10) + ((wholeNumber / 10) % 10) + 
 *                              ((wholeNumber / 100) % 10);
 *             Step 3: Displays the number entered by the user and the sum of it's digits.
 **/
using System;

namespace Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declares the variables used for input and output.
            int wholeNumber,
                sumOfDigits;

            // Step 1: Prompt the user for a three digit whole number.
            Console.Write("Enter a three digit whole number: ");
            wholeNumber = int.Parse(Console.ReadLine());

            // Step 2: Calculate the sum of digits using the following formula:
            sumOfDigits = (wholeNumber % 10) + ((wholeNumber / 10) % 10) + ((wholeNumber / 100) % 10);

            //Step 3: Displays the number entered by the user and the sum of it's digits.
            Console.Write($"Your number is {wholeNumber} and the sum of its digit is {sumOfDigits}");
        }
    }
}
