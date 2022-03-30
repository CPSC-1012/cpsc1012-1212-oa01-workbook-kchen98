using System;

namespace _Objects_Class__DieExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a 6 sided Die and a 12 sided Die
            Die sixSidedDie = new Die(6);
            Die twelveSidedDie = new Die(12);

            Console.WriteLine($"{sixSidedDie.Value, 10} {twelveSidedDie.Value, 10}");
            // Simulate rolling the two Die 5 times
            Console.WriteLine($"Rolling the two Die 5 times. ");
            for (int index = 0; index < 5; index++)
            {
                sixSidedDie.Roll();
                twelveSidedDie.Roll();
                Console.WriteLine($"{sixSidedDie.Value,10} {twelveSidedDie.Value,10}");
            }
        }
    }
}
