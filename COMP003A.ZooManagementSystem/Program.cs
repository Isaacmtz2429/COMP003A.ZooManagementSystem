/*
// Author: Isaac Martinez
// Course: COMP-003
// Faculty: Jonathan Cruz
// Purpose: Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#.
*/
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
            }
        }
    }
}
