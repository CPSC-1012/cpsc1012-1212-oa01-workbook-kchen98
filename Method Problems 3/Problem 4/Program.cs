using System;
using Cpsc1012;
namespace Problem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length,
                width,
                height;
            int surfaceArea,
                volume;

            length = Utilities.PromptForPositiveNumber("Enter a length for a rectangle: ");
            width = Utilities.PromptForPositiveNumber("Enter a width for a rectangle: ");
            height = Utilities.PromptForPositiveNumber("Enter a height for a rectangle: ");
            surfaceArea = CalculateArea(length, width, height);
            volume = CalculateVolume(length, width, height);

            Console.WriteLine($"The surface area of the rectangle is {surfaceArea} and the volume is {volume}");
        }

        static int CalculateArea(int length, int width, int height)
        {
            int area;
            area = 2 * (length * width + width * height + height * length);
            return area;
        }

        static int CalculateVolume(int length, int width, int height)
        {
            int volume;
            volume = length * width * height;
            return volume;
        }
    }
}
