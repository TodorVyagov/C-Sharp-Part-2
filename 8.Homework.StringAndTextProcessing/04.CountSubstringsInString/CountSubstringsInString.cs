//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
using System;
using System.Text;

namespace CountSubstringsInString
{
    class CountSubstringsInString
    {
        static void Main()
        {
            Console.WriteLine("This program will find how many times a substring is contained in a given text\n");

            string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            Console.WriteLine(text);

            string substring = "in";
            int counter = 0;

            if (!text.Contains(substring))
            {
                Console.WriteLine("The text do not contain the substring \"{0}\".", substring);
                return;
            }
            int index = text.IndexOf(substring, 0, StringComparison.InvariantCultureIgnoreCase);

            while (index != -1)
            {
                counter++;
                index++;
                index = text.IndexOf(substring, index, StringComparison.InvariantCultureIgnoreCase);
            }

            Console.WriteLine("The substring \"{0}\" is {1} times repeated in the text.", substring, counter);

        }
    }
}
