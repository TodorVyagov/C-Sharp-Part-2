//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks. 
using System;
using System.Collections.Generic;
using System.Text;

namespace ReplaceForbiddenWordsInText
{
    class ReplaceForbiddenWordsInText
    {
        static void Main()
        {
            Console.WriteLine("This program will replace forbidden words from given list with asterisks");
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            List<string> forbiddenWords = new List<string>() { "PHP", "CLR", "Microsoft", ".NET"};

            StringBuilder resultText = new StringBuilder(text);

            foreach (var word in forbiddenWords)
            {
                resultText.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine("Text is:\n{0}\nText after replacing:\n{1}", text, resultText);
        }
    }
}
