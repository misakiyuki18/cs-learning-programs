using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double i = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Product of them equals: " + (x / i));

            Console.ReadLine();
        }
    }
}
