//Problem 2. Binary to decimal

//Write a program to convert binary numbers to their decimal representation.

using System;

class BinToDec
{
    static void Main()
    {
        Console.Write("Enter binary: ");
        string strBinary = Console.ReadLine();
        
        char[] array = strBinary.ToCharArray();
        int decimalNum = 0;
        int digit;
        for (int i = 0; i < array.Length; i++)
        {
            digit = (int)Char.GetNumericValue(array[array.Length - 1 - i]);
            decimalNum += digit * (int)Math.Pow(2, i);
        }
        Console.Write("The decimal representation of {0} is: {1} \n\n", strBinary, decimalNum);

       
    }
}