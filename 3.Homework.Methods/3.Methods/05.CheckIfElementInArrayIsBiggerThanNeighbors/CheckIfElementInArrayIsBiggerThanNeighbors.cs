//Write a method that checks if the element at given position in given array of 
//integers is bigger than its two neighbors (when such exist).
using System;

namespace CheckIfElementInArrayIsBiggerThanNeighbors
{
    class CheckIfElementInArrayIsBiggerThanNeighbors
    {
        static void Main()
        {
            Console.Write("This program will check if element in array is bigger than its two neighbors.\nEnter size of array = ");
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

            Console.Write("Enter index of element you want to check = ");
            int indexOfElement = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', 50));
            CompareNeighborElements(arrayOfNumbers, indexOfElement);
        }

        static void CompareNeighborElements(int[] arrayOfNumbers, int index)
        {
            bool isBigger = false;

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
            Print(isBigger, index, arrayOfNumbers[index]);
        }

        static void Print(bool isBigger, int index, int value)
        {
            if (isBigger)
            {
                Console.WriteLine("arr[{0}] = {1} is bigger than its neighbors.", index, value);
            }
            else
            {
                Console.WriteLine("arr[{0}] = {1} is NOT bigger than its neighbors.", index, value);
            }
        }
    }
}
