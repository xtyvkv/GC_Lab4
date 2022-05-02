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
                "cheese",
                "cereal",
                "pizza",
                "chicken alfredo",
                "Soylent"
            };

            string[] studentCategories = new string[2]
            {
                "Hometown",
                "Favorite Food"
            };

            // Print student list
            Console.WriteLine("Here are all of my students. Pick one by entering their number.");
            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {studentNames[i]}");
            }

            // Select student
            var studentChoice = int.Parse(Console.ReadLine());

            // Print categories
            Console.WriteLine();
            Console.WriteLine($"What would you like to know about {studentNames[studentChoice - 1]}?");
            for (int i = 0; i < studentCategories.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {studentCategories[i]}");
            }
            var categoryChoice = int.Parse(Console.ReadLine());
            
            // Output student info
            if (categoryChoice == 1)
            {
                Console.WriteLine();
                Console.WriteLine($"{studentNames[studentChoice - 1]}'s {studentCategories[categoryChoice - 1].ToLower()} is {studentTowns[studentChoice - 1]}.");
            }
            else if (categoryChoice == 2)
            {
                Console.WriteLine();
                Console.WriteLine($"{studentNames[studentChoice - 1]}'s {studentCategories[categoryChoice - 1].ToLower()} is {studentFoods[studentChoice - 1]}.");
            }
            Console.WriteLine();
            Console.WriteLine("Goodbye!");

            // Probably not possible, but setting this aside to try again later. Would be cool if I could do this in one string.
                /*
                // Select category
                var categoryChoice = int.Parse(Console.ReadLine());

                // Output student info
                Console.WriteLine($"{studentNames[studentChoice - 1]}'s {studentCategories[categoryChoice - 1]} is ???");
                */
        }
    }
}
