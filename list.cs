using System;
using System.Collections.Generic;

namespace Stuff_for_school
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            int i = 0;

            do
            {
                Console.Write("Wprowadź znaki: ");
                list.Add(Console.ReadLine());
                i++;

            } while (i < 5);
            list.Sort();
            foreach (string s in list) { Console.WriteLine(s); }

            Console.ReadLine();
        }
    }
}