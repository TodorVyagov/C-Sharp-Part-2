//Write a program to convert decimal numbers to their hexadecimal representation.
using System;

namespace ConvertDecimalToHexadecimal
{
    class ConvertDecimalToHexadecimal
    {
        static void Main()
        {
            Console.Write("This program will convert given decimal number to its hexadecimal representation.\nEnter decimal number = ");
            int decimalNumber = int.Parse(Console.ReadLine());

            //This is the easiest way, but in this womework we need to learn how to convert between different numeral systems manually.
            //Console.WriteLine("{0:X}", decimalNumber); //Only printing as hex
            //string hexNum = decimalNumber.ToString("X"); //Assign it at string
            //Console.WriteLine(hexNum);

            string hexadecimalNumber = ConvertDecimalNumberToHexadecimal(decimalNumber);
            Console.WriteLine("Decimal number {0} in hexadecimal numeral system is {1}", decimalNumber, hexadecimalNumber);
        }

        static string ConvertDecimalNumberToHexadecimal(int decimalNumber)
        {
            string hexNumber = null;

            while (decimalNumber > 0)
            {
                int currentIntDigit = decimalNumber % 16;
                string currentDigit;
                switch (currentIntDigit)
                {
                    case 10: currentDigit = "A"; break;
                    case 11: currentDigit = "B"; break;
                    case 12: currentDigit = "C"; break;
                    case 13: currentDigit = "D"; break;
                    case 14: currentDigit = "E"; break;
                    case 15: currentDigit = "F"; break;
                    default: currentDigit = currentIntDigit.ToString(); break;
                }
                hexNumber = currentDigit + hexNumber;
                decimalNumber /= 16;
            }
            return hexNumber;
        }
    }
}
