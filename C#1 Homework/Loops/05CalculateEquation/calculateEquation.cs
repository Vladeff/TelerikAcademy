/*Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point.*/

using System;

    class calculateEquation
    {
        static void Main()
        {   
                                        //S = 1 + 1!/x + 2!/x2
                                        //n!/x^n.
            Console.WriteLine("Enter two integers numbers: N and X in S = 1 + 1!/x + 2!/x2 + … + n!/x^n. ");
            Console.Write("n =" );
            int n = int.Parse(Console.ReadLine());
            Console.Write("x =");
            int x = int.Parse(Console.ReadLine());

            int factoriel = 1;
            double sum = 1;

            for (int i = 1; i <= n; i++)
            {
                factoriel *= i;
                sum += (double)(factoriel) / (double)Math.Pow(x, i);
            }

            Console.WriteLine("{0:0.00000}", sum);
        }
    }

