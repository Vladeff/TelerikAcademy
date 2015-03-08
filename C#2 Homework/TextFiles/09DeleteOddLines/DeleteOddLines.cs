namespace E09_DeleteOddLines
{
    // Write a program that deletes from given text file all odd lines.
    // The result should be in the same file.
    using System;
    using System.IO;
    using System.Text;

    class DeleteOddLines
    {
        static void Main()
        {
            string[] lines = File.ReadAllLines("../../TextFile.txt");

            using (StreamWriter streamWriter = new StreamWriter("../../TextFile.txt"))
            {

                for (int index = 0; index < lines.Length; index+=1)
                {
                    if (index %2!=0)
                    {
                        streamWriter.WriteLine(lines[index]);                        
                    }
                }

                Console.WriteLine("TextFile.txt - Done");
            }
        }
    }
}