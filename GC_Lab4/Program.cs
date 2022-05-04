// TO DO
// - Deal with invalid iput (input that won't convert to int)

using System;

namespace GC_Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool goAgain = true;

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
                "hometown",
                "favorite food"
            };

            while (goAgain)
            {
                // Ask for student number
                Console.WriteLine("Please enter a student number. If you would like to see the student directory please enter \"099\".");
                var studentChoice = int.Parse(Console.ReadLine());
                if (studentChoice == 099)
                {
                    for (int i = 0; i < studentNames.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {studentNames[i]}");
                    }
                    Console.WriteLine();
                    continue;
                }
                else if (studentChoice < 1 || studentChoice > studentNames.Length)
                    Console.WriteLine("There is no student associated with that number.");
                else
                {
                    // Print categories
                    Console.WriteLine();
                    Console.WriteLine($"Student {studentChoice} is {studentNames[studentChoice - 1]}. What would you like to know? Enter \"{studentCategories[0]}\" or \"{studentCategories[1]}\".");
                    var categoryChoice = Console.ReadLine();

                    // Output student info
                    if (categoryChoice.Equals(studentCategories[0], StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine();
                        Console.WriteLine($"{studentNames[studentChoice - 1]}'s {studentCategories[0]} is {studentTowns[studentChoice - 1]}.");
                    }
                    else if (categoryChoice.Equals(studentCategories[1], StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine();
                        Console.WriteLine($"{studentNames[studentChoice - 1]}'s {studentCategories[1]} is {studentFoods[studentChoice - 1]}.");
                    }
                }

                // Go again?
                Console.WriteLine();
                Console.WriteLine("Would you like to learn about another student (y/n)?");
                string userWillGoAgain = Console.ReadLine();
                if (userWillGoAgain == "y")
                {
                    Console.WriteLine();
                    continue;
                }
                    else if (userWillGoAgain == "n")
                    break;
                else
                    Console.WriteLine();
                    Console.WriteLine("Invalid input.");
                    break;
            }
                Console.WriteLine();
                Console.WriteLine("Goodbye!");
        }
    }
}
