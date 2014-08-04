using System;

class MostFrequentNumberInArray
{
    static void Main()
    {
        //Write a program that finds the most frequent number in an array. Example:
	    //{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)

        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int mostFrequentNumber = array[0];
        int counterOfRepeatings = 0;

        for (int i = 0; i < array.Length; i++)
        {
            int currentCounter = 0;

            for (int j = i; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    currentCounter++;
                }
            }

            if (currentCounter > counterOfRepeatings)
            {
                counterOfRepeatings = currentCounter;
                mostFrequentNumber = array[i];
            }
        }

        //Printing:
        Console.WriteLine("This is our array:");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0}, ", array[i]);
        }
        Console.WriteLine();

        if (counterOfRepeatings == 1)
        {
            Console.WriteLine("All numbers in the array are diferent!");
        }
        else
        {
            Console.WriteLine("The most frequent number is {0} -> {1} times repeated", mostFrequentNumber, counterOfRepeatings);
        }

    }
}
