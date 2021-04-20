using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] studentsG1 = { "Jana", "Ivan", "Stefan", "Matej", "Darko" };
            string[] studentsG2 = { "Marko", "Nikola", "Martina", "Marija", "Andrej" };

            Console.Write("Enter student group: (for group G1 enter 1 and for group G2 enter 2): ");
            string input = Console.ReadLine();
            while (true)
            {
                if (input == "1")
                {
                    foreach (var student in studentsG1)
                    {
                        Console.WriteLine(student);
                    }
                    break;
                }
                else if (input == "2")
                {
                    foreach (var student in studentsG2)
                    {
                        Console.WriteLine(student);
                    }
                    break;
                }
                else
                {
                    Console.Write("Invalid input! Try again: ");
                    input = Console.ReadLine();
                }

            }
        }

    }
}

