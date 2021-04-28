using System;

namespace WindDrawsLosses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of the wins: ");
            bool checkWins = long.TryParse(Console.ReadLine(), out long winsInput);

            Console.WriteLine("Please enter the number of the draws: ");
            bool checkDraws = long.TryParse(Console.ReadLine(), out long drawsInput);

            Console.WriteLine("Please enter the number of the losses: ");
            bool checkLosses = long.TryParse(Console.ReadLine(), out long lossesInput);


            long result = Points(winsInput, drawsInput, lossesInput);
            Console.WriteLine($"The football team has {result} points");

            static long Points(long winsInput, long drawsInput, long lossesInput)
            {
                long winsPoints = winsInput * 3;
                long drawsPoints = drawsInput * 1;
                long lossesPoints = lossesInput * 0;

                return winsPoints + drawsPoints + lossesPoints;
            }
        }
    }
}