/*  Purpose:    To calculate and display tax due based on taxable income entered by the user.
 *  
 *  Input:  taxable income
 *  
 *  Output: tax due
 *  
 *  Algorithm:  Step 1: Prompt the user to enter a valid taxable income
 *              Step 2: Using if statement to display and calculate tax due
 **/
using System;

namespace Problem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a valid taxable income
            Console.Write("Enter taxable income: ");
            double taxableIncome = double.Parse(Console.ReadLine());

            // Using if statement to display and calculate tax due
            if (taxableIncome > 0 && taxableIncome <= 50000)
            {
                Console.WriteLine("$0 + 5% of amount over 0$");
                Console.WriteLine($"{0 + taxableIncome * 0.05:c}");
            }
            else if (taxableIncome > 50000 && taxableIncome <= 100000)
            {
                Console.WriteLine("$2,500 + 7% of amount over $50,000");
                Console.WriteLine($"{2500 + taxableIncome * 0.07:c}");
            }
            else if (taxableIncome > 100000)
            {
                Console.WriteLine("$6,000 + 9% of the amount over $100,000");
                Console.WriteLine($"{6000 + taxableIncome * 0.09:c}");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
