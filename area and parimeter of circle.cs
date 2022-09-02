using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius of the circle: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Area of this circle equals: {0}",Math.PI * Math.Pow(x, 2));
            Console.WriteLine("Perimeter of this square equals: {0}", 2 * Math.PI * x);

            Console.ReadLine();
        }
    }
}
