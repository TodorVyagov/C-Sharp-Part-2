using System;

class PrintAllCombinatiosOfKElements
{
    static void Main()
    {
        //Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
        //Example: N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

        Console.Write("This program will generate all the combinations of K distinct elements from the set [1..N].\nEnter N = ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter K = ");
        int K = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[K];
        
        PrintCombinations(N, K, arrayOfNumbers);
    }
    static void PrintCombinations(int N, int K, int[] arr)
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
            bool isHigherOrEqual = false;

            for (int j = 0; j < arr.Length - K; j++)
            {
                if (arr[arr.Length - K] <= arr[j])
                {
                    isHigherOrEqual = true;
                }
            }
            if (isHigherOrEqual)
            {
                continue;
            }
            PrintCombinations(N, K - 1, arr);
        }
    }
}
