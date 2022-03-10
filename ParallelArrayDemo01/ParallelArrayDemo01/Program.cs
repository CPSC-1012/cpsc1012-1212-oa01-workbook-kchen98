using System;

namespace ParallelArrayDemo01
{
    internal class Program
    {
        // Create a method that is passed in the array of student names and array of student marks
        // and it will print the name of mark of each student
        static void PrintStudentArrays (string[] nameArray, double[] markArray, int studentCount)
        {
            Console.WriteLine($"{"Student Name",-25} {"Mark",4}");
            Console.WriteLine($"{"------------",-25} {"----",4}");
            for (int index = 0; index < studentCount; index++)
            {
                Console.WriteLine($"{nameArray[index],-25} {markArray[index],4}");
            }
        }

        // TO DO 1: Add a method to sort the array by name
        static void SortStudentName(string[] studentNames)
        {
            
        }
        // TO DO 2: Add a method to sort the arrays by mark descending

        // TO DO 3: Add a method to find the index of the student with the highest mark (if there is a tie, return the first)
        static int IndexOfHighestMark(double[] markArray, int studentCount)
        {
            int highestIndex = 0;
            // Assume the first element contains the highest mark
            double highestMark = markArray[0];
            for (int index = 1; index < studentCount; index++)
            {
                // Check if the current mark is greater than the current highest mark 
                if (markArray[index] > highestMark)
                {
                    // Assign the current mark as the highest mark
                    highestMark = markArray[index];
                    // Assign the current index as the new highest index
                    highestIndex = index;
                }
            }
            return highestIndex;
        }

        // TO DO 4: Add a method to return the average mark in class
        static double MarkAverage(double[] markArray, int studentCount)
        {
            double averageMark = 0;
            double sumMarks = 0;
            for (int index = 0; index < studentCount; index++)
            {
                sumMarks += markArray[index];
            }
            averageMark = sumMarks / studentCount;
            return averageMark;
        }

        // TO DO 5: Add a method display the name and mark of the student with the highest mark
        static void ValedictorianStudent(string[] nameArray, double[] markArray, int studentCount)
        {
            // Determine which student has the highest mark
            int indexOfHighestValue = IndexOfHighestMark(markArray, studentCount);
            Console.Write($"The student with the highest mark is: ");
            Console.WriteLine($"{nameArray[indexOfHighestValue]} with a mark of {markArray[indexOfHighestValue]}");
        }
        // TO DO 6: Read from a file that contains a list of student name and student marks
        static void Main(string[] args)
        {
            // Declare a constant for size of the arrays
            const int ArraySize = 5;
            // Declare and create a new array of string of size ArraySize for student names
            string[] studentNameArray = new string[ArraySize];
            // Declare and create a new array of double of size ArraySize for student marks
            double[] studentMarkArray = new double[ArraySize];

            // Declare a variable to count the number of studens in the class
            int studentCount = 0;

            // Ask the user for the number of students in the class
                Console.Write("How many students in the class: ");
                studentCount = int.Parse(Console.ReadLine());
            // Ask the user to enter the name and mark for each student in the class
            if (studentCount <= ArraySize)
            {
                for (int index = 0; index < studentCount; index++)
                {
                    Console.WriteLine("Enter the name of the student: ");
                    studentNameArray[index] = Console.ReadLine();
                    Console.WriteLine($"Enter the {studentNameArray[index]}'s mark: ");
                    studentMarkArray[index] = double.Parse(Console.ReadLine());
                }
                // Call the PrintStudentArray method
                PrintStudentArrays(studentNameArray, studentMarkArray, studentCount);
                
            }
            else
            {
                Console.WriteLine($"This program does not support more than {ArraySize} students.");
                Console.WriteLine($"Upgrade to the PAID version to handle more than {ArraySize} students.");
            }           
        }
    }
}
