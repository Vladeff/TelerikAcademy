/*Problem 15. Hexadecimal to Decimal Number

Using loops write a program that converts a hexadecimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.*/

using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter hexadecimal: ");
        string hexadecimal = Console.ReadLine();
        int length = hexadecimal.Length;
        long decimalNumber = 0;
        string[] hexes = new string[16] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

        for (int i = 0; i < length; i++)
        {
            string substring = hexadecimal.Substring(hexadecimal.Length - 1, 1);
            long index = Array.IndexOf(hexes, substring);

            if (index < 0)
            {
                Console.WriteLine("Error! Please use capital letters A-F and digits.");
                decimalNumber = -1;
                return;
            }

            long power = (long)Math.Pow(16, i);

            hexadecimal = hexadecimal.Substring(0, hexadecimal.Length - 1);
            decimalNumber += index * power;
        }

        Console.WriteLine(decimalNumber);

    }
}

