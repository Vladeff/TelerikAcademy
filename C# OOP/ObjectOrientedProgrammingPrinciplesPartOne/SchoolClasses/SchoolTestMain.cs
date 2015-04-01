/*  Problem 1. School classes

We are given a school. In the school there are classes of students. Each class has a set of teachers. 
 Each teacher teaches, a set of disciplines. Students have a name and unique class number. Classes 
 have unique text identifier. Teachers have a name. Disciplines have a name, number of lectures and 
 number of exercises. Both teachers and students are people. Students, classes, teachers and disciplines 
 could have optional comments (free text block).
 Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate 
 their fields, define the class hierarchy and create a class diagram with Visual Studio.
*/

namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    class SchoolTestMain
    {
        static void Main()
        {
            School mySchool = new School("Telerik Academy");

            // Creating students
            Student[] studentsFirstGroup = new Student[]
            {
                new Student("Petko Petkov", 11111),
                new Student("Pesho Peshov", 22222),
                new Student("Gencho Genchev", 33333)
               
            };

            Student[] studentsSecondGroup = new Student[]
            {
                new Student("Maria Petkova", 44444),
                new Student("Martina Doncheva", 55555),
                new Student("Lepa Brena", 66666)
               
            };

            // Creating disciplines
            Discipline cSharp = new Discipline("C Sharp Fundamentals", 30, 30);
            Discipline javaScript = new Discipline("JavaScript Fundamentals", 40, 50);
            Discipline html = new Discipline("HTML5", 12, 13);
            Discipline css = new Discipline("CSS3");

            // Creating teachers
            Teacher teacher1 = new Teacher("Nikolay Kostov");
            Teacher teacher2 = new Teacher("Ivaylo Kenov");            

            teacher1.AddDiscipline(javaScript, cSharp);
            teacher2.AddDiscipline(cSharp);

            // Creating Group classes
            SchoolClass firstGroupClass = new SchoolClass("First Group-morning");
            SchoolClass secondGroupClass = new SchoolClass("Second Group-evening");

            firstGroupClass.AddTeacher(teacher1, teacher2);
            secondGroupClass.AddTeacher(teacher1);
          
           firstGroupClass.AddStudent(studentsFirstGroup);
           secondGroupClass.AddStudent(studentsSecondGroup);
          
             mySchool.AddClass(firstGroupClass);
             mySchool.AddClass(secondGroupClass);
           Console.WriteLine(mySchool);
        }
    }
}