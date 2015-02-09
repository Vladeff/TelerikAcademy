/*Problem 12. Null Values Arithmetic

Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.*/

using System;

class nullValuesArithmetic
{
    static void Main()
    {
        int? integerVal;
        double? doubleVal;

        integerVal = null;
        doubleVal = null;

        Console.WriteLine("Print vars without assigned value:");
        Console.WriteLine("Integer - {0}", integerVal);
        Console.WriteLine("Double - {0}", doubleVal);

        Console.WriteLine();

        integerVal = 1;
        doubleVal = 1.5;

        Console.WriteLine("Print vars with assigned value:");
        Console.WriteLine("Integer - {0}", integerVal);
        Console.WriteLine("Double - {0}", doubleVal);


    }
}

