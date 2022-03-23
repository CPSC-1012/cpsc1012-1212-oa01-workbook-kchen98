/*  Purpose: To calculate the future value of your investments
 *  
 *  Input: investment amount 
 *         annual interest rate
 *         number of years
 *  
 *  Output: future investment value
 *  
 *  Algorithm: Step 1: Prompt the user to enter values for investment amount, 
 *                      annual interest rate and number of years.
 *             Step 2: Calculate monthly interest rate and future investment value 
 *                      using the following formula in order:
 *                          monthlyInterestRate = annualInterestRate / 12 / 100;
 *                          futureInvestmentValue = investmentAmount * 
 *                                  (Math.Pow((1 + monthlyInterestRate),(numberOfYears * 12)))
 *             Step 3: Displays the future value of your investment.
 **/
using System;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declares the variables used for input and output
            double investmentAmount,
                   annualInterestRate,
                   numberOfYears,
                   monthlyInterestRate,
                   futureInvestmentValue;

            /* Step 1: Prompt the user to enter values for investment amount,
                        annual interest rate and number of years.*/
            Console.WriteLine("Enter investment amount: ");
            investmentAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter annual interest rate in percentage: ");
            annualInterestRate = double.Parse(Console.ReadLine()); 

            Console.Write("Enter number of years: ");
            numberOfYears = double.Parse(Console.ReadLine());

            /* Step 2: Calculate monthly interest rate and future investment value
                        using the following formula in order: */
            monthlyInterestRate = annualInterestRate / 12 / 100;
            futureInvestmentValue = investmentAmount * 
                                    (Math.Pow((1 + monthlyInterestRate),(numberOfYears * 12)));

            // Step 3: Displays the future value of your investment.
            Console.Write($"Future value is {futureInvestmentValue:c}");
        }
    }
}
