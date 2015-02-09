/*Problem 4. Number Comparer

Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.*/

using System;

class numberComparer
{
    static void Main()
    {
        Console.WriteLine("Please, enter two real numbers to compare");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        while (a > b)
        {
            Console.WriteLine("{0} > {1}", a, b);
            break;
        }
        while (a < b)
        {
            Console.WriteLine("{0} < {1}", a, b);
            break;
        }
        while (a == b)
        {
            Console.WriteLine("{0} = {1}", a, b);
            break;
        }
    }
}

