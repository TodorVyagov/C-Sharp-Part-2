//Write a program to convert decimal numbers to their binary representation.
using System;

namespace ConvertDecimalToBinary
{
    class ConvertDecimalToBinary
    {
        static void Main()
        {
            Console.Write("This program will convert given decimal number to its binary representation.\nEnter decimal number = ");
            int number = int.Parse(Console.ReadLine());

            //This is the easiest way, but in this womework we need to learn how to convert between different numeral systems manually
            //string binaryRepresentation = Convert.ToString(number, 2);
            //Console.WriteLine(binaryRepresentation);

            string numberToBinary = ConvertDecimalNumberToBinary(number);
            Console.WriteLine("Decimal number {0} in binary numeral system is {1}", number, numberToBinary);
        }

        static string ConvertDecimalNumberToBinary(int number) //The name of method cannot be the same as the name of Class!
        {
            string numberToBinary = null;

            while (number > 0)
            {
                string currentDigit = Convert.ToString(number % 2);
                numberToBinary = currentDigit + numberToBinary;
                number /= 2;
            }
            return numberToBinary;
        }
    }
}
