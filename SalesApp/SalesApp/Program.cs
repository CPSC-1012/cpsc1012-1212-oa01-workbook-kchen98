/*  Purpose: Compute the total of a sales item using the price and tax.
 *  
 *  Inputs:  price in dollars and cents
 *  
 *  Outputs: sales tax
 *           sales total
 *  
 *  Algorithm: Step 1) Prompt and read in the sale price
 *             Step 2) Calculate the sale total using the formula:
 *                            salesTax = salePrice * 0.05
 *                            salesTotal = salePrice + salesTax
 *             Step 3) Display the computed sale total and total
 *             
 *  Last modified:  2022-01-12
 *  */
using System;

namespace SalesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for the price, tax, and total.
            double price,
                    tax,
                    total;
            const double salesTax = 0.05;
            string userinput;

            // Prompt and read in the sale price
            Console.Write("Enter the price of the item:");
            userinput = Console.ReadLine();

            // Calculate the sale total using the formula
            price = double.Parse(userinput);
            tax = price * salesTax;
            total = price + tax;

            // Display the computed sale total and total
            Console.WriteLine($"The price of the item is {price:C}");
            Console.WriteLine($"The tax is {tax:C}");
            Console.WriteLine($"The total is {total:C}");

            Console.WriteLine($"{"Price:", -10}{price,8:c}");
            Console.WriteLine($"{"Tax:",-10}{tax,8:c}");
            Console.WriteLine($"{"Total:",-10}{total,8:c}");
        }
    }
}
