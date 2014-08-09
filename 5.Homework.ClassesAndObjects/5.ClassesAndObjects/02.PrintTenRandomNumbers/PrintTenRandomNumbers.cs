//Write a program that generates and prints to the console 10 random values in the range [100, 200].
using System;

namespace PrintTenRandomNumbers
{
    class PrintTenRandomNumbers
    {
        static void Main()
        {
            Console.WriteLine("This program will generate 10 random numbers in the range [100; 200]");
            Random randomNumber = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Number {0, 2} = {1}.", i + 1, randomNumber.Next(100, 201)); //If we want to include 200 we have to assign 201
            }
        }
    }
}
