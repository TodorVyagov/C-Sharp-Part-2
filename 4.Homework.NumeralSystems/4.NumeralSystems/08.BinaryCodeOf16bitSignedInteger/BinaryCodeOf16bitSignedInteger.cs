//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
using System;

namespace BinaryCodeOf16bitSignedInteger
{
    class BinaryCodeOf16bitSignedInteger
    {
        static void Main()
        {
            Console.WriteLine("This program will show the binary representation of given 16-bit signed integer number (the C# type short).");
            //bitwise is easier, but we are trying more interesting ways :)
            Console.Write("Enter number between -32'768 and 32'767:\nNumber = ");
            short number = short.Parse(Console.ReadLine());
            string binaryNumber = ShortToBinary(number);

            //Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0')); //This is used only to check if program works correctly
            Console.WriteLine("Binary representation of {0} is : {1}.", number, binaryNumber);
        }

        static string ShortToBinary(int number)
        {
            string binaryNum = string.Empty;
            bool isNegative = false;

            if (number < 0)
            {
                number = (short)((1 << 15) + number);//using + because the number is negative; 1 << 15 means 2 ^ 15
                isNegative = true;
            }

            while (number > 0) //Filling number with 0 and 1
            {
                string currentDigit = Convert.ToString(number % 2);
                binaryNum = currentDigit + binaryNum;
                number /= 2;
            }

            while (binaryNum.Length < 15) //adding leading zeros up to 15 digits 
            {
                binaryNum = "0" + binaryNum;
            }

            if (isNegative) // adding most significant bit
            {
                binaryNum = "1" + binaryNum;
            }
            else
            {
                binaryNum = "0" + binaryNum;
            }
            return binaryNum;
        }
    }
}
