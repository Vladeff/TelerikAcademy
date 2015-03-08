﻿using System;

//Problem 6. Maximal K sum

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

class maxKSum
{
    static void Main()
    {
        Console.WriteLine("N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("K");
        int k = int.Parse(Console.ReadLine());

        
        int[] arr = new int[n];
        Console.WriteLine("Array:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);

        string elements = "";

        for (int i = arr.Length - 1; i > arr.Length - 1 - k; i--)
        {
            elements += arr[i] + ",";
        }

        Console.WriteLine(elements.TrimEnd(','));

    }
}