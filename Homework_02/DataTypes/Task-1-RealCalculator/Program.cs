using System;

namespace Task_1_RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            char symbol;

            Console.Write("Enter first number:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter operation symbol");
            symbol = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter second number");
            b = Convert.ToInt32(Console.ReadLine());


            if (symbol == '+')
                Console.WriteLine("{0} + {1} = {2}", a, b, a + b);

            else if (symbol == '-')
                Console.WriteLine("{0} - {1} = {2}", a, b, a - b);

            else if (symbol == '*')
                Console.WriteLine("{0} * {1} = {2}", a, b, a * b);

            else if (symbol == '/')
                Console.WriteLine("{0} / {1} = {2}", a, b, a / b);

            else
                Console.WriteLine("Wrong character! Please try again!");

            

        }
    }
}
