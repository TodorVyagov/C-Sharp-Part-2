//Write a program that reverses the words in given sentence.
//	Example: "C# is not C++, not PHP and not Delphi!" -> "Delphi not and PHP, not C++ not is C#!".
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseWordsInSentence
{
    class ReverseWordsInSentence
    {
        static void Main()
        {
            Console.WriteLine("This program will reverse order of the words in sentence.");
            string sentence = "C# is not C++, not PHP and not Delphi!";

            //spliting the sentence into words, but punctuation marks are connected to the words
            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); 
            List<string> sentenceOfWords = new List<string>(words.Reverse());
            char[] punctuationMarks = { '.', ',', '!', '?',  '-' };
            
            //foreach (var word in sentenceOfWords) //used for visualisation
            //{
            //    Console.WriteLine(word);
            //}

            for (int wordIndex = 0; wordIndex < sentenceOfWords.Count; wordIndex++) 
            {
                string currentWord = sentenceOfWords[wordIndex];
                int lastIndexOfWord = currentWord.Length - 1;

                if (punctuationMarks.Contains(currentWord[lastIndexOfWord]))
                //removing the punctuation mark from the reversed order of words
                {
                    sentenceOfWords[wordIndex] = currentWord.Substring(0, currentWord.Length - 1);
                }

                string wordForPunctuation = words[wordIndex];
                if (punctuationMarks.Contains(wordForPunctuation[wordForPunctuation.Length - 1])) 
                //Reading from the original sentence positions of punctution marks and adding them to the reversed list
                {
                    sentenceOfWords[wordIndex] = sentenceOfWords[wordIndex] + wordForPunctuation[wordForPunctuation.Length - 1];
                }
            }

            //foreach (var word in sentenceOfWords) //used for visualisition
            //{
            //    Console.WriteLine(word);
            //}

            string reversedSentence = string.Join(" ", sentenceOfWords);
            Console.WriteLine("Original sentence is:\n{0}\nReversed sentence:\n{1}", sentence, reversedSentence);
        }
    }
}
