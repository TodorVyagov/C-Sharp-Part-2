//Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints 
//the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
using System;
using System.Globalization;

namespace ReadDateTimeAndPrintAfter6Hours
{
    class ReadDateTimeAndPrintAfter6Hours
    {
        static void Main()
        {
            Console.WriteLine("This program will read a date and time given in the format: day.month.year hour:minute:second and print the date and time after 6 hours and 30 minutes");
            string format = "d.M.yyyy H:m:s";
            DateTime date = DateTime.ParseExact("13.3.2006 17:25:13", format, CultureInfo.InvariantCulture);
            Console.WriteLine(date.ToString(format));
            date = date.AddHours(6).AddMinutes(30);
            Console.WriteLine(date.ToString(format));
        }
    }
}
