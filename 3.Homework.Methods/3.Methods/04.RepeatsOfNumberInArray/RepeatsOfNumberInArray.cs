//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is working correctly.
using System;

namespace RepeatsOfNumberInArray
{
    class RepeatsOfNumberInArray
    {
        static int size = 12;
        static int[] arrayOfNumbers = new int[size];
        static bool[] isCounted = new bool[arrayOfNumbers.Length]; //We use bool array to avoid repeat when printing results.

        static void Main()
        {
            Console.WriteLine("This program will count how many times number appears in array.");
 
            Random randomInputNumber = new Random();

            //Initializing and printing array:
            Console.WriteLine("This is the array:");

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = randomInputNumber.Next(0, 9);
                Console.Write(arrayOfNumbers[i] + " ");
            }
            Console.WriteLine();

            //Results:
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (isCounted[i] == false)
                {
                    int result = RepeatingsOfNumberInArray(arrayOfNumbers[i]);
                    Console.WriteLine("Number {0} is repeated exactly {1} times.", arrayOfNumbers[i], result);
                }
            }
        }

        static int RepeatingsOfNumberInArray(int numberToCheck)
        {
            int counterOfRepeatings = 0;

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] == numberToCheck)
                {
                    counterOfRepeatings++;
                    isCounted[i] = true;
                }
            }
            return counterOfRepeatings;
        }
    }
}
