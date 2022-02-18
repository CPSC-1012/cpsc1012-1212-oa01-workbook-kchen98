using System;

namespace MathTutor4
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
           
            char menuChoice = 'x';
            bool exitProgram = false;
            while (exitProgram == false)
            {
                menuChoice = PromptForMenuChoice();

                switch (menuChoice)
                {
                    case 'a':
                        Console.WriteLine("Addition Question");
                        AskAdditionQuestion();
                        break;
                    case 's':
                        Console.WriteLine("Subtraction Question");
                        AskSubtractionQuestion();
                        break;
                    case 'm':
                        Console.WriteLine("Multiplication Question");
                        AskMultiplicationQuestion();
                        break;
                    case 'd':
                        Console.WriteLine("Division Question");
                        AskDivisionQuestion();
                        break;
                    case 'x':
                        Console.WriteLine("Goodbye and thanks for playing.");
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("Logic Error in PromptMenuChoice");
                        break;

                }
            }
        }

        static void AskDivisionQuestion()
        {
            // Create a Random object for generating random numbers
            Random rand = new Random();
            // Generate two random numbers between 1 and 99
            int num1 = rand.Next(1, 100);
            int num2 = rand.Next(1, 100);
            //Compute the correct additional answer
            char repeatProgram;
            int tempNum;
            int attemptCount = 0;
            if (num2 > num1)
            {
                tempNum = num2;
                num2 = num1;
                num1 = tempNum;
            }
            int correctAnswer = num1 / num2;

            do
            {
                // Prompt the user for the answer to the addition question
                double userAnswer = PromptForIntegerValue($"What is {num1} / {num2} = ");

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
            } while (repeatProgram == 'y');

            if (repeatProgram == 'n')
            {
                Console.WriteLine($"The correct answer is {correctAnswer}");
            }

            static double PromptForIntegerValue(string message)
            {
                double integerValue = 0.0;

                // Prompt the user using the message parameter variable
                Console.Write(message);
                while (double.TryParse(Console.ReadLine(), out integerValue) == false)
                {
                    // Input value is not an integer
                    Console.WriteLine("Invalid input! You must enter a double value for the answer.");
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
        static void AskMultiplicationQuestion()
        {
            // Create a Random object for generating random numbers
            Random rand = new Random();
            // Generate two random numbers between 1 and 99
            int num1 = rand.Next(1, 100);
            int num2 = rand.Next(1, 100);
            //Compute the correct additional answer
            char repeatProgram;
            int attemptCount = 0;
            int correctAnswer = num1 * num2;
            do
            {
                // Prompt the user for the answer to the addition question
                int userAnswer = PromptForIntegerValue($"What is {num1} * {num2} = ");

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
            } while (repeatProgram == 'y');

            if (repeatProgram == 'n')
            {
                Console.WriteLine($"The correct answer is {correctAnswer}");
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
        static void AskSubtractionQuestion()
        {
                // Create a Random object for generating random numbers
                Random rand = new Random();
                // Generate two random numbers between 1 and 99
                int num1 = rand.Next(1, 100);
                int num2 = rand.Next(1, 100);
                //Compute the correct additional answer
                char repeatProgram;
                int tempNum;
                int attemptCount = 0;
                if (num2 > num1)
                {
                    tempNum = num2;
                    num2 = num1;
                    num1 = tempNum;
                }
                int correctAnswer = num1 - num2;
                do
                {
                    // Prompt the user for the answer to the addition question
                    int userAnswer = PromptForIntegerValue($"What is {num1} - {num2} = ");

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
                } while (repeatProgram == 'y');

                if (repeatProgram == 'n')
                {
                    Console.WriteLine($"The correct answer is {correctAnswer}");
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
        static void AskAdditionQuestion()
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
                } while (repeatProgram == 'y');

                if (repeatProgram == 'n')
                {
                    Console.WriteLine($"The correct answer is {correctAnswer}");
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

        static char PromptForMenuChoice()
        {
            char menuChoice;
            bool validMenuChoice = false;
            do
            {
                DisplayMenu();
                validMenuChoice = char.TryParse(Console.ReadLine().ToLower(), out menuChoice);
            } while (!validMenuChoice && (menuChoice != 'a' || menuChoice != 's' || menuChoice != 'm' || menuChoice !=
                        'd' || menuChoice != 'x'));
            return menuChoice;
        }

        static void DisplayMenu()
        {
            Console.Write(@"
Math Tutor – Version 0.4
------------------------
a) Addition
s) Subtraction
m) Multiplication
d) Division
x) Exit Program
Enter a letter for your choice: ");
        }


    }
}
