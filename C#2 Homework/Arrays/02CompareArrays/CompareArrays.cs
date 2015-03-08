/*Problem 2. Compare arrays

Write a program that reads two integer arrays from the console and compares them element by element. */

using System;

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Comparing two arrays.Enter size of the arrays");    
        int sise = int.Parse(Console.ReadLine());
        int[] arr1 = new int[sise];
        int[] arr2 = new int[sise];


        Console.WriteLine("Enter {0} integers of the first array:", sise);
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write("arr[{0}]: ",i);
            arr1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter {0} integers of the second array:", sise);
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.Write("arr[{0}]: ", i);
            arr2[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < sise; i++)
        {
            if (arr1[i] < arr2[i])
            {
                Console.WriteLine("{0} < {1}",arr1[i],arr2[i]);
            }
            else if (arr1[i] > arr2[i])
            {
                Console.WriteLine("{0} > {1}", arr1[i], arr2[i]);
            }
            else if (arr1[i] == arr2[i])
            {
                Console.WriteLine("{0} = {1}", arr1[i], arr2[i]);
            }
        }
    }
}

