using System;

class FindSumInArray
{
    static void Main()
    {
        //Write a program that finds in given array of integers a sequence of given sum S (if present). 
        //Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}

        Console.WriteLine("This program will find in given array of integers a sequence of given sum S (if present).");
        int[] array = { 4, 3, 1, 4, 2, 5, 8 }; //Its boring to enter elements every time you test the program 

        //Printing the array:
        Console.WriteLine("This is our array:");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0}, ", array[i]);
        }
        Console.WriteLine();
        Console.Write("Enter the Sum that we will be looking for:\nS = ");
        int sum = int.Parse(Console.ReadLine());

        for (int i = 0; i < array.Length; i++)
        {
            int currentSum = 0;

            for (int j = i; j < array.Length; j++)
            {
                currentSum += array[j];

                if (sum == currentSum)
                {
                    int index = j;
                    while (true)
                    {
                        Console.Write(array[index]);
                        currentSum -= array[index]; //printing elements of array is in reverse order

                        if (currentSum == 0)
                        {
                            break;
                        }
                        Console.Write("+");
                        index--;
                    }
                    Console.WriteLine("=" + sum);
                    break;
                }
            }
        }
    }
}
