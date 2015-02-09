/*Problem 8. Prime Number Check

Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive*/

using System;

class primeNumberCheck
{
    static void Main()
    {
        Console.Write("Please enter an integer >= 2: ");
        int input = int.Parse(Console.ReadLine());
        bool isPrime = true;
        for (int i = 2; i <= Math.Sqrt(input); i++)
        {
            if (input % i == 0)
            {
                isPrime = false;
            }
        }
        if (isPrime)
        {
            Console.WriteLine(input + " is prime.");
        }
        else
        {
            Console.WriteLine(input + " is not prime.");
        }
    }
}

