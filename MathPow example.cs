using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input number of power number: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double i = Math.Pow(x, y);
            Console.WriteLine("{0} rised to power of {1} equals: {2}", x, y, i);

            Console.ReadLine();
        }
    }
}
