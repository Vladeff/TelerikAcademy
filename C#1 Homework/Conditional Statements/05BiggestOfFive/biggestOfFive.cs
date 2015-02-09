/*Problem 6. The Biggest of Five Numbers

Write a program that finds the biggest of five numbers by using only five if statements.*/

using System;

class biggestOfFive
{
    static void Main()
    {
        Console.WriteLine("Please, enter three numbers to show you the biggest.");
        Console.Write("a=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c=");
        double c = double.Parse(Console.ReadLine());
        Console.Write("c=");
        double d = double.Parse(Console.ReadLine());
        Console.Write("c=");
        double e = double.Parse(Console.ReadLine());

        double biggest = a;

        if (b > biggest)
        {
            biggest = b;
        }
        if (c > biggest)
        {
            biggest = c;
        }
        if (d > biggest)
        {
            biggest = d;
        }
        if (e > biggest)
        {
            biggest = e;
        }
        Console.WriteLine("Biggest: " + biggest);
    }
}

