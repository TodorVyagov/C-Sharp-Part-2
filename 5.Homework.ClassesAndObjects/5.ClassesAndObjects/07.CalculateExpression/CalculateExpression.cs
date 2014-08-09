/*Write arithmeticOperator program that calculates the value of given arithmetical readLine. The readLine can contain the following elements only:
Real numbers, e.g. 5, 18.33, 3.14159, 12.6
Arithmetic operators: +, -, *, / (standard priorities)
Mathematical functions: ln(x), sqrt(x), pow(x,y)
Brackets (for changing the default priorities)
	Examples:
	(3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7) -> ~ 10.6
	pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3) -> ~ 21.22*/

using System;
using System.Collections.Generic;

namespace CalculateExpression
{
    public class CalculateExpression
    {
        public static List<char> arithmeticOperators = new List<char>() {'+', '-', '*', '/' };
        public static List<char> brackets = new List<char>() { '(', ')' };
        public static List<string> functions = new List<string>() { "pow", "sqrt", "ln" };

        public static int Precedence(char arithmeticOperator)
        {
            int result = 0;
            if (arithmeticOperator == '+' || arithmeticOperator == '-')
            {
                result = 1;
            }
            else
	        {
                result = 2;
	        }
            return result;
        }

        public static Queue<string> ShuntingYardAlgorithm(List<string> tokens)
        {
            Queue<string> queue = new Queue<string>();
            Stack<string> stack = new Stack<string>();

            for (int indexofToken = 0; indexofToken < tokens.Count; indexofToken++)
            {
                string token = tokens[indexofToken];
                double number;
                
                if (double.TryParse(token, out number))
                {
                    queue.Enqueue(token);
                }
                else if (functions.Contains(token))
                {
                    stack.Push(token);
                }
                else if (token == ",")
                {
                    while (stack.Count > 0 && stack.Peek() != "(")
                    {
                        queue.Enqueue(stack.Pop());
                    }

                    if (stack.Peek() != "(")
                    {
                        throw new ArgumentException("Wrong use of parentheses!");
                    }
                }
                else if (token == "(")
                {
                    stack.Push(token);
                }
                else if (arithmeticOperators.Contains(token[0]))
                {
                    while (stack.Count > 0 && arithmeticOperators.Contains(stack.Peek()[0]) && Precedence(token[0]) <= Precedence(stack.Peek()[0]))
                    {
                        queue.Enqueue(stack.Pop());
                    }
                    stack.Push(token);
                }
                else if (token == ")")
                {
                    while (stack.Count > 0 && stack.Peek() != "(")
                    {
                        queue.Enqueue(stack.Pop());
                    }

                    if (stack.Peek() != "(")
                    {
                        throw new ArgumentException("Wrong use of parentheses!");
                    }
                    else
                        stack.Pop();

                    if (stack.Count > 0 && functions.Contains(stack.Peek()))
                    {
                        queue.Enqueue(stack.Pop());
                    }
                }
            }

            while (stack.Count > 0)
            {
                if (brackets.Contains(stack.Peek()[0]))
                {
                    throw new ArgumentException("Wrong use of parentheses!");
                }
                queue.Enqueue(stack.Pop());
            }

            return queue;
        }

