//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.
using System;
using System.Collections.Generic;

namespace MinMaxAverageSumProductOfIntegers
{
    class MinMaxAverageSumProductOfIntegers
    {
        static List<int> listOfNumbers = new List<int>();

        static void Main()
        {
            Console.WriteLine("This program will calculate minimum, maximum, average, sum and product of given set of integer numbers.");
            Console.WriteLine("Enter sequence of numbers. When finished enter a letter or word or other non integer type.");

            //Filling the array/list
            while (true)
            {
                string currentNumberString = Console.ReadLine();
                int currentNumber;
                if (int.TryParse(currentNumberString, out currentNumber))
                {
                    listOfNumbers.Add(currentNumber);
                }
                else
                {
                    break;
                }
            }

            //Minimal and Maximal numbers
            int minimalNumber = int.MaxValue;
            int maximalNumber = int.MinValue;
            MinimalAndMaximalMemberOfSequence(ref minimalNumber, ref maximalNumber);

            //Average and Sum of of given set of integer numbers
            int sum = 0;
            double average = AverageAndSumOfIntegerSequence(ref sum);

            //Product
            int product = ProductOfSequenceOfIntegers();

            //Printing results
            Console.WriteLine("Minimal number of the sequence is: {0}.\nMaximal number is: {1}.", minimalNumber, maximalNumber);
            Console.WriteLine("Sum = {0}\nAverage = {1}\nProduct = {2}", sum, average,product);
        }

        static void MinimalAndMaximalMemberOfSequence(ref int minimalNumber, ref int maximalNumber)
        {
            foreach (var number in listOfNumbers)
            {
                if (minimalNumber > number)
                {
                    minimalNumber = number;
                }
                
                if (maximalNumber < number)
                {
                    maximalNumber = number;
                }
            }
        }

        static double AverageAndSumOfIntegerSequence(ref int sum)
        {
            foreach (var number in listOfNumbers)
            {
                sum += number;
            }
            double average = (double)sum / listOfNumbers.Count;
            return average;
        }

        static int ProductOfSequenceOfIntegers()
        {
            int product = 1;
            foreach (var number in listOfNumbers)
            {
                product *= number;
            }
            return product;
        }
    }
}
