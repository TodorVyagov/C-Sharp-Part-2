//Write a program that compares two text files line by line and prints the number of lines that are
//the same and the number of lines that are different. Assume the files have equal number of lines.
using System;
using System.IO;

namespace CompareTwoTextFiles
{
    class CompareTwoTextFiles
    {
        static void Main()
        {
            Console.WriteLine("This program will compare two text files line by line and will print number of equal lines and number of different lines.");
            StreamReader textFileOne = new StreamReader(@"..\..\TextFileOne.txt");
            StreamReader textFileTwo = new StreamReader(@"..\..\TextFileTwo.txt");
            int numberOfEqualLines = 0;
            int numberOfDifferentLines = 0;

            using (textFileOne)
            {
                using (textFileTwo)
                {
                    string lineOfFileOne = textFileOne.ReadLine();
                    string lineOfFileTwo = textFileTwo.ReadLine();

                    while (lineOfFileOne != null)
                    {
                        Console.WriteLine("Line of file 1 = {0}", lineOfFileOne);
                        Console.WriteLine("Line of file 2 = {0}", lineOfFileTwo);

                        if (lineOfFileOne == lineOfFileTwo)
                        {
                            numberOfEqualLines++;
                        }
                        else
                        {
                            numberOfDifferentLines++;
                        }

                        lineOfFileOne = textFileOne.ReadLine();
                        lineOfFileTwo = textFileTwo.ReadLine();
                    }
                }
            }

            Console.WriteLine("Two files have {0} equal lines, and {1} different lines.", numberOfEqualLines, numberOfDifferentLines);
        }
    }
}
