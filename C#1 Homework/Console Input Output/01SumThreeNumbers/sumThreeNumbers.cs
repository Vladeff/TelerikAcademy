﻿/*Problem 1. Sum of 3 Numbers

Write a program that reads 3 real numbers from the console and prints their sum.*/

using System;

class sumThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Please, enter three real numbers to sum.");
        Console.Write("a=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c=");
        double c = double.Parse(Console.ReadLine());        

        Console.WriteLine("a+b+c={0}", (a + b + c));
    }
}

