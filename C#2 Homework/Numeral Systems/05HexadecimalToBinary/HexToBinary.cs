//Problem 5. Hexadecimal to binary

//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;

class HexToBinary
{
    static string HexToBin(string hexNum)
    {
        string binary = string.Empty;

        for (int i = 0; i < hexNum.Length; i++)
        {
            if (Char.IsDigit(hexNum[i]))
            {
                binary += Convert.ToString(int.Parse(hexNum[i].ToString()), 2).PadLeft(4, '0');
            }
            else
            {
                binary += Convert.ToString((hexNum[i] - 'A' + 10), 2).PadLeft(4, '0');
            }
        }
        return binary.TrimStart('0');
    }
    static void Main()
    {
        Console.Write("Enter a hexadecimal number: ");
        string hex = Console.ReadLine().ToUpper();

        Console.WriteLine("The binary representation of the hexadecimal number {0} is:{1}\n", hex, HexToBin(hex));
    }

    
}