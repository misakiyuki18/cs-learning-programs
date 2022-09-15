using System;

namespace ConsoleApp5

{
    class Program
    {
        static void Main(string[] args)
        {
            string lower = "abcdefghijklmnopqrstuvwxyz";
            string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "0123456789";
            var x = new Random();
            int lenght = 12;
            

            for (int i = 0; i < lenght; i++)
            {
                int y = x.Next(15);
                if (y < 5)
                {
                    for (int m = 0; i < lenght; i++)
                    {
                        int a = x.Next(9);
                        Console.Write(lower[a]);
                        break;
                    }
                }
                if (y >= 5 && y < 10)
                {
                    for (int n = 0; i < lenght; i++)
                    {
                        int a = x.Next(9);
                        Console.Write(upper[a]);
                        break;
                    }
                }
                if (y >= 10)
                {
                    for (int o = 0; i < lenght; i++)
                    {
                        int a = x.Next(9);
                        Console.Write(numbers[a]);
                        break;
                    }
                }
            }

            
            
            
            Console.ReadLine();
        }
    }
   
}