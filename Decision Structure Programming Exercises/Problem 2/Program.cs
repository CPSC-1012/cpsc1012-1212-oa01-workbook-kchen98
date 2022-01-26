/*  Purpose=    Determine if a year entered by the user is a leap year
 *  
 *  Input=  Year
 *  
 *  Output= True or False
 *  
 *  Algorithm:  Step 1: Prompt the user to enter a year.
 *              Step 2: Use if statement to determine if a year is a leap year.
 * */
using System;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a year.
            Console.WriteLine("Enter a year to determine if it's a leap year: ");
            int userYear = int.Parse(Console.ReadLine());

            // Use if statement to determine if a year is a leap year.
            if (userYear % 4 == 0 && userYear % 100 != 0 || userYear % 400 == 0)
            {
                Console.WriteLine($"True, {userYear} is a leap year");
            }
            else
            {
                Console.WriteLine($"False, {userYear} is not leap year");
            }
        }
    }
}
