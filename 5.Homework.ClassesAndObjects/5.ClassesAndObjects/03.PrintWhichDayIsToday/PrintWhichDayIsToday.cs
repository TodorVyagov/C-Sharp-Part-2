//Write a program that prints to the console which day of the week is today. Use System.DateTime.
using System;

namespace PrintWhichDayIsToday
{
    class PrintWhichDayIsToday
    {
        static void Main()
        {
            Console.WriteLine("This program will print to the console which day of the week is today.");
            DateTime today = DateTime.Now;
            Console.WriteLine("Today it is {0}.", today.DayOfWeek);
            Console.WriteLine("Tomorrow it will be {0}.", today.AddDays(1).DayOfWeek);
        }
    }
}
