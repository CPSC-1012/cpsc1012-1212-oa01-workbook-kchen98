using System;

namespace _Objects__Class__RoomCalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Rectangle object (instance) for the four sides of the room
            Rectangle leftWall = new Rectangle(10, 8);
            Rectangle rightWall = new Rectangle(10, 8);
            Rectangle frontWall = new Rectangle(12, 8);
            Rectangle backWall = new Rectangle(12, 8);

            Rectangle door = new Rectangle(7, 2.5);
            Rectangle window = new Rectangle(3, 4.5);
            Rectangle closet = new Rectangle(7, 5);

            double paintableWallArea = leftWall.Area() + rightWall.Area() + frontWall.Area() + backWall.Area() - door.Area() - window.Area() - closet.Area();
            Console.WriteLine($"The paintable wall area should be 286.");
            Console.WriteLine($"Actual area is {paintableWallArea}");
        }
    }
}
