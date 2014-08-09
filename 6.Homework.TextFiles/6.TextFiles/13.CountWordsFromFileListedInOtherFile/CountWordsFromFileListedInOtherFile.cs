/*Write a program that reads a list of words from a file words.txt and finds how many times each of the words is contained in another file test.txt.
 * The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
 * Handle all possible exceptions in your methods.*/

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CountWordsFromFileListedInOtherFile
{
    class CountWordsFromFileListedInOtherFile
    {
        static void Main()
        {
            Console.WriteLine("This program will count all words listed in one text file contained in another text file.");
            List<string> wordsToCount = new List<string>();
            StringBuilder outputText = new StringBuilder();

            //Reading list of words in list
            try
            {
                using (StreamReader reader = new StreamReader(@"..\..\ListOfWords.txt"))
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        line = line.Trim(); //clears if there are any whitespaces 
                        line = line.ToLower();
                        wordsToCount.Add(line);
                        line = reader.ReadLine();
                    }
                }
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("One of the lines in the text file is too long.");
                return;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Wrong file name or file does not exist!");
                return;
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Wrong directory name or directory does not exist!");
                return;
            }
            catch (IOException ioEx)
            {
                Console.Error.WriteLine(ioEx.Message);
                return;
            }

            //Reading text file and count repeats in words list
            int[] counter = new int[wordsToCount.Count];
            try
            {
                using (StreamReader textFile = new StreamReader(@"..\..\DevetashkaCave.txt"))
                {
                    string line = textFile.ReadLine();

                    while (line != null)
                    {
                        line = line.ToLower();
                        string[] words = line.Split(new char[] { ' ', '.', ',', '!', '?', '-', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                        for (int index = 0; index < wordsToCount.Count; index++)
                        {
                            for (int index1 = 0; index1 < words.Length; index1++)
                            {
                                Console.WriteLine("+" + words[index1] + "+");
                                if (wordsToCount[index] == words[index1])
                                {
                                    counter[index]++;
                                }
                            }
                        }
                        line = textFile.ReadLine();
                    }
                }
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("One of the lines in the text file is too long.");
                return;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Wrong file name or file does not exist!");
                return;
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Wrong directory name or directory does not exist!");
                return;
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            //if you want to overwrite the text file uncomment the code below
            for (int i = 0; i < counter.Length; i++)
            {
                Console.WriteLine("{0} is {1} times repeated.", wordsToCount[i], counter[i]);
            }
        }
    }
}
