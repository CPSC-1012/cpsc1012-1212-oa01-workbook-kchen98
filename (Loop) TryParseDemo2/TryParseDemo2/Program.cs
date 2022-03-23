using System;

namespace TryParseDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userChoice;
            int number = 0;
            double points = 0.0;
            bool validChoice = true;
            do
            {
                Console.WriteLine("Hockey Player Stats");
                Console.WriteLine("-------------------");
                Console.WriteLine("1. Enter player number");
                Console.WriteLine("2. Enter player points");
                Console.WriteLine("9. Display player info (number and points)");
                Console.WriteLine("66. Exit Program");
                Console.Write("Enter your choice >: ");
                validChoice = int.TryParse(Console.ReadLine(), out userChoice);    

                switch (userChoice)
                {
                    case 1:
                        bool validNumber = true;
                        Console.Write("Player Number: ");
                        validNumber = int.TryParse(Console.ReadLine(),out number);
                        Console.WriteLine();
                        break;
                    case 2:
                        bool validPoints = true;
                        Console.Write("Player Points: ");
                        validPoints = double.TryParse(Console.ReadLine(), out points);
                        Console.WriteLine();
                        break;
                    case 9:
                        Console.WriteLine($"Player {number} has {points:f2} points.\n");
                        break;
                    case 66:
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        Console.WriteLine("Invalid Input Try Again\n");
                        break;
                }
            } while (!validChoice || userChoice != 66);
        }
    }
}
