using System;
using Cpsc1012;
namespace Problem_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char menuChoice = 'X';
            double totalGrossIncome = 0;     
            bool endProgram = false;

            while (endProgram == false)
            {
                // Display a menu of choices
                DisplayMenuChoice();
                menuChoice = Console.ReadKey().KeyChar;
                menuChoice = char.ToUpper(menuChoice);
                Console.WriteLine();

                // Process the menu choice as follows:
                // A - Calculate Airport Amount
                // R - Calculate Regular Fare Amount
                // X - Exit Program
                switch (menuChoice)
                {
                    case 'A':
                        totalGrossIncome += CalculateAirportAmount();  
                        break;
                    case 'R':
                        totalGrossIncome += CalculateRegularFareAmount();   
                        break;
                    case 'F':
                        totalGrossIncome += CalculateFlatRateAmount();
                        break;
                    case 'X':
                        endProgram = true;
                        break;
                    default:
                        Console.WriteLine("Invalid menu choice");
                        break;
                }
            }
            // Display the total gross income
            Console.WriteLine($"The daily total gross income is {totalGrossIncome:c}");
        }

        static double CalculateAirportAmount()
        {
            double airportAmount = 0;
            const double FlatRateAirportCharge = 25.00;
            double tipAmount = Utilities.PromptForDoublePositiveOrZero("Enter tip amount: ");
            airportAmount = FlatRateAirportCharge + tipAmount;
            return airportAmount;
        }

        static double CalculateRegularFareAmount()
        {
            double regularFareAmount = 0;
            const double ChargePerKilometer = 1.10;
            const double ChargePerMinute = 0.20;
            double distance = Utilities.PromptForDoublePositiveOrZero("Enter distance travelled in km: ");
            double time = Utilities.PromptForDoublePositiveOrZero("Enter time travelled in minutes: ");
            double tipAmount = Utilities.PromptForDoublePositiveOrZero("Enter tip amount: ");
            regularFareAmount = distance * ChargePerKilometer + time * ChargePerMinute + tipAmount;
            return regularFareAmount;
        }

        static double CalculateFlatRateAmount()
        {
            double flatRateAmount = 0;
            double flatRate = Utilities.PromptForDoublePositiveOrZero("Enter flat rate amount: ");
            double tipAmount = Utilities.PromptForDoublePositiveOrZero("Enter tip amount: ");
            flatRateAmount = flatRate + tipAmount;
            return flatRateAmount;
        }

        static void DisplayMenuChoice()
        {
            Console.WriteLine(@"
Enter a letter for your choice
A: Airport Trip
R: Regular Fare
F: Flat Rate
X: Exit Program
    Your Choice: ");
        }
    }
}
