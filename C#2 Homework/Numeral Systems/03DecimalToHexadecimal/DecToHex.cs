﻿//Problem 3. Decimal to hexadecimal

//Write a program to convert decimal numbers to their hexadecimal representation.

using System;

class DecToHex
{
    static string DecimalToHexadecimalConverter(int number)
    {
        string hexNum = "";
        if (number == 0)
        {
            hexNum = "0";
        }
        else
        {
            while (number > 0)
            {
                switch (number % 16)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9: hexNum = number % 16 + hexNum;
                        break;
                    case 10:
                        hexNum = "A" + hexNum;
                        break;
                    case 11:
                        hexNum = "B" + hexNum;
                        break;
                    case 12:
                        hexNum = "C" + hexNum;
                        break;
                    case 13:
                        hexNum = "D" + hexNum;
                        break;
                    case 14:
                        hexNum = "E" + hexNum;
                        break;
                    case 15:
                        hexNum = "F" + hexNum;
                        break;
                }
                number /= 16;
            }
        }
        return hexNum;
    }
    static void Main()
    {
        Console.Write("Enter positive integer: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("The hexadecimal representation of {0} is {1}", number, DecimalToHexadecimalConverter(number));
    }

   
}