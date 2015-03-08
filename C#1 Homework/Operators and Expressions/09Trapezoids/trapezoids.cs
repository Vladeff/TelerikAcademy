/*Problem 9. Trapezoids

Write an expression that calculates trapezoid's area by given sides a and b and height h.*/

using System;

class trapezoids
{
    static void Main()
    {
        Console.Write("Please enter length of side a: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Please enter length of side b: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Please enter height h: ");
        double height = double.Parse(Console.ReadLine());
        double trapezoidArea = height * (sideA + sideB) / 2;
        Console.WriteLine("The area of a trapezoid with sides a = " + sideA + ", b = " + sideB + ", and height = " + height + " is " + trapezoidArea);
    }
}

