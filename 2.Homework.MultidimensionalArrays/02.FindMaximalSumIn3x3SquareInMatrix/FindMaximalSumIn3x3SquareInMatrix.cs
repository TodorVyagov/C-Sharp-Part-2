using System;

class FindMaximalSumIn3x3SquareInMatrix
{
    static void Main()
    {
        //Write a program that reads a rectangular matrix of size N x M and 
        //finds in it the square 3 x 3 that has maximal sum of its elements.

        //I will use random numbers between 0 and 10 to fill the matrix, because reading each element of matrix N x M is >= 9 elements.

        Console.WriteLine("This program will find in matrix(of size N x M) the square 3 x 3 with maximal sum of its elements.");
        int rows = 0;
        int cols = 0;

        do
        {
            Console.Write("Please enter correct N >= 3 and M >= 3\nEnter N(rows) = ");
            rows = int.Parse(Console.ReadLine());
            Console.Write("Enter M(columns) = ");
            cols = int.Parse(Console.ReadLine());
        } while (rows < 3 || cols < 3);

        int[,] matrix = new int[rows, cols];
        Random number = new Random();

        //Filling the matrix;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = number.Next(0, 10);//here you can change the min - max range of numbers now they are min = 0, max = 10
            }
        }

        //Printing the matrix:
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 3}", matrix[row, col]);
            }
            Console.WriteLine();
        }

        //Searching for the biggest sum in square of elements 3 x 3:
        int maxSum = int.MinValue;
        int rowIndex = 0;
        int colIndex = 0;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int currentSum = 0;

                //i decided to use nested for loops inster of if with 9 elemtnts to sum.
                for (int currentRow = row; currentRow < row + 3; currentRow++)
                {
                    for (int currentCol = col; currentCol < col + 3; currentCol++)
                    {
                        currentSum += matrix[currentRow, currentCol];
                    }
                }

                if (maxSum < currentSum)
                {
                    maxSum = currentSum;
                    rowIndex = row;
                    colIndex = col;
                }
            }
        }

        //Printing the part of matrix with max sum:
        //If there are more than one squares with equal max sum we will find and print only the first one found!
        Console.WriteLine("The maximal sum of square 3 x 3 = {0}.\nIndex of first element is [{1}, {2}]", maxSum, rowIndex, colIndex);

        for (int row = rowIndex; row < rowIndex + 3; row++)
        {
            for (int col = colIndex; col < colIndex + 3; col++)
            {
                Console.Write("{0, 3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}
