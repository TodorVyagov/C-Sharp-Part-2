//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace RemoveAllListedWordsFromTextFile
{
    class RemoveAllListedWordsFromTextFile
    {
        static void Main()
        {
            Console.WriteLine("This program will remove all words listed in one text file from another text file.");
            List<string> wordsToRemove = new List<string>();
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
                        wordsToRemove.Add(line);
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

            //Reading text file and save in StringBuilder text with replaced words
            try
            {
                using (StreamReader textFile = new StreamReader(@"..\..\DevetashkaCave.txt"))
                {
                    string line = textFile.ReadLine();

                    while (line != null)
                    {
                        foreach (var word in wordsToRemove)
	                    {
                            string pattern = @"\b" + word + @"\b";
                            line = Regex.Replace(line, pattern, string.Empty, RegexOptions.IgnoreCase); 
        	            }
                        outputText.AppendLine(line);
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
            Console.WriteLine(outputText);


            ////Write StringBuilder to file
            //try
            //{
            //    using (StreamWriter writer = new StreamWriter(@"..\..\DevetashkaCave.txt"))
            //    {
            //        writer.WriteLine(outputText);
            //    }
            //}
            //catch (ArgumentException)
            //{
            //    Console.WriteLine("You did not enter correct path to the file!");
            //    return;
            //}
            //catch (UnauthorizedAccessException)
            //{
            //    Console.WriteLine("You are not authorized to oppen this file!");
            //    return;
            //}
            //catch (DirectoryNotFoundException)
            //{
            //    Console.WriteLine("The dir of the text file cannot be found!");
            //    return;
            //}
            //catch (PathTooLongException)
            //{
            //    Console.WriteLine("The path of the text file is to long!");
            //    return;
            //}
            //catch (System.Security.SecurityException sEx)
            //{
            //    Console.WriteLine(sEx.Message);
            //    return;
            //}
            //catch (IOException ex)
            //{
            //    Console.Error.WriteLine(ex.Message);
            //    return;
            //}
        }
    }
}
