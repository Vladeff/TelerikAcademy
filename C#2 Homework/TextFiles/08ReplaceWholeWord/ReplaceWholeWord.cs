﻿﻿namespace ReplaceWholeWord
 {
     // Modify the solution of the previous problem to 
     // replace only whole words (not strings).

     using System;
     using System.IO;
     using System.Text.RegularExpressions;

     class ReplaceWholeWord
     {
        static void Main()
         {
           
             using (StreamReader streamReader = new StreamReader("../../Text.txt"))
             {
                 using (StreamWriter streamWriter = new StreamWriter("../../Result.txt"))
                 {
                     string line = streamReader.ReadLine();

                     while (line != null)
                     {
                         streamWriter.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
                         line = streamReader.ReadLine();
                     }

                     Console.WriteLine("Result.txt - Done");
                 }
             }
         }
     }
 }