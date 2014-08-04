using System;

class FillAndPrintMatrix
{
    static void Main()
    {
        //Write a program that fills and prints a matrix of size (n, n).

        //c)
        Console.Write("Enter size of matrix\nN = ");
        int N = int.Parse(Console.ReadLine());
        int[,] matrix = new int[N, N];
        int maxNumber = N * N;
        int currentNumber = 1;
        int startRow = matrix.GetLength(0) - 1;
        int startCol = 0; //These are coordinates of starting position(bottom left corner)

        while (currentNumber <= maxNumber)
        {
            int currentRow = startRow;
            int currentCol = startCol;

            while (currentRow < matrix.GetLength(0) && currentRow >= 0 && currentCol < matrix.GetLength(1) && currentCol >= 0)
            {
                //With this loop we are filling diagonal

                matrix[currentRow, currentCol] = currentNumber;
                currentRow++;
                currentCol++;
                currentNumber++;
            }

            if (currentCol >= matrix.GetLength(1))
            {
                startCol++;
            }
            else if (currentRow >= matrix.GetLength(0))
            {
                startRow--;
            }
            
        }

        //Printing:
        Console.WriteLine("c)");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}
