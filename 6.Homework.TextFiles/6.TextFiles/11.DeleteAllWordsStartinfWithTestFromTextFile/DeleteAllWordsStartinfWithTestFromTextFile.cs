//Write a program that deletes from a text file all words that start with the prefix "test".
//Words contain only the symbols 0...9, a...z, A…Z, _.
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace DeleteAllWordsStartinfWithTestFromTextFile
{
    class DeleteAllWordsStartinfWithTestFromTextFile
    {
        static void Main()
        {
            Console.WriteLine("This program will delete all words starting with \"test\" from a text file.");
            StringBuilder output = new StringBuilder();

            using (StreamReader textFile = new StreamReader(@"..\..\TextFile.txt"))
            {
                string line = textFile.ReadLine();

                while (line != null)
                {
                    line = Regex.Replace(line, @"\btest\w*\b", string.Empty);
                    // \b means start and end of word; \w* means that there can be 0 or more letters in that word
                    output.AppendLine(line);
                    line = textFile.ReadLine();
                }
            }
            Console.WriteLine(output);

            //if you want to overwrite the text file uncomment the code below:

            //using (StreamWriter writer = new StreamWriter(@"..\..\textFile.txt"))
            //{
            //    writer.WriteLine(output);
            //}
        }
    }
}
