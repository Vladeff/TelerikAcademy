/*Problem 6. Quadratic Equation

Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).*/

using System;

class quadraticEquation
{
    static void Main()
    {

        Console.WriteLine("In the equation ax2 + bx + c = 0 :");
        Console.Write("a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c= ");
        double c = double.Parse(Console.ReadLine());

        double discr = ((b * b) - (4 * a * c));

        double rootOne;
        double rootTwo;

        if (a != 0)
        {
            if (discr < 0)
            {
                Console.WriteLine("No real roots");
            }
            else if (discr == 0)
            {
                rootOne = rootTwo = (-b / (2 * a));
                Console.WriteLine("x1 == x2 = {0}", rootOne);
            }
            else
            {
                rootOne = (-b + Math.Sqrt(discr)) / (2 * a);
                rootTwo = (-b - Math.Sqrt(discr)) / (2 * a);
                Console.WriteLine("roots: x1 = {0};\nx2 = {1}", rootOne, rootTwo);
            }
        }
        else
        {
            rootOne = rootTwo = (-c / b);
            Console.WriteLine("x1 == x2 = {0}", rootOne);
        }
    }
}
