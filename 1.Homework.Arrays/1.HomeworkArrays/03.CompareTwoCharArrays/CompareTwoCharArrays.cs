using System;

class CompareTwoCharArrays
{
    static void Main()
    {
        //Write a program that compares two char arrays lexicographically (letter by letter).

        //We have to compare the char arrays char by char, but not like as we are comparing strings(words).
        Console.WriteLine("This program will compare lexicographically elements of two char arrays(letter by letter).");
        Console.Write("Enter size of char arrays: ");
        int size = int.Parse(Console.ReadLine());
        char[] arrOne = new char[size];
        char[] arrTwo = new char[size];
        Console.WriteLine("Please be correct and enter correct data!");
        Console.Write("Enter all {0} chars of first array as string without spaces: ", size);
        string currentCharArray = Console.ReadLine();
        arrOne = currentCharArray.ToCharArray();

        Console.Write("Enter all {0} chars of second array as string without spaces: ", size);
        currentCharArray = Console.ReadLine();
        arrTwo = currentCharArray.ToCharArray();

        //Comparison:
        for (int i = 0; i < size; i++)
        {
            if (arrOne[i] > arrTwo[i])
            {
                Console.WriteLine("{0} is lexicographically after {1}", arrOne[i], arrTwo[i]);
            }
            else if (arrOne[i] < arrTwo[i])
            {
                Console.WriteLine("{0} is lexicographically before {1}", arrOne[i], arrTwo[i]);
            }
            else //arrOne[i] == arrTwo[i]
            {
                Console.WriteLine("{0} is lexicographically equal to {1}", arrOne[i], arrTwo[i]);
            }
        }
    }
}
