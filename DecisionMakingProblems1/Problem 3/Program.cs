/*  Purpose:    To display a student's name and letter grade based on the marks entered by a student
 *  
 *  Input:  Student Name
 *          Student Marks
 *          
 *  Output: Student Name
 *          Student Grade
 *          
 *  Algorithm: Step 1:  Prompts the user to enter student name and marks.
 *             Step 2:  Displays the student name and using if statement to display student grade.
 **/
using System;

namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompts the user to enter student name and marks.
            Console.Write("Enter your student name: ");
            string studentName = Console.ReadLine();
           
            Console.Write("Enter your mark: ");
            int studentMark = int.Parse(Console.ReadLine());

            // Displays the student name and using if statement to display student grade.
            Console.WriteLine($"Name of student: {studentName}");
            if (studentMark <= 100 && studentMark >= 90)
            {
                Console.WriteLine("Your grade is A");
            }
            else if (studentMark <= 89 && studentMark >= 80)
            {
                Console.WriteLine("Your grade is B");
            }
            else if (studentMark <= 79 && studentMark >= 70)
            {
                Console.WriteLine("Your grade is C");
            }
            else if (studentMark <= 69 && studentMark >= 50)
            {
                Console.WriteLine("Your grade is D");
            }
            else if (studentMark <= 49 && studentMark >= 0)
            {
                Console.WriteLine("Your grade is F");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
