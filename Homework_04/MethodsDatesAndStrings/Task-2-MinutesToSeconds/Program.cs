using System;

namespace Task_2_MinutesToSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter how many minutes you want to convert to seconds : ");
                bool parsedNumber = int.TryParse(Console.ReadLine(), out int minutesInput);

                if (parsedNumber && minutesInput >= 0)
                {
                    ConvertToSeconds(minutesInput);
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter only positive numbers!");
                }
            }
        }
        public static int ConvertToSeconds(int minInput)
        {
            int minToSec = 60;
            int convertedMins = minInput * minToSec;
            Console.WriteLine($"{minInput}minutes converted in seconds are {convertedMins}seconds.");
            return convertedMins;
        }
    }
}
