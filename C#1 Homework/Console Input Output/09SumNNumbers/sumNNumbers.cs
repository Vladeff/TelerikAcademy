/*Problem 9. Sum of n Numbers

Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop. */

using System;

    class sumNNumbers
   {
        static void Main()
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter {0} from {1} numbers = ", i + 1, n);
                double newNumber = double.Parse(Console.ReadLine());
                sum += newNumber;
            }
            Console.WriteLine("The sum is " + sum);
        }
    }

