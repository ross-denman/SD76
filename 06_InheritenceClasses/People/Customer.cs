using _06_Inheritance.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritence.People
{
    public class Customer : User
    {
        private int _maxId = 0;
        public int CustomerNumber { get; set; }
        public Customer(string email) : base(email, "Customer")
        {
            // Random random = new Random();
            // CustomerNumber = random.Next(0,999999999);
            CustomerNumber = _maxId;
            _maxId++;
        }
    }
}
