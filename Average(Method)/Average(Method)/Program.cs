using System;

namespace Average_Method_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            const int SentinelValue = 999;
            bool sentinelValueEntered = false;
            double average = 0;

            while (!sentinelValueEntered)
            {
                int number = PromptForPositiveNumber("Enter a number: ");
                if (number != SentinelValue)
                {
                    count++;
                    sum += number;
                }
                else
                {
                    sentinelValueEntered = true;
                }
            }
            if (count > 0)
            {
                average = sum / count;
                Console.WriteLine($"Average of input is {average:f1}");
            }
        }

        static int PromptForPositiveNumber(string message)
        {
            int userNumber = 0;
            bool validUserNumber = false;

            do
            {
                Console.WriteLine(message);
                validUserNumber = int.TryParse(Console.ReadLine(), out userNumber);
                if (!validUserNumber || userNumber < 0)
                {
                    Console.WriteLine("Invalid input");
                }
            }while (!validUserNumber || userNumber < 0);
            return userNumber;
        }


    }
}
