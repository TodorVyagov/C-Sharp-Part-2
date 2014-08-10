//Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key,
//the second – with the second, etc. When the last key character is reached, the next is the first.
using System;
using System.Text;

namespace EncodeAndDecode
{
    class EncodeAndDecode
    {
        static string EncodeDecode(string key, string text)
        {
            StringBuilder encripted = new StringBuilder();

            for (int charIndex = 0; charIndex < text.Length; charIndex++)
            {
                encripted.Append((char)(text[charIndex] ^ key[charIndex % key.Length]));
            }
            return encripted.ToString();
        }

        static void Main()
        {
            Console.WriteLine("This program will encode and decode a string using given encryption key (cipher).");
            string text = "MyPasswordInTelerik";
            string key = "2014";

            string encriptedText = EncodeDecode(key, text);
            Console.WriteLine("The text is {0}.\nCipher is: {1}.\nEncoded text is:\n{2}", text, key, encriptedText);
            //If we twice encript the same text it must be the same as in the beginning.

            string textAfterEncodeAndDecode = EncodeDecode(key, encriptedText);
            Console.WriteLine("\nThe coded text is\n{0}.\nCipher is: {1}.\nDecoded text is:\n{2}", encriptedText, key, textAfterEncodeAndDecode);
        }
    }
}
