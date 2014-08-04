using System;

class FillAndPrintMatrix
{
    static void Main()
    {
        //Write a program that fills and prints a matrix of size (n, n).

        //d)
        Console.Write("Enter size of matrix\nN = ");
        int N = int.Parse(Console.ReadLine());
        int[,] matrix = new int[N, N];
        int maxNumber = N * N;
        int currentNumber = 1;
        int currentRow = -1;//because in switch it will increase it with 1
        int currentCol = 0;
        string direction = "down";
        int upperBorder = 0;
        int bottomBorder = matrix.GetLength(0) - 1;
        int rightBorder = matrix.GetLength(1) - 1;
        int leftborder = 0;
        //we use borders, because we do not want to fill twice any cell(overwrite)

        while (currentNumber <= maxNumber)
        {
            //we have 4 directions(Down, Right, Up, Left).
            
            switch (direction)
            {
                case "down": 
                    currentRow++;
                    break;
                case "right": 
                    currentCol++;
                    break;
                case "up": 
                    currentRow--; 
                    break;
                case "left": 
                    currentCol--; 
                    break;
            }

            matrix[currentRow, currentCol] = currentNumber;
            currentNumber++;

            if (currentRow == bottomBorder && direction == "down")
            {
                direction = "right";
                leftborder++; //when we fill the left most column we increase the border
            }
            else if (currentCol == rightBorder && direction == "right")
            {
                direction = "up";
                bottomBorder--;
            }
            else if (currentRow == upperBorder && direction == "up")
            {
                direction = "left";
                rightBorder--;
            }
            else if (currentCol == leftborder && direction == "left")
            {
                direction = "down";
                upperBorder++;
            }
        }

        //Printing:
        Console.WriteLine("d)*");
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
