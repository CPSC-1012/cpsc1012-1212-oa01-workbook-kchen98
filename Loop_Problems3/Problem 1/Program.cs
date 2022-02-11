using System;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double NaturalLogarithm = Math.E;
            int initialPopulation;
            double finalPopulation,
                   growthRate;
            bool validInitialPopulation = false;
            bool validGrowthRate = false;
            Console.WriteLine(@"This program will calculate the final population of bacteria
in a culture after time(in days).");

            Console.WriteLine("Enter an initial population of bacteria: ");
            validInitialPopulation = int.TryParse(Console.ReadLine(), out initialPopulation);
            while (!validInitialPopulation || initialPopulation < 1)
            {
                Console.WriteLine("Invalid Input, Try Again.\n");
                Console.WriteLine("Enter an initial population of bacteria: ");
                validInitialPopulation = int.TryParse(Console.ReadLine(), out initialPopulation);
            }
            Console.WriteLine("Enter the growth rate precentage for the bacteria: ");
            validGrowthRate = double.TryParse(Console.ReadLine(), out growthRate);
            while (!validGrowthRate || growthRate < 1)
            {
                Console.WriteLine("Invalid Input, Try Again.\n");
                Console.WriteLine("Enter the growth rate precentage for the bacteria: ");
                validGrowthRate = double.TryParse(Console.ReadLine(), out growthRate);
            }
            growthRate = growthRate / 100;

            Console.WriteLine("\t Bacteria Population Count");
            Console.WriteLine("\t--------------------------");
            Console.WriteLine($"\t{"Day",-7}{"Number of Bacteria Present", -19}");

            for (int days = 1; days <= 10; days++)
            {
                finalPopulation = initialPopulation * (Math.Pow(NaturalLogarithm, (growthRate * days)));
                Console.WriteLine($"\t{days,-7}{finalPopulation,-19:f0}");
            }
        }
    }
}
