//Write a program to convert binary numbers to hexadecimal numbers (directly).
using System;

namespace ConvertBinaryToHexadecimal
{
    class ConvertBinaryToHexadecimal
    {
        static void Main()
        {
            Console.Write("This program will convert given binary number to hexadecimal.\nEnter binary number = ");
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

            //Adding Leading zeros to make it divisable by 4
            while ((binaryNumber.Length % 4) != 0)
            {
                binaryNumber = "0" + binaryNumber;
            }

            //easier way:
            //string hexNum = Convert.ToString(Convert.ToInt32(binaryNumber, 2), 16).ToUpper();
            //Console.WriteLine(hexNum);

            string hexadecimalNumber = ConvertBinaryNumbertoHexadecimal(binaryNumber);
            Console.WriteLine("Binary number {0} in hexadecimal numeral system is {1}.", binaryNumber, hexadecimalNumber);
        }

        static string ConvertBinaryNumbertoHexadecimal(string binaryNumber)
        {
            string hexadecimalNumber = null;

            for (int digitInBinNum = binaryNumber.Length - 4; digitInBinNum >= 0; digitInBinNum -= 4)
            {
                string currentDigitToAdd = null;
                string sequnce = binaryNumber.Substring(digitInBinNum, 4);

                switch (sequnce)
                {
                    case "0000": currentDigitToAdd = "0"; break;
                    case "0001": currentDigitToAdd = "1"; break;
                    case "0010": currentDigitToAdd = "2"; break;
                    case "0011": currentDigitToAdd = "3"; break;
                    case "0100": currentDigitToAdd = "4"; break;
                    case "0101": currentDigitToAdd = "5"; break;
                    case "0110": currentDigitToAdd = "6"; break;
                    case "0111": currentDigitToAdd = "7"; break;
                    case "1000": currentDigitToAdd = "8"; break;
                    case "1001": currentDigitToAdd = "9"; break;
                    case "1010": currentDigitToAdd = "A"; break;
                    case "1011": currentDigitToAdd = "B"; break;
                    case "1100": currentDigitToAdd = "C"; break;
                    case "1101": currentDigitToAdd = "D"; break;
                    case "1110": currentDigitToAdd = "E"; break;
                    case "1111": currentDigitToAdd = "F"; break;
                }
                hexadecimalNumber = currentDigitToAdd + hexadecimalNumber;
            }
            return hexadecimalNumber;
        }
    }
}
