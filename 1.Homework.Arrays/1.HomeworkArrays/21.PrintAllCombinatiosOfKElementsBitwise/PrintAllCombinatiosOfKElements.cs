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
        int[] arrayOfNumbers = new int[N];

        for (int i = 0; i < N; i++)
        {
            arrayOfNumbers[N - 1 - i] = i + 1;
        }

        //Bitwise solution
        //We search the numbers that have in their binary representation K ones(1). 
        //And use the positions of the binary representation as index of the array to print. 
        for (int subset = (1 << N) - 1; subset >= 1; subset--)
        {
            int counter = 0;

            for (int bit = 0; bit < N; bit++)
            {
                if (((subset >> bit) & 1) == 1)
                {
                    counter++;
                }
            }

            if (counter == K)
            {
                for (int bit = N - 1; bit >= 0; bit--)
                {
                    if (((subset >> bit) & 1) == 1)
                    {
                        Console.Write(arrayOfNumbers[bit] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