        public static List<string> ConvertStringToTokenList(string expression)
        {
            List<string> tokens = new List<string>();
            expression.ToLower();

            for (int indexOfChar = 0; indexOfChar < expression.Length; indexOfChar++)
            {
                string currentSymbol = expression[indexOfChar].ToString();

                if (char.IsDigit(currentSymbol[0]) || currentSymbol == "-")
                {
                    string currentNumber = string.Empty;
                    if (currentSymbol == "-")
	                {
		                if (tokens.Count == 0)
                        {
                            currentNumber += currentSymbol;
                            indexOfChar++;
                        }
                        else if ((tokens[tokens.Count - 1] == "(" || tokens[tokens.Count - 1] == ","))
                        {
                            currentNumber += currentSymbol;
                            indexOfChar++;
                        }
                        else
                        {
                            tokens.Add(currentSymbol);
                            continue;
                        }
	                }
                    
                    while (indexOfChar < expression.Length)
                    {
                        currentNumber += expression[indexOfChar].ToString();
                        indexOfChar++;
                        if ((indexOfChar < expression.Length - 1) && !(char.IsDigit(expression[indexOfChar]) || expression[indexOfChar] == '.'))
                        {
                            break;
                        }
                    }
                    indexOfChar--;

                    tokens.Add(currentNumber);
                }
                else if (arithmeticOperators.Contains(currentSymbol[0]) || brackets.Contains(currentSymbol[0]) || currentSymbol == ",")
                {
                    tokens.Add(currentSymbol.ToString());                
                }
                
                else if (char.IsLetter(currentSymbol[0]))
                {
                    while (true)
                    {
                        indexOfChar++;
                        currentSymbol += expression[indexOfChar]; 

                        if (functions.Contains(currentSymbol))
                        {
                            tokens.Add(currentSymbol);
                            break;
                        }
                        else if (currentSymbol.Length > 4)
                        {
                            throw new ArgumentException("Invalid name of function or other text!");
                        }
                        
                    }
                }
                else if (currentSymbol == " ") //removes whitespaces
                {
                    continue;
                }
                else 
                {
                    throw new ArgumentException("Invalid symbol in the expression!");
                }

            }


            return tokens;
        }

        public static double ReversePolishNotation(Queue<string> tokens)
        {
            Stack<double> stack = new Stack<double>();

            while (tokens.Count > 0)
            {
                string token = tokens.Dequeue();
                double number;

                if (double.TryParse(token, out number))
                {
                    stack.Push(number);
                }
                else if (arithmeticOperators.Contains(token[0]))
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid expression! Not enough arguments!");
                    }
                    double secondNum = stack.Pop();
                    double firstNum = stack.Pop();
                    
                    if (token == "+")
                    {
                        stack.Push(firstNum + secondNum);
                    }
                    else if (token == "-")
                    {
                        stack.Push(firstNum - secondNum);
                    }
                    else if (token == "*")
                    {
                        stack.Push(firstNum * secondNum);
                    }
                    else if (token == "/")
                    {
                        stack.Push(firstNum / secondNum);
                    }
                }
                else if (token == "pow")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid expression! Not enough arguments!");
                    }
                    double power = stack.Pop();
                    double numberToPower = stack.Pop();
                    stack.Push(Math.Pow(numberToPower, power));
                }
                else if (token == "sqrt")
                {
                    if (stack.Count < 1)
                    {
                        throw new ArgumentException("Invalid argument for square root!");
                    }
                    double numberToSquareRoot = stack.Pop();
                    stack.Push(Math.Sqrt(numberToSquareRoot));
                }
                else if (token == "ln")
                {
                    if (stack.Count < 1)
                    {
                        throw new ArgumentException("Invalid argument for natural logarithm!");
                    }
                    double numberToLn = stack.Pop();
                    stack.Push(Math.Log(numberToLn)); 
                }
            }

            if (stack.Count != 1)
            {
                throw new ArgumentException("Invalid expression!");
            }
            return stack.Pop();
        }

        static void Main()
        {
            Console.WriteLine("This program will calculate given by user mathematical expression.\nAllowed arithmetical operators are: +, -, * and /.");
            Console.WriteLine("Allowed functions are:\npow(number, power)\nsqrt(number) - returns the square root of number\nln(number) - returns the natural logarithm of number");
            //Read arithmeticOperator expression as string.
            Console.Write("Expression = ");
            string expression = Console.ReadLine();

            //Separate tokens.
            var tokens = ConvertStringToTokenList(expression);

            //Arrange tokens by the Shunting-yard algorithm.
            var postfixNotation = ShuntingYardAlgorithm(tokens);

            //Calculate result by the reverse polish notation(postfix).
            var result = ReversePolishNotation(postfixNotation);

            Console.WriteLine("The result of expression is: {0}", result);
            Console.ReadLine();
        }

    }
}
