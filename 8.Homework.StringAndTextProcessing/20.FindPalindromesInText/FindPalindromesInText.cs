//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
using System;

namespace FindPalindromesInText
{
    class FindPalindromesInText
    {
        static void Main()
        {
            Console.WriteLine("This program will find and print all palindiomes in text.");

            string text = "Wrirw a program exe, that extracts ABBA. from a (kapak) given boob text all dates that match evitative the rice. Display them lamal in the standard date format for Canada.";
            Console.WriteLine("Text is:\n{0}", text);
            string[] words = text.Split(new char[] { ' ', ',', '.', '(', ')', '-', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            for (int wordIndex = 0; wordIndex < words.Length; wordIndex++)
            {
                string currentWord = words[wordIndex].ToLower();
                bool isPalindrome = true;

                for (int charIndex = 0; charIndex < currentWord.Length / 2; charIndex++)
                {
                    if (currentWord[charIndex] != currentWord[currentWord.Length - 1 - charIndex])
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                if (isPalindrome)
	            {
                    Console.WriteLine(currentWord);
	            }
            }
        }
    }
}
