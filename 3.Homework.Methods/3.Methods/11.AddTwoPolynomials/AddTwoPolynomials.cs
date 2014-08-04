//Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//x^2 + 5 = 1x^2 + 0x + 5 -> arr{5, 0 , 1};
using System;

namespace AddTwoPolynomials
{
    class AddTwoPolynomials
    {
        static void Main()
        {
            int[] polynomialOne = new int[3];
            int[] polynomialTwo = new int[3];
            Console.WriteLine("This program will add two polynomials.\na*x^2 + b * x + c\nEnter coefficients of first polynomial:");

            for (int i = 1; i <= 2; i++)
            {
                for (int j = 0; j < polynomialOne.Length; j++)
                {
                    switch (j)
                    {
                        case 0: Console.Write("a{0} = ", i); break;
                        case 1: Console.Write("b{0} = ", i); break;
                        case 2: Console.Write("c{0} = ", i); break;
                    }
                    switch (i)
                    {
                        case 1: polynomialOne[j] = int.Parse(Console.ReadLine()); break;
                        case 2: polynomialTwo[j] = int.Parse(Console.ReadLine()); break;
                    }
                }
            }
            int[] resultPolynomial = AddPolynomials(polynomialOne, polynomialTwo);

            Console.WriteLine("Result polynomial is:");
            Console.WriteLine("{0}*x^2 + {1}*x + {2}.", resultPolynomial[2], resultPolynomial[1], resultPolynomial[0]);
        }

        static int[] AddPolynomials(int[] polynomialOne, int[] polynomialTwo)
        {
            for (int i = 0; i < polynomialOne.Length; i++)
            {
                polynomialOne[i] += polynomialTwo[i];
            }
            return polynomialOne;
        }
    }
}
