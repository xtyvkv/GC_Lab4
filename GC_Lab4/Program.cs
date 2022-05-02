// TO DO
// - Deal with invalid iput

using System;

namespace GC_Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Student data
            string[] studentNames = new string[5]
            {
                "Pamela",
                "Gordo",
                "Chelsea",
                "Craig",
                "Sasha"
            };

            string[] studentTowns = new string[5]
            {
                "Columbus, OH",
                "Denver, CO",
                "Detroit, MI",
                "Toledo, OH",
                "Tampa, FL",
            };
            

            string[] studentFoods = new string[5]
            {
                "Cheese",
                "Cereal",
                "Pizza",
                "Chicken Alfredo",
                "Soylent"
            };

            // Print student list
            Console.WriteLine("Here are all of my students. Pick one by entering their number.");
            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {studentNames[i]}");
            }

            // Select student
            var studentChoice = int.Parse(Console.ReadLine());
            Console.WriteLine($"You chose {studentNames[studentChoice - 1]}");

            // Select category
            Console.WriteLine("Display Hometown or Favorite Food?");
            var categoryChoice = Console.ReadLine();

            // Output student info
            if (categoryChoice.Equals("Hometown", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{studentTowns[studentChoice - 1]}");
            }
            else if (categoryChoice.Equals("Favorite Food", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{studentFoods[studentChoice - 1]}");
            }
            else
                Console.WriteLine("Invalid input.");
            Console.WriteLine("Bye!");
        }
    }
}
