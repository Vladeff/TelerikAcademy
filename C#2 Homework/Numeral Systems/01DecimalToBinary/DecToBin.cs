﻿//Problem 1. Decimal to binary

//Write a program to convert decimal numbers to their binary representation.

using System;

class DecToBin
{
    static string DecimalToBinaryConverter(int decimalNumber)
    {
        string binaryNum = string.Empty;

        if (decimalNumber == 0)
        {
            binaryNum = "0";
        }
        else
        {
            while (decimalNumber > 0)
            {
                binaryNum = decimalNumber % 2 + binaryNum;
                decimalNumber /= 2;
            }
        }
        return binaryNum;
    }
    static void Main()
    {
        Console.Write("Enter positive integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The binary representation of {0} is:\n{1}"
                                                       , number, DecimalToBinaryConverter(number));
    }


}