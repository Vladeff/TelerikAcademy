﻿namespace SaveSortedNames
 {
     using System;
     using System.Collections.Generic;
     using System.IO;
     using System.Linq;

     class SaveSortedNames
     {
         static void Main()
         {
             // Write a program that reads a text file containing a list 
             // of strings, sorts them and saves them to another text file.
             // Example:
             // input.txt 	        output.txt
             // Ivan                 George
             // Peter                Ivan
             // Maria                Maria
             // George 	            Peter

             string inputPath = @"..\..\InputFile.txt";
             string outputPath = @"..\..\OutputFile.txt";


             List<string> names = new List<string>();

             using (StreamReader stream = new StreamReader(inputPath))
             {
                 names = stream.ReadToEnd()
                     .Split('\n')
                     .Select(x => x.Trim())
                     .OrderBy(x => x)
                     .ToList();

                 File.WriteAllLines(outputPath, names);

                 Console.WriteLine("DIRECTORY: " +
                     Path.GetFullPath(outputPath).Replace(Path.GetFileName(outputPath), String.Empty));

                 Console.WriteLine("A file {0} is done with reversed  names.",
                     Path.GetFileName(outputPath));
             }
         }
     }
 }