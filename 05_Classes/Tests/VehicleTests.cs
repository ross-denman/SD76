using _05_Classes.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes.Tests
{
    [TestClass]
    public class VehicleTests
    {
        [TestMethod]
        public void Properties()
        {
            Vehicle firstVehicle = new Vehicle("Honda", "Civic", VehicleType.Car);
            firstVehicle.Make = "Honda";

            Console.WriteLine(firstVehicle.Make);
            firstVehicle.Make = "Dodge";
            firstVehicle.Model = "Journey";
            firstVehicle.Mileage = 240000;
            firstVehicle.Type = VehicleType.Car;
        }
        [TestMethod]
        public void Methods()
        {
            
            Vehicle myCar = new Vehicle("Honda", "Civic", VehicleType.Car);
            Console.WriteLine(myCar.IsRunning);
            myCar.TurnOn();
            Console.WriteLine(myCar.IsRunning);
        }
    }
}
