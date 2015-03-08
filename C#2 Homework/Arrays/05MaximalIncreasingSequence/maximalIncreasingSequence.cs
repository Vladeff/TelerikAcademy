using System;

//Problem 5. Maximal increasing sequence

//Write a program that finds the maximal increasing sequence in an array.
//Example:

//input	                result
//3, 2, 3, 4, 2, 2, 4	    2, 3, 4

class maximalIncreasingSequence
{
    static void Main()
    {
        // pretty much the same as last problem, we only change if(elements[i-1] == elements[i]) to if(elements[i-1] < elements[i])
        Console.WriteLine("N:");
        int n = int.Parse(Console.ReadLine());

        // helpers
        int longest = 1;
        int currentSequence = 1;
        string sequence = "";


        int[] elements = new int[n];

        Console.WriteLine("Array:");
        elements[0] = int.Parse(Console.ReadLine()); // set manually, because we do comparison with index i-1
        string temp = elements[0] + ","; // set manually

        for (int i = 1; i < n; i++)
        {

            elements[i] = int.Parse(Console.ReadLine()); // input

            if (elements[i - 1] < elements[i])
            {
                currentSequence++; // we're counting the length of the current sequence
                temp += elements[i] + ","; // keep the current sequence here

                if (currentSequence > longest) // if the current sequence is longer than our longest, make it the new longest
                {
                    longest = currentSequence;
                    sequence = temp;
                }

            }
            else // if no match between previous and current, reset
            {
                currentSequence = 1;
                temp = elements[i] + ",";
            }
        }

        // remove trailing ", "
        Console.WriteLine(sequence.TrimEnd(','));

    }
}