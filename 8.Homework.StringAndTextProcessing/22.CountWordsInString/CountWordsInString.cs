//Write a program that reads a string from the console and lists all different words in the 
//string along with information how many times each word is found.
using System;
using System.Collections.Generic;

namespace CountWordsInString
{
    class CountWordsInString
    {
        static void Main()
        {
            Console.WriteLine("This program will read a string from the console and list all different words in the string along with information how many times each word is found.");

            //string text = Console.ReadLine().ToLower(); //ToLower - to be case insensitive
            string text = "Write a program that that reads a string from the console and prints all different a letter in the string string with information how many write each letter is found.".ToLower();
            //I used defined text for easier testing the program
            Dictionary<string, int> counterOfWords = new Dictionary<string, int>();
            string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);

            for (int wordIndex = 0; wordIndex < words.Length; wordIndex++)
            {
                if (counterOfWords.ContainsKey(words[wordIndex]))
                {
                    counterOfWords[words[wordIndex]] += 1;
                }
                else
                {
                    counterOfWords.Add(words[wordIndex], 1);
                }
            }

            foreach (var word in counterOfWords)
            {
                Console.WriteLine("Word {0, 12} is {1} time(s) repeated.", word.Key, word.Value);
            }
        }
    }
}
