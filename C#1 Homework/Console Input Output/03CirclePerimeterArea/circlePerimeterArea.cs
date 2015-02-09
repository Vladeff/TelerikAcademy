/*Problem 3. Circle Perimeter and Area

Write a program that reads the radius r of a circle and prints its perimeter and area formatted 
 * with 2 digits after the decimal point. */

using System;

class circlePerimeterArea
    {
        static void Main()
        {
           
            Console.WriteLine("Please write radius in:");
            double r = double.Parse(Console.ReadLine());
            double perimeter = ((r * 2) * Math.PI);
            double area = (Math.PI * Math.Pow(r, 2));
            Console.WriteLine("The perimeter of circle is {0:F2}", perimeter);
            Console.WriteLine("The area is                {0:F2}", area);
        }
    }

