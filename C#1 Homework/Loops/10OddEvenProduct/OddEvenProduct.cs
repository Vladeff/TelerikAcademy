/*Problem 10. Odd and Even Product

You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.*/

using System;

    class OddEvenProduct
    {
        static void Main()
        {
            Console.WriteLine("Enter n integers (given in a single line, separated by a space) :");
            string strNum = Console.ReadLine();
            string[] Numbers = strNum.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            int oddProduct = 1;
            int evenProduct = 1;

            for (int i = 0; i < Numbers.Length; i++)
            {
                int currentNum = int.Parse(Numbers[i]);
                if (i % 2 == 0)
                {
                    evenProduct *= currentNum;
                }
                else if (i % 2 != 0)
                {
                    oddProduct *= currentNum;
                }
            }
            bool equalProducts = oddProduct == evenProduct;
            Console.WriteLine(Math.Max)(equalProducts ? "Yes\nProduct = {0}" : "No\nOddProduct = {0}\nEvenProduct = {1}", oddProduct, evenProduct);

        }
    }

