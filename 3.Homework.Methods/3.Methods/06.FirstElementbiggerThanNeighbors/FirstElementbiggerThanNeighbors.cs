//Write a method that returns the index of the first element in array that 
//is bigger than its neighbors, or -1, if there’s no such element.
//Use the method from the previous exercise.
using System;

namespace FirstElementbiggerThanNeighbors
{
    class FirstElementbiggerThanNeighbors
    {
        static void Main()
        {
            Console.Write("This program will find first element in array that is bigger than its two neighbors(if such exists).\nEnter size of array = ");
            int size = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = new int[size];
            Random inputNumber = new Random();

            //Initialization and print of the array:
            Console.WriteLine("This is the array:");
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = inputNumber.Next(0, 10);
                Console.WriteLine("arr[{0}] = {1} ", i, arrayOfNumbers[i]);
            }
            int index = CompareNeighborElements(arrayOfNumbers);

            if (index >= 0)
            {
                Console.WriteLine("First element that is bigger than its neighbors is arrayOfNumbers[{0}] = {1}.", index, arrayOfNumbers[index]);
            }
            else
            {
                Console.WriteLine("There is no element in the array that is bigger than its neighbors.");
            }
        }

        static int CompareNeighborElements(int[] arrayOfNumbers)
        {
            bool isBigger = false;

            for (int index = 0; index < arrayOfNumbers.Length; index++)
            //if you want to check elements that have 2 neighbors assign the loop that way: 
            //for (int index = 1; index < arrayOfNumbers.Length - 1; index++)
            {
                if (index == 0)
                {
                    if (arrayOfNumbers[index] > arrayOfNumbers[index + 1])
                        isBigger = true;
                }
                else if (index == arrayOfNumbers.Length - 1)
                {
                    if (arrayOfNumbers[index] > arrayOfNumbers[index - 1])
                        isBigger = true;
                }
                else if (arrayOfNumbers[index] > arrayOfNumbers[index - 1] && arrayOfNumbers[index] > arrayOfNumbers[index + 1])
                {
                    isBigger = true;
                }

                if (isBigger)
                {
                    return index;
                }
            }
            return -1;
        }
    }
}
