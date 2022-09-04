using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator:\n + - to add, - to subtrackt, * to multiply,\n / to divide, ^ to raise a number to the power of other number, $ - square root\n");
            string op = Console.ReadLine();
            if (op == "$")
            {
                Console.Write(Math.Sqrt(num1));
                Console.ReadLine();
                return ;
            }
            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            if (op == "+")
            {
                Console.Write(num1 + num2);
            }
            else if (op == "-")
            {
                Console.Write(num1 - num2);
            }
            else if (op == "*")
            {
                Console.Write(num1 * num2);
            }
            else if (op == "/")
            {
                Console.Write(num1 / num2);
            }
            else if (op == "^")
            {
                Console.Write(Math.Pow(num1, num2));
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }

            Console.ReadLine();
        }
    }
}
