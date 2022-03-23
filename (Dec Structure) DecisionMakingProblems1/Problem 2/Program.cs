/*  Purpose:    To determine the cost of admission for a theatre based on the age of the user.
 *  
 *  Input:  Age of user
 *  
 *  Output: The price of admission based on the age of user
 *  
 *  Algorithm:  Step 1: Prompt the user to enter their age.
 *              Step 2: Use the if statement to determine the price of admission based on user age.
 **/
using System;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter their age.
            Console.Write("Enter your age: ");
            int userAge = int.Parse(Console.ReadLine());

            // Use the if statement to determine the price of admission based on user age.
            if (userAge <= 6)
            {
                Console.WriteLine("Children 6 and under = FREE($0.00)");
            }
            else if (userAge <= 17)
            {
                Console.WriteLine("Students 7 to 17 = $9.80");
            }
            else if (userAge <= 54)
            {
                Console.WriteLine("Adults 18 to 54 = $11.35");
            }
            else
            {
                Console.WriteLine("Seniors 55+ = $10.00");
            }
        }
    }
}
