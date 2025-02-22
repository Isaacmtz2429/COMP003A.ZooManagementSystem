using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    public abstract class Animal
    {
        private string _name;
        private string _species;

        public string Name
        {
            get => _name;
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be null or empty.");
                _name = value;
            }
        }

        public string Species
        {
            get => _species;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Species cannot be null or empty.");
                _species = value;
            }
        }

        public Animal( string name, string species)
        {
            Name = name;
            Species = species;
        }

        public abstract void MakeSound();

        public class Lion : Animal
        {
            public Lion(string name, string species) : base(name, species) { }
            public override void MakeSound()
            {
                Console.WriteLine("The lion roars!");
            }
        }
        public class Parrot : Animal
        {
            public Parrot(string name, string species) : base(name, species) { }
            public override void MakeSound()
            {
                Console.WriteLine("The parrot squawks!");
            }
        }
    }
}
