//Write a program that extracts from a given text all sentences containing given word.
//Consider that the sentences are separated by "." and the words – by non-letter symbols.
using System;
using System.Collections.Generic;

namespace ExtraxtSentencesFromText
{
    class ExtraxtSentencesFromText
    {
        static void Main()
        {
            /*My algorithm is 
            1.Find first word "in" in the text.
            2.Start going on the left of the text and search for Capital letter.
            3.Find the "." after the word "in".
            4.Save the sentence. 
            5.Repeat to the end of the text.*/
            Console.WriteLine("This program will extract from a given text all sentences containing given word.");
            string text = "In are living int a yellow submarine. We don't have in anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it 5 days in."; 
            //Works in all cases start of text, end of text and as a capital letter
            string word = "in";
            List<string> sentences = new List<string>();
            
            for (int charIndex = 0; charIndex < text.Length; charIndex++)
			{
                bool isWord = false;
                int index = text.IndexOf(word, charIndex, StringComparison.OrdinalIgnoreCase); //Step 1.

			    if (index >= 0)
	            {
                    if (index != 0 && !char.IsLetter(text[index - 1]) && !char.IsLetter(text[index + word.Length]))
                    {
                        isWord = true;
                    }
                    else if (!char.IsLetter(text[index + word.Length]))
                    {
                        isWord = true;
                    }

                    if (isWord == false)
                    {
                        continue;
                    }

                    int startIndex = index;
		            while (!char.IsUpper(text[startIndex])) //Step 2.
	                {
                        startIndex--;
	                }

                    int indexOfPoint = index;
                    while (text[indexOfPoint] != '.') //Step 3.
                    {
                        indexOfPoint++;
                    }

                    sentences.Add(text.Substring(startIndex, indexOfPoint - startIndex + 1));//Step 4.
                    charIndex = indexOfPoint;
	            }
			}

            Console.WriteLine("Text is:\n{0}\n", text);
            Console.WriteLine("Sentences that contain the word \"{0}\":", word);

            foreach (var sentence in sentences)
            {
                Console.WriteLine(sentence);
            }
        }
    }
}
