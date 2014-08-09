//Write a program that reads a text file and prints on the console its odd lines.
using System;
using System.IO;

namespace PrintOddLinesOfTextFile
{
    class PrintOddLinesOfTextFile
    {
        static void Main()
        {
            Console.WriteLine("This program will print the odd lines of a text file.");
            StreamReader sr = new StreamReader(@"..\..\Stonehenge crowds.txt");
            int counterOfLines = 0;

            using (sr)
            {
                string line = sr.ReadLine();

                while (line != null)
                {
                    counterOfLines++;
                    
                    if (counterOfLines % 2 == 1)
                    {
                        Console.WriteLine("Line{0}: {1}", counterOfLines, line);
                    }
                    line = sr.ReadLine();
                }
            }
        }
    }
}
