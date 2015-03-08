//Problem 2. Random numbers

//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class RandomNumbers
{
    static Random rnd = new Random();
    static double GetRandomNumber(int from, int to)
    {
        double randomValue = rnd.NextDouble() * Math.Min(from, to) + (Math.Max(from, to) - Math.Min(from, to));
        int intNumber = (int)randomValue;
        return intNumber;
    }
    static void Main()
    {
        Console.WriteLine("10 random values from 100 to 200: ");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(GetRandomNumber(100, 200));
        }
    }

    
}