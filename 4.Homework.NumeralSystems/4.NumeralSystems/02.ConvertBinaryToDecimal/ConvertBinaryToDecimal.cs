//Write a program to convert binary numbers to their decimal representation.
using System;

namespace ConvertBinaryToDecimal
{
    class ConvertBinaryToDecimal
    {
        static void Main()
        {
            Console.Write("This program will convert given binary number to its decimal representation.\nEnter binary number = ");
            string binaryNumber = Console.ReadLine();

            //Chack if the number is binary:
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                if (binaryNumber[i] != '0' && binaryNumber[i] != '1')
                {
                    Console.WriteLine("Your number isn't binary!");
                    Environment.Exit(0);
                }
            }

            //This is the easiest way, but in this womework we need to learn how to convert between different numeral systems manually
            //int binaryRepresentation = Convert.ToInt32(binaryNumber, 2);
            //Console.WriteLine(binaryRepresentation);

            int decimalNumber = ConvertBinaryNumberToDecimal(binaryNumber);
            Console.WriteLine("Binary number {0} in decimal numeral system is {1}", binaryNumber, decimalNumber);
        }

        static int ConvertBinaryNumberToDecimal(string binaryNumber)
        {
            int decimalNumber = 0;

            for (int i = binaryNumber.Length - 1, degree = 0; i >= 0; i--, degree++)
            {
                decimalNumber += (binaryNumber[i] - '0') * PowOfTwo(degree);
            }

            return decimalNumber;
        }

        static int PowOfTwo(int degree)
        {
            int result = 1;

            for (int i = 0; i < degree; i++)
            {
                result *= 2;
            }
            return result;
        }
    }
}
