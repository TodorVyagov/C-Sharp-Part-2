using System;

class MaxSumInArray
{
    static void Main()
    {
        //Write a program that finds the sequence of maximal sum in given arrayOfNumbers. Example:
	    //{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
	    //Can you do it with only one loop (with single scan through the elements of the arrayOfNumbers)?

        int[] arrayOfNumbers = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        //This is easier way than manually input in the console every time the whole arrayOfNumbers.
        //We are not given how many consecutive elements from the arrayOfNumbers we are searching so we have to find the sequence.
        int consecutiveElements = 0;
        int sum = 0;
        int indexOfLastElementInSequence = 0;

        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            int currentSum = 0;
            int currentCounter = 0;

            for (int j = i; j < arrayOfNumbers.Length; j++)
            {
                currentSum += arrayOfNumbers[j];
                currentCounter++;

                if (currentSum > sum)
                {
                    sum = currentSum;
                    indexOfLastElementInSequence = j;
                    consecutiveElements = currentCounter;
                }
            }
        }

        //Printing:
        Console.WriteLine("This is our array:");

        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            Console.Write("{0}, ", arrayOfNumbers[i]);
        }
        Console.WriteLine();
        Console.Write("These {0} consecutive elements form biggest sum:\n", consecutiveElements);

        for (int i = indexOfLastElementInSequence - consecutiveElements + 1; i <= indexOfLastElementInSequence; i++)
        {
            Console.Write(arrayOfNumbers[i] + " + ");
        }
        Console.WriteLine("\b\b\b = " + sum);
    }
}
