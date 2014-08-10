//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample" -> "elpmas".
using System;

namespace ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            Console.Write("This program will reverse given string.\nEnter string = ");
            string inputText = Console.ReadLine();
            string reversedText = string.Empty;

            for (int currChar = 0; currChar < inputText.Length; currChar++)
            {
                reversedText = inputText[currChar] + reversedText;
            }
            Console.WriteLine("Reversed string is: {0}", reversedText);
        }
    }
}
