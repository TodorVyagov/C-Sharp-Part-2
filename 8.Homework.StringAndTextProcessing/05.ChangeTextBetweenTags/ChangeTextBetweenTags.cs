//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. 
using System;
using System.Text;

namespace ChangeTextBetweenTags
{
    class ChangeTextBetweenTags
    {
        static StringBuilder textEditor = new StringBuilder();
        const string startPattern = "<upcase>";
        const string endPattern = "</upcase>";
        static string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";


        static void AddLetters(int startIndex, int endIndex, bool areCapitals)
        {
            int length = endIndex - startIndex;

            if (areCapitals)
            {
                textEditor.Append(text.Substring(startIndex, length).ToUpper());
            }
            else
            {
                textEditor.Append(text.Substring(startIndex, length));
            }
        }

        static void Main()
        {
            Console.WriteLine("This program will change the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase.\nThis is our text:");
            Console.WriteLine(text);

            int startIndex = 0;
            int endIndex = 0;
            startIndex = text.IndexOf(startPattern, endIndex);

            while (startIndex != -1)
            {
                if (endIndex == 0)
                {
                    AddLetters(endIndex, startIndex, false);
                }
                else
                {
                    AddLetters(endIndex + endPattern.Length, startIndex, false);
                }
                endIndex = text.IndexOf(endPattern, startIndex);
                AddLetters(startIndex + startPattern.Length, endIndex, true);
                startIndex = text.IndexOf(startPattern, endIndex);
            }
            textEditor.Append(text.Substring(endIndex + endPattern.Length));
            Console.WriteLine("Edited text:\n{0}", textEditor);
        }
    }
}
