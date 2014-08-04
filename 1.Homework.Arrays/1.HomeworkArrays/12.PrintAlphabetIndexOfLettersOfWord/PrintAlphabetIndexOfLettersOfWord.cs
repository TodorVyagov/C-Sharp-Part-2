using System;

class PrintAlphabetIndexOfLettersOfWord
{
    static void Main()
    {
        //Write a program that creates an array containing all letters from the alphabet (A-Z).
        //Read a word from the console and print the index of each of its letters in the array.

        char[] capitalAlphabet = new char[26];
        char[] alphabet = new char[26];
        capitalAlphabet[0] = 'A';
        alphabet[0] = 'a';

        for (int i = 1; i < 26; i++)
        {
            capitalAlphabet[i] = (char)(capitalAlphabet[0] + i);
            alphabet[i] = (char)(alphabet[0] + i);
        }

        Console.WriteLine("This program will read a word from the console and will print the index of each of its letters from the alphabet.\nEnter word: ");
        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                if (word[i] == alphabet[j] || word[i] == capitalAlphabet[j])
                {
                    Console.WriteLine("{0} has index in the alphabet No.{1}", word[i], j + 1);
                    break;
                }
            }
        }
    }
}
