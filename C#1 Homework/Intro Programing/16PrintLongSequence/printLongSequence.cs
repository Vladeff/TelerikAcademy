using System;

class printLongSequence
{
    static void Main()
    {
        for (int number = 2; number < 1001; number++)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + ", ");
            }
            else
                Console.Write(number * (-1) + ", ");
        }
        Console.WriteLine("\n");
    }
}