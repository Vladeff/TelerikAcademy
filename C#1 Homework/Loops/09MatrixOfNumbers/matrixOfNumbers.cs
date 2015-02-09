/*Problem 9. Matrix of Numbers

Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
 * and prints a matrix like in the examples below. Use two nested loops.*/

using System;

    class matrixOfNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter integer number n (1 ≤ n ≤ 20) ");
            Console.Write("n =");
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int coll = 0; coll < n; coll++)
                {
                    Console.Write("{0,-2} ", coll + row);
                }
                Console.WriteLine();
            }


        }
    }

