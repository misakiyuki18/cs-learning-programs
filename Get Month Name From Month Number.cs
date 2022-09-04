using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input month number: ");
            int monthNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Month with number {0}", monthNum);
            string monthName;

            switch (monthNum)
            {
                    case 1:
                    monthName = "January";
                    Console.Write(" is {0}", monthName);
                    break;

                    case 2:
                    monthName = "February";
                    Console.Write(" is {0}", monthName);
                    break;

                    case 3:
                    monthName = "March";
                    Console.Write(" is {0}", monthName);
                    break;

                    case 4:
                    monthName = "April";
                    Console.Write(" is {0}", monthName);
                    break;

                    case 5:
                    monthName = "May";
                    Console.Write(" is {0}", monthName);
                    break;

                    case 6:
                    monthName = "June";
                    Console.Write(" is {0}", monthName);
                    break;

                    case 7:
                    monthName = "July";
                    Console.Write(" is {0}", monthName);
                    break;

                    case 8:
                    monthName = "August";
                    Console.Write(" is {0}", monthName);
                    break;

                    case 9:
                    monthName = "September";
                    Console.Write(" is {0}", monthName);
                    break;

                    case 10:
                    monthName = "October";
                    Console.Write(" is {0}", monthName);
                    break;

                    case 11:
                    monthName = "November";
                    Console.Write(" is {0}", monthName);
                    break;

                    case 12:
                    monthName = "December";
                    Console.Write(" is {0}", monthName);
                    break;

                    default:
                    monthName = "Invalid month Number";
                    break;
            }
            Console.ReadLine();
        }
    }
}
