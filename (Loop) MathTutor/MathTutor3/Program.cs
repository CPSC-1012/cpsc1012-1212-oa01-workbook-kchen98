using System;

namespace MathTutor3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char anotherQuestion;
            int totalQuestion = 0;
            int correctQuestions = 0;
            do
            {
                // Create a Random object for generating random numbers
                Random rand = new Random();
                // Generate two random numbers between 1 and 99
                int num1 = rand.Next(1, 100);
                int num2 = rand.Next(1, 100);
                //Compute the correct additional answer
                int correctAnswer = num1 + num2;
                char repeatProgram;
                
                do
                {
                    // Prompt the user for the answer to the addition question
                    int userAnswer = PromptForIntegerValue($"What is {num1} + {num2} = ");

                    // Determine if the user answer is correct
                    if (userAnswer == correctAnswer)
                    {
                        correctQuestions++;
                        // Correct Answer
                        Console.WriteLine($"Correct!");
                        repeatProgram = 'x';
                    }
                    else
                    {
                        // Incorrect Answer
                        Console.Write("Incorrect! ");
                        repeatProgram = YesOrNo("Would you like to try again (y/n): ");
                    }
                } while (repeatProgram == 'y');

                if (repeatProgram == 'n')
                {
                    Console.WriteLine($"The correct answer is {correctAnswer}");
                }
                totalQuestion++;
                anotherQuestion = YesOrNo("Would you like another question (y/n): ");
            } while (anotherQuestion == 'y');
            Console.WriteLine($"Thanks for playing! You answered {correctQuestions} out of {totalQuestion} questions correctly.");
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

        static char YesOrNo(string message)
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
