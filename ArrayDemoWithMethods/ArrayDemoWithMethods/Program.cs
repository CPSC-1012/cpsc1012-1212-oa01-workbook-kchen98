using System;

namespace ArrayDemoWithMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // To Do: Prompt the user for the number of quick picks

            // To Do: For each quick pick generate 7 random numbers between 1 and 50 by calling the GenerateNumbers methods.
            int[] lottoNumbers = GenerateNumbers(1, 50, 7);
            // Display all the numbers generated
            DisplayNumbers(lottoNumbers);
        }

        static int[] GenerateNumbers(int minValue, int maxValue, int numberCount)
        {
            // Declare and create a  new int array of size numberCount
            int[] numberArray = new int[numberCount];
            // Create a new random object that we can use to generate random numbers
            Random rand = new Random();
            // Assign a random number between minValue and maxValue for each element in the array
            for (int index = 0; index < numberCount;)
            {
                // Generate a random number between minValue and maxValue
                // Add the random number to the array only if it is not a duplicate
                // Hint: You can call the IsDuplicateNumber method
                int randomNumber = rand.Next(minValue, maxValue);
                if (IsDuplicateNumber(randomNumber,numberArray) == false)
                {
                    numberArray[index] = randomNumber;
                    index++;
                }        
            }
            // OR
            /*for (int index = 0; index < numberCount; index++)
            {
                int number = rand.Next(minValue, maxValue + 1);
                if (IsDuplicateNumber(number, numberArray))
                {
                    index--;
                }
                else
                {
                    numberArray[index] = number;
                }
            }*/

            // Sort the numberArray ascending from smallest to largest
            // Hint: The Array class has a static class-level method for sort
            Array.Sort(numberArray);
            return numberArray;           
        }

        static bool IsDuplicateNumber(int number, int[] numberArray)
        {
            bool isDuplicate = false;
            for (int index = 0; index < numberArray.Length; index++)
            {
                if (numberArray[index] == number)
                {
                    isDuplicate = true;
                    index = numberArray.Length; // graceful technique to exit loop
                }
            }
            return isDuplicate;
        }
        static void DisplayNumbers(int[] numberArray)
        {
            // Display each element in numberArray separated by one empty space
            foreach (int number in numberArray)
            {
                Console.Write(number);
                Console.WriteLine();
            }
            // OR
            /*for (int index = 0; index < numberArray.Length; index++)
            {
                Console.Write(numberArray[index]);
                Console.WriteLine();
            }*/
        }
    }
}
