//Write a program that deletes from given text file all odd lines. The result should be in the same file.
using System;
using System.IO;
using System.Text;

namespace DeleteOddLinesInTextFile
{
    class DeleteOddLinesInTextFile
    {
        static void Main()
        {
            Console.WriteLine("This program will delete the odd lines in text file.");
            StringBuilder outputContents = new StringBuilder();

            using (StreamReader textFile = new StreamReader(@"..\..\TextFile.txt"))
            {
                int lineCounter = 1;
                string line = textFile.ReadLine();

                while (line != null)
                {
                    if (lineCounter % 2 == 0)
                    {
                        outputContents.AppendLine(line);
                    }
                    lineCounter++;
                    line = textFile.ReadLine();
                }
            }

            using (StreamWriter writer = new StreamWriter(@"..\..\TextFile.txt"))
            {
                writer.WriteLine(outputContents);
            }
        }
    }
}
