﻿namespace ExtensionMethodsDelegatesLambdaLINQ
{
using StudentGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ExtractStudentsWithTwoMarks
    {
        static void Main()
        {
            Student student1 = new Student("Gosho", "Goshev", 15000, "+3598811111", "Gosho@gmail.com", 1);
            student1.AddMark(6);
            student1.AddMark(2);

            Student student2 = new Student("Pesho", "Peshev", 15001, "+3598922222", "Pesho@gmail.com", 2);
            student2.AddMark(6);
            student2.AddMark(6);
            student2.AddMark(2);
            student2.AddMark(4);

            Student student3 = new Student("Smesho", "Peshev", 15030, "+3598922222", "Pesho@gmail.com", 1);
            student3.AddMark(4);
            Student student4 = new Student("Gesho", "Peshev", 15011, "+3598922222", "Pesho@abv.com", 2);
            student4.AddMark(6);
            student4.AddMark(6);
            student4.AddMark(3);
            student4.AddMark(4);

            List<Student> students = new List<Student>() 
            {
                student1, student2, student3, student4
            };

            var extractedStudents = students.Where(s => s.Marks.Count == 2).Select(s => s);

            foreach (Student student in extractedStudents)
                Console.WriteLine(student);
        }
    }
}