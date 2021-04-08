using System;

namespace Task_3_SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number");
            string firstNumber = Console.ReadLine();
            int firstNum = int.Parse(firstNumber);

            Console.WriteLine("Input second number");
            string secondNumber = Console.ReadLine();
            int secondNum = int.Parse(secondNumber);

            int firstVarToSec = secondNum;
            int secondVarToFirst = firstNum;

            firstNum = firstVarToSec;
            secondNum = secondVarToFirst;

            Console.Write("After Swapping : ");

            Console.WriteLine("First number: " + firstNum);
            Console.WriteLine("Second number: " + secondNum);

        }
    }
}
