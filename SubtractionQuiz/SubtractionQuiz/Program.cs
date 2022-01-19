using System;

namespace SubtractionQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generate two random single-digit integers
            Random random = new Random();
            int number1 = random.Next(1, 10);
            int number2 = random.Next(1, 10);

            // If number 1 < number 2, swap number 1 with number 2
            if (number1 < number2)
            { 
                int temp = number1;
                number1 = number2;
                number2 = temp;
            }

            // Prompt the student to answer, "What is number1 - number2
            Console.Write($"What is {number1} - {number2} = ");
            int answer = int.Parse(Console.ReadLine());

            // Check the student's answer and display whether the answer is correct.
            if (number1 - number2 == answer)
            {
                Console.WriteLine("You are correct.");
            }
            else
            {
                Console.WriteLine("Your answer is wrong.");
                Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
            }
        }
    }
}
