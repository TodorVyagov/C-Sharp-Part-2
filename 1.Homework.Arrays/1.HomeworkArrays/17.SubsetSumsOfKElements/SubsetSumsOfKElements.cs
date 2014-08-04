using System;

class SubsetSumsOfKElements
{
    static void Main()
    {
        //Write a program that reads three integer numbers N, K and S and an array of N elements from the console. 
        //Find in the array a subset of K elements that have sum S or indicate about its absence.

        Console.Write("This program will find if there exists a subset of K elements that have sum S.\nEnter size of the array N = ");
        int N = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[N];

        for (int i = 0; i < N; i++)
        {
            Console.Write("Enter Arr[{0}] = ", i);
            arrayOfNumbers[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter Sum S = ");
        int sum = int.Parse(Console.ReadLine());
        Console.Write("Enter Subset K = ");
        int K = int.Parse(Console.ReadLine());
        bool isFoundSubset = false;

        //Solution
        for (int subset = 1; subset < (1 << N); subset++)  //This will work for arrays up to 31 elements - for more you can use long (64 elements)
        {
            int subsetSum = 0;
            int counter = 0;

            for (int bit = 0; bit < N; bit++)
            {
                if (((subset >> bit) & 1) == 1)
                {
                    subsetSum += arrayOfNumbers[bit];
                    counter++;
                }
            }

            if (subsetSum == sum && counter == K)
            {
                Console.WriteLine("Subset of {0} elements found:", K);
                isFoundSubset = true;

                for (int bit = 0; bit < N; bit++)
                {
                    if (((subset >> bit) & 1) == 1)
                    {
                        Console.Write(arrayOfNumbers[bit] + " + ");
                    }
                }
                Console.WriteLine("\b\b= " + sum); //\b -deletes last char - in this case the last "+"
            }
        }

        if (isFoundSubset == false)
        {
            Console.WriteLine("There is no such subset with {0} elements that makes sum = {1}.", K, sum);
        }
    }
}
