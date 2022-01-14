/*  Purpose: To calculate the hypotenuse of a right triangle using values prompted from the user.
 *  
 *  Input: base
 *         height
 *         
 *  Output: hypotenuse
 *  
 *  Algorithm: Step 1: Prompt user to enter base and height value.
 *             Step 2: Calculate hypotenuse using the following formula:
 *                          hypotenuse = Sqrt((base ^ 2 ) + (height ^ 2))
 *             Step 3: Displays the value of the hypotenuse.
 **/
using System;

namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declares the variables used for input and output.
            double height,
                   baselength,
                   hypotenuse;

            // Step 1: Prompt user to enter base and height value.
            Console.WriteLine("Enter the base and height value respectively: ");
            baselength = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());

            // Step 2: Calculate hypotenuse using the following formula:
            hypotenuse = Math.Sqrt((Math.Pow(baselength, 2) + Math.Pow(height, 2)));

            // Step 3: Displays the value of the hypotenuse.
            Console.Write($"The hypotenuse of your right triangle is {hypotenuse:F2}");
        }
    }
}
