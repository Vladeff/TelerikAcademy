
using System;

class ageAfterDecade
{
    static void Main()
    {
        Console.Write("Enter the year of born :");
        int bornYear = int.Parse(Console.ReadLine());
        int curentYear = DateTime.Now.Year;
        int ageNow;
        int ageAfter;
        if (bornYear >= 1950 && bornYear < curentYear)
        {
            ageNow = curentYear - bornYear;
            ageAfter = ageNow + 10;
            Console.WriteLine("Your age now is {0}, and your age in 10 years will be {1}", ageNow, ageAfter);        
        }
        else
        {
            Console.WriteLine("You little liar :) ");
        }
    }
}