/*Write a program that can solve these tasks:
-Reverses the digits of a number
-Calculates the average of a sequence of integers
-Solves a linear equation a * x + b = 0
		Create appropriate methods.
		Provide a simple text-based menu for the user to choose which task to solve.
		Validate the input data:
-The decimal number should be non-negative
-The sequence should not be empty
-a should not be equal to 0 */ 
using System;
using System.Collections.Generic;

namespace SolveDifferentTasks
{
    class SolveDifferentTasks
    {
        static void Main()
        {
            Console.WriteLine("This program can solve different tasks:\n\t1) Reverses the digits of a number\n\t2) Calculates the average of a sequence of integers\n\t3) Solves a linear equation a * x + b = 0.");
            Console.WriteLine("Choose which task you want to solve by typing: 1, 2 or 3");
            int choise = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1: ReverseNumberDigits(); break;
                case 2: CalculateAverageOfSequence(); break;
                case 3: LinearEquationSolver(); break;
                default: Console.WriteLine("Invalid input!"); break;
            }
        }

        static void ReverseNumberDigits()
        {
            //It's the same solution as in priblem 7.
            Console.Write("This program will reverse the digits of given decimal number.\nEnter non negative number = ");
            decimal number = decimal.Parse(Console.ReadLine());

            if (number < 0) // validation
            {
                Console.WriteLine("The number has to be NON Negative!");
                return;
            }

            string numToString = Convert.ToString(number);
            int counterOfIntDigits = 0;
            int counterOfFlopDigits = 0;
            bool isBeforePoint = true;
            int positionOfPoint = -1;
            decimal reversedNumber = 0;

            //Counting digits
            for (int i = 0; i < numToString.Length; i++)
            {
                if (numToString[i] == '.')
                {
                    isBeforePoint = false;
                    positionOfPoint = i;
                }
                else if (isBeforePoint)
                {
                    counterOfIntDigits++;
                }
                else
                {
                    counterOfFlopDigits++;
                }
            }

            if (counterOfFlopDigits > 0)//check if number is integer 
            {
                int endIndex = numToString.Length - counterOfFlopDigits;
                //Filling floating point part of reverse number:
                for (int i = counterOfIntDigits - 1, j = 0; i >= 0; i--, j++)
                {
                    reversedNumber += (numToString[i] - '0') * (0.1m / Pow(j));
                }
            }
            else
            {
                counterOfFlopDigits = counterOfIntDigits;
            }

            //Filling integer part of reverse number:
            for (int i = numToString.Length - 1; i > positionOfPoint; i--)
            {
                reversedNumber += (numToString[i] - '0') * Pow(counterOfFlopDigits - 1);
                counterOfFlopDigits--;
            }
            Console.WriteLine("Reversed number is = " + reversedNumber);
        }

        static int Pow(int degree) //This method is used insted of Math.Pow();, because it's faster
        {
            int number = 1;
            for (int i = 0; i < degree; i++)
            {
                number *= 10;
            }
            return number;
        }

        static void CalculateAverageOfSequence()
        {
            Console.WriteLine("This program will calculate average of sequence of integers.\nEnter your integer numbers. When finished enter a letter or word or other non integer type.");
            List<int> arrayOfNumbers = new List<int>();

            while (true)
            {
                string currentNumberString = Console.ReadLine();
                int currentNumber;
                if (int.TryParse(currentNumberString, out currentNumber))
                {
                    arrayOfNumbers.Add(currentNumber);
                }
                else
                {
                    break;
                }
            }

            if (arrayOfNumbers.Capacity == 0) //validation
            {
                Console.WriteLine("The sequence cannot be empty!");
                return;
            }

            double sum = 0;
            foreach (var number in arrayOfNumbers)
            {
                sum += number;
            }

            double average = sum / arrayOfNumbers.Count;
            Console.WriteLine("Average number is: {0:f2}", average);
        }

        static void LinearEquationSolver()
        {
            Console.WriteLine("This program will solve linear equation a*x + b = 0, by given coefficients \"a\" and \"b\".");
            int a = 0;
            while (a == 0)
            {
                Console.Write("\"a\" should not be equal to 0!\nEnter a = ");
                a = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter b = ");
            int b = int.Parse(Console.ReadLine());

            double x = (double)-b / a;

            Console.WriteLine("Root of {0}*x + {1} = 0 is\nx = {2:f2}",a, b, x);
        }
    }
}
