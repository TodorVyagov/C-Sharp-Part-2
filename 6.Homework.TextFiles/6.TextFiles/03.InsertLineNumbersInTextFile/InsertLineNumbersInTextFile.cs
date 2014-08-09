//Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//The result should be written to another text file.
using System;
using System.IO;

namespace InsertLineNumbersInTextFile
{
    class InsertLineNumbersInTextFile
    {
        static void Main()
        {
            Console.WriteLine("This program will read a text file and insert line numbers in front of each of its lines.\nThe result will be written to another text file.");
            StreamReader textFile = new StreamReader(@"..\..\GoldenGateBridge.txt");
            StreamWriter outputTextFile = new StreamWriter(@"..\..\GoldenGateBridgeWithLineNumbers.txt");

            using (textFile)
            {
                Console.WriteLine("This is the input file:");

                using (outputTextFile)
                {
                    string line = textFile.ReadLine();
                    int numberOfLine = 1;

                    while (line != null)
                    {
                        Console.WriteLine(line);
                        outputTextFile.WriteLine(numberOfLine + ". " + line);
                        line = textFile.ReadLine();
                        numberOfLine++;
                    }
                }
            }

            textFile = new StreamReader(@"..\..\GoldenGateBridgeWithLineNumbers.txt");

            using (textFile)
            {
                string wholeFile = textFile.ReadToEnd();
                Console.WriteLine("\nThis is the file after adding line numbers:\n" + wholeFile);
            }

        }
    }
}
