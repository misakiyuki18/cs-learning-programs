using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the lenght of one side: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Area of this square is: {0}", Math.Pow(x, 2));
            Console.WriteLine("Perimeter of this square is: {0}", x * 4);

            Console.ReadLine();
        }
    }
}
