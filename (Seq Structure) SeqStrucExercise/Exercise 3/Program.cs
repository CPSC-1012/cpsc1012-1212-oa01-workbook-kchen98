/*  Purpose: To calculate area of a hexagon using the length of a side prompted from the user.
 *  
 *  Input:  sidelength
 *  
 *  Output: area
 *  
 *  Algorithm:  Step 1: Prompt the user to enter the length of the side
 *              Step 2: Calculate the area using:
 *                          3.0 * Sqrt(3)/2 * Pow(sidelength,2)
 *              Step 3: Displays the value of area
 *                                  
 **/
using System;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring the variables used in the program
            double sidelength,
                   area;

            // Prompt the user to enter the length of the side
            Console.WriteLine("Enter the length of the side: ");
            sidelength = double.Parse(Console.ReadLine());

            // Calculate the area using:
            area = 3.0 * Math.Sqrt(3)/2 * Math.Pow(sidelength,2);

            // Displays the value of area
            Console.Write($"The area of the hexagon is {Math.Round(area,4)}");
        }
    }
}
