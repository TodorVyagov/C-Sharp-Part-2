//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, 
//the rest of the characters should be filled with '*'. Print the result string into the console.
using System;
using System.Text;

namespace FillStringToLengthOf20Characters
{
    class FillStringToLengthOf20Characters
    {
        static void Main()
        {
            Console.Write("This program will read text from the console with length not more than 20 characters.\nIf the length is less than 20 it will automatically fill the string with '*'.\nEnter string = ");
            string inputText = Console.ReadLine();

            if (inputText.Length > 20)
            {
                throw new ArgumentOutOfRangeException("Your inputText has to be not more than 20 characters!");
            }
            StringBuilder text = new StringBuilder(inputText);

            while (text.Length < 20)
            {
                text.Append('*');
            }

            string outputText = text.ToString();
            Console.WriteLine("Result string is: {0}", outputText);
        }
    }
}
