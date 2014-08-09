//Write a program that extracts from given XML file all the text without the tags.
using System;
using System.IO;
using System.Text;

namespace ExtractTextFromXMLFile
{
    class ExtractTextFromXMLFile
    {
        const char leftBorder = '<';
        const char rightBorder = '>';

        static void Main()
        {
            Console.WriteLine("This program will extract text without tags from given XML file.");
            StringBuilder contentsWithoutTags = new StringBuilder();

            using (StreamReader textFile = new StreamReader(@"..\..\XML.txt"))
            {
                string line = textFile.ReadLine();

                while (line != null)
                {
                    bool isInTag = false;
                    line = line.Trim();

                    for (int index = 0; index < line.Length; index++)
                    {
                        if (line[index] == leftBorder)
                        {
                            isInTag = true;
                        }
                        else if (line[index] == rightBorder)
                        {
                            isInTag = false;
                        }

                        if (isInTag == false && line[index] != rightBorder)
                        {
                            contentsWithoutTags.Append(line[index]);
                        }
                    }

                    contentsWithoutTags.AppendLine();
                    line = textFile.ReadLine();
                }
            }
            Console.WriteLine(contentsWithoutTags);
        }
    }
}
