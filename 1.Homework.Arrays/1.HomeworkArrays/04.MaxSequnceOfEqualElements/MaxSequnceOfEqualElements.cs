using System;

class MaxSequnceOfEqualElements
{
    static void Main()
    {
        //Write a program that finds the maximal sequence of equal elements in an array.
        //Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.
        
        Console.WriteLine("This program will find the maximal sequence of equal elements in an array.");
        //int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 }; //This is optional if you don't want manually to enter numbers in the console.
        Console.Write("How many elements you want to have in the array: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        Console.WriteLine("Enter elements of the array:");
        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int counterOfEqualElements = 1; //It's better to understand the program if we start with 1.
        int currentCounter = 1;
        int valueOfEqualElements = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1]) 
            {
                currentCounter++;
            }
            else
            {
                currentCounter = 1;
            }

            if (currentCounter > counterOfEqualElements)
            {
                counterOfEqualElements = currentCounter;
                valueOfEqualElements = array[i];
            }
        }
        if (counterOfEqualElements > 1)
        {
            Console.WriteLine("Maximal sequence of equal elements is {0}, and the element is: {1}.", counterOfEqualElements, valueOfEqualElements);
        }
        else
        {
            Console.WriteLine("There is no sequnce of equal elements.");
        }
    }
}
