using System;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will count the number of a specific character in a string");
            Console.Write("Enter any string: ");
            string userString = Console.ReadLine();

            Console.Write("Enter a character of the string: ");
            char userCharacter = char.Parse(Console.ReadLine());

            int count = 0;
            foreach (char check in userString)
            {
                if (check == userCharacter)
                {
                    count++;
                }
            }
            Console.Write($"The character {userCharacter} appears {count} times in {userString}");
        }
    }
}
