/*  Purpose: To calculate tax amount owed based on taxable income   
 *  
 *  Input:  taxable income
 *  
 *  Output: tax rate
 *          tax amount owed
 *          
 *  Algorithm:  Step 1: Prompt the user to enter taxable income.
 *              Step 2: Use if statement to calculate the user's tax rate and tax amount owed.
 *              Step 3: Displays tax rate and tax amount.
 * */
using System;

namespace Problem_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Displays the tax rate guideline
            Console.WriteLine("Alberta provincial tax rate");
            Console.WriteLine("10% on the first $126,625, +");
            Console.WriteLine("12% on the next $25,325, +");
            Console.WriteLine("13% on the next $50,650, +");
            Console.WriteLine("14% on the next $101,300, +");
            Console.WriteLine("15% on the amount over $303,900\n");

            // Prompt the user to enter taxable income.
            Console.WriteLine("Enter your taxable income: ");
            int taxableIncome = int.Parse(Console.ReadLine());

            // Use if statement to calculate the user's tax rate and tax amount owed.
            double taxAmount,
                   albertaTaxRate;
            const double TaxRate1 = 0.10;
            const double TaxRate2 = 0.12;
            const double TaxRate3 = 0.13;
            const double TaxRate4 = 0.14;
            const double TaxRate5 = 0.15;
            if (taxableIncome <= 126625 && taxableIncome > 0)
            {               
                taxAmount = taxableIncome * TaxRate1;
                albertaTaxRate = TaxRate1;
            }
            else if (taxableIncome > 126625 && taxableIncome <= 151950)
            {              
                taxAmount = (126625 * TaxRate1) + ((taxableIncome - 126625) * TaxRate2);
                albertaTaxRate = TaxRate2;
            }
            else if (taxableIncome > 151950 && taxableIncome <= 202600)
            {               
                taxAmount = (126625 * TaxRate1) + (25325 * TaxRate2) + ((taxableIncome - 151950) * TaxRate3);
                albertaTaxRate = TaxRate3;
            }
            else if (taxableIncome > 202600 && taxableIncome <= 303900)
            {               
                taxAmount = (126625 * TaxRate1) + (25325 * TaxRate2) + (50650 * TaxRate3) + ((taxableIncome - 202600) * TaxRate4);
                albertaTaxRate = TaxRate4;
            }
            else if (taxableIncome > 303900)
            {               
                taxAmount = (126625 * TaxRate1) + (25325 * TaxRate2) + (50650 * TaxRate3) + (101300 * TaxRate4) + ((taxableIncome - 202800) * TaxRate5);
                albertaTaxRate = TaxRate5;
            }
            else
            {
                taxAmount = 0;
                albertaTaxRate = 0;
                Console.WriteLine("Invalid Input");
            }

            // Displays tax rate and tax amount.
            Console.WriteLine($"Your Alberta provincial government tax rate is {albertaTaxRate:p} and you owe the province {taxAmount:c} in taxes!");
        }
    }
}
