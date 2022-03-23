using System;

namespace Temperature_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minValue,
                maxValue;

            Console.Write("Enter starting celsius value: ");
            minValue = int.Parse(Console.ReadLine());   

            Console.Write("Enter ending celsius value: ");
            maxValue = int.Parse(Console.ReadLine());

            for (int celsius = minValue; celsius <= maxValue; celsius++)
            {
                double fahrenheit = (celsius * 9.0 / 5) + 32;
                Console.WriteLine($"{celsius,-10}{fahrenheit,10:f2}");
            }
        }
    }
}
