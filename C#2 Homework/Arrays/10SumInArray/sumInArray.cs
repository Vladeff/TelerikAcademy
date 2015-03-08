//Problem 10. Find sum in array

//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:

//array	                    S	                result
//4, 3, 1, 4, 2, 5, 8	    11	                4, 2, 5
﻿


using System;


class sumInArray
{
    static void Main()
    {
        Console.WriteLine("Size:");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("S:");
        int s = int.Parse(Console.ReadLine());
        Console.WriteLine("Array:");

        int[] numbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }


        bool exists = false;


        for (int i = 0; i < size && !exists; i++)
        {
            int sum = numbers[i];
            string sequence = numbers[i] + ",";

            for (int j = i + 1; j < size && !exists; j++)
            {
                sum += numbers[j];
                sequence += numbers[j] + ",";

                if (sum == s)
                {
                    Console.WriteLine(sequence.TrimEnd(','));
                    exists = true;
                }

            }

        }


        if (!exists)
        {
            Console.WriteLine("Nada");
        }
    }
}