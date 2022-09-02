using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input string: ");
            string s = Console.ReadLine();
            int i = s.Length;
            Console.WriteLine("Number of letters in this string (including space) is: {0}", i);

            Console.ReadLine();
        }
    }
}
