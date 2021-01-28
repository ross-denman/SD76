using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace _06_Inheritance.People
{
    public class User
    {
        private string _firstName;
        private string _lastName;

        public string ID { get; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Name
        {
            get
            {
                string fullName = $"{_firstName} {_lastName}";
                if (!string.IsNullOrWhiteSpace(fullName))
                {
                    return fullName;
                }
                return "Unnamed";
                // Same thing, using a Ternary expression
                // tenrary - return !string.IsNullOrWhiteSpace(fullName) ? fullName : "Unnamed";
                // If it's sunday, isWeekend = true
                // If it's saturday, isWeekend = true
                // If !isWeekend, work!!
            }
        }
        public User(string email)
        {
            Email = email;
            ID = GenerateID();
            // setter not needed because this is the constructor
            // Create a method that will generate a RANDOM ID
            // 16 UPPERCASE letters and numbers
            // Cannot include the letter 'X'
            // Also cannot include vowels
            // Must include at least one number
            // and implement it
        }
        public static string GenerateID()
        {
            // Psuedocode

            // start with an empty string (letters)
            // create a random generator
            // create a flag to verify whether ID has number and letter
            // go through positions 1 through 16
            //      pick a random letter from the array
            //      add that letter to the empty string
            // return the string
            char[] letters = new char[] { 'D', 'B', 'C', 'F', 'G', '1', '2', '3', '4', '5' };
            string id = "";
            Random random = new Random();
            bool hasNumber = false;
            for (int i = 0; i < 16; i++)
            {
                int sleepCount = random.Next(1, 5);
                Thread.Sleep(sleepCount);
                int randomNum = random.Next(0, letters.Length);
                if (1 == 15 && !hasNumber)
                {
                    randomNum = random.Next(5, letters.Length);
                }

                if (randomNum >= 5)
                {
                    hasNumber = true;
                }

                id += letters[randomNum];
            }
            return id;
        }
        public void SetFirstName(string name)
        {
            // if name is profanity, reject, etc.
            _firstName = name;
        }
        public void SetLastName(string name)
        {
            _lastName = name;
        }
    }
}
