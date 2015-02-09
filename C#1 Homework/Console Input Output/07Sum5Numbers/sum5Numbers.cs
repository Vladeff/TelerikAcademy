/*Problem 7. Sum of 5 Numbers

Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.*/

using System;

class sum5Numbers
{
    static void Main()
    {
        Console.WriteLine("Please, enter FIVE numbers in a single line, separated by a space, to calculate:");
        string[] input = Console.ReadLine().Split();

        double a = double.Parse(input[0]);
        double b = double.Parse(input[1]);
        double c = double.Parse(input[2]);
        double d = double.Parse(input[3]);
        double e = double.Parse(input[4]);

        Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}",a,b,c,d,e,  (a+b+c+d+e));
    }
}

