using _05_Classes.Classes;
using _06_Inheritance.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes.Classes
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void NameTest()
        {
            Person person = new Person();
            person.FirstName = "Ross";
            person.LastName = "Denman";
            person.DateOfBirth = new DateTime(1975, 1, 9);
            Console.WriteLine($"{person.FirstName} {person.LastName} {person.Age}");

            Console.WriteLine(person.FullName);

            Person otherPerson = new Person(
                "Ashely",
                "Lawrence",
                new DateTime(1989, 4, 26),
                new Vehicle("Chevy", "Malibu", VehicleType.Car));
        }
        [TestMethod]
        public void IdTest()
        {
            for (int i = 0; i < 10; i++)
            {
                User user = new User("dsfh");
                Console.WriteLine(user.ID);
            }
        }
    }
}
