using System;

class InitializeArrayOfTwentyElements
{
    static void Main()
    {
        //Write a program that allocates array of 20 integers and initializes each element by 
        //its index multiplied by 5. Print the obtained array on the console.

        int[] array = new int[20];

        //Assigning values
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 5;
        }

        //Print the array
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
