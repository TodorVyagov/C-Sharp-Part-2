//Write a program to convert hexadecimal numbers to their decimal representation.
using System;

namespace ConverHexadecimalToDecimal
{
    class ConverHexadecimalToDecimal
    {
        static void Main()
        {
            Console.Write("This program will convert given hexadecimal number to its decimal representation.\nEnter hexadecimal number = ");
            string hexadecimalNumber = Console.ReadLine().ToUpper();

            //Validation
            bool isCorrect = true;
            for (int i = 0; i < hexadecimalNumber.Length; i++)
            {
                if (char.IsDigit(hexadecimalNumber[i]))
                {
                    continue;
                }
                else if (hexadecimalNumber[i] > ('A' + ('F' - 'A')))
                {
                    isCorrect = false;
                }

                if (isCorrect == false)
                {
                    Console.WriteLine("Your number is not in hexadecimal numeral system!");
                    Environment.Exit(0);
                }
            }

            //Easier way:
            //int decimalNum = Convert.ToInt32(hexadecimalNumber, 16);
            //Console.WriteLine(decimalNum);

            int decimalNumber = ConvertHexadecimalNumberToDecimal(hexadecimalNumber);
            Console.WriteLine("Hexadecimal number {0} in decimal numeral system is {1}", hexadecimalNumber, decimalNumber);
        }

        static int ConvertHexadecimalNumberToDecimal(string hexadecimalNumber)
        {
            int decimalNumber = 0;

            for (int i = hexadecimalNumber.Length - 1, degree = 0; i >= 0; i--, degree++)
            {
                int digitToMultiply;
                if (hexadecimalNumber[i] >= 'A' && hexadecimalNumber[i] <= 'F')
                {
                    digitToMultiply = hexadecimalNumber[i] - 'A' + 10;
                }
                else
                {
                    digitToMultiply = hexadecimalNumber[i] - '0';
                }
                decimalNumber += digitToMultiply * PowOfHex(degree);
            }
            return decimalNumber;
        }

        static int PowOfHex(int degree)
        {
            int result = 1;
            for (int i = 0; i < degree; i++)
            {
                result *= 16;
            }
            return result;
        }
    }
}
