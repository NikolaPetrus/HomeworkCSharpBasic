using System;

namespace Task_2_AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number:");
            string firstNum = Console.ReadLine();
            double num1 = int.Parse(firstNum);

            Console.WriteLine("Please enter second number:");
            string secondNum = Console.ReadLine();
            double num2 = int.Parse(secondNum);

            Console.WriteLine("Please enter third number:");
            string thirdNum = Console.ReadLine();
            double num3 = int.Parse(thirdNum);

            Console.WriteLine("Please enter fourth number:");
            string fourthNum = Console.ReadLine();
            double num4 = int.Parse(fourthNum);

            double averageResult;
            averageResult = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine("The average of " + num1 + ", " + num2 + ", " + num3 + " and " + num4 + " is: " + averageResult);


            Console.Read();
        }
    }
}
