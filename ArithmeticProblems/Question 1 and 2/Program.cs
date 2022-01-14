/*  Purpose: To calculate mean average using three real numbers prompted from the user.
 *  
 *  Input: first real number
 *         second real number
 *         third real number
 *         
 *  Output: mean average
 *  
 *  Algorithm: Step 1: Prompt the user to enter three real numbers.
 *             Step 2: Calculate mean average using the following formula:
 *                          sumOfRealNumbers = frstRealNumber + secondRealNumber + thrdRealNumber 
 *                          meanAverage = sumOfRealNumbers / numberOfRealNumbers
 *             Step 3: Displays the mean average of the three numbers entered.
 **/
using System;

namespace Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declares the variables used for input and output.
            double frstRealNumber,
                   secondRealNumber,
                   thrdRealNumber,
                   meanAverage,
                   sumOfRealNumbers;
            const int numberOfRealNumbers = 3;

            // Step 1: Prompt the user to enter three real numbers.
            Console.WriteLine("Enter three real numbers: ");
            frstRealNumber = double.Parse(Console.ReadLine());  
            secondRealNumber = double.Parse(Console.ReadLine());
            thrdRealNumber = double.Parse(Console.ReadLine());

            // Step 2: Calculate mean average using the following formula:
            sumOfRealNumbers = frstRealNumber + secondRealNumber + thrdRealNumber;
            meanAverage = sumOfRealNumbers / numberOfRealNumbers;

            // Step 3: Displays the mean average of the three numbers entered.
            Console.Write($"The mean average of your three real numbers is {meanAverage:F2}");

        }
    }
}
