//Write a method that returns the last digit of given integer as an English word. 
//Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine".
using System;

namespace PrintLastDigitOfIntAsWord
{
    class PrintLastDigitOfIntAsWord
    {
        static void Main(string[] args)
        {
            Console.Write("This program will print as an English word the last digit of number.\nEnter integer number = ");
            int number = int.Parse(Console.ReadLine());
            PrintLastDigit(number);
        }

        static void PrintLastDigit(int number)
        {
            string word = null;

            switch (number % 10)
            {
                case 0: word = "zero"; break;
                case 1: word = "one"; break;
                case 2: word = "two"; break;
                case 3: word = "three"; break;
                case 4: word = "four"; break;
                case 5: word = "five"; break;
                case 6: word = "six"; break;
                case 7: word = "seven"; break;
                case 8: word = "eight"; break;
                case 9: word = "nine"; break;
            }
            Console.WriteLine("Last digit of your number is: {0}", word);
        }
    }
}
