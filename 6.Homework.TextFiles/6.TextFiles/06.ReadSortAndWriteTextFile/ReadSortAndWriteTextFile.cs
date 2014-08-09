//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. 
using System;
using System.Collections.Generic;
using System.IO;

namespace ReadSortAndWriteTextFile
{
    class ReadSortAndWriteTextFile
    {
        static List<string> names = new List<string>();

        static void SortList()
        {
            for (int index = 0; index < names.Count - 1; index++)
            {
                for (int index1 = index + 1; index1 < names.Count; index1++)
                {
                    if (CompareLexicographicallyTwoWords(names[index], names[index1]) == 2)
                    {
                        Swap(index, index1);
                    }
                }
            }
        }

        static void Swap(int index1, int index2)
        {
            string temp1 = names[index1];
            string temp2 = names[index2];
            names.RemoveAt(index1);
            names.Insert(index1, temp2);
            names.RemoveAt(index2);
            names.Insert(index2, temp1);
        }

        static int CompareLexicographicallyTwoWords(string word1, string word2)
        {
            int shorterWord;
            //Making comparison case insensitive
            word1 = word1.ToLower();
            word2 = word2.ToLower();
            
            if (word1.Length <= word2.Length)
            {
                shorterWord = word1.Length;
            }
            else
            {
                shorterWord = word2.Length;
            }

            for (int indexOfChar = 0; indexOfChar < shorterWord; indexOfChar++)
            {
                if (word1[indexOfChar] < word2[indexOfChar])
                {
                    return 1;
                }
                else if (word1[indexOfChar] > word2[indexOfChar])
                {
                    return 2;
                }
            }

            //the words are same
            return 0;
        }

        static void Main()
        {
            Console.WriteLine("This program will read a file containing list of strings, sort the list and write it to another file.");

            //Reading strings and adding them to List
            using (StreamReader textFile = new StreamReader(@"..\..\Names.txt"))
            {
                string line = textFile.ReadLine();

                while (line != null)
                {
                    names.Add(line);
                    line = textFile.ReadLine();
                }
            }

            //Print Unsorted list
            Console.WriteLine("\tUnsorted list:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            //Sorting list by my own case insensitive algorithm ;)
            SortList();

            //Print sorted list
            Console.WriteLine("\n\tSorted list:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            //Write sorted list into new text file
            using (StreamWriter outputTextFile = new StreamWriter(@"..\..\NamesSorted.txt"))
            {
                foreach (var name in names)
                {
                    outputTextFile.WriteLine(name);
                }
            }
        }
    }
}
