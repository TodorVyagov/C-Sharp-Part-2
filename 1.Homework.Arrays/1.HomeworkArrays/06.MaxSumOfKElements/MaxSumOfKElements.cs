using System;

class MaxSumOfKElements
{
    static void Main()
    {
        //Write a program that reads two integer numbers N and K and an array of N elements from 
        //the console. Find in the array those K elements that have maximal sum.

        Console.WriteLine("This program will find the maximal sum of K elements in array with N elements.");
        int N = 0;
        int K = 0;

        do
        {
            Console.Write("Please enter N = ");
            N = int.Parse(Console.ReadLine());
            Console.Write("Please enter valid K <= N, K > 1\nK = ");
            K = int.Parse(Console.ReadLine());
        } while (K > N || K <= 1 || N <= 0);
        int[] nums = new int[N];
        int[] index = new int[K];

        Console.WriteLine("Enter elements of the array:");
        for (int i = 0; i < N; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        int sum = int.MinValue;

        for (int i = 1; i < (1 << N); i++)
        {
            int counter = 0;
            int currentSum = 0;
            for (int j = 0; j < N; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    counter++;
                }
            }

            if (counter == K)
            {
                for (int j = 0; j < N; j++)
                {
                    if (((i >> j) & 1) == 1)
                    {
                        currentSum += nums[j];
                    }
                }

                if (sum < currentSum)
                {
                    sum = currentSum;
                }
            }
        }
        Console.WriteLine("The maximal sum of {0} elements is {1}.", K, sum);
    }
}
