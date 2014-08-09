//Write a method that calculates the number of workdays between today and given date, passed as parameter. 
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
using System;

namespace CalculateWorkdaysToGivenDate
{
    class CalculateWorkdaysToGivenDate
    {
        static void Main()
        {
            Console.WriteLine("This program will calculate the number of workdays between today and given date.");
            DateTime today = DateTime.Today;
            Console.Write("Enter year = ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter month = ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter day = ");
            int day = int.Parse(Console.ReadLine());
            DateTime givenDate = new DateTime();
            try
            {
                givenDate = new DateTime(year, month, day);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("You entered incorrect date! There is no such calendar date as {0}.{1}.{2}", day, month, year);
                Environment.Exit(0);
            }
            Console.WriteLine("Today it is: " + today.ToString("dd.MM.yyyy"));
            Console.WriteLine("Entered date is: " + givenDate.ToString("dd.MM.yyyy"));

            if (givenDate < today)
            {
                Console.WriteLine("The date you entered is before the current date.");
                Environment.Exit(0);
            }

            int[] holidaysOf2014 = { 1, 62, 108, 109, 110, 111, 121, 122, 125, 126, 144, 249, 265, 305, 358, 359, 360, 365};
            //Source of official holidays list: http://www.trudipravo.bg/index.php?option=com_content&view=article&id=2087&Itemid=134
            //Converted day.month into dayOfYear
            int workdays = 0;

            while (today <= givenDate)
            {
                int currentDay = today.DayOfYear;
                string dayOfWeek = today.DayOfWeek.ToString();;
                bool isHoliday = false;
                bool isWeekday = true;

                for (int i = 0; i < holidaysOf2014.Length; i++) //check if it is holiday
                {
                    if (currentDay == holidaysOf2014[i])
                    {
                        isHoliday = true;
                    }
                }

                if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
                {
                    isWeekday = false;
                }

                if (isHoliday == false && isWeekday == true) 
                {
                    workdays++;
                }
                today = today.AddDays(1);
            }

            Console.WriteLine("There are {0} working days.", workdays);
            //the given date is included in the check
        }
    }
}
