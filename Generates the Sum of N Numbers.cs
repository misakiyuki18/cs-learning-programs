using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new Random();
            int a = x.Next(100);
            int[] numbers = new int[a];
            
            Console.WriteLine("{0}\n -----------------------------", a);
            int num = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                num = x.Next(1000);
                numbers[i] = num;
                Console.WriteLine("Number #{0}: {1}", i, num);
            }

            Console.WriteLine("\nSum of numbers above equals: {0}", numbers.Sum());

            Console.ReadLine();
        }
    }
}
