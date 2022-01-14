/*  Purpose: Displays the user's name, age and annual pay.
 *  
 *  Input:  name
 *          age
 *          annual pay
 *          
 *  Output: name
 *          age
 *          annual pay
 *          
 *  Algorithm:  Step 1: Prompts user to enter name, age and annual pay
 *              Step 2: Displays the information entered by the user
 **/
using System;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring the variables used for input and output
            string name;
            int age;
            double annualPay;

            // Step 1: Prompts user to enter name, age and annual pay
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Enter your annual salary: ");
            annualPay = double.Parse(Console.ReadLine());

            // Step 2: Displays the information entered by the user
            Console.Write($"My name is {name}, my age is {age} and I hope to earn {annualPay:C} per year");
        }
    }
}
