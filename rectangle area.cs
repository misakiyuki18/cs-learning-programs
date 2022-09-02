using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the width: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the height: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Area of this rectangle equals: {0}", x * y);

            Console.ReadLine();
        }
    }
}
