/*Problem 12. Extract Bit from Integer

Write an expression that extracts from given integer n the value of given bit at index p.*/

using System;

class extractBitfromInteger
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter position to check bit: ");
        int position = int.Parse(Console.ReadLine());

        Console.WriteLine(BitIsOne(number, position) ? "One(1)" : "Zero(0)");
    }

    private static bool BitIsOne(int number, int position)
    {
        if ((number & (1 << position)) == 0) return false;
        return true;
    }
}

