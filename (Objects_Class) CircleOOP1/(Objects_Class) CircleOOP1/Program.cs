using System;

namespace _Objects_Class__CircleOOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Circle with a radius of 1
            Circle circle1 = new Circle(); 
            // The radius of circle1 should be 1
            Console.WriteLine(circle1.Radius);

            // area should be
            double area = circle1.Area();
            Console.WriteLine(area);

            // perimeter should be
            double perimeter = circle1.Perimeter();   
            Console.WriteLine(perimeter);

            // Change the radius of circle1 to 5
            circle1.Radius = 5;
            // The radius of circle1 should be 1
            Console.WriteLine(circle1.Radius);

            // area should be
            area = circle1.Area();
            Console.WriteLine(area);

            // perimeter should be
            perimeter = circle1.Perimeter();
            Console.WriteLine(perimeter);

            // Change the radius of circle1 to -25
            // It should throw an exception
            try
            {
                circle1.Radius = -25;
                Console.WriteLine("An exception should have been thrown");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
