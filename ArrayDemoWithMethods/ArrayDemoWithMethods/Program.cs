using System;
using System.IO;
namespace ArrayDemoWithMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // To Do: Modify the program to implement a menu-driven system where the user can:
            // 1) Generate lotto quick picks
            // 2) Read lotto quick picks from a file
            // 3) Quit program

            // To Do: Prompt the user for the number of quick picks
            int numberOfQuickPicks = 0;
            Console.Write("How many quick picks do you want: ");
            numberOfQuickPicks = int.Parse(Console.ReadLine());

            // To Do: Ask the user if they want to write the numbers to a file 
            // If user answers yes then prompt for a filename and write the generated numbers to the filename      
            Console.WriteLine("Do you want to write the numbers in a file");
            Console.Write("Enter (y) if yes or any other key if no: ");
            bool writeToFile = char.ToLower(Console.ReadKey().KeyChar) == 'y' ? true : false;
            Console.WriteLine();
            if (writeToFile)
            {
                // Ask the user for the file name
                Console.WriteLine("Enter the file path to write to (ex. D:\\temp\\mar09.txt): ");
                string dataExportFilePath = Console.ReadLine();
                try
                {

                    StreamWriter writer = new StreamWriter(dataExportFilePath);
                    for (int counter = 0; counter < numberOfQuickPicks; counter++)
                    {
                        int[] lottoNumberArray = GenerateNumbers(1, 50, 7);
                        int index = 0;
                        foreach (int lottoNumber in lottoNumberArray)
                        {
                            writer.Write(lottoNumber);
                            index++;
                            if (index < lottoNumberArray.Length)
                            {
                                writer.Write(",");
                            }
                        }
                        writer.WriteLine();
                    }
                    writer.Close();
                    Console.WriteLine($"Successfully wrote numbers to {dataExportFilePath}");
                }
                catch (Exception ex)
                {
                    // Report the exception to the user
                    Console.WriteLine($"Error writing to file exception?: {ex.Message}");
                }

            }
            else
            {
                // Generate the quick picks
                for (int counter = 0; counter < numberOfQuickPicks; counter++)
                {
                    // To Do: For each quick pick generate 7 random numbers between 1 and 50 by calling the GenerateNumbers methods.
                    int[] lottoNumbers = GenerateNumbers(1, 50, 7);
                    // Display all the numbers generated
                    Console.Write($"Quick Pick #{counter + 1}: ");
                    DisplayNumbers(lottoNumbers);
                }
            }
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
                Console.Write($"{number} ");            
            }
            Console.WriteLine();
            // OR
            /*for (int index = 0; index < numberArray.Length; index++)
            {
                Console.Write(numberArray[index]);               
            }
            Console.WriteLine();*/
        }
    }
}
