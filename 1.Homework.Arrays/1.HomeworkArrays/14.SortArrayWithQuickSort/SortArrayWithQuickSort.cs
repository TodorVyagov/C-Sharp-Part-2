using System;

class SortArrayWithQuickSort
{
    static void Main()
    {
        //Write a program that sorts an array of strings using the quick sort algorithm.
        //Source: http://www.youtube.com/watch?v=COk73cpQbFQ

        Console.Write("Enter size of the array that will be sorted by Quick sort algorithm:\n");
        int sizeOfArray = int.Parse(Console.ReadLine());
        int[] arrayToSort = new int[sizeOfArray];
        Random randomNumber = new Random();

        for (int i = 0; i < sizeOfArray; i++)
        {
            arrayToSort[i] = randomNumber.Next(0, 50);//filling the array with random numbers between 0 and 50;
        }

        //Printing unsorted array
        Console.WriteLine("This is the unsorted array:");
        for (int i = 0; i < sizeOfArray; i++)
        {
            Console.Write(arrayToSort[i] + " ");
        }
        Console.WriteLine();
        QuickSort(arrayToSort, 0, arrayToSort.Length - 1);

        //Printing sorted array
        Console.WriteLine("This is the sorted array:");
        for (int i = 0; i < arrayToSort.Length; i++)
        {
            Console.Write(arrayToSort[i] + " ");
        }

    }
    static void QuickSort(int[] arrayToSort, int minIndex, int maxIndex)
    {
        if (minIndex >= maxIndex)
        {
            return;
        }
        int pIndex = Partition(arrayToSort, minIndex, maxIndex);

        QuickSort(arrayToSort, minIndex, pIndex - 1);
        QuickSort(arrayToSort, pIndex + 1, maxIndex);

    }
    static int Partition(int[] arrayToSort, int minIndex, int maxIndex)
    {
        int pivot = arrayToSort[maxIndex];
        int pIndex = minIndex;

        for (int i = minIndex; i < maxIndex; i++)
        {
            if (arrayToSort[i] <= pivot)
            {
                Swap(arrayToSort, i, pIndex);
                pIndex++;
            }
        }
        Swap(arrayToSort, pIndex, maxIndex);
        return pIndex;
    }
    static void Swap(int[] arrayToSwap, int a, int b)
    {
        if (a == b)
        {
            return;
        }
        arrayToSwap[a] ^= arrayToSwap[b];
        arrayToSwap[b] ^= arrayToSwap[a];
        arrayToSwap[a] ^= arrayToSwap[b];
    }
}
