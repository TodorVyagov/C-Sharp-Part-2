using System;

//Write a program that finds the largest area of equal neighbor elements 
//in a rectangular matrix and prints its size. 
namespace LargestAreaOfEqualElementsInArray
{
    class LargestAreaOfEqualElementsInArray
    {
        static int[,] matrix = 
            {
                {1, 3, 2, 2, 2, 4},
                {3, 3, 3, 2, 4, 4},
                {4, 3, 1, 2, 3, 3},
                {4, 3, 1, 3, 3, 1},
                {4, 3, 3, 3, 1, 1}
            };

        static bool[,] isCounted = new bool[matrix.GetLength(0), matrix.GetLength(1)];

        static void Main()
        {
            int counter = 0;
            int element = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int currentCounter = 0;

                    if (!isCounted[row, col])
                    {
                        currentCounter = CounterOfEqualNeighborElements(row, col, currentCounter);
                    }

                    if (currentCounter > counter)
                    {
                        counter = currentCounter;
                        element = matrix[row, col];
                    }
                }
            }

            //Printing array:
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("There is sequence of {0} neighbor elements with value = {1}.", counter, element);
        }

        static int CounterOfEqualNeighborElements(int startRow, int startCol, int counter)
        {
            isCounted[startRow, startCol] = true;
            counter++;

            if (startRow - 1 >= 0) //up direction
            //this check is if the element is in the bounds of the matrix
            {
                if (matrix[startRow - 1, startCol] == matrix[startRow, startCol] && isCounted[startRow - 1, startCol] == false)
                //This checks if the neighbor element has the same value and whether the element is already counted
                {
                    counter = CounterOfEqualNeighborElements(startRow - 1, startCol, counter);
                }
            }

            if (startCol - 1 >= 0) //left
            {
                if (matrix[startRow, startCol - 1] == matrix[startRow, startCol] && isCounted[startRow, startCol - 1] == false)
                {
                    counter = CounterOfEqualNeighborElements(startRow, startCol - 1, counter);
                }
            }

            if (startRow + 1 < matrix.GetLength(0)) //down
            {
                if (matrix[startRow + 1, startCol] == matrix[startRow, startCol] && isCounted[startRow + 1, startCol] == false)
                {
                    counter = CounterOfEqualNeighborElements(startRow + 1, startCol, counter);
                }
            }

            if (startCol + 1 < matrix.GetLength(1)) //right
            {
                if (matrix[startRow, startCol + 1] == matrix[startRow, startCol] && isCounted[startRow, startCol + 1] == false)
                {
                    counter = CounterOfEqualNeighborElements(startRow, startCol + 1, counter);
                }
            }

            return counter;
        }
    }
}
