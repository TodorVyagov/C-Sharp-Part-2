//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 
using System;
using System.Text;

namespace ConvertStringToUnicodeChars
{
    class ConvertStringToUnicodeChars
    {
        static void Main()
        {
            Console.WriteLine("This program will convert string into squience of Unicode character literals.");
            string text = "Hi!";
            StringBuilder result = new StringBuilder();

            for (int charIndex = 0; charIndex < text.Length; charIndex++)
            {
                string unicodeSequence = "\\u" + ((int)text[charIndex]).ToString("X").PadLeft(4, '0');
                result.Append(unicodeSequence);
            }
            Console.WriteLine("Text is: {0}\nResult is: {1}.", text, result);
        }
    }
}
