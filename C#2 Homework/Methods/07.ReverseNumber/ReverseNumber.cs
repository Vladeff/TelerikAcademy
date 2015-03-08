//Problem 7. Reverse number

//Write a method that reverses the digits of given decimal number.


namespace Problem07ReverseNumber
{
    using System;
    class ReverseNumber
    {
        static decimal ReverseDigits(decimal value)
        {
            char[] ch = value.ToString().ToCharArray();
            Array.Reverse(ch);
            return decimal.Parse(new string(ch));
        }

        static void Main()
        {
            Console.WriteLine("Enter decimal value: ");
            decimal x = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Reversed {0}" ,ReverseDigits(x));
        }
    }
}