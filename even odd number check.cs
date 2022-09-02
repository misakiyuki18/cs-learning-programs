using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number: ");
            int i = Convert.ToInt32(Console.ReadLine());
            if (isEven(i))
            {
                Console.WriteLine("Number is even");
            } else
            {
                Console.WriteLine("Number is odd");
            }
            Console.ReadLine();
        }
        public static bool isEven(int n)
        {
            return (n % 2 == 0);
        }
    }
}
