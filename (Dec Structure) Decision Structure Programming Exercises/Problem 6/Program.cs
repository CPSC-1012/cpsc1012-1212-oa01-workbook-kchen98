/*  Purpose:    To determine the chinese zodiac animal of a year inputted by the user
 *  
 *  Input:  year
 *  
 *  Output: zodiac animal
 *  
 *  Algorithm:  Step 1: Prompt the user to enter a year.
 *              Step 2: Use switch statement to determine which zodiac animal the user gets 
 *                          for the entered year.
 *              Step 3: Displays the zodiac animal of the year entered.
 * */
using System;

namespace Problem_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a year.
            Console.Write("Enter a year to find out the zodiac animal: ");
            int year = int.Parse(Console.ReadLine());

            /* Use switch statement to determine which zodiac animal the user gets 
                           for the entered year. */
            string userZodiacAnimal;
            switch (year % 12)
            {
                case 0:
                    userZodiacAnimal = "Monkey";
                    break;
                case 1:
                    userZodiacAnimal = "Rooster";
                    break;
                case 2:
                    userZodiacAnimal = "Dog";
                    break;
                case 3:
                    userZodiacAnimal = "Pig";
                    break;
                case 4:
                    userZodiacAnimal = "Rat";
                    break;
                case 5:
                    userZodiacAnimal = "Ox";
                    break;
                case 6:
                    userZodiacAnimal = "Tiger";
                    break;
                case 7:
                    userZodiacAnimal = "Rabbit";
                    break;
                case 8:
                    userZodiacAnimal = "Dragon";
                    break;
                case 9:
                    userZodiacAnimal = "Snake";
                    break;
                case 10:
                    userZodiacAnimal = "Horse";
                    break;
                case 11:
                    userZodiacAnimal = "Sheep";
                    break;
                default:
                    userZodiacAnimal = "";
                    break;
            }

            // Displays the zodiac animal of the year entered.
            Console.WriteLine($"The chinese zodiac animal for the year {year} is {userZodiacAnimal}");
        }
    }
}
