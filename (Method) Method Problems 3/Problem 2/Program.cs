using System;
using Cpsc1012;
namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours,
                minutes,
                seconds,
                totalSeconds;

            hours = Utilities.PromptForPositiveNumber("Enter number of hours: ");
            minutes = Utilities.PromptForPositiveNumber("Enter number of minutes: ");
            seconds = Utilities.PromptForPositiveNumber("Enter number of seconds: ");
            totalSeconds = CalculateSeconds(hours, minutes, seconds);
            Console.WriteLine($"The total seconds is {totalSeconds}");
        }

        static int CalculateSeconds(int hours,int minutes,int seconds)
        {
            int totalSeconds;
            hours = hours * 3600;
            minutes = minutes * 60;

            totalSeconds = hours + minutes + seconds;
            return totalSeconds;
        }

    }
}
