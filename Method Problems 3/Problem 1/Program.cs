using System;
using Cpsc1012;
namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pennies,
                nickels,
                dimes,
                quarters,
                loonies,
                twoonies;
            double totalAmount;


            pennies = Utilities.PromptForPositiveNumber("Enter number of pennies: ");
            nickels = Utilities.PromptForPositiveNumber("Enter number of nickels: ");
            dimes = Utilities.PromptForPositiveNumber("Enter number of dimes: ");
            quarters = Utilities.PromptForPositiveNumber("Enter number of quarters: ");
            loonies = Utilities.PromptForPositiveNumber("Enter number of loonies: ");
            twoonies = Utilities.PromptForPositiveNumber("Enter number of twoonies: ");
            totalAmount = GetTotal(pennies, nickels, dimes, quarters, loonies, twoonies);
            Console.WriteLine($"Your total amount of coins is {totalAmount:c}");
        }

        static double GetTotal(double pennies, double nickels, double dimes, double quarters, double loonies, double twoonies)
        {
            double totalAmount;

            pennies = pennies * 0.01;
            nickels = nickels * 0.05;
            dimes = dimes * 0.10;
            quarters = quarters * 0.25;
            loonies = loonies * 1.00;
            twoonies = twoonies * 2.00;

            totalAmount = pennies + nickels + dimes + quarters + loonies + twoonies;
            return totalAmount;
        }

        
    }
}
