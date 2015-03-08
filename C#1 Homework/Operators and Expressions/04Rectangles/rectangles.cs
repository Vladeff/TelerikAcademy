/*Problem 4. Rectangles

Write an expression that calculates rectangle’s perimeter and area by given width and height.*/
//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.


using System;

class rectangles
{
    static void Main()
    {       
        Console.Write("Please enter width: ");
        double recWidth = Convert.ToDouble(Console.ReadLine());
        Console.Write("Please enter height: ");
        double recHeight = Convert.ToDouble(Console.ReadLine());
        double recleArea = recWidth * recHeight;
        double recPerimeter = 2 * (recWidth + recHeight);
        Console.WriteLine("Width: {0}\n Height: {1}\n Perimeter: {2}\n Area: {3}", recWidth, recHeight, recPerimeter, recleArea);
    }
}

