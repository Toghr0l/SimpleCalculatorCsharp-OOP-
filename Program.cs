using System;

namespace Calculator_example
{
    class Program
    {
        static ICalculate calculate = new Calculate();
        static void Main(string[] args)
        {
            /* string @if = "Hello world!";
            System.Console.WriteLine(@if); */

            Console.WriteLine("Hello, this is a calculator program!");
            Console.Write("Enter your first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine()?.Trim());
            Console.Write("Enter your second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine()?.Trim());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------Which-kind-of-operation-you-want-to-apply?--------");
            Console.ResetColor();
            Console.WriteLine("Options available: + - * / ");
            while (true)
            {
                Console.Write("Your choice(q to exit): ");
                string option = Console.ReadLine().ToLower();
                if (option == "+")
                {
                    Console.WriteLine(calculate.sum(firstNumber, secondNumber));
                }
                else if (option == "-")
                {
                    Console.WriteLine(calculate.minus(firstNumber, secondNumber));
                }
                else if (option == "*")
                {
                    Console.WriteLine(calculate.multiple(firstNumber, secondNumber));
                }
                else if (option == "/")
                {
                    Console.WriteLine(calculate.divide(firstNumber, secondNumber));
                }
                else if (option == "q")
                {
                    Console.WriteLine("Good bye lil bro! Thanks for using me!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option entered.");
                }
            }
        }
    }
}
