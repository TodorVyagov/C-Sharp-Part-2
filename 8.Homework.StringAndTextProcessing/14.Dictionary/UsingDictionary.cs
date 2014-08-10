//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary. 
using System;
using System.Collections.Generic;

namespace UsingDictionary
{
    class UsingDictionary
    {
        static void Main()
        {
            Console.Write("This program will read a word and translate it by using dictionary.\nEnter word: ");

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add(".NET", "platform for applications from Microsoft");
            dictionary.Add("CLR", "managed execution environment for .NET");
            dictionary.Add("namespace", "hierarchical organization of classes");
            dictionary.Add("Microsoft", "comapany that develops, manufactures, licenses, supports and sells computer software, consumer electronics and personal computers and services.");

            string word = Console.ReadLine();

            if (dictionary.ContainsKey(word))
            {
                Console.WriteLine("{0} is {1}", word, dictionary[word]);
            }
            else
            {
                Console.WriteLine("This word is not added to the dictionary.");
            }
        }
    }
}
