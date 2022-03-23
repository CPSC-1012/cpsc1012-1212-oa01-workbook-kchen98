using System;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays;
            string dayOfWeek;
            bool validNumberOfDays = false;
            
            Console.Write("Enter how many days you want in a month (1-31): ");
            validNumberOfDays = int.TryParse(Console.ReadLine(), out numberOfDays);
            while (!validNumberOfDays || numberOfDays > 31)
            {
                Console.WriteLine("Enter a valid number.\n");
                Console.Write("Enter how many days you want in a month: ");
                validNumberOfDays = int.TryParse(Console.ReadLine(), out numberOfDays);
            }

            Console.WriteLine("\nDays of Week (sun,mon,tue,wed,thu,fri,sat).");
            Console.Write("Enter what day of the week you want to start the first number: ");
            dayOfWeek = Console.ReadLine().ToLower();
            while (dayOfWeek != "sun" && dayOfWeek != "mon" && dayOfWeek != "tue" && dayOfWeek != "wed" &&
                    dayOfWeek != "thu" && dayOfWeek != "fri" && dayOfWeek != "sat")
            {
                Console.WriteLine("\nDays of Week (sun,mon,tue,wed,thu,fri,sat).");
                Console.Write("Enter a valid day: ");
                dayOfWeek = Console.ReadLine();
            }
            
            Console.WriteLine("Sun  Mon  Tue  Wed  Thu  Fri  Sat");

            for (int dayCount = 1; dayCount <= numberOfDays; dayCount++)
            {
                if (dayOfWeek == "sun")
                {
                    Console.Write($" {dayCount,-4}");
                    if (dayCount == 7 || dayCount == 14 || dayCount == 21 || dayCount == 28)
                    {
                        Console.WriteLine();
                    }
                }
                else if (dayOfWeek == "mon")
                {
                    if (dayCount == 1)
                    {
                        Console.Write($"{"", 5} {dayCount, -4}");
                    }
                    else
                    {
                        Console.Write($" {dayCount,-4}");
                    }
                    if (dayCount == 6 || dayCount == 13 || dayCount == 20 || dayCount == 27)
                    {
                        Console.WriteLine();
                    }
                }
                else if (dayOfWeek == "tue")
                {
                    if (dayCount == 1)
                    {
                        Console.Write($"{"",10} {dayCount,-4}");
                    }
                    else
                    {
                        Console.Write($" {dayCount,-4}");
                    }
                    if (dayCount == 5 || dayCount == 12 || dayCount == 19 || dayCount == 26)
                    {
                        Console.WriteLine();
                    }
                }
                else if (dayOfWeek == "wed")
                {
                    if (dayCount == 1)
                    {
                        Console.Write($"{"",15} {dayCount,-4}");
                    }
                    else
                    {
                        Console.Write($" {dayCount,-4}");
                    }
                    if (dayCount == 4 || dayCount == 11 || dayCount == 18 || dayCount == 25)
                    {
                        Console.WriteLine();
                    }
                }
                else if (dayOfWeek == "thu")
                {
                    if (dayCount == 1)
                    {
                        Console.Write($"{"",20} {dayCount,-4}");
                    }
                    else
                    {
                        Console.Write($" {dayCount,-4}");
                    }
                    if (dayCount == 3 || dayCount == 10 || dayCount == 17 || dayCount == 24)
                    {
                        Console.WriteLine();
                    }
                }
                else if (dayOfWeek == "fri")
                {
                    if (dayCount == 1)
                    {
                        Console.Write($"{"",25} {dayCount,-4}");
                    }
                    else
                    {
                        Console.Write($" {dayCount,-4}");
                    }
                    if (dayCount == 2 || dayCount == 9 || dayCount == 16 || dayCount == 23 || dayCount == 30)
                    {
                        Console.WriteLine();
                    }
                }
                else
                {
                    if (dayCount == 1)
                    {
                        Console.Write($"{"",30} {dayCount,-4}");
                    }
                    else
                    {
                        Console.Write($" {dayCount,-4}");
                    }
                    if (dayCount == 1 || dayCount == 8 || dayCount == 15 || dayCount == 22 || dayCount == 29)
                    {
                        Console.WriteLine();
                    }
                }
               

            }
        }
    }
}
