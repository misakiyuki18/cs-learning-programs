using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding biggest number from list of 3 numbers");
            Console.Write("First number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Second number: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Third number: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a > b && a > c){
                Console.WriteLine("{0} is the biggest number", a);
            } else if (a < b && b > c)
            {
                Console.WriteLine("{0} is the biggest number", b);
            } else if (a < c && b < c)
            {
                Console.WriteLine("{0} is the biggest number", c);
            }
        }
    }
}