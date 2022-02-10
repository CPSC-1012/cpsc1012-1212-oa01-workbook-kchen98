using System;

namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program reads in a value N, inputted by the user ");
            Console.WriteLine("and prints it's digit in a column starting with the last digit\n");

            int n,
                digitValue;

            Console.Write("Enter a value for N: ");
            n = int.Parse(Console.ReadLine());

            while (n / 10.0 != 0)
            {
                digitValue = n % 10;
                Console.WriteLine(digitValue);
                n = n / 10;
            }
        }
    }
}
