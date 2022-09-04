using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (checkAge(age))
            {
                Console.WriteLine("{0} is an age of adult person", age);
            } else
            {
                Console.WriteLine("They're not adult person");
            }

        }
        static bool checkAge(int age)
        {

            return age >= 18 ? true : false;
        }
    }
}