//Write a program to convert hexadecimal numbers to binary numbers (directly).
using System;

namespace ConvertHexadecimalToBinary
{
    class ConvertHexadecimalToBinary
    {
        static void Main()
        {
            Console.Write("This program will convert given hexadecimal number to binary.\nEnter hexadecimal number = ");
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
            //string binaryNum = Convert.ToString(Convert.ToInt32(hexadecimalNumber, 16), 2);
            //Console.WriteLine(binaryNum);

            string binaryNumber = ConvertHexadecimalNumberToBinary(hexadecimalNumber);
            Console.WriteLine("Hexadecimal number {0} in binary numeral system is {1}.", hexadecimalNumber, binaryNumber);
        }

        static string ConvertHexadecimalNumberToBinary(string hexadecimalNumber)
        {
            string binaryNumber = null;

            for (int digitInHexNum = hexadecimalNumber.Length - 1; digitInHexNum >= 0; digitInHexNum--)
            {
                string currentDigitsToAdd = null;

                switch (hexadecimalNumber[digitInHexNum])
                {
                    case '0': currentDigitsToAdd = "0000"; break;
                    case '1': currentDigitsToAdd = "0001"; break;
                    case '2': currentDigitsToAdd = "0010"; break;
                    case '3': currentDigitsToAdd = "0011"; break;
                    case '4': currentDigitsToAdd = "0100"; break;
                    case '5': currentDigitsToAdd = "0101"; break;
                    case '6': currentDigitsToAdd = "0110"; break;
                    case '7': currentDigitsToAdd = "0111"; break;
                    case '8': currentDigitsToAdd = "1000"; break;
                    case '9': currentDigitsToAdd = "1001"; break;
                    case 'A': currentDigitsToAdd = "1010"; break;
                    case 'B': currentDigitsToAdd = "1011"; break;
                    case 'C': currentDigitsToAdd = "1100"; break;
                    case 'D': currentDigitsToAdd = "1101"; break;
                    case 'E': currentDigitsToAdd = "1110"; break;
                    case 'F': currentDigitsToAdd = "1111"; break;
                }

                binaryNumber = currentDigitsToAdd + binaryNumber;
            }
            return binaryNumber;
        }

    }
}
