/*Problem 10. Point Inside a Circle & Outside of a Rectangle

Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2)*/

using System;


class pointInsideCircleOutsideRectangle
{
    static void Main()
    {
        Console.Write("Please enter coordinate X: ");
        double coordX = double.Parse(Console.ReadLine());
        Console.Write("Please enter coordinate Y: ");
        double coordY = double.Parse0(Console.ReadLine());
        double r = 1.5;
        bool withinCircle = ((coordX - 1) * (coordX - 1) + (coordY - 1) * (coordY - 1)) <= Math.Pow(r, 2);
        bool outsideRect = ((coordX < -1) || (coordX > 5) || (coordY > 1) || (coordY < -1));
        bool checkC = withinCircle && outsideRect;
        Console.WriteLine("Point (x,y) with coordinates (" + coordX + "," + coordY + ") is within circle K and outside the rectangle R --> " + checkC);
    }
}

