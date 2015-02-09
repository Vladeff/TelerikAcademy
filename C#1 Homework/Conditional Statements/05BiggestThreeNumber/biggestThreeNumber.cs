/*Problem 5. The Biggest of 3 Numbers

Write a program that finds the biggest of three numbers.*/

using System;

class biggestThreeNumber
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

       double biggest = a;

        if (b > biggest)
        {
            biggest = b;
        }
        if (c > biggest)
        {
            biggest = c;
        }
        Console.WriteLine(biggest);
        }
    }


