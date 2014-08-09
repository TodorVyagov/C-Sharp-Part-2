//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
//Ensure it will work with large files (e.g. 100 MB).
using System;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace ReplaceStartWithFinishInATextFile
{
    class ReplaceStartWithFinishInATextFile
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
                            case 1: line.Append(" "); break;
                            case 2: line.Append("start"); break;
                            case 3: line.Append("."); break;
                            case 4: line.Append("hi"); break;
                            case 5: line.Append("be"); break;
                            case 6: line.Append(" "); break;
                            case 7: 
                            case 8: line.Append("start"); break;
                            case 9: line.Append("ing"); break;
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
            Console.WriteLine("This program will replace all occurrences of the substring \"start\" with the substring \"finish\" in a text file.");
            //Generating file:
            Create100MBTextFile();
            Console.WriteLine("Now please wait until the program is replacing words. It is about 3-4 seconds.");
            Stopwatch sw = new Stopwatch();
            sw.Start();

            using (StreamReader textFile = new StreamReader(@"..\..\TextFile.txt"))
            {
                using (StreamWriter outputTextFile = new StreamWriter(@"..\..\TextFile1.txt"))
                {
                    string line = textFile.ReadLine();

                    while (line != null)
                    {
                        line = line.Replace("start", "finish");
                        outputTextFile.WriteLine(line);
                        line = textFile.ReadLine();
                    }
                }
            }
            File.Replace(@"..\..\TextFile1.txt", @"..\..\TextFile.txt", @"..\..\backup.txt");
            File.Delete(@"..\..\TextFile1.txt");
            //the results are in TextFile.txt
            //the original file is backup.txt, so you can compare results
            sw.Stop();
            Console.WriteLine("Elapsed time in the program: {0} seconds.", sw.Elapsed.TotalSeconds);
        }
    }
}
