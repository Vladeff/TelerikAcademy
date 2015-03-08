
namespace LineNumbers
{
    
﻿//Write a program that reads a text file and inserts line numbers in front of each of its lines.
    //The result should be written to another text file.

    using System;
    using System.IO;
    using System.Text;
    class LineNumbers
    {
        static void Main()
        {
            string outputFile = @"..\..\OutTextFile.txt";
            string inputFile = @"..\..\InTextFile.txt";
            StringBuilder result = new StringBuilder();
            using (StreamReader stream = new StreamReader(inputFile))
            {
                string line;
                int lineNumber = 1;
                while ((line = stream.ReadLine()) != null)
                {
                    result.AppendLine(String.Format("{0,-5:D3}{1}", lineNumber, line));
                    ++lineNumber;
                }               

                File.WriteAllLines(outputFile, result.ToString().Split('\n'));
                Console.WriteLine("Directory: " +
                    Path.GetFullPath(inputFile)
                    .Replace(Path.GetFileName(inputFile), String.Empty));

                Console.WriteLine("File without line numbers: " +
                    Path.GetFileNameWithoutExtension(inputFile));

                Console.WriteLine("File with line numbers created in same directory: "
                    + Path.GetFileNameWithoutExtension(outputFile));


            }
        }
    }
}
