//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 
using System;
using System.Globalization;

namespace CalculateDaysBetweenTwoDates
{
    class CalculateDaysBetweenTwoDates
    {
        static void Main()
        {
            Console.Write("This program will read two dates in the format: day.month.year and calculate the number of days between them.\nEnter first date in the format day.month.year: ");
            string format = "d.M.yyyy";
            string readDate = Console.ReadLine();
            DateTime dateOne = DateTime.ParseExact(readDate, format, CultureInfo.InvariantCulture);

            Console.WriteLine("Enter second date in the format day.month.year: ");
            readDate = Console.ReadLine();
            DateTime dateTwo = DateTime.ParseExact(readDate, format, CultureInfo.InvariantCulture);

            int days = Math.Abs(dateTwo.DayOfYear - dateOne.DayOfYear);
            Console.WriteLine("There are {0} days between the two dates.", days - 1); //Subtractiong 1 because we do not want to include the day
        }
    }
}
