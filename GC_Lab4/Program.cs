// you shouldn't have to repeat quewstions and stuff every possible number choice
// better way to write out array?
// linking together

using System;

namespace GC_Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentNames = new string[5];
            studentNames[0] = "Pamela";
            studentNames[1] = "Gordo";
            studentNames[2] = "Chelsea";
            studentNames[3] = "Craig";
            studentNames[4] = "Sasha";

            string[] studentTowns = new string[5];
            studentTowns[0] = "Columbus, OH";
            studentTowns[1] = "Denver, CO";
            studentTowns[2] = "Detroit, MI";
            studentTowns[3] = "Toledo, OH";
            studentTowns[4] = "Tampa, FL";

            string[] studentFood = new string[5];
            studentFood[0] = "Cheese";
            studentFood[1] = "Cereal";
            studentFood[2] = "Pizza";
            studentFood[3] = "Chicken Alfredo";
            studentFood[4] = "Soylent";

            Console.WriteLine("Here are all of my students. Pick one by entering their number.");
            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {studentNames[i]}");
            }
            var userChoice = int.Parse(Console.ReadLine());
            if (userChoice == 1)
            {
                Console.WriteLine(studentNames[0]);
                Console.WriteLine("Display Hometown or Favorite Food?");
                var userCatagoryChoice = Console.ReadLine();
                if (userCatagoryChoice == "Hometown")
                {
                    Console.WriteLine($"{studentTowns[userChoice - 1]}");
                }
            }
            Console.WriteLine("Bye!");
        }
    }
}
