//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).
using System;

namespace CheckIfExpressionIsCorrect
{
    class CheckIfExpressionIsCorrect
    {
        static void Main()
        {
            Console.Write("This program will check if in given expression brackets are put correctly.\nEnter expression = ");
            string expression = Console.ReadLine();

            int bracketCounter = 0;

            for (int currChar = 0; currChar < expression.Length; currChar++)
            {
                if (expression[currChar] == '(')
                {
                    bracketCounter++;
                }
                else if (expression[currChar] == ')')
                {
                    bracketCounter--;
                }

                if (bracketCounter < 0)
                {
                    break;
                }
            }

            if (bracketCounter == 0)
            {
                Console.WriteLine("Expression you entered is correct.");
            }
            else
            {
                Console.WriteLine("You entered incorrect expression.");
            }
        }
    }
}
