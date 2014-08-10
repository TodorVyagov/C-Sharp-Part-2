//Write a program that reads a string from the console and replaces all series of consecutive identical 
//letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa".
using System;
using System.Text;

namespace ReplaceSequnceOfEqualLettersInStringWithSingle
{
    class ReplaceSequnceOfEqualLettersInStringWithSingle
    {
        static void Main()
        {
            Console.WriteLine("This program will replace all series of consecutive identical letters with a single one in given string.");

            string word = "aaaaabbbbbcdddeeeedssaaaaaaaaaaaaaaaaaaaaaa";
            Console.WriteLine("This is the string:\n{0}", word);
            StringBuilder newWord = new StringBuilder();
            char lastChar = word[0];

            for (int charIndex = 1; charIndex < word.Length; charIndex++)
            {
                char currentChar = word[charIndex];
                if (currentChar != lastChar)
                {
                    newWord.Append(lastChar);
                    lastChar = currentChar;
                }

                if (charIndex == word.Length - 1)
                {
                    newWord.Append(currentChar);
                }
            }

            Console.WriteLine("Word with replaced repeating letters:\n{0}", newWord);
        }
    }
}
