using System;

class SieveOfEratosthenes
{
    static void Main()
    {
        //Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm.

        Console.WriteLine("This program will find all prime numbers in the range [1...10 000 000] using the sieve of Eratosthenes algorithm");
        int N = 10000000; //you may use little numbers to test program, because printing prime numbers up to 10'000'000 is very slow operation. 
        bool[] isPrimeNumber = new bool[N];

        for (int i = 2; i < N; i++)
        {
            isPrimeNumber[i] = true;
        }

        for (int i = 2; i < Math.Sqrt(N); i++)
        {
            for (int j = i * i ; j < N; j += i)
            {
                isPrimeNumber[j] = false;
            }
        }

        //Printing 
        int counter = 0;
        for (int i = 0; i < N; i++)
        {
            if (isPrimeNumber[i] == true)
            {
                Console.Write("{0, 8}", i);
                counter++;
            
                if (counter % 10 == 0)//this is to print only 10 numbers at a line
                {
                    Console.WriteLine();
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine(counter);
    }
}
