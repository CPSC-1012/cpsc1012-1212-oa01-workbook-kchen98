/*  Purpose:    Create a rock paper scissors game with the computer as the opponent
 *  
 *  Input:  Scissor (0), Rock (1), Paper(2)
 *  
 *  Output: Win, Lose or Draw
 *  
 *  Algorithm:  Step 1: Randomly generate an integer from 0 to 2 that will represent rock, paper and
 *                          scissors.
 *              Step 2: Prompt the user to enter their choice.
 *              Step 3: Use switch statement to assign the integers one of the signs.
 *              Step 4: Use switch and if statements to test whether the user choice will result in a
 *                          win, lose or draw.
 *              Step 5: Displays the results
 **/
using System;

namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Randomly generate an integer from 0 to 2 that will represent rock, paper and
                         scissors. */
            Random game = new Random();
            int computerChoice = game.Next(0,3);

            // Prompt the user to enter their choice.
            Console.WriteLine(computerChoice);
            Console.WriteLine("You will be playing rock paper scissors with the computer");
            Console.WriteLine("Scissor (0), Rock (1), Paper(2)");
            Console.Write("Enter the number corresponding to your pick: ");
            int userChoice = int.Parse(Console.ReadLine());

            // Use switch statement to assign the integers one of the signs.
            string computerSign,
                   userSign,
                   results = "";
            switch (userChoice)
            {
                case 0:
                    userSign = "scissors";
                    break;
                case 1:
                    userSign = "rock";
                    break;
                case 2:
                    userSign = "paper";
                    break;
                default:
                    userSign = "?";
                    break;
            }

            /* Use switch and if statements to test whether the user choice will result in a
                          win, lose or draw. */
            switch (computerChoice)
            {
                case 0:
                    computerSign = "scissors";
                    if (userChoice == 0)
                    {
                        results = "It is a draw.";
                    }
                    else if (userChoice == 1)
                    {
                        results = "You win.";
                    }
                    else if (userChoice == 2)
                    {
                        results = "You lose.";
                    }
                    else
                    {
                        results = "Invalid Results";
                    }
                    break;
                case 1:
                    computerSign = "rock";
                    if (userChoice == 0)
                    {
                        results = "You lose.";
                    }
                    else if (userChoice == 1)
                    {
                        results = "It is a draw.";
                    }
                    else if (userChoice == 2)
                    {
                        results = "You win.";
                    }
                    else
                    {
                        results = "Invalid Results";
                    }
                    break;
                case 2:
                    computerSign = "paper";
                    if (userChoice == 0)
                    {
                        results = "You win.";
                    }
                    else if (userChoice == 1)
                    {
                        results = "You lose.";
                    }
                    else if (userChoice == 2)
                    {
                        results = "It is a draw.";
                    }
                    else
                    {
                        results = "Invalid Results";
                    }
                    break;
                default:
                    computerSign = "";
                    break;

            }

            // Displays the results
            Console.WriteLine($"The computer is {computerSign}. You are {userSign}. {results}");
        }   
    }
}
