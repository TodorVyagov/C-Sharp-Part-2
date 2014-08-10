//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…[/URL]. 
using System;
using System.Text;

namespace ReplaceHTMLTags
{
    class ReaplceHTMLTags
    {
        static void Main()
        {
            Console.WriteLine("This program will replace in a HTML document given as string all the tags <a href=\"...\">...</a> with corresponding tags [URL=...]...[/URL].");
            string htmlText = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
            StringBuilder textWithReplacedTags = new StringBuilder(htmlText);

            int index = htmlText.IndexOf("<a href=\"");

            while (index >= 0)
            {
                textWithReplacedTags.Remove(index, "<a href=\"".Length);
                textWithReplacedTags.Insert(index, "[URL=");

                index = textWithReplacedTags.ToString().IndexOf("\">", index);
                textWithReplacedTags.Remove(index, "\">".Length);
                textWithReplacedTags.Insert(index, "]");

                index = textWithReplacedTags.ToString().IndexOf("</a>", index);
                textWithReplacedTags.Remove(index, "</a>".Length);
                textWithReplacedTags.Insert(index, "[/URL]");

                index = textWithReplacedTags.ToString().IndexOf("<a href=\"", index);
            }

            Console.WriteLine("Original text:\n{0}\nEdited text:", htmlText);
            Console.WriteLine(textWithReplacedTags);
        }
    }
}
