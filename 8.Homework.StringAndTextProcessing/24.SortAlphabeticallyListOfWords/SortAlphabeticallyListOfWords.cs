//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
using System;
using System.Collections.Generic;

namespace SortAlphabeticallyListOfWords
{
    class SortAlphabeticallyListOfWords
    {
        static void Main()
        {
            Console.WriteLine("This program will sort alphabetically list of words.");
            string listOfWords = "Write a program that reads a list of words separated by spaces and prints the list in an alphabetical order".ToLower();
            string[] words = listOfWords.Split(' ');
            SortedSet<string> sortedList = new SortedSet<string>();
            Console.WriteLine("List of words:\n{0}", listOfWords);

            foreach (var word in words)
            {
                sortedList.Add(word);
            }

            Console.WriteLine("Words sorted alphabetically:");
            foreach (var word in sortedList)
            {
                Console.WriteLine(word);
            }
        }
    }
}
