/*Problem 1. Allocate array

Write a program that allocates array of 20 integers and initializes 
each element by its index multiplied by 5.
Print the obtained array on the console.*/

using System;
using System.Collections.Concurrent;
class AllocateArray
{
    static void Main()
    {
        Console.WriteLine("Please, enter 20 integers to multiply by 5:");
        int[] numberArray = new int[20];

        for (int i = 0; i < numberArray.Length; i++)
        {
            numberArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < numberArray.Length; i++)
        {
            int newValue = numberArray[i] * 5;
            Console.WriteLine("{0} * 5 = {1}",numberArray[1],  newValue);
        }
    }
}

