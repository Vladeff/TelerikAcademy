﻿//Problem 9. Frequent number

//Write a program that finds the most frequent number in an array.
//Example:

//input	                                        result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	        4 (5 times)


using System;


class frequentNumber
{
    static void Main()
    {
        Console.WriteLine("Size:");
        int size = int.Parse(Console.ReadLine());
        int[] numbers = new int[size];

        Console.WriteLine("Array:");
        for (int i = 0; i < size; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }


        Array.Sort(numbers);

        int count = 0, tempcount = 0;
        int Element = 0; 


        for (int i = 1; i < size; i++)
        {
            while (i < size)
            {
                if (numbers[i - 1] == numbers[i])
                {
                    tempcount++;
                    i++;
                }
                else
                {
                    break;
                }

            }

            if (count <= tempcount && Element < numbers[i - 1])
            {
                Element = numbers[i - 1];
                count = tempcount;
                tempcount = 0;
            }
            // reset
            tempcount = 0;
        }

        Console.WriteLine(Element);
    }
}
