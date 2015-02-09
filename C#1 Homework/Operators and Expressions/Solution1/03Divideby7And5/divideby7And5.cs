/*Problem 3. Divide by 7 and 5

Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.*/

using System;

class divideby7And5
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        string str = Console.ReadLine();
        int number = int.Parse(str);

        if (number % 5 == 0)
        {
            if (number % 7 == 0)
                Console.WriteLine("Entered number can be divided  by 7 and 5 at the same time");
            else
                Console.WriteLine("Entered number can't be divided  by 7 and 5 at the same time");

        }
        else
            Console.WriteLine("Entered number can't be divided by 7 and 5 at the same time");

    }
}

