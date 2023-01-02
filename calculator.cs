using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;

            Console.WriteLine("Enter first number:");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter operation (+, -, *, /):");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    return;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
