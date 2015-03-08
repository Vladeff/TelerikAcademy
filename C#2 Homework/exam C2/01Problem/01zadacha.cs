﻿//Problem 4. Hexadecimal to decimal

//Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Collections.Generic;

class HexToDec
{
    static string DecimalToMewConverter(ulong number)
    {
        string mewNum = "";
        if (number == 0)
        {
            mewNum = "0";
        }
        else
        {
            while (number > 0)
            {
                switch (number % 23)
                {
                    case 0: mewNum = "a" + mewNum; break;
                    case 1: mewNum = "b" + mewNum; break;
                    case 2: mewNum = "c" + mewNum; break;
                    case 3: mewNum = "d" + mewNum; break;
                    case 4: mewNum = "e" + mewNum; break;
                    case 5: mewNum = "f" + mewNum; break;
                    case 6: mewNum = "g" + mewNum; break;
                    case 7: mewNum = "h" + mewNum; break;
                    case 8: mewNum = "i" + mewNum; break;
                    case 9: mewNum = "j" + mewNum; break;
                    case 10: mewNum = "k" + mewNum; break;
                    case 11: mewNum = "l" + mewNum; break;
                    case 12: mewNum = "m" + mewNum; break;
                    case 13: mewNum = "n" + mewNum; break;
                    case 14: mewNum = "o" + mewNum; break;
                    case 15: mewNum = "p" + mewNum; break;
                    case 16: mewNum = "q" + mewNum; break;
                    case 17: mewNum = "r" + mewNum; break;
                    case 18: mewNum = "s" + mewNum; break;
                    case 19: mewNum = "t" + mewNum; break;
                    case 20: mewNum = "u" + mewNum; break;
                    case 21: mewNum = "v" + mewNum; break;
                    case 22: mewNum = "w" + mewNum; break;
                        
                }
                number /= 23;
            }
        }
        return mewNum;
    }      //homework
    static ulong MewToDecConverter(string mewNumber)
    {
        ulong decimalNumber = 0;
        for (int i = mewNumber.Length - 1; i >= 0; i--)
        {
            switch (mewNumber[i])
            {
                
                case 'a':
                    decimalNumber += 0 * (ulong)Math.Pow(23, mewNumber.Length - 1 - i);
                    break;
                case 'b':
                    decimalNumber += 1 * (ulong)Math.Pow(23, mewNumber.Length - 1 - i);
                    break;
                case 'c':
                    decimalNumber += 2 * (ulong)Math.Pow(23, mewNumber.Length - 1 - i);
                    break;
                case 'd':
                    decimalNumber += 3 * (ulong)Math.Pow(23, mewNumber.Length - 1 - i);
                    break;
                case 'e':
                    decimalNumber += 4 * (ulong)Math.Pow(23, mewNumber.Length - 1 - i);
                    break;
                case 'f':
                    decimalNumber += 5 * (ulong)Math.Pow(23, mewNumber.Length - 1 - i);
                    break;
                case 'g':
                    decimalNumber += 6 * (ulong)Math.Pow(23, mewNumber.Length - 1 - i);
                    break;
                case 'h':
                    decimalNumber += 7 * (ulong)Math.Pow(23, mewNumber.Length - 1 - i);
                    break;
                case 'i':
                    decimalNumber += 8 * (ulong)Math.Pow(23, mewNumber.Length - 1 - i);
                    break;
                case 'j':
                    decimalNumber += 9 * (ulong)Math.Pow(23, mewNumber.Length - 1 - i);
                    break;
                case 'k':
                    decimalNumber += 10 * (ulong)Math.Pow(23, mewNumber.Length - 1 - i);
                    break;
                case 'l':
                    decimalNumber += 11 * (ulong)Math.Pow(23, mewNumber.Length - 1 - i);
                    break;
                case 'm':
                    decimalNumber += 12 * (ulong)Math.Pow(23, mewNumber.Length - 1 - i);
                    break;
                case 'n':
                    decimalNumber += 13 * (ulong)Math.Pow(23, mewNumber.Length - 1 - i);
                    break;
                case 'o':
                    decimalNumber += 14 * (ulong)Math.Pow(23, mewNumber.Length - 1 - i);
                    break;
                case 'p':
                    decimalNumber += 15 * (ulong)Math.Pow(23, mewNumber.Length - 1 - i);
                    break;
                case 'q':
                    decimalNumber += 16 * (ulong)Math.Pow(23, mewNumber.Length - 1 - i);
                    break;
                case 'r':
                    decimalNumber += 17 * (ulong)Math.Pow(23, mewNumber.Length - 1 - i);
                    break;
                case 's':
                    decimalNumber += 18 * (ulong)Math.Pow(23, mewNumber.Length - 1 - i);
                    break;
                case 't':
                    decimalNumber += 19 * (ulong)Math.Pow(23, mewNumber.Length - 1 - i);
                    break;
                case 'u':
                    decimalNumber += 20 * (ulong)Math.Pow(23, mewNumber.Length - 1 - i);
                    break;
                case 'v':
                    decimalNumber += 21 * (ulong)Math.Pow(23, mewNumber.Length - 1 - i);
                    break;
                case 'w':
                    decimalNumber += 22 * (ulong)Math.Pow(23, mewNumber.Length - 1 - i);
                    break;

            }
        }
        return decimalNumber;
    }       //homework

    static void Main()
    {
        ulong sum = 0;
        string mewNumber = Console.ReadLine();

        string[] separeteMews = mewNumber.Split(' ');

        foreach (var mew in separeteMews)
        {           
            sum += MewToDecConverter(mew);            
        }

        if (separeteMews.Length <= 1)
        {
            Console.WriteLine("{0} = {1}", mewNumber, sum);            
        }

        else
        {
            Console.WriteLine("{0} = {1}", DecimalToMewConverter(sum), sum);
        }
    }


}