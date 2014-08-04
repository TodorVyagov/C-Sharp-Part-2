using System;

class FindLargestNumberLessThanOrEqualToKInArray
{
    static void Main()
    {
        //Write a program, that reads from the console an array of N integers and an integer K, sorts the array 
        //and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

        Console.WriteLine("This program will read an array of N integers and an integer K and will find the largest number in the array which is ≤ K.");
        Console.Write("Enter size of array N = ");
        int N = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[N];

        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            Console.Write("Enter arr[{0}] = ", i);
            arrayOfNumbers[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter K = ");
        int K = int.Parse(Console.ReadLine());

        //Printing array before sort:
        Console.WriteLine("Array before sort:");
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            Console.Write(arrayOfNumbers[i] + " ");
        }
        Console.WriteLine();
        Sort(arrayOfNumbers);

        //Printing array after sort:
        Console.WriteLine("Array after sort:");
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            Console.Write(arrayOfNumbers[i] + " ");
        }
        Console.WriteLine();
        int indexOfLargestNumber = -1;
        
        for (int i = K; i >= 0; i--)
        {
            indexOfLargestNumber = Array.BinarySearch(arrayOfNumbers, i);

            if (indexOfLargestNumber >= 0)
            {
                break;
            }
        }

        Console.WriteLine("Largest number lower or equal to K({2}) is arr[{1}] = {0}", arrayOfNumbers[indexOfLargestNumber] ,indexOfLargestNumber, K);
    }

    static void Sort(int[] arrayOfNumbers)
    {
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            for (int j = i; j < arrayOfNumbers.Length; j++)
            {
                if (arrayOfNumbers[i] > arrayOfNumbers[j])
                {
                    int temp = arrayOfNumbers[i];
                    arrayOfNumbers[i] = arrayOfNumbers[j];
                    arrayOfNumbers[j] = temp;
                }
            }
        }


    }
}
