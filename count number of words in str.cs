using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input string: ");
            string s = Console.ReadLine();
            int i, word, l;
            l = 0;
            word = 1;

            do
            {
                if (s[l] == ' ' || s[l] == '\n' || s[l] == 't')
                {
                    word++;
                }

            l++;

            } while (l <= s.Length - 1);

            Console.WriteLine("Number of words in this string is: {0}", word);

            Console.ReadLine();
        }
    }
}
