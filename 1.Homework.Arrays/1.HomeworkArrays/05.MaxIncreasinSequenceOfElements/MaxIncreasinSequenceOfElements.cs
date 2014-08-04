using System;

class MaxIncreasinSequenceOfElements
{
    static void Main()
    {
        //Write a program that finds the maximal increasing sequence in an array.
        //Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.

        Console.Write("This program will find the maximal increasing sequence in an array.\nEnter size of array = ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        Console.WriteLine("Enter elements of the array:");

        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int counter = 1;
        int indexOfLastElementInSequence = 0;
        int currentCounter = 1;

        for (int i = 1; i < size; i++)
        {
            if (array[i] == array[i - 1] + 1)
            {
                currentCounter++;
            }
            else
            {
                currentCounter = 1;
            }

            if (currentCounter > counter)
            {
                counter = currentCounter;
                indexOfLastElementInSequence = i;
            }
        }

        if (counter > 1)
        {
            Console.WriteLine("The maximal increasing sequence in the array is {0} elements.", counter);

            for (int i = indexOfLastElementInSequence - counter + 1; i <= indexOfLastElementInSequence; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        else
        {
            Console.WriteLine("There is no increasing sequence in an array.");
        }

    }
}
