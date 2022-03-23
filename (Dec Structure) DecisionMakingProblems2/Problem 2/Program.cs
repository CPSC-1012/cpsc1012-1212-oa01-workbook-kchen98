/*  Purpose:    To make a simple conversion program that converts value entered by the user
 *  
 *  Input:  Conversion letter
 *          Value the user wants to convert
 *          
 *  Output: Converted value
 *          Converted sign
 *          
 *  Algorithm: Step 1: Prompts the user to enter a letter for the conversion they want to use.
 *             Step 2: Prompts the user to enter a value they want to convert.
 *             Step 3: Use a switch statement to determine the converted value.
 *             Step 4: Displays the converted value and it's appropriate sign
 * */
using System;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instructions for the program
            Console.WriteLine("A = Pounds to Kilograms");
            Console.WriteLine("B = Fluid Ounces to Liters");
            Console.WriteLine("C = Inches to Centimeters");
            Console.WriteLine("D = Fahrenheit to Celsius");
            Console.WriteLine("Enter the letter in Upper Case that corresponds to the conversion you want");
            Console.WriteLine("for reverse conversion enter the letter in lowercase instead.\n");

            // Prompts the user to enter a letter for the conversion they want to use.
            Console.Write("Enter the letter for your conversion: ");
            char conversionInput = char.Parse(Console.ReadLine());

            // Prompts the user to enter a value they want to convert.
            Console.Write("Enter the value you want to convert: ");
            double numberInput = double.Parse(Console.ReadLine());

            // Use a switch statement to determine the converted value.
            double conversionResult;
            string conversionSign;
            switch (conversionInput)
            {
                case 'A':
                    conversionResult = numberInput / 2.2046;
                    conversionSign = "kg";
                    break;
                case 'a':
                    conversionResult = numberInput * 2.2046;
                    conversionSign = "lbs";
                    break;
                case 'B':
                    conversionResult = numberInput / 33.8140226;
                    conversionSign = "liters";
                    break;
                case 'b':
                    conversionResult = numberInput * 33.8140226;
                    conversionSign = "fluid ounces";
                    break;
                case 'C':
                    conversionResult = numberInput / 0.39370;
                    conversionSign = "cm";
                    break;
                case 'c':
                    conversionResult = numberInput * 0.39370;
                    conversionSign = "inches";
                    break;
                case 'D':
                    conversionResult = (numberInput - 32) / 1.800;
                    conversionSign = "Celsius";
                    break;
                case 'd':
                    conversionResult = (numberInput * 1.800) + 32;
                    conversionSign = "Fahrenheit";
                    break;

                default:
                    conversionResult = 0;
                    conversionSign = "";
                    break;
            }
            // Displays the converted value and it's appropriate sign
            Console.WriteLine($"Your converted number is {conversionResult:f2} {conversionSign}");
        }
    }
}
