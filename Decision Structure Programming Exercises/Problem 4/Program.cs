/*  Purpose:    To calculate tax amount owed based on taxable income
 *  
 *  Input:  taxable income
 *  
 *  Output: tax amount owed
 *  
 *  Algorithm:  Step 1: Prompt the user to enter taxable income.
 *              Step 2: Use if statement to calculate the user's tax rate and tax amount owed.
 *              Step 3: Displays tax rate and tax amount.
 * */
using System;

namespace Problem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter taxable income.
            Console.WriteLine("Enter your taxable income: ");
            int taxableIncome = int.Parse(Console.ReadLine());

            // Use if statement to calculate the user's tax rate and tax amount owed.
            double taxAmount,
                   federalTaxRate;
            if (taxableIncome <= 45916 && taxableIncome > 0)
            {
                const double TaxRate1 = 0.15;
                taxAmount = taxableIncome * TaxRate1;
                federalTaxRate = TaxRate1;
            }
            else if (taxableIncome > 45916 && taxableIncome <= 91831)
            {
                const double TaxRate2 = 0.205;
                taxAmount = 6887 + ((taxableIncome - 45916) * TaxRate2);
                federalTaxRate = TaxRate2;
            }
            else if (taxableIncome > 91831 && taxableIncome <= 142353)
            {
                const double TaxRate3 = 0.26;
                taxAmount = 16300 + ((taxableIncome - 91831) * TaxRate3);
                federalTaxRate = TaxRate3;
            }
            else if (taxableIncome > 142353 && taxableIncome <= 202800)
            {
                const double TaxRate4 = 0.29;
                taxAmount = 29436 + ((taxableIncome - 142353) * TaxRate4);
                federalTaxRate = TaxRate4;
            }
            else if (taxableIncome > 202800)
            {
                const double TaxRate5 = 0.33;
                taxAmount = 46965 + ((taxableIncome - 202800) * TaxRate5);
                federalTaxRate = TaxRate5;
            }
            else
            {
                taxAmount = 0;
                federalTaxRate = 0;
                Console.WriteLine("Invalid Input");
            }

            // Displays tax rate and tax amount.
            Console.WriteLine($"Your federal tax rate is {federalTaxRate:p} and you owe the federal government {taxAmount:c} in taxes");
        }
    }
}
