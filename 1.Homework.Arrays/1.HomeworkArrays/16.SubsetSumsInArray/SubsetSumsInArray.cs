using System;

class SubsetSumsInArray
{
    static void Main()
    {
        // We are given an array of integers and a number S. Write a program to find
        //if there exists a subset of the elements of the array that has a sum S. 
        //Example: arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14 -> yes (1+2+5+6)

        Console.Write("This program will find if there exists a subset of the elements of the array that has a sum S.\nEnter size of the array:\n");
        int sizeOfArray = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[sizeOfArray];
        Random randomNumber = new Random();

        for (int i = 0; i < sizeOfArray; i++)
        {
            arrayOfNumbers[i] = randomNumber.Next(0, 10);//filling the array with random numbers between 0 and 10;
        }

        //Printing array
        Console.WriteLine("This is the array:");
        for (int i = 0; i < sizeOfArray; i++)
        {
            Console.Write(arrayOfNumbers[i] + " ");
        }
        Console.WriteLine();
        Console.Write("Enter Sum S = ");
        int sum = int.Parse(Console.ReadLine());

        //Solution
        for (int subset = 1; subset < (1 << sizeOfArray); subset++) //(1 << sizeOfArray) is the same as Math.Pow(2, sizeOfArray), but is much faster.
        {
            int subsetSum = 0;

            for (int bit = 0; bit < sizeOfArray; bit++)
            {
                if (((subset >> bit) & 1) == 1)
                {
                    subsetSum += arrayOfNumbers[bit];
                }
            }

            if (subsetSum == sum)
            {
                Console.WriteLine("Subset of elements found:");

                for (int bit = 0; bit < sizeOfArray; bit++)
                {
                    if (((subset >> bit) & 1) == 1)
                    {
                        Console.Write(arrayOfNumbers[bit] + "+");
                    }
                }
                Console.WriteLine("\b = " + sum); //\b -deletes last char - in this case the last "+"
            }
        }
    }
}
