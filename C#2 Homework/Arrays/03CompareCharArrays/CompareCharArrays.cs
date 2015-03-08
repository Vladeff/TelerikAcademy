/*Problem 3. Compare char arrays

Write a program that compares two char arrays lexicographically (letter by letter).*/


using System;

    class CompareCharArrays
    {
        static void Main()
        {
            Console.WriteLine("Comparing two letter arrays.Enter size of the arrays");
            int sise = int.Parse(Console.ReadLine());
            char[] arr1 = new char[sise];
            char[] arr2 = new char[sise];


            Console.WriteLine("Enter {0} letter of the first array:", sise);
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("arr[{0}]: ", i);
                arr1[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter {0} letter of the second array:", sise);
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("arr[{0}]: ", i);
                arr2[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < sise; i++)
            {
                if (arr1[i] > arr2[i])
                {
                    Console.WriteLine("{0} < {1}", arr1[i], arr2[i]);
                }
                else if (arr1[i] < arr2[i])
                {
                    Console.WriteLine("{0} > {1}", arr1[i], arr2[i]);
                }
                else if (arr1[i] == arr2[i])
                {
                    Console.WriteLine("{0} = {1}", arr1[i], arr2[i]);
                }
            }
        }
    }

