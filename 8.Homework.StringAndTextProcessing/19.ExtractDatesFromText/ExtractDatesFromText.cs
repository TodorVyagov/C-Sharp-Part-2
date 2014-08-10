//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.
using System;
using System.Globalization;

namespace ExtractDatesFromText
{
    class ExtractDatesFromText
    {
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");

            Console.WriteLine("This program will extract from text all dates that match the format DD.MM.YYYY.");

            string text = "On 10.04.1912, the Titanic, 01.02.2014. largest ship afloat, left Southampton, England 2.3.1989 on her maiden voyage to New York City. The White Star Line had spared no expense in assuring her luxury. A legend even before she sailed 14.12.2003, her passengers were a mixture of the world's wealthiest basking in the elegance of first class accommodations 24.12.1999 and immigrants packed into steerage 14.5.1010!";

            string[] words = text.Split(new char[] {' ', ',', '!', '?'}, StringSplitOptions.RemoveEmptyEntries); //we are searching only for dates, so we remove the commas
            string dateFormat = "d.M.yyyy";

            for (int wordIndex = 0; wordIndex < words.Length; wordIndex++)
            {
                string currentWord = words[wordIndex];
                if (currentWord[currentWord.Length - 1] == '.')
                {
                    currentWord = currentWord.Substring(0, currentWord.Length - 1);
                }

                try
                {
                    DateTime date = DateTime.ParseExact(currentWord, dateFormat, new CultureInfo("en-CA"));
                    Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
