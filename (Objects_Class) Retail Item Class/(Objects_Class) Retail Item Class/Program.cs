using System;

namespace _Objects_Class__Retail_Item_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RetailItem item1 = new RetailItem("Gears of War 4(Xbox One)", 30, 79.99m);
            RetailItem item2 = new RetailItem("Minecraft(PS4)", 100, 21.99m);
            RetailItem item3 = new RetailItem("Skylanders Imaginators Starter Pack(Wii I)", 15, 89.99m);

            // No override method in class
            Console.WriteLine($"{item1.Description}, {item1.UnitsOnHand}, {item1.Price:c}");
            Console.WriteLine($"{item2.Description}, {item2.UnitsOnHand}, {item2.Price:c}");
            Console.WriteLine($"{item3.Description}, {item3.UnitsOnHand}, {item3.Price:c}");

            // have override ToString in class
            Console.WriteLine(item1);
            Console.WriteLine(item2.ToString());
            Console.WriteLine(item3.ToString());

            Console.WriteLine();
            // Write the code to prompt the user for the Description, UnitsOnHand, and Price
            // for a new RetailItem.
            Console.WriteLine("Enter an item description, units on hand and price of the item");
            Console.Write("Item Description: ");
            string description = Console.ReadLine();
            Console.Write("Units on Hand: ");
            int unitsOnHand = int.Parse(Console.ReadLine());
            Console.Write("Price of Item: ");
            decimal price = decimal.Parse(Console.ReadLine());

            RetailItem item4 = new RetailItem(description, unitsOnHand, price);
            // Display the Description, UnitsOnHand, and Price of a new RetailItem object
            // with value assigned by the end user
            Console.WriteLine(item4);

            // Modify the RetailItem class to include either a computed property name TotalValue
            // that returns the UnitsOnHand multiply Price
            // or code a method named TotalValue() that returns the results of multiplying
            // UnitsOnHand with Price

            // Modify the program output to display the TotalValue for each RetailItem
        }
    }
}
