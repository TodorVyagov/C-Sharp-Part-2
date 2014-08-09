//Write a program that concatenates two text files into another text file.
using System;
using System.IO;

namespace ConcatenateTwoTextFiles
{
    class ConcatenateTwoTextFiles
    {
        static void Main()
        {
            Console.WriteLine("This program will concatenate two text files into another text file.");
            StreamReader textFile = new StreamReader(@"..\..\TextFileOne.txt");
            StreamWriter outputTextFile = new StreamWriter(@"..\..\OutputTextFile.txt");
            string line;

            using (outputTextFile)
            {
                using (textFile)
                {
                    line = textFile.ReadLine();
                    Console.WriteLine("\nFirst text file contents: ");

                    while (line != null)
                    {
                        Console.WriteLine(line);
                        outputTextFile.WriteLine(line);
                        line = textFile.ReadLine();
                    }
                }

                textFile = new StreamReader(@"..\..\TextFileTwo.txt");
                Console.WriteLine("\nSecond text file:");

                using (textFile)
                {
                    line = textFile.ReadLine();

                    while (line != null)
                    {
                        Console.WriteLine(line);
                        outputTextFile.WriteLine(line);
                        line = textFile.ReadLine();
                    }
                }
            }

            //Printing the output text file:
            textFile = new StreamReader(@"..\..\OutputTextFile.txt");
            Console.WriteLine("\nThis is the output text file:");

            using (textFile)
            {
                line = textFile.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = textFile.ReadLine();

                }
            }
        }
    }
}
