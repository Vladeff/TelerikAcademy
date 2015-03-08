/*Problem 6. Four-Digit Number

Write a program that takes as input a four-digit number in format abcd (e.g. 2011)
 * and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.*/

using System;


class Program
{
    static void Main()
    {
        Console.Write("Please enter a 4-digit number: ");
        int numA = (Console.Read());
        char chA = (char)numA;
        int a = (int)Char.GetNumericValue(chA);

        int numB = (Console.Read());
        char chB = (char)numB;
        int b = (int)Char.GetNumericValue(chB);

        int numC = (Console.Read());
        char chC = (char)numC;
        int c = (int)Char.GetNumericValue(chC);

        int numD = (Console.Read());
        char chD = (char)numD;
        int d = (int)Char.GetNumericValue(chD);

        Console.WriteLine((a + b + c + d));

        if (d != 0 && c != 0 && b != 0)
        {
            Console.WriteLine("{0}{1}{2}{3}", d, c, b, a); //dcba

        }

        else
            Console.WriteLine("Error!");
        if (d != 0)
        {
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c); //dabc
        }

        else
            Console.WriteLine("Error!");

        if (a != 0)
        {
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d); //acbd
        }
        else
            Console.WriteLine("Error!");

      


    }
}
