/*Problem 11. Bitwise: Extract Bit #3

Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.*/

using System;

class bitwiseExtractBit
{
    static void Main()
    {
        Console.Write("Please enter an integer n: ");
        int input = int.Parse(Console.ReadLine());
        Console.Write("Please enter an integer for bit number p: ");
        int position = int.Parse(Console.ReadLine());
        int bitValue = ((input >> position) & 1);
        Console.WriteLine("n = " + input + "; the bit at position p = " + position + " is " + bitValue);
    }
}

