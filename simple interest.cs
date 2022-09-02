using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            a	=	final amount
            p	=	initial principal balance - how much money was invested 
            r	=	annual interest rate - %
            t	=	time (in years)*/

            Console.Write("Enter the initial principal balance: ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the annual interest rate: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the time (in years): ");
            double t = Convert.ToDouble(Console.ReadLine());
            double i = r * 0.01;
            double a = p * i * t; 

            Console.WriteLine("Simple interest equals: {0:0.##}", a);

            Console.ReadLine();
        }
    }
}
