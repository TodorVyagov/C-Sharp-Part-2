//Write a method that reverses the digits of given decimal number. Example: 256 -> 652
using System;

namespace ReverseNumberDigits
{
    class ReverseNumberDigits
    {
        static void Main()
        {
            Console.Write("This program will reverse the digits of given decimal number.\nEnter number = ");
            decimal number = decimal.Parse(Console.ReadLine());

            decimal reversedNumber = ReverseNumber(number);
            Console.WriteLine("Reversed number is = " + reversedNumber);
        }

        static decimal ReverseNumber(decimal number)
        {
            string numToString = Convert.ToString(number);
            int counterOfIntDigits = 0;
            int counterOfFlopDigits = 0;
            bool isBeforePoint = true;
            int positionOfPoint = -1;
            decimal reverseNumber = 0;

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
                    reverseNumber += (numToString[i] - '0') * (0.1m / PowOfTen(j));
                }
            }
            else
            {
                counterOfFlopDigits = counterOfIntDigits;
            }

            //Filling integer part of reverse number:
            for (int i = numToString.Length - 1; i > positionOfPoint; i--)
            {
                reverseNumber += (numToString[i] - '0') * PowOfTen(counterOfFlopDigits - 1);
                counterOfFlopDigits--;
            }

            return reverseNumber;
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
