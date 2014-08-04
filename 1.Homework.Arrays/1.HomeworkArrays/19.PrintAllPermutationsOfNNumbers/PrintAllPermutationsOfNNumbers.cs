using System;
 
class PrintAllPermutationsOfNNumbers
{
    static void Main()
    {
        //Write a program that reads a number N and generates and prints all the permutations of the numbers[1 - N]. 
        //Example: n = 3 -> {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}

        //Only recursion will help here instead of n nested for loops ;)

        Console.Write("This program will generate and print all the permutations of the numbers[1-N].\nEnter N = ");
        int N = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[N];

        PrintPermutations(N, N, arrayOfNumbers);
    }
    static void PrintPermutations(int N, int K, int[] arr)
    {
        if (K == 0) //Exit condition of recursion and print current row before exit
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            return;
        }

        for (int i = 0; i < N; i++)
        {
            arr[arr.Length - K] = i + 1;
            bool areEqual = false;

            for (int j = 0; j < arr.Length - K; j++)
            {
                if (arr[arr.Length - K] == arr[j])
                {
                    areEqual = true;
                }
            }
            if (areEqual)
            {
                continue;
            }
            PrintPermutations(N, K - 1, arr);
        }
    }
}
