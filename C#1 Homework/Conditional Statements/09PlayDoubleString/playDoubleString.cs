/*Problem 9. Play with Int, Double and String

Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.*/

using System;

    class playDoubleString
    {
        static void Main()
        {
            Console.Write("Please, enter number(1-int, 2-double, 3-string):");
            int num = int.Parse(Console.ReadLine());
            if (num ==1)
            {
                Console.Write("Please enter int:");
                int intN = int.Parse(Console.ReadLine());
                Console.WriteLine(intN + 1);
            }
            if (num == 2)
            {
                Console.Write("Please enter double:");
                double doubleN = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleN + 1);
            }
            if (num == 3)
            {
                Console.Write("Please enter string:");
                string text = Console.ReadLine();
                Console.WriteLine(text + "*");
            }
        }
    }

