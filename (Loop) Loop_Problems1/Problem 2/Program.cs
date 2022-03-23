using System;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will calculate the average age from a list of numbers entered by the user\n");
            
            int userInput,
                average,
                numberOFInputs = 0,
                sumOfAge = 0;
            do
            {
                Console.Write("Enter a number for a list of age (enter 0 to stop inputting numbers): ");
                userInput = int.Parse(Console.ReadLine());
                sumOfAge += userInput;
                numberOFInputs++;
            }while (userInput != 0);

            numberOFInputs--;
            average = sumOfAge / numberOFInputs;
            Console.WriteLine($"The average of your list of numbers is {average}.");
        }
    }
}
