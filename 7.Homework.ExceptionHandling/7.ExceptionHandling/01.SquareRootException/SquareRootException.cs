//Write a program that reads an integer number and calculates and prints its square root. If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.
using System;

namespace SquareRootException
{
    class SquareRootException
    {
        static void Main()
        {
            Console.Write("This program will calculate the square root of given integer number and if it is invalid or negative will give message.\nEnter number = ");
            try
            {
                double number = double.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentException();
                }
                double num = Math.Sqrt(number);
                Console.WriteLine("The square root of your number is {0}", num);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid number! Number must be >= 0!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number! You did not enter correct number!");
            }
            finally
            {
                Console.WriteLine("Goodbye!");
            }
                
        }
    }
}
