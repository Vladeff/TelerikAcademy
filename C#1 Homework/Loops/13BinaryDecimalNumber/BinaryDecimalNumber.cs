/*Problem 13. Binary to Decimal Number

Using loops write a program that converts a binary integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.*/



using System;

    class BinaryDecimalNumber
    {
        static void Main()
        {
            Console.Write("Enter binary number = ");
            string binNumber = Console.ReadLine();

            long decNumber = 0;
            int position = binNumber.Length - 1;
            long powerNumber = 1;
            for (int i = 0; i < binNumber.Length; i++)
            {
                int bit = int.Parse(binNumber[i].ToString());
                for (int j = 0; j < position; j++)
                {
                    powerNumber = powerNumber * 2;
                }
                decNumber += bit * powerNumber;
                powerNumber = 1;
                position--;
            }
            Console.WriteLine("{0} --> {1}", binNumber, decNumber);
        }
    }

