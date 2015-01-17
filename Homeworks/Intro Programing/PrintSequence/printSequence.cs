using System;

class PrintSequence
{
    static void Main()
    {
        for (int number = 2; number < 12; number++)
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