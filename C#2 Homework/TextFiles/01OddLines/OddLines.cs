namespace OddLines
{
    /*Problem 1. Odd lines

Write a program that reads a text file and prints on the console its odd lines*/

    using System;
    using System.IO;
    using System.Text;

    public class OddLines
    {
        public static void Main()
        {

            using (StreamReader stream = new StreamReader(@"..\..\..\TextFile.txt"))
            {
                string[] allLines = stream.ReadToEnd().Split('\n');

                StringBuilder result = new StringBuilder();
                for (int line = 1; line < allLines.Length; line += 2)
                {
                    result.AppendLine(allLines[line]);
                }

                Console.WriteLine();
            }
        }
    }
}