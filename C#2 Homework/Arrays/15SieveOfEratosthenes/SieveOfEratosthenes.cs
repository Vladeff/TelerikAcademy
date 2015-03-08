/*Problem 15. Prime numbers

Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
*/

using System;

class SieveOfEratosthenes
{
    static void Main()
    {
        bool[] primes = new bool[10000000];

        
        for (int i = 2; i < Math.Sqrt(primes.Length); i++)
        {
            if (primes[i] == false)
            {
                for (int j = i * i; j < primes.Length; j += i)
                {
                    primes[j] = true;
                }
            }
        }

        {
            if (!primes[i]) Console.Write(i + " ");
        }
    }
}