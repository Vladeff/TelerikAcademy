/*Problem 6. Sum integers

You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.*/﻿

using System;
using System.Linq;

class SumIntegers
{
    public static long SumArray(string numbers)
    {
        int[] array = numbers.Split(' ').Select(int.Parse).ToArray();
        return array.Sum();
    }
    static void Main()
    {
        Console.WriteLine("Enter array of integers, separated by spaces (1 2 3 ...): ");
        string input = Console.ReadLine();

        Console.WriteLine("The sum of the entered numbers is: {0}", SumArray(input));

    }

    
}