using System;

namespace Task_1_SumofEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter six numbers:");
            int checkFirstNumber;
            int checkSecondNumber;
            int checkThirdNumber;
            int checkFourthNumber;
            int checkFifthNumber;
            int checkSixtNumber;

            bool firstInput = int.TryParse(Console.ReadLine(), out checkFirstNumber);
            bool secondInput = int.TryParse(Console.ReadLine(), out checkSecondNumber);
            bool thirdInput = int.TryParse(Console.ReadLine(), out checkThirdNumber);
            bool fourthInput = int.TryParse(Console.ReadLine(), out checkFourthNumber);
            bool fifthInput = int.TryParse(Console.ReadLine(), out checkFifthNumber);
            bool sixthInput = int.TryParse(Console.ReadLine(), out checkSixtNumber);


            if (firstInput && secondInput && thirdInput && fourthInput && fifthInput && sixthInput)
            {
                int[] arrayOfNums = { checkFirstNumber, checkSecondNumber, checkThirdNumber, checkFourthNumber, checkFifthNumber, checkSixtNumber };
                int sum = 0;
                foreach (var num in arrayOfNums)
                {
                    if (num % 2 == 0)
                    {
                        sum += num;
                    }

                }
                Console.WriteLine("The result is " + sum);

            }
            else
            {
                Console.WriteLine("Please enter six numbers");
            }
        }
    }
}
