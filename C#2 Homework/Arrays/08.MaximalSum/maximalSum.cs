using System;

//Problem 8. Maximal sum

//Write a program that finds the sequence of maximal sum in given array.
//Example:

//input	                                result
//2, 3, -6, -1, 2, -1, 6, 4, -8, 8	    2, -1, 6, 4

class maximalSum
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
       
        int start, end, tempStart;
        int maxSum = int.MinValue, sum = 0;
        start = end = tempStart = 0;

        for (int i = 0; i < size; i++)
        {
            sum += numbers[i];
            if (sum > maxSum)
            {
                maxSum = sum;
                end = i; 
                start = tempStart;
            }
            if (sum <= 0)
            {
                sum = 0;
                tempStart = i + 1;
            }

        }

        for (int i = start; i <= end; i++)
        {
            Console.Write(numbers[i] + (i != end ? ", " : ""));
        }

        Console.WriteLine();

    }
}