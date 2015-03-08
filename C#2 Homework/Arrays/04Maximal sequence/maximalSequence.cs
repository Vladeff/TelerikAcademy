/*Problem 4. Maximal sequence

Write a program that finds the maximal sequence of equal elements in an array.
Example:

input	                                result
2, 1, 1, 2, 3, 3, 2, 2, 2, 1	        2, 2, 2 */


using System;
using System.Collections.Generic;
using System.Linq;

class maximalSequence
{
    static void Main()
    {
        Console.WriteLine(new String('-', 57));
        Console.WriteLine("Enter elements of the array in one lane separated by \" , \":");
        Console.WriteLine(new String('-', 57));
        string input = Console.ReadLine();
        Console.WriteLine();

        string[] stringArray = input.Split(',');
        int[] intArray = Array.ConvertAll(stringArray, int.Parse);

        List<int> tempMax = new List<int>();
        List<int> maxSecElements = new List<int>();


        for (int i = 0; i < intArray.Length; i++)
        {

            if (((i < intArray.Length - 1) && ((intArray[i] == intArray[i + 1]))))
            {
                tempMax.Add(i);
            }
            else if (((i > 0) && ((intArray[i] == intArray[i - 1]))))
            {
                tempMax.Add(i);
            }


            if ((i < intArray.Length - 1) && (intArray[i] != intArray[i + 1]))
            {

                if (tempMax.Count > maxSecElements.Count)
                {


                    maxSecElements = tempMax.ToList();
                    tempMax.Clear();
                }
                else
                {
                    tempMax.Clear();
                }

            }

        }

        if (tempMax.Count > maxSecElements.Count)
        {

            maxSecElements = tempMax.ToList();
            tempMax.Clear();
        }

        Console.WriteLine("The longest secuence of equal symbols is");
        for (int i = 0; i < maxSecElements.Count; i++)
        {
            if (i == maxSecElements.Count - 1)
            {
                Console.Write("{0} - Total {1} equal elements", array[maxSecElements[i]], maxSecElements.Count);
            }
            else
            {
                Console.Write("{0}, ", array[maxSecElements[i]]);
            }
        }
    }
}
    

