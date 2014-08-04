using System;

class FindMaxSequanceOfEqualStringsInMatrix
{
    static void Main()
    {
        //We are given a matrix of strings of size N x M. Sequences in the matrix we define as
        //sets of several neighbor elements located on the same line, column or diagonal. 
        //Write a program that finds the longest sequence of equal strings in the matrix. 

        string[,] matrix = 
        {
            {"ha", "fif", "ho", "hi"},
            {"fo", "ha", "hi", "xx"},
            {"xxx", "ho", "ha", "xx"}
        };
        //These are the input matrices with who I checked if my program works correctly
        /*
        {"ha", "fif", "ho", "hi"},
        {"fo", "he", "hi", "xx"},
        {"xxx", "hi", "ha", "xx"} 
          
        {"ha", "fif", "ho", "hi"},
        {"fo", "he", "hi", "xx"},
        {"xxx", "ho", "ha", "xx"}  
          
        {"ha", "fif", "ho", "hi"},
        {"fo", "he", "hp", "xx"},
        {"xxx", "ho", "ha", "xx"}  
         
        {"ha", "fif", "ho", "hi"},
        {"fo", "he", "hp", "x"},
        {"xxx", "ho", "ha", "xx"}
          
        {"s", "qq", "s"},
        {"pp", "pp", "s"},
        {"pp", "qq", "s"}
        */

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 5}", matrix[row, col]);
            }
            Console.WriteLine();
        }

        //Searching for sequence of equal elements:
        //We have to check 4 directions(if possible) for each element in the matrix: 
        //right, right-down diagonal, down and left-down diagonal.
        int counterOfEqualElements = 1;
        string elementOfSequence = null;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int currentCounter = 1; //because we will start from the next element and if it is the same the counter will increase to 2(two equal elements);
                string currentElement = null;
                string direction = "right";
                int currentRow = row;
                int currentCol = col;

                while (true)
                {
                    //here we set the direction of check
                    switch (direction)
                    {
                        case "right": 
                            currentCol++; 
                            break;
                        case "right-down":
                            currentRow++; 
                            currentCol++;
                            break;
                        case "down": 
                            currentRow++; 
                            break;
                        case "left-down": 
                            currentRow++;
                            currentCol--;
                            break;
                    }

                    //if we are out of the matrix, we change the direction 
                    if (direction == "right" && currentCol == (matrix.GetLength(1)))
	                {
		                currentCol = col;
                        direction = "right-down";
                        currentCounter = 1;
                        continue;
	                }
                    else if (direction == "right-down" && (currentRow == matrix.GetLength(0) || currentCol == matrix.GetLength(1)))
	                {
		                currentRow = row;
                        currentCol = col;
                        direction = "down";
                        currentCounter = 1;
                        continue;
	                }
                    else if (direction == "down" && currentRow == matrix.GetLength(0))
	                {
		                currentRow = row;
                        direction = "left-down";
                        currentCounter = 1;
                        continue;
	                }
                    else if (direction == "left-down" && (currentRow == matrix.GetLength(0) || currentCol < 0))
                    {
                        break;
                    }

                    //searching for equal elements and counting them
                    if (matrix[row, col] == matrix[currentRow, currentCol])
                    {
                        currentCounter++;
                        currentElement = matrix[row, col];
                    }
                    else //if the element is not the same as previous
                    {
                        currentCounter = int.MinValue;//if here we assign 1 if there are 2 equal elements in same row, col or diagonal,
                        //but are not neighbours it will also count them and the result will be incorrect.
                    }

                    if (currentCounter > counterOfEqualElements)
                    {
                        counterOfEqualElements = currentCounter;
                        elementOfSequence = currentElement;
                    }
                }

            }
        }

        //Printing results:
        //If there are more than one equal sequences of elements the program will display only the first one found!
        if (counterOfEqualElements > 1)
        {
            Console.Write("There are {0} equal elements: ", counterOfEqualElements);
            for (int i = 0; i < counterOfEqualElements; i++)
                Console.Write("{0}, ", elementOfSequence);
            Console.WriteLine("\b\b.");
        }
        else 
        {
            Console.WriteLine("There is no sequance of equal elements in row, col or diagonal of the matrix!");
        }
    }
}
