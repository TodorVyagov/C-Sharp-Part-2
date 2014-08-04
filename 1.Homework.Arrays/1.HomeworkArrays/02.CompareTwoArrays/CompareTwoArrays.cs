using System;
 
class CompareTwoArrays
{
    static void Main()
    {
        //Write a program that reads two arrays from the console and compares them element by element.
        //I think that the arrays need to have equal number of elements.
        //And it will be easier if we use only integer numbers, but it is also easy to change.

        Console.WriteLine("This program will compare two arrays element by element.");
        Console.Write("Enter size of arrays: ");
        int size = int.Parse(Console.ReadLine());
        int[] arrOne = new int[size];
        int[] arrTwo = new int[size];

        Console.WriteLine("Enter values of elements in the FIRST array:");
        for (int i = 0; i < size; i++)
        {
            Console.Write("arrOne[{0}] = ", i);
            arrOne[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter values of elements in the SECOND array:");
        for (int i = 0; i < size; i++)
        {
            Console.Write("arrTwo[{0}] = ", i);
            arrTwo[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < size; i++)
        {
            Console.Write("Comparing arrays element number {0}: ", i + 1);
            if (arrOne[i] == arrTwo[i])
            {
                Console.WriteLine(arrOne[i] + " = " + arrTwo[i]);

            }
            else if (arrOne[i] > arrTwo[i])
            {
                Console.WriteLine(arrOne[i] + " > " + arrTwo[i]);
            }
            else //arrOne[i] < arrTwo[i]
            {
                Console.WriteLine(arrOne[i] + " < " + arrTwo[i]);
            }
        }
    }
}
