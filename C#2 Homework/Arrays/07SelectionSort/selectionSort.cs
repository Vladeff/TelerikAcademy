﻿using System;

//Problem 7. Selection sort

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the
//smallest from the rest, move it at the second position, etc.

class selectionSort
{
    static void Main()
    {
       
        int[] numbers = { 1, -2, 3, -4, 5, -6, -7, 8, -9, 11, 12 };

       
        for (int i = 0; i < numbers.Length; i++)
        {
          
            int min = i;
            for (int j = 1 + i; j < numbers.Length; j++)
            {
                if (numbers[min] > numbers[j])
                {
                    min = j;
                }
            }

            if (i != min)
            {
                numbers[i] += numbers[min];
                numbers[min] = numbers[i] - numbers[min];
                numbers[i] -= numbers[min];
            }

        }

        foreach (var item in numbers)
        {
            Console.Write(item + " ");
        }
    }
}