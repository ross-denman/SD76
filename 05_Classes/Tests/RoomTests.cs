using _05_Classes.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes.Tests
{
    [TestClass]
    public class RoomTests
    {
        [TestMethod]
        public void SizeTest()
        {
            Room room1 = new Room();
            room1.Length = 12;
            room1.Width = 9;
            room1.Height = 8;
            Console.WriteLine($"Room is {room1.Length} feet long,");
            Console.WriteLine($"room is {room1.Width} feet wide,");
            Console.WriteLine($"and room is {room1.Height} feet high.");
            Console.WriteLine($"Surface area is {room1.SurfaceArea} square feet");
            Console.WriteLine($"Volume is {room1.Volume} cubic feet");

            Room closet = new Room(12, 9, 8);
            Console.WriteLine($"Closet length is {closet.Length}");
            Console.WriteLine($"Closet is {closet.SurfaceArea} square feet.");
            Console.WriteLine($"Closet is {closet.Volume} cubic feet.");
        }
    }
}
