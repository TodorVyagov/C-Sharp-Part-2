using System;

class FillAndPrintMatrix
{
    static void Main()
    {
        //Write a program that fills and prints a matrix of size (n, n).

        Console.Write("Enter size of matrix\nN = ");
        int N = int.Parse(Console.ReadLine());
        int[,] matrix = new int[N, N];
        int maxNumber = N * N;
        int currentNumber = 1;
        int currentCol = 0;

        //a)
        while (maxNumber >= currentNumber)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, currentCol] = currentNumber;
                currentNumber++;
            }
            currentCol++;
        }

        //b)
        //Only difference is in printing.

        //Printing:
        Console.WriteLine("a)");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("b)");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col % 2 == 0)
                {
                    Console.Write("{0, 4}", matrix[row, col]);
                }
                else
                {
                    Console.Write("{0, 4}", matrix[N - 1 - row, col]); //When we print  EVEN column we do it in reverse order.
                }
            }
            Console.WriteLine();
        }
    }
}
