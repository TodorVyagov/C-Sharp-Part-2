//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. 
using System;
using System.Text;

namespace ExtractHeadAndBodyInHTMLDocument
{
    class ExtractHeadAndBodyInHTMLDocument
    {
        static void Main()
        {
            Console.WriteLine("This program will extract from given HTML file its title (if available), and its body text without the HTML tags.");

            string htmlDocument = @"
<html>
  <head><title>News</title></head>
  <body><p><a href=""http://academy.telerik.com\"">Telerik
    Academy</a>aims to provide free real-world practical
    training for young people who want to turn into
    skillful .NET software engineers.</p></body>
</html>";
            StringBuilder extractedText = new StringBuilder();

            for (int charIndex = 0; charIndex < htmlDocument.Length; charIndex++)
            {
                if (htmlDocument[charIndex] == '<')
                {
                    while (htmlDocument[charIndex] != '>')
                    {
                        charIndex++;
                    }
                }
                else
                {
                    extractedText.Append(htmlDocument[charIndex]);
                }
            }

            Console.WriteLine(extractedText);
        }
    }
}
