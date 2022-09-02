using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of $: ");
            double i = Convert.ToDouble(Console.ReadLine());
            double x = i * 100;
            Console.WriteLine("{0}$ equals to {1}¢", i, x);

            Console.ReadLine();
        }
    }
}
