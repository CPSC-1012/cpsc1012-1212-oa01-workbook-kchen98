using System;

namespace TryParseDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hockeyPlayerNumber;
            bool validInput = false;

            Console.Write("Enter the hockey player number (1-99): ");
            validInput = int.TryParse(Console.ReadLine(), out hockeyPlayerNumber);

            while (!validInput || hockeyPlayerNumber < 1 || hockeyPlayerNumber > 99)
            {
                Console.WriteLine("Invalid input value. Try again.");
                Console.Write("Enter the hockey player number (1-99): ");
                validInput = int.TryParse(Console.ReadLine(), out hockeyPlayerNumber);
            }
            Console.WriteLine($"The hockey player number is {hockeyPlayerNumber}");
        }
    }
}
