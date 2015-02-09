/*Problem 6. Calculate N! / K!

Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.*/


using System;
using System.Numerics;
    class CalculateNK
    {
        static void Main()
        {
            Console.WriteLine("Enter two integers numbers1 < k < n < 100 : ");
            Console.Write("n =");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k =");
            int k = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            while (100 >=n && n > k && k >1)
            {
                result *= n;
                n--;
            }
            Console.WriteLine(result);

        }
    }
