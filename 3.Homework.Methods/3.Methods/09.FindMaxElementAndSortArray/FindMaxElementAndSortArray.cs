//Write a method that returns the maximal element in a portion of array of integers starting at given index. 
//Using it write another method that sorts an array in ascending / descending order.
using System;

namespace FindMaxElementAndSortArray
{
    class FindMaxElementAndSortArray
    {
        const int size = 10;
        static int[] arrayOfNumbers = new int[size];

        static void Main()
        {
            //Filling and printing array:
            Random num = new Random();
            Console.WriteLine("This is the array:");

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = num.Next(0, 15);
                Console.Write(arrayOfNumbers[i] + " ");
            }
            Console.WriteLine("\nMaximal element is: arr[{1}] = {0}", arrayOfNumbers[FindMaxElementOfArray()], FindMaxElementOfArray());

            SortArrayDescending();
            Console.WriteLine("Sorted Array Descending:");

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                Console.Write(arrayOfNumbers[i] + " ");
            }
            Console.WriteLine();
            SortArrayAscending();
            Console.WriteLine("Sorted Array Ascending:");

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                Console.Write(arrayOfNumbers[i] + " ");
            }

        }

        static int FindMaxElementOfArray(int startIndex = 0, int endIndex = size - 1)
        //If you do not assing values it will search the whole array
        {
            int indexOfMaximalElement = startIndex;

            for (int i = startIndex; i <= endIndex; i++)
            {
                if (arrayOfNumbers[indexOfMaximalElement] < arrayOfNumbers[i])
                {
                    indexOfMaximalElement = i;
                }
            }
            return indexOfMaximalElement;
        }

        static void Swap(int indexOfFirstElement, int indexOfSecondElement)
        {
            int temp = arrayOfNumbers[indexOfFirstElement];
            arrayOfNumbers[indexOfFirstElement] = arrayOfNumbers[indexOfSecondElement];
            arrayOfNumbers[indexOfSecondElement] = temp;
        }

        static void SortArrayDescending()
        {
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                int currentIndexOfMaxElement = FindMaxElementOfArray(i);
                Swap(i, currentIndexOfMaxElement);
            }

        }

        static void SortArrayAscending()
        {
            for (int i = arrayOfNumbers.Length - 1; i >= 0 ; i--)
            {
                int currentIndexOfMaxElement = FindMaxElementOfArray(0, i);
                Swap(i, currentIndexOfMaxElement);
            }

        }
    }
}
