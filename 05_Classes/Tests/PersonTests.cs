using _05_Classes.Classes;
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
            Console.WriteLine($"{person.FirstName} {person.LastName}");

            Console.WriteLine(person.FullName);

            Person otherPerson = new Person(
                "Ashely",
                "Lawrence",
                new DateTime(1989, 4, 26),
                new Vehicle());
        }
    }
}
