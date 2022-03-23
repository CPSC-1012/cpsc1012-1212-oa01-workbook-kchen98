using System;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will calculate the sum of squares of the integer from 1 to MySquare.");
            Console.WriteLine("where MySquare is the input of the user.\n");

            int mySquare,
                sumOFAnswer = 0,
                answer;
            Console.Write("Enter MySquare/Max Integer: ");
            mySquare = int.Parse(Console.ReadLine());

            for (int count = 1; count <= mySquare; count++)
            {
                Console.WriteLine($"{count}*{count}");
                answer = count * count;
                sumOFAnswer += answer;
            }
            Console.WriteLine($"Total is {sumOFAnswer}");
        }
    }
}
