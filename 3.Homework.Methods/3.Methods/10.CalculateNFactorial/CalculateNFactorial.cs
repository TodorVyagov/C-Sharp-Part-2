//Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method that 
//multiplies a number represented as array of digits by given integer number. 
using System;
using System.Collections.Generic;

namespace CalculateNFactorial
{
    class CalculateNFactorial
    {
        static List<int> factorial = new List<int>();

        static void Main()
        {
            factorial.Add(1);

            for (int i = 1; i <= 100; i++)
            {
                MultiplyNumberByArray(i);
                Console.WriteLine("factorial of {0} is:", i);

                for (int j = factorial.Count - 1; j >= 0; j--)
                {
                    Console.Write(factorial[j]);
                }
                Console.WriteLine();
            }
        }

        static void MultiplyNumberByArray(int multiplier)
        {
            int startIndex = 0;
            
            for (int i = 0; i < factorial.Count; i++)
            {
                factorial[i] *= multiplier; 
            }

            for (int i = startIndex; i < factorial.Count; i++)
            {
                if (factorial[i] > 9)
                {
                    int number = factorial[i];
                    factorial[i] = number % 10;
                    number /= 10;

                    if (i == factorial.Count - 1)
                    {
                        factorial.Add(number);
                    }
                    else
                    {
                        factorial[i + 1] += number;
                    }
                }
            }
        }

    }
}
