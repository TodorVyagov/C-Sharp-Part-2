//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.
//Example: string = "43 68 9 23 318" -> result = 461
using System;
using System.Collections.Generic;

namespace SumOfSequenceOfPositiveIntsInString
{
    class SumOfSequenceOfPositiveIntsInString
    {
        static List<int> arrayOfNumbers = new List<int>();

        static void Main()
        {
            Console.WriteLine("This program will read and calculate a sequence of positive integer values written into a string.");
            string sequenceOfIntegers = "43 68 9 23 318";
            //if you want to manually enter string uncomment the row below and enter your own input(only positive integers are allowed and intervals)
            //sequenceOfIntegers = Console.ReadLine();
            ValidationOfInputString(sequenceOfIntegers);
            Console.WriteLine("This is the input string = " + sequenceOfIntegers);
            ConvertStringToListOfIntArray(sequenceOfIntegers);
            int sum = 0;

            foreach (var number in arrayOfNumbers)
            {
                sum += number;
            }
            Console.WriteLine("The sum of all numbers in the string is:\nSum = {0}.", sum);
        }

        static void ValidationOfInputString(string input)
        {
            for (int currChar = 0; currChar < input.Length; currChar++)
            {
                if (!(char.IsDigit(input[currChar]) || (input[currChar] == ' ')))
                {
                    throw new ArgumentException("Incorrect input. There are not allowed symbols in the input string!");
                }
            }

        }

        static void ConvertStringToListOfIntArray(string sequence)
        {
            int currentNumber = 0;
            int power = 0;
            int index = sequence.Length - 1; //starting from the right most digit

            while (index != -1)
            {
                if (sequence[index] != ' ')
                {
                    int currentDigit = sequence[index] - '0';
                    currentNumber += PowOfTenMultipliedByNumber(currentDigit, power);
                    power++;
                }
                
                if (sequence[index] == ' ' || index == 0)
                {
                    arrayOfNumbers.Add(currentNumber);
                    currentNumber = 0;
                    power = 0; //adding the number and make it equal to 0 to add the next one
                }
                index--;
            }
        }

        static int PowOfTenMultipliedByNumber(int number, int power)
        {
            int result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= 10;
            }
            result *= number;
            return result;
        }
    }
}
