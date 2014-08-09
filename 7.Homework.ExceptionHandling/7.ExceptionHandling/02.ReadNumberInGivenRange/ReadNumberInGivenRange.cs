//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
//If an invalid number or non-number text is entered, the method should throw an exception. 
//Using this method write a program that enters 10 numbers:
//a1, a2, … a10, such that 1 < a1 < … < a10 < 100
using System;

namespace ReadNumberInGivenRange
{
    class ReadNumberInGivenRange
    {
        static void Main()
        {
            Console.WriteLine("This program will read 10 numbers in the range [1; 100] and will check if they are correct.\nEnter numbers below:");
            int[] arrayOfNumbers = new int[10];
            for (int index = 0; index < arrayOfNumbers.Length; index++)
            {
                Console.Write("arr[{0}] = ", index);
                arrayOfNumbers[index] = ReadNumber(1, 100);
            }
            
        }

        static int ReadNumber(int start, int end)
        {
            //Console.WriteLine("Enter number in the range [{0}; {1}]: ", start, end);
            string numToString = Console.ReadLine();
            int number;

            if (!int.TryParse(numToString, out number))
            {
                throw new FormatException();
            }

            if (number < start || number > end)
            {
                throw new ArgumentException("Invalid number! Value is not in the desired range!");
            }
            return number;
        }
    }
}
