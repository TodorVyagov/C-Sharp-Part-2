//Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that 
//reads 3 integers from the console and prints the biggest of them using the method GetMax().
using System;

namespace GetMaxValueOfThreeIntegers
{
    class GetMaxValueOfThreeIntegers
    {
        static void Main()
        {
            Console.Write("This program will print the biggest of three numbers entered by you.\nEnter number one = ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.Write("Enter number two = ");
            int numberTwo = int.Parse(Console.ReadLine());
            Console.Write("Enter number three = ");
            int numberThree = int.Parse(Console.ReadLine());

            int maxNumber = GetMax(numberOne, numberTwo);
            maxNumber = GetMax(maxNumber, numberThree);

            Console.WriteLine("The maximal number is {0}.", maxNumber);
        }

        static int GetMax(int numberOne, int numberTwo)
        {
            if (numberOne > numberTwo)
            {
                return numberOne;
            }
            else
            {
                return numberTwo;
            }
        }
    }
}
