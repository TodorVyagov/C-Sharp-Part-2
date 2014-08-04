using System;

namespace SortArrayOfStringsByLength
{
    class SortArrayOfStringsByLength
    {
        static void Main()
        {
            //You are given an array of strings. Write a method that sorts the array by the 
            //length of its elements (the number of characters composing them).

            string[] arrayOfStrings = 
            {
                "USA",
                "telerik",
                "academy",
                "piano",
                "guitar",
                "pony"
            };

            SortStringArray(arrayOfStrings);

            //Print sorted array:
            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                Console.WriteLine(arrayOfStrings[i]);
            }
        }

        static void SortStringArray(string[] arrayOfStrings)
        {
            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                for (int j = i; j < arrayOfStrings.Length; j++)
                {
                    if (arrayOfStrings[i].Length > arrayOfStrings[j].Length)
                    {
                        string temp = arrayOfStrings[i];
                        arrayOfStrings[i] = arrayOfStrings[j];
                        arrayOfStrings[j] = temp;
                    }
                }
            }
        }
    }
}
