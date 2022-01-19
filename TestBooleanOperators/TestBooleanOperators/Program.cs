using System;

namespace TestBooleanOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0 && number % 3 == 0)
            {
                Console.WriteLine($"{number} is divisible by 2 and 3");
            }
            if (number % 2 == 0 || number % 3 == 0)
            {
                Console.WriteLine($"{number} is divisible by 2 or 3");
            }
            if (number % 2 == 0 ^ number % 3 == 0)
            {
                Console.WriteLine($"{number} is divisible by 2 or 3 but not both.");
            }
        }
    }
}
