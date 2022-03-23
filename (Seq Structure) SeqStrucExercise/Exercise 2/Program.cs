/*  Purpose: Computes the area and volume using radius ang length prompted from the user
 *  
 *  Input: radius
 *         length
 *         
 *  Output: area
 *          volume
 *          
 *  Algorithm: Step 1: Prompts the user to enter radius and length values
 *             Step 2: Calculates area and volume using the formula:
 *                          area = radius * radius * pie
 *                          volume = area * length
 *             Step 3: Displays area and volume
 **/
using System;

namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables used in the program
            double area,
                   volume;
            const double pie = 3.14159;

            // Step 1: Prompts the user to enter radius and length values
            Console.WriteLine("Enter the radius and length of a cylinder: ");
            double radius = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());

            // Step 2: Calculates area and volume using information prompted from the user
            area = radius * radius * pie;
            volume = area * length;

            // Step 3: Displays area and volume
            Console.WriteLine($"The area is {area:F4}");
            Console.WriteLine($"The volume is {volume:F1}");
        }
    }
}
