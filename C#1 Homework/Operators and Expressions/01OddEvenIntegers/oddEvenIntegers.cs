/*1. Odd or Even Integers

Write an expression that checks if given integer is odd or even.*/

using System;

class oddEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        string str = Console.ReadLine();
        int number = int.Parse(str);

        if (number % 2 == 0)
        {
            Console.WriteLine("You entered {0} ,which is even number.", number);

        }
        else

            Console.WriteLine("You entered {0} ,which is odd number.", number);
    }
}

