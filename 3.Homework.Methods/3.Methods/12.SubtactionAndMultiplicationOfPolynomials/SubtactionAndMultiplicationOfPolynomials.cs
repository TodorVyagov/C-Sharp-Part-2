//Extend the program to support also subtraction and multiplication of polynomials.
using System;

namespace SubtactionAndMultiplicationOfPolynomials
{
    class SubtactionAndMultiplicationOfPolynomials
    {
        static void Main()
        {
            Console.WriteLine("This program will subtract and multiply two polynomials.");
            Console.WriteLine("There are linear polynomials, quadratic polynomials and cubic polynomials.\nFor higher degrees the specific names are not commonly used,\nalthough quartic polynomial (for degree four)and quintic polynomial (for degree five) are sometimes used.");
            Console.Write("Enter degree of polynomial 1 = ");
            //The values have to be  degree >= 0, 0 means that we will have only number or a*x^0 = a
            int degreeOfPolynomialOne = int.Parse(Console.ReadLine());
            int[] polynomialOne = new int[degreeOfPolynomialOne + 1];
            Console.Write("Enter degree of polynomial 2 = ");
            int degreeOfPolynominalTwo = int.Parse(Console.ReadLine());
            int[] polynomialTwo = new int[degreeOfPolynominalTwo + 1];
            
            Console.WriteLine("Enter coefficients of polynomial 1:");
            for (int i = polynomialOne.Length - 1; i >= 0 ; i--)
            {
                Console.Write("Coef. of x^{0} is ", i);
                polynomialOne[i] = int.Parse(Console.ReadLine()); 
                //the degree of X corresponds to its index in the array and is easier to understand the program
            }

            Console.WriteLine("Enter coefficients of polynomial 2:");
            for (int i = polynomialTwo.Length - 1; i >= 0 ; i--)
            {
                Console.Write("Coef. of x^{0} is ", i);
                polynomialTwo[i] = int.Parse(Console.ReadLine());
            }
            //Sum of polinomials
            int[] resultOfSumArray = SumPolynomials(polynomialOne, polynomialTwo);
            Console.WriteLine("Result of polynomial sum is:");
            PrintPolynomial(resultOfSumArray);

            //Subtraction 
            int[] resultOfSubtractionArray = SubtractPolynomials(polynomialOne, polynomialTwo);
            Console.WriteLine("Result of polynomial subtraction is:");
            PrintPolynomial(resultOfSubtractionArray);

            //Multiplication
            int[] resultOfMultiplication = MultiplicatePolinomials(polynomialOne, polynomialTwo);
            Console.WriteLine("Result of polynomials multiplication is:");
            PrintPolynomial(resultOfMultiplication);
            
        }

        static int[] SumPolynomials(int[] polynomialOne, int[] polynomialTwo)
        {
            int[] resultPolynomial = CopyLongerFromTwoArrays(polynomialOne, polynomialTwo);

            if (polynomialOne.Length >= polynomialTwo.Length)
            {
                for (int i = 0; i < polynomialTwo.Length; i++)
                {
                    resultPolynomial[i] = polynomialOne[i] + polynomialTwo[i];
                }
            }
            else
            {
                for (int i = 0; i < polynomialOne.Length; i++)
                {
                    resultPolynomial[i] = polynomialOne[i] + polynomialTwo[i];
                }
            }
            return resultPolynomial;
        }

        static int[] SubtractPolynomials(int[] polynomialOne, int[] polynomialTwo)
        {
            int[] resultPolynomial = CopyLongerFromTwoArrays(polynomialOne, polynomialTwo);

            if (polynomialOne.Length >= polynomialTwo.Length)
            {
                for (int i = 0; i < polynomialTwo.Length; i++)
                {
                    resultPolynomial[i] = polynomialOne[i] - polynomialTwo[i];
                }
            }
            else
            {
                for (int i = 0; i < polynomialOne.Length; i++)
                {
                    resultPolynomial[i] = polynomialOne[i] - polynomialTwo[i];
                }
            }
            return resultPolynomial;
        }

        static int[] MultiplicatePolinomials(int[] polynomialOne, int[] polynomialTwo)
        {
            int[] resultPolynomial = new int[polynomialOne.Length + polynomialTwo.Length - 1];

            for (int i = 0; i < polynomialOne.Length; i++)
            {
                for (int j = 0; j < polynomialTwo.Length; j++)
                {
                    resultPolynomial[i + j] += polynomialOne[i] * polynomialTwo[j];
                    //This means (a*x^i) * (b*x^j) = a*b*x^(i+j)  
                }
            }
            return resultPolynomial;
        }

        static int[] CopyLongerFromTwoArrays(int[] arrayOne, int[] arrayTwo)
        {
            int[] longerArray;
            if (arrayOne.Length >= arrayTwo.Length)
            {
                longerArray = new int[arrayOne.Length];

                for (int i = 0; i < longerArray.Length; i++)
			    {
                    longerArray[i] = arrayOne[i];
			    }
            }
            else
            {
                longerArray = new int[arrayTwo.Length];

                for (int i = 0; i < longerArray.Length; i++)
                {
                    longerArray[i] = -arrayTwo[i];
                }
            }
            return longerArray;
        }

        static void PrintPolynomial(int[] polynomial)
        {
            bool isEmpty = true;//check if there are only Zeros in the polynomial(possible in subtraction or if we are multipliing by 0)

            for (int i = polynomial.Length - 1; i >= 0; i--)
            {
                if (polynomial[i] != 0)
                {
                    switch (i)
                    {
                        case 0: Console.Write("{0} + ", polynomial[i]); break;
                        case 1: Console.Write("{0}*x + ", polynomial[i], i); break;
                        default: Console.Write("{0}*x^{1} + ", polynomial[i], i); break;
                    }
                    isEmpty = false;
                }
            }
            if (!isEmpty)
            {
                Console.Write("\b\b \n");//deletes the last "+ "
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
