/*  Purpose: To create a program that calculates wage base on hours worked
 *  
 *  Inputs: regular Wages
 *          overtime Wages
 *          regular Hours
 *          overtime Hours
 *          
 *  Outputs: regular Wages
 *           overtime Wages
 *           total Wages
 *  
 *  Algorithm: Step 1: Prompt User for regular wages, overtime wages, regular hours and overtime hours
 *             Step 2: Compute the following values:
 *                      regularWages = regularHours * basePay;
 *                       overtimeWages = overtimeHours * overtimePay;
 *                       totalWages = regularWages + overtimeWages;
 *             Step 3: Display the wages for the week
 *  */
using System;

namespace WagesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for inputs and outputs
            double regularWages,
                   overtimeWages,
                   regularHours,
                   overtimeHours,
                   totalWages,
                   basePay,
                   overtimePay;

            //Step 1: Prompt User for regular wages, overtime wages, regular hours and overtime hours
            Console.Write("Enter regular hourly wage: ");
            basePay = double.Parse(Console.ReadLine());

            Console.Write("Enter overtime hourly wage: ");
            overtimePay = double.Parse(Console.ReadLine());

            Console.Write("Enter regular hours worked: ");
            regularHours = double.Parse(Console.ReadLine());

            Console.Write("Enter overtime hours worked: ");
            overtimeHours = double.Parse(Console.ReadLine());

            //Step 2: Compute the following values:
            regularWages = regularHours * basePay;
            overtimeWages = overtimeHours * overtimePay;
            totalWages = regularWages + overtimeWages;

            //Step 3: Display the wages for the week
            Console.WriteLine($"Your regular wage is {regularWages,8:c}");
            Console.WriteLine($"Your overtime wage is {overtimeWages,8:c}");
            Console.WriteLine($"Your wage is {totalWages,8:c}");
        }
    }
}
