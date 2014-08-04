using System;

class SortArray
{
    static void Main()
    {
        //Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
        //Use the "selection sort" algorithm: Find the smallest element, move it at the first position, 
        //find the smallest from the rest, move it at the second position, etc.

        Console.Write("This program will sort(ascending) array with N integer numbers.\nEnter N = ");
        int N = int.Parse(Console.ReadLine());
        int[] nums = new int[N];
        Console.WriteLine("Enter elements of the array:");

        for (int i = 0; i < N; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = i; j < N; j++)
            {
                if (nums[i] > nums[j])
                {                       //For example:
                    nums[i] ^= nums[j]; // 10 ^ 5 = 1010 ^ 0101 = 1111
                    nums[j] ^= nums[i]; // 0101 ^ 1111 = 1010 == 10
                    nums[i] ^= nums[j]; // 1111 ^ 1010 = 0101 == 5
                }  // Swapping their values!
            }
        }

        Console.WriteLine("This is the sorted array:");
        for (int i = 0; i < N; i++)
        {
            Console.Write(nums[i] + " ");
        }
    }
}
