/*Problem 14. Modify a Bit at Given Position

We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to 
 * hold the value v at the position p from the binary representation of n while preserving all other bits in n.*/

using System;

class modifyBitGivenPosition
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("Enter value: ");
        int value = int.Parse(Console.ReadLine());

        if (((number >> position) & 1) != value) number = ChangeBit(number, position);

        Console.Clear();
        Console.WriteLine("Result: " + number);

    }

    private static int ChangeBit(int number, int position)
    {
        return number ^ (1 << position);
    }
}

