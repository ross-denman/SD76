using _06_Inheritance.People;
using _06_Inheritence.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_Inheritence.PeopleTests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void CustomerAndUsers()
        {
            User user = new User("fake@email.com", "fake Name");
            Customer customer = new Customer("notReal@fakeEmail.biz");

            //user.SetFirstName("Ross");
            //user.SetLastName("Denman");

            customer.SetFirstName("Zuri");
            customer.SetLastName("Rojas");

            Console.WriteLine("User:");
            Console.WriteLine(user.ID);
            Console.WriteLine(user.Email);
            Console.WriteLine("Customer:");
            Console.WriteLine(customer.ID);
            Console.WriteLine(customer.Email);
        }
    }
}
