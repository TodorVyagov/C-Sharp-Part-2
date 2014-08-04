using System;

class BinarySearchAlgorithm
{
    static void Main()
    {
        //Write a program that finds the index of given element in a sorted 
        //array of integers by using the binary search algorithm.
        //Source: http://en.wikipedia.org/wiki/Binary_search_algorithm

        int[] arrayToSearch = { 14, 21, 13, 4, 16, 28, 19, 12, 5, 7, 2, 15, 10, 9, 11 };
        //We have to sort the array.
        Array.Sort(arrayToSearch); //this is easier way, but we can also use the algorithm in 07.Problem.
        //The array must be sorted to be able to use the use the method of middle point(as we studied it in the university or in English Binary search).

        for (int i = 0; i < arrayToSearch.Length; i++)
        {
            Console.Write(arrayToSearch[i] + " ");
        }
        Console.WriteLine();
        Console.Write("Enter value of element who we will be searching for: ");
        int searchingValue = int.Parse(Console.ReadLine());
        int? indexOfElement = null;
        int minIndex = 0;
        int maxIndex = arrayToSearch.Length;
        //if you enter searchingValue that doesn't match with any of the elements in the array we have to stop the loop at any moment:
        int counterOfCycles = 0;
        int maxCycles = 1 + (int)Math.Log(arrayToSearch.Length, 2); //We assign number of cycles in the loop,
        //because max number of checks is maxCycles if there is such element in the array.

        while (counterOfCycles <= maxCycles)
        {
            int midIndex = (minIndex + maxIndex) / 2;

            if (arrayToSearch[midIndex] > searchingValue)
            {
                maxIndex = midIndex - 1;
            }
            else if (arrayToSearch[midIndex] < searchingValue)
            {
                minIndex = midIndex + 1;
            }
            else //arrayToSearch[midIndex] == searchingValue and the element is found
            {
                indexOfElement = midIndex;
                break;
            }
            counterOfCycles++;
        }

        if (indexOfElement == null)
        {
            Console.WriteLine("There is no such element in the array.");
        }
        else
        {
            Console.WriteLine("The index of element you are looking for is: " + indexOfElement);
        }

    }
}
