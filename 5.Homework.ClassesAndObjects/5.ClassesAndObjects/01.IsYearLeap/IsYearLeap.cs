//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
using System;

namespace IsYearLeap
{
    class IsYearLeap
    {
        static void Main()
        {
            Console.Write("This program will check if given year is a leap one.\nEnter year: ");
            int givenYear = int.Parse(Console.ReadLine());
            bool isLeap = DateTime.IsLeapYear(givenYear);
            
            if (isLeap)
            {
                Console.WriteLine("The year you entered is a leap one.");
            }
            else
            {
                Console.WriteLine("The year you entered isn't a leap one.");
            }
        }
    }
}
