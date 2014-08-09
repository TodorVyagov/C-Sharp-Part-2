//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
//Modify the solution of the previous problem to replace only whole words (not substrings).
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ReplaceOnlyWholeWordsInTextFile
{
    class ReplaceOnlyWholeWordsInTextFile
    {
        static void Create100MBTextFile()
        {
            Random randomNumber = new Random();
            StringBuilder line = new StringBuilder();

            using (StreamWriter writer = new StreamWriter(@"..\..\TextFile.txt"))
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Console.WriteLine("Please wait until the 100MB text file is created. It is about 4-5 seconds.");
                Console.Write("Loading...");
                for (int rows = 0; rows < 160000; rows++)
                {
                    for (int cols = 0; cols < 200; cols++)
                    {

                        int number = randomNumber.Next(1, 11); //numbers between 1 and 10 inclusive 

                        switch (number)
                        {
                            case 1: 
                            case 2: line.Append(" "); break;
                            case 3: line.Append("."); break;
                            case 4: line.Append("bear"); break;
                            case 5: line.Append("smile"); break;
                            case 6: line.Append(" "); break;
                            case 7: 
                            case 8: line.Append("start"); break;
                            case 9: line.Append("in"); break;
                            case 10: line.Append("restart"); break;
                        }
                    }
                    line.AppendLine();
                }
                writer.WriteLine(line);

                Console.Write("\b\b\b\b\b\b\b\b\b\bFile successfully created.\n");
                sw.Stop();
                Console.WriteLine("Time elapsed: {0} seconds", sw.Elapsed.TotalSeconds);
            }
        }

        static void Main()
        {
            Console.WriteLine("This program will replace only whole word \"start\" with \"finish\" in text file.");
            Create100MBTextFile();
            Console.WriteLine("Now please wait until the program is replacing words. It is about 9 seconds.");
            Stopwatch sw = new Stopwatch();
            sw.Start();

            using (StreamReader textReader = new StreamReader(@"..\..\TextFile.txt"))
            {
                using (StreamWriter outputTextFile = new StreamWriter(@"..\..\TextFile1.txt"))
                {
                    string line = textReader.ReadLine();

                    while (line != null)
                    {
                        line = Regex.Replace(line, @"\bstart\b", "finish"); // \b means start of word and also end of word
                        outputTextFile.WriteLine(line);
                        line = textReader.ReadLine();
                    }
                }
            }
            File.Replace(@"..\..\TextFile1.txt", @"..\..\TextFile.txt", @"..\..\backup.txt");
            File.Delete(@"..\..\TextFile1.txt");
            //the results are in TextFile.txt
            //Created text file is backup.txt
            sw.Stop();
            Console.WriteLine("Elapsed time in the program: {0} seconds.", sw.Elapsed.TotalSeconds);
        }
    }
}
