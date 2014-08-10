//Write a program for extracting all email addresses from given text. All substrings that match 
//the format <identifier>@<host>…<domain> should be recognized as emails.
using System;
using System.Text.RegularExpressions;

namespace ExtractEMailsFromText
{
    class ExtractEMailsFromText
    {
        static void Main()
        {
            Console.WriteLine("This program will print all email addresses from given text.");
            string str = "By simply sending an email to cellnumber@myboostmobile.com for example, cellnumber@tmomail can also be applied to your peter@hotmail.com DIY projects. For example, if you were j@yahoo.com creating a DIY security system, 44@abv.net you could number@gmail.com use your computer’s parallel port to automatically text you if your alarm goes off.";

            foreach (var email in Regex.Matches(str, @"[\w.]{2,20}@[\w]{2,20}[.]{1}[\w.]{2,6}"))
            {
                Console.WriteLine(email);
            }

            if (str == @"[\w.]{2,20}@[\w]{2,20}[.]{1}[\w.]{2,6}")
            {
                
            }
        }
    }
}
