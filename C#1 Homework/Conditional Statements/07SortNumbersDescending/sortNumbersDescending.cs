/*Problem 7. Sort 3 Numbers with Nested Ifs

Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.
Note: Don’t use arrays and the built-in sorting functionality.*/

using System;

    class sortNumbersDescending
    {
        static void Main()
        {            
           
            Console.WriteLine("Please, enter three numbers to sort in descending order.");
            Console.WriteLine("Enter the a number");           
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the b number");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the c number");
            double c = double.Parse(Console.ReadLine());

            if (c > b)
            {
                c = c + b;
                b = c - b;
                c = c - b;
            }
            if (c > a)
            {
                c = c + a;
                a = c - a;
                c = c - a;
            }
            if (b > a)
            {
                b = b + a;
                a = b - a;
                b = b - a;
            }
            Console.WriteLine("{0} {1} {2}", a, b, c);


        }
    }
