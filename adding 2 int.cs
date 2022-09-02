using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an intiger: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second intiger: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of them equals: " + (x + i));

            Console.ReadLine();
        }
    }
}
