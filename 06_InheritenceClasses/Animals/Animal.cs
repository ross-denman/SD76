using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_InheritenceClasses.Animals
{
    public enum DietType { Herbivore, Carnivore, Omnivore }
    // abstract class means we're only using this class for inheritance
    // we are not defining class itself
    public abstract class Animal
    {
        public Animal()
        {
            Console.WriteLine("This is the animal constructor");
        }
        public int NumberOfLegs { get; set; }
        public DietType DietType { get; set; }
        public bool IsHungry { get; set; }
        public virtual void Move()
        {
            Console.WriteLine($"This {GetType().Name} moves!");
        }
    }
}
