/*
// Author: Isaac Martinez
// Course: COMP-003
// Faculty: Jonathan Cruz
// Purpose: Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#.
*/
using System.Diagnostics;
using static COMP003A.ZooManagementSystem.Animal;

namespace COMP003A.ZooManagementSystem
{
    internal class Program
    {
        static List<Animal> animals = new List<Animal>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nWelcome to the Zoo Managment System!");
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Add a Lion");
                Console.WriteLine("2. Add a Parrot");
                Console.WriteLine("3. Display All Animals");
                Console.WriteLine("4. Describe an Animal");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddLion();
                        break;
                    case "2":
                        AddParrot();
                        break;
                    case "3":
                        DisplayAllAnimals();
                        break;
                    case "4":
                        DescribeAnimal();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, Please try again.");
                        break;
                }
            }
        }
        static void AddLion()
        {
            try
            {
                Console.WriteLine("Enter the name of the lion: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the species of the lion: ");
                string species = Console.ReadLine();

                Animal lion = new Lion(name, species);
                animals.Add(lion);

                Console.WriteLine("Lion added successfully!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        static void AddParrot()
        {
            try
            {
                Console.WriteLine("Enter the name of the parrot: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the species of the parrot: ");
                string species = Console.ReadLine();

                Animal parrot = new Parrot(name, species);
                animals.Add(parrot);

                Console.WriteLine("Parrot added successfully!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
