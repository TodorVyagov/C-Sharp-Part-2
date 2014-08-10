//Write a program that reads a string from the console and prints all different letters in 
//the string along with information how many times each letter is found. 
using System;
using System.Collections.Generic;

namespace CountLettersInString
{
    class CountLettersInString
    {
        static void Main()
        {
            Console.Write("This program will read a string from the console and print all different letters in the string along with information how many times each letter is found.\nEnter string: ");

            string text = Console.ReadLine().ToLower(); //ToLower - to be case insensitive
            Dictionary<char, int> counterOfLetters = new Dictionary<char, int>();

            for (int charIndex = 0; charIndex < text.Length; charIndex++)
            {
                if (counterOfLetters.ContainsKey(text[charIndex]))
                {
                    counterOfLetters[text[charIndex]] += 1;
                }
                else
                {
                    counterOfLetters.Add(text[charIndex], 1);
                }
            }

            foreach (var letter in counterOfLetters)
            {
                Console.WriteLine("Letter '{0}' is {1} time(s) repeated.", letter.Key, letter.Value); //intervals are also counted
            }
        }
    }
}
