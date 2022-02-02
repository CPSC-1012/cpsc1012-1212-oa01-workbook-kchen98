using System;

namespace PassFail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int results;
            int pass = 0;
            int fail = 0;
            int studentTest = 0;
            while (studentTest != 10)
            {
                Console.Write("Enter result (1 = pass, 2 = fail): ");
                results = int.Parse(Console.ReadLine());
                while (results != 1 && results != 2)
                {
                    Console.WriteLine("Invalid Input");
                    Console.Write("Enter result (1 = pass, 2 = fail): ");
                    results = int.Parse(Console.ReadLine());
                }
                if (results == 1)
                {
                    pass++;
                }
                else
                {
                    fail++;
                }
                studentTest++;
            }
            Console.WriteLine($"Passed: {pass}");
            Console.WriteLine($"Failed: {fail}");
        }
    }
}
