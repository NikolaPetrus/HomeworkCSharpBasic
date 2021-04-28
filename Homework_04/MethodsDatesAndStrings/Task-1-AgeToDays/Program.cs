using System;

namespace Task_1_AgeToDays
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter your age to convert to days: ");
                int ageNumber = 0;
                bool checkParsedNumber = int.TryParse(Console.ReadLine(), out ageNumber);

                if (ageNumber >= 0)
                {
                    AgeToDays(ageNumber);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again with only positive numbers!");
                };

            }

        }

        public static int AgeToDays(int ageNumber)
        {
            int days = 365;
            int ageInDays = days * ageNumber;
            Console.WriteLine($"Your entered age: {ageNumber} converted in days is: {ageInDays} days.");
            return ageInDays;
        }
    }
}
