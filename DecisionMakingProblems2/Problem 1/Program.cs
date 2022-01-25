/*  Purpose:    To calculate the total amount a user will pay based on the package plan picked
 *  
 *  Input: A,B or C
 *         Hours used for package A or B
 *  
 *  Output: Total amount the user will pay
 *  
 *  Algorithm:  Step 1: Prompt the user to enter (A, B or C) based on the package they want.
 *              Step 2: Use a switch statement to determine the total amount a user will pay based 
 *                          on the package chosen.
 *              Step 3: Displays the package chosen and the amount the user will pay.
 * */
using System;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter (A, B or C) based on the package they want.
            Console.WriteLine("Package A is $9.95 per month for up to 10 hours; additional hours are billed at $2.00 per hour");
            Console.WriteLine("Package B is $13.95 per month for up to 20 hours; additional hours are billed at $1.00 per hour");
            Console.WriteLine("Package C is $19.95 per month for unlimited hours");
            Console.Write("Choose a package (A, B, C): ");
            char userPackage = char.Parse(Console.ReadLine());    
            userPackage = char.ToUpper(userPackage);

            /* Use a switch statement to determine the total amount a user will pay based 
            *on the package chosen. */
            int hoursUsed;
            double totalCost;
            switch (userPackage)
            {
                case 'A':
                    const int AMinHours = 10;
                    const double AMinAmount = 9.95;
                    const double AOverchargeRate = 2.00;
                    Console.WriteLine("Enter hours used: ");
                    hoursUsed = int.Parse(Console.ReadLine());
                    if (hoursUsed > AMinHours)
                    {
                        totalCost = AMinAmount + ((hoursUsed - AMinHours) * AOverchargeRate);
                    }
                    else
                    {
                        totalCost = AMinAmount;
                    }
                    break;
                
                case 'B':
                    const int BMinHours = 20;
                    const double BMinAmount = 13.95;
                    const double BOverchargeRate = 1.00;
                    Console.WriteLine("Enter hours used: ");
                    hoursUsed = int.Parse(Console.ReadLine());
                    if (hoursUsed > BMinHours)
                    {
                        totalCost = BMinAmount + ((hoursUsed - BMinHours) * BOverchargeRate);
                    }
                    else
                    {
                        totalCost = BMinAmount;
                    }
                    break;
                
                case 'C':
                    totalCost = 19.95;
                    break;
                
                default:
                    totalCost = 0.00;
                    Console.WriteLine("Invalid input");
                    break;
            }
            // Displays the package chosen and the amount the user will pay.
            Console.WriteLine($"Your total cost for package {userPackage} is {totalCost}");

        }
    }
}
