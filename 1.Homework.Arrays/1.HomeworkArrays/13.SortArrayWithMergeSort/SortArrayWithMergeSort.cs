using System;

class SortArrayWithMergeSort
{
    static void Main()
    {
        //Write a program that sorts an array of integers using the merge sort algorithm.
        //I used this video: http://www.youtube.com/watch?v=TzeBrDU-JaY
        //And it is very good said how to make Merge Sort Algorithm

        Console.Write("Enter size of the array that will be sorted by Merge sort algorithm:\n");
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
        Split(arrayToSort);

        //Printing sorted array
        Console.WriteLine("This is the sorted array:");
        for (int i = 0; i < arrayToSort.Length; i++)
        {
            Console.Write(arrayToSort[i] + " ");
        }
    }
    
    static void MergeSort(int[] mainArray, int[] leftArray, int[] rightArray)
    {
        int leftLength = leftArray.Length;
        int rightLength = rightArray.Length;
        int i = 0, j = 0 , k = 0;

        while (i < leftLength && j < rightLength)
        {
            if (leftArray[i] <= rightArray[j])
            {
                mainArray[k] = leftArray[i];
                i++;
            }
            else
            {
                mainArray[k] = rightArray[j];
                j++;
            }
            k++;
        }
        while (i < leftLength)
        {
            mainArray[k] = leftArray[i];
            i++;
            k++;
        }
        while (j < rightLength)
        {
            mainArray[k] = rightArray[j];
            j++;
            k++;
        }
    }

    static void Split(int[] mainArray)
    {
        if (mainArray.Length < 2)//Splitting the array until we have arrays with only 1 element
        {
            return;
        }
        int mid = mainArray.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[mainArray.Length - mid];

        for (int i = 0; i < mid; i++)
        {
            left[i] = mainArray[i];
        }

        for (int i = mid; i < mainArray.Length; i++)
        {
            right[i - mid] = mainArray[i];
        }
        Split(left);
        Split(right);
        MergeSort(mainArray, left, right);
    }
}
