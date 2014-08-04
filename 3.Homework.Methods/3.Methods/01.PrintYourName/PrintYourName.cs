//Write a method that asks the user for his name and prints “Hello, <name>”
//(for example, “Hello, Peter!”). Write a program to test this method.
using System;

namespace PrintYourName
{
    class PrintYourName
    {
        static void Main()
        {
            PrintName();
        }

        static void PrintName()
        {
            Console.Write("Enter your name: ");
            string nameOfClient = Console.ReadLine();
            Console.WriteLine("Hello, {0}! Nice to meet you!", nameOfClient);
        }
    }
}
