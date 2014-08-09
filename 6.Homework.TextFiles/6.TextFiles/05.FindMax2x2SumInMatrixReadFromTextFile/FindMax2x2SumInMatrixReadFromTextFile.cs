//Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 
//with a maximal sum of its elements. The first line in the input file contains the size of matrix N. Each of the next
//N lines contain N numbers separated by space. The output should be a single number in a separate text file. 
using System;
using System.IO;

namespace FindMax2x2SumInMatrixReadFromTextFile
{
    class FindMax2x2SumInMatrixReadFromTextFile
    {
        static void Main()
        {
            Console.WriteLine("This program will read square integer matrix from text file and will find in the matrix an area of size 2 x 2 with a maximal sum of its elements");
            StreamReader textFile = new StreamReader(@"..\..\matrixOfIntegers.txt");
            int[,] matrix;

            //Reading text file and filling the int matrix
            using (textFile)
            {
                string line = textFile.ReadLine();
                int sizeOfMatrix = int.Parse(line);
                matrix = new int[sizeOfMatrix, sizeOfMatrix];

                for (int row = 0; row < matrix.GetLength(0); row++) //there are only N lines containing N numbers at a line
                {
                    line = textFile.ReadLine();

                    string[] wholeRow = line.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                    for (int col = 0; col < wholeRow.Length; col++)
                    {
                        matrix[row, col] = int.Parse(wholeRow[col]); 
                    }
                }
            }

            //Printing int matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

            //Searching for maximal 2x2 sum
            int maxSum = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }
            Console.WriteLine("maximal 2x2 sum in matrix is {0}.", maxSum);

            //Writing result to another text file
            using (StreamWriter outputTextFile = new StreamWriter(@"..\..\MaxSumInMatrix.txt"))
            {
                outputTextFile.WriteLine(maxSum);
            }
        }
    }
}
