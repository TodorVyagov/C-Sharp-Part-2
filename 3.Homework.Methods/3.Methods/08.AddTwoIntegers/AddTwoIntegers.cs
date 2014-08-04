//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; 
//the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.
using System;

namespace AddTwoIntegers
{
    class AddTwoIntegers
    {
        static void Main()
        {
            Console.WriteLine("This program will add two positive integer numbers represented as arrays of digits.");
            Console.Write("Enter first number = ");
            string firstNumberString = Console.ReadLine();
            Console.Write("Enter second number = ");
            string secondNumberString = Console.ReadLine();
            int longerNumber;

            if (firstNumberString.Length >= secondNumberString.Length)
            {
                longerNumber = firstNumberString.Length;
            }
            else
            {
                longerNumber = secondNumberString.Length;
            }

            int[] firstNumArray = ConvertStringToIntArray(firstNumberString, longerNumber);
            int[] secondNumArray = ConvertStringToIntArray(secondNumberString, longerNumber);
            int[] resultArray = AddTwoNumbers(firstNumArray, secondNumArray);

            //Printing Results
            Console.WriteLine("This prigram added these two numbers(represented as arrays of digits) and the result is: ");
            for (int i = resultArray.Length - 1; i >= 0; i--)
            {
                if (i == resultArray.Length - 1 && resultArray[i] == 0) // if first digit is 0 we do not print it
                {
                    continue;
                }
                Console.WriteLine("arr[{0}] = {1}", i, resultArray[i]);
            }
            Console.WriteLine();

            Console.WriteLine("This is result array converted to int:\n" + ConvertIntArrayToInt(resultArray));

        }

        static int[] AddTwoNumbers(int[] firstNumArray, int[] secondNumArray)
        {
            bool moreThanNine = false;

            int[] resultArray = new int[firstNumArray.Length + 1]; //For example this is needed because when we have 999 and 1 next number will be 4 digits(1000). 

            for (int i = 0; i < firstNumArray.Length; i++)
            {
                int currentSum = firstNumArray[i] + secondNumArray[i];

                if (moreThanNine)
                {
                    currentSum++;
                    moreThanNine = false;
                }

                resultArray[i] = currentSum % 10;

                if (currentSum > 9)
                {
                    moreThanNine = true;
                }
            }

            if (moreThanNine)
            {
                resultArray[resultArray.Length - 1]++;
            }

            return resultArray;
        }

        static int[] ConvertStringToIntArray(string numberString, int length)
        {
            int[] arrayOfDigits = new int[length];

            for (int i = 0; i < numberString.Length; i++)
            {
                arrayOfDigits[i] = numberString[numberString.Length - 1 - i] - '0';
            }

            return arrayOfDigits;
        }

        static int ConvertIntArrayToInt(int[] arrayOfNumbers)
        {
            int resultNumber = 0;

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                resultNumber += arrayOfNumbers[i] * PowOfTen(i);
            }
            return resultNumber;
        }

        static int PowOfTen(int degree) //This method is used insted of Math.PowOfTen();, because it's faster
        {
            int number = 1;
            for (int i = 0; i < degree; i++)
            {
                number *= 10;
            }
            return number;
        }
    }
}
