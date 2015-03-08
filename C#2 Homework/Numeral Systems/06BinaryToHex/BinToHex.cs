//Problem 6. binary to hexadecimal

//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class BinToHex
{
    static string ConvertBinToHex(string binaryNum)
    {
        string hexNum = string.Empty;
        if (binaryNum.Length % 4 != 0)
        {
            binaryNum = new string('0', 4 - binaryNum.Length % 4) + binaryNum;
        }
        for (int i = 0; i < binaryNum.Length; i += 4)
        {
            string hexDigit = binaryNum.Substring(i, 4);
            switch (hexDigit)
            {
                case "0000":
                    hexNum += 0;
                    break;
                case "0001":
                    hexNum += 1;
                    break;
                case "0010":
                    hexNum += 2;
                    break;
                case "0011":
                    hexNum += 3;
                    break;
                case "0100":
                    hexNum += 4;
                    break;
                case "0101":
                    hexNum += 5;
                    break;
                case "0110":
                    hexNum += 6;
                    break;
                case "0111":
                    hexNum += 7;
                    break;
                case "1000":
                    hexNum += 8;
                    break;
                case "1001":
                    hexNum += 9;
                    break;
                case "1010":
                    hexNum += "A";
                    break;
                case "1011":
                    hexNum += "B";
                    break;
                case "1100":
                    hexNum += "C";
                    break;
                case "1101":
                    hexNum += "D";
                    break;
                case "1110":
                    hexNum += "E";
                    break;
                case "1111":
                    hexNum += "F";
                    break;
            }
        }
        return hexNum;
    }
    static void Main()
    {
        Console.WriteLine("Enter binary number: ");
        string binary = Console.ReadLine();

        Console.WriteLine("The hexadecimal representation of {0}\nis: {1}", binary, ConvertBinToHex(binary));
    }

    
}