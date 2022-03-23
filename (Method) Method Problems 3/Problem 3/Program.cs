using System;
using Cpsc1012;
namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours,
                hourlyPayRate;
            double grossPay;

            hours = Utilities.PromptForPositiveNumber("Enter number of hours: ");
            hourlyPayRate = Utilities.PromptForPositiveNumber("Enter hourly pay rate: ");
            grossPay = CalculatePay(hours, hourlyPayRate);
            Console.WriteLine($"Your gross pay is {grossPay}");
        }

        static double CalculatePay(int hours,int hourlyPayRate)
        {
            double grossPay = 0;

            if (hours <= 40)
            {
                grossPay = hours * hourlyPayRate;
            }
            else if (hours <= 50)
            {
                grossPay = 40 * hourlyPayRate + 1.5 * (hours -40) * hourlyPayRate;
            }
            else
            {
                grossPay = 40 * hourlyPayRate + 1.5 * 10 * hourlyPayRate + 2.0 * (hours - 50) * hourlyPayRate;
            }

            return grossPay;
        }
    }
}
