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
                Console.WriteLine("\nPlease choose an option:");
                Console.WriteLine("1. Add a Lion");
                Console.WriteLine("2. Add a Parrot");
                Console.WriteLine("3. Display All Animals");
                Console.WriteLine("4. Describe an Animal");
                Console.WriteLine("5. Exit");
                Console.Write("\nYour Choice: ");

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
                Console.Write("Enter the name of the lion: ");
                string name = Console.ReadLine();
                Console.Write("Enter the species of the lion: ");
                string species = Console.ReadLine();

                Animal lion = new Lion(name, species);
                animals.Add(lion);

                Console.WriteLine("\nLion added successfully!");
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
                Console.Write("Enter the name of the parrot: ");
                string name = Console.ReadLine();
                Console.Write("Enter the species of the parrot: ");
                string species = Console.ReadLine();

                Animal parrot = new Parrot(name, species);
                animals.Add(parrot);

                Console.WriteLine("\nParrot added successfully!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        static void DisplayAllAnimals()
        {
            Console.WriteLine("Displaying all animals:");
            foreach(var animal in animals)
            {
                animal.MakeSound();
                Console.WriteLine($"({animal.Name}, {animal.Species})");
            }
        }
        static void DescribeAnimal()
        {
            Console.WriteLine("Choose an overload:");
            Console.WriteLine("1. DescribeAnimal (name only)");
            Console.WriteLine("2. DescribeAnimal (name and species)");
            Console.WriteLine("3. DescribeAnimal (name, species, and age)");
            Console.Write("\nYour Choice: ");

            string choice = Console.ReadLine();

            Console.Write("Enter the name of the animal: ");
            string name = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ZooUtility.DescribeAnimal(name);
                    break;
                case "2":
                    Console.Write("Enter the species of the animal: ");
                    string species = Console.ReadLine();
                    ZooUtility.DescribeAnimal(name, species);
                    break;
                case "3":
                    Console.Write("Enter the species of the animal: ");
                    species = Console.ReadLine();
                    Console.Write("Enter the age of the animal: ");
                    if (int.TryParse(Console.ReadLine(), out int age))
                    {
                        ZooUtility.DescribeAnimal(name, species, age);
                    }
                    else
                    {
                        Console.WriteLine("Invalid age input. ");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
