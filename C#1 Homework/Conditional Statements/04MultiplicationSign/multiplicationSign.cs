/*Problem 4. Multiplication Sign

Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.*/

using System;

    class multiplicationSign
    {
        static void Main()
        {
            Console.WriteLine("Please, enter three numbers to multiply. The result is +, - or 0");
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());    
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            double c = double.Parse(Console.ReadLine());

            if (a==0 || b==0 || c==0)
            {
                Console.WriteLine("0");
            }                
            else
            {
                if (a > 0 && b > 0 && c > 0)     //I know it's dumm, but it works :)
                {
                    Console.WriteLine("+");
                }
                if (a < 0 && b > 0 && c > 0)
                {
                    Console.WriteLine("-");
                }
                if (a > 0 && b < 0 && c > 0)
                {
                    Console.WriteLine("-");
                }
                if (a > 0 && b > 0 && c < 0)
                {
                    Console.WriteLine("-");
                }
                if (a < 0 && b < 0 && c < 0)
                {
                    Console.WriteLine("-");
                }
                if (a < 0 && b < 0 && c > 0)
                {
                    Console.WriteLine("+");
                }
                if (a > 0 && b < 0 && c < 0)
                {
                    Console.WriteLine("+");
                }
                if (a < 0 && b > 0 && c < 0)
                {
                    Console.WriteLine("+");
                }          
            }
            

        }
    }

