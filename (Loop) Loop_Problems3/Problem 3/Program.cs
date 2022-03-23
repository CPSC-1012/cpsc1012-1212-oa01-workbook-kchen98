using System;

namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfHours,
                extraHours;
            double totalCost;
            char userPackage,
                 userChoice;
            do
            {
                Console.WriteLine("A: $9.95 per month for 10 hours; additional hours are billed at $2.00 per hour");
                Console.WriteLine("B: $13.95 per month for 20 hours; additional hours are billed at $1.00 per hour");
                Console.WriteLine("C: $19.95 per month of unlimited hours");
                Console.Write("Enter a package: ");
                userPackage = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Enter number of hours used: ");
                numberOfHours = int.Parse(Console.ReadLine());

                switch (userPackage)
                {
                    case 'A':
                        const double PackageAMinAmount = 9.95;
                        if (numberOfHours > 10)
                        {
                            extraHours = numberOfHours - 10;
                            totalCost = extraHours * 2 + PackageAMinAmount;
                        }
                        else
                        {
                            totalCost = PackageAMinAmount;
                        }
                        break;
                    case 'B':
                        const double PackageBMinAmount = 13.95;
                        if (numberOfHours > 20)
                        {
                            extraHours = numberOfHours - 20;
                            totalCost = extraHours * 1 + PackageBMinAmount;
                        }
                        else
                        {
                            totalCost = PackageBMinAmount;
                        }
                        break;
                    case 'C':
                        const double PackageCMinAmount = 19.95;
                        totalCost = PackageCMinAmount;
                        break;
                    default:
                        totalCost = 0.0;
                        Console.WriteLine("Invalid Input");
                        break;
                }
                Console.WriteLine($"Your total cost for {numberOfHours} hours on package {userPackage} is {totalCost:c}");
                Console.WriteLine("Do you want to calculate another bill (y/n): ");
                userChoice = char.Parse(Console.ReadLine().ToLower());
            } while (userChoice == 'y');
        }
    }
}
