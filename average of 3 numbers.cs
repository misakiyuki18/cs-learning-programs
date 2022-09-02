using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input second number: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input third number: ");
            double z = Convert.ToDouble(Console.ReadLine());
            double i = (x + y + z) / 3;
            Console.WriteLine("Average of those 3 numbers is: {0}", i);

            Console.ReadLine();
        }
    }
}
