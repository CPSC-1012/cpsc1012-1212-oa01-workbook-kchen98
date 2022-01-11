using System;

namespace IntVariableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int checking;
            long days;

            checking = -20;
            days = 189000;

            Console.WriteLine($"Our account balance is {checking:c}");
            Console.WriteLine($"About {days} days ago Columbus stood on this spot");
        }
    }
}
