using System;
using System.Collections.Generic;

class RemoveElementsToSortArray
{
    static void Main()
    {
        //Write a program that reads an array of integers and removes from it a minimal number of elements 
        //in such way that the remaining array is sorted in increasing order. Print the remaining sorted array. 
        //Example: {6, 1, 4, 3, 0, 3, 6, 4, 5} -> {1, 3, 3, 4, 5}

        Console.WriteLine("This program will read an array of integers and will remove from it minimal number of elements in such way that the remaining array is sorted in increasing order.");
        Console.Write("Enter size of the array N = ");
        int size = int.Parse(Console.ReadLine());
        List<int> arrayToSort = new List<int>(); //We have to use resizeable array, because we will delete elements.

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter arr[{0}] = ", i);
            arrayToSort.Add(int.Parse(Console.ReadLine()));
        }

        int numberOfElementsInNewArray = 0;
        int maxSubset = 0;

        for (int subset = 1; subset < (1 << size); subset++) //This will work for arrays up to 31 elements - for more you can use long (64 elements)
        {
            int innerCounter = 0;
            int lastElement = 0;

            for (int bit = 0; bit < size; bit++)
            {
                if (((subset >> bit) & 1) == 1)
                {
                    if (innerCounter == 0)
                    {
                        lastElement = arrayToSort[bit];
                        innerCounter++;
                    }
                    else
                    {
                        if (lastElement <= arrayToSort[bit])
                        {
                            lastElement = arrayToSort[bit];
                            innerCounter++;
                        }
                        else
                        {
                            innerCounter = 0;
                            break;
                        }
                    }
                }
            }

            if (numberOfElementsInNewArray < innerCounter)
            {
                numberOfElementsInNewArray = innerCounter;
                maxSubset = subset;
            }
        }

        //Removing elements:
        //Starting with the last element, otherwise we would delete incorrect element, because after each delete of element indexes of elements is changed.
        if (numberOfElementsInNewArray > 1)
        {
            for (int bit = size - 1; bit >= 0; bit--)
            {
                if (((maxSubset >> bit) & 1) == 0)
                {
                    arrayToSort.RemoveAt(bit);
                }
            }

            //Printing array:
            Console.WriteLine("This is the sorted array(after removing elements) with {0} elements", arrayToSort.Count);
            for (int i = 0; i < arrayToSort.Count; i++)
            {
                Console.Write(arrayToSort[i] + " ");
            }
        }
        else 
        {
            Console.WriteLine("Your array is in descreasing order!");
        }
        Console.WriteLine();
        //If there are more than one possible solutions with equal number of elements this program will only display the first one found!
        //For example: Arr = {1, 6, 3} -> The program will give answer {1, 6}.
    }
}
