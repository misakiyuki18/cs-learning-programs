using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            int a = r.Next(10);
            int num = 0;
            do
            {
                a = r.Next(10);
            } while (a == 0);
            int[] numbers = new int[a];
            int numbersAAvg = 0;
            int numbersUAvg = 0;
            int numbersEqToAvg = 0;
            Console.WriteLine("calculating average of {0} random numbers\n -----------------------------", a);

            for (int i = 0; i < a; i++)
            {
                num = r.Next(10);
                numbers[i] = num;
                Console.WriteLine(num);

            }
            double avg = numbers.Average();

            for (int i = 0; i < a; i++)
            {
                if (numbers[i] > avg)
                {
                    numbersAAvg++;
                }
                if (numbers[i] < avg)
                {
                    numbersUAvg++;
                }
                if (numbers[i] == avg)
                {
                    numbersEqToAvg++;
                }

            }
            Console.WriteLine("-----------------------------\nAverage: {0}\nnumber of numbers above average: {1}" +
                "\nnumber of numbers under average: {2}\nnumber of numbers equal to average: {3}", avg, numbersAAvg, numbersUAvg, numbersEqToAvg);

            Console.ReadLine();
        }
    }
}


