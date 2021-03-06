﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes.Classes
{
    public class Greeter
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
        public void SayRandomGreeting(string name)
        {
            Console.WriteLine($"{GetRandomGreeting()}, {name}");
        }
        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }
        Random _random = new Random();
        private string GetRandomGreeting()
        {
            string[] greetings = new string[] { "Hi", "Yo", "What's up", "How are you", "Hola"};
            int randomNumber = _random.Next(0, greetings.Length);
            string randomGreeting = greetings.ElementAt(randomNumber);
            return randomGreeting;
        }
    }
}
