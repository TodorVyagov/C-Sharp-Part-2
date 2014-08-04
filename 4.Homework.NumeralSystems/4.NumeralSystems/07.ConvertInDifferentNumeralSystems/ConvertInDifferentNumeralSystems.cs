//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

using System;

namespace ConvertInDifferentNumeralSystems
{
    class ConvertInDifferentNumeralSystems
    {
        static int s = 0, d = 0;
        static void Main()
        {
            Console.WriteLine("This program will convert from any numeral system of given base s to any other numeral system of base d.");
            
            while (s < 2 || s > 16 || d < 2 || d > 16 || s == d)
            {
                Console.WriteLine("2 <= s, d <= 16; s != d");
                Console.Write("Enter base s = ");
                s = int.Parse(Console.ReadLine());
                Console.Write("Enter base d = ");
                d = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter number in {0} numeral system = ", s);
            string sNumber = Console.ReadLine().ToUpper();

            //Validation
            bool isCorrect = true;
            for (int i = 0; i < sNumber.Length; i++)
            {
                if (s > 10)
                {
                    if (sNumber[i] > ('A' + (s - 11)))
                    {
                        isCorrect = false;
                    }
                }
                else
                {
                    if (sNumber[i] >= (char)s)
                    {
                        isCorrect = false;
                    }
                }

                if (isCorrect == false)
                {
                    Console.WriteLine("Your number is not in {0} numeral system!", s);
                    Environment.Exit(0);
                }
            }

            //The idea is to convert the sNumber first to decimal numeral system and then decimal number to D numeral system.
            int decimalNumber = ConvertFromSNumSystemToDecimal(sNumber);
            Console.WriteLine(decimalNumber);
            string dNumber = ConvertDecimalToDNumSystem(decimalNumber);
            Console.WriteLine("Number {0} in {1} numeral system is number {2} in {3} numeral system.", sNumber, s, dNumber, d);
        }

        static int ConvertFromSNumSystemToDecimal(string sNumber)
        {
            int decimalNumber = 0;

            for (int i = sNumber.Length - 1, power = 0; i >= 0; i--, power++)
            {
                int digitToMultiply;
                if (sNumber[i] >= 'A' && sNumber[i] <= 'F')
                {
                    digitToMultiply = sNumber[i] - 'A' + 10;
                }
                else
                {
                    digitToMultiply = sNumber[i] - '0';
                }
                decimalNumber += digitToMultiply * Pow(s, power);
            }
            return decimalNumber;
        }

        static int Pow(int number, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }

        static string ConvertDecimalToDNumSystem(int decimalNumber)
        {
            string dNumber = null;

            while (decimalNumber > 0)
            {
                int currentIntDigit = decimalNumber % d;
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
                dNumber = currentDigit + dNumber;
                decimalNumber /= d;
            }
            return dNumber;
        }
    }
}
