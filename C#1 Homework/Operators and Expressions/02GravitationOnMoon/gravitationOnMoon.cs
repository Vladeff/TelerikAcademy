/*Problem 2. Gravitation on the Moon

The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.*/

using System;

class gravitationOnMoon
{
    static void Main()
    {
        Console.WriteLine("Enter your weight:");
        string str = Console.ReadLine();
        double earghtW = double.Parse(str);
        double moonW = (earghtW * 0.17);
        Console.WriteLine("Your weight on the Moon will be: {0} kg.", moonW);
    }
}

