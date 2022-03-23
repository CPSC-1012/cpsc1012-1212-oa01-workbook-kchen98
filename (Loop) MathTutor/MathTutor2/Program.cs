using System;

namespace MathTutor2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Random object for generating random numbers
            Random rand = new Random();
            // Generate two random numbers between 1 and 99
            int num1 = rand.Next(1, 100);
            int num2 = rand.Next(1, 100);
            //Compute the correct additional answer
            int correctAnswer = num1 + num2;
            char repeatProgram;
            int attemptCount = 0;

            do
            {
                // Prompt the user for the answer to the addition question
                int userAnswer = PromptForIntegerValue($"What is {num1} + {num2} = ");

                // Determine if the user answer is correct
                if (userAnswer == correctAnswer)
                {
                    attemptCount++;
                    // Correct Answer
                    Console.WriteLine($"Correct! You got the correct answer in {attemptCount} attempts.");
                    repeatProgram = 'x';
                }
                else
                {
                    attemptCount++;
                    // Incorrect Answer
                    Console.Write("Incorrect! ");
                    repeatProgram = RepeatProgramAnswer("Would you like to try again (y/n): ");
                }
            }while (repeatProgram == 'y');

            if (repeatProgram == 'n')
            {
                Console.WriteLine($"The correct answer is {correctAnswer}");
            }
        }

        static int PromptForIntegerValue(string message)
        {
            int integerValue = 0;

            // Prompt the user using the message parameter variable
            Console.Write(message);
            while (int.TryParse(Console.ReadLine(), out integerValue) == false)
            {
                // Input value is not an integer
                Console.WriteLine("Invalid input! You must enter an integer value for the answer.");
                Console.Write(message);
            }
            return integerValue;
        }

        static char RepeatProgramAnswer(string message)
        {
            char answer;
            bool validAnswer = false;
            Console.Write(message);
            validAnswer = char.TryParse(Console.ReadLine().ToLower(), out answer);
            while (!validAnswer && (answer != 'y' || answer != 'n'))
            {
                Console.Write($"Invalid input. {message}");
                validAnswer = char.TryParse(Console.ReadLine().ToLower(), out answer);
            }
            return answer;
        }
    }
}
