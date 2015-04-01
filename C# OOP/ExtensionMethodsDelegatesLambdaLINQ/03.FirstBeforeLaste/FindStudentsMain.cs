namespace ExtensionMethodsDelegatesLambdaLINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FindStudentsMain
    {
        static void Main()
        {
            Student[] students = new Student[] 
            {
                new Student("Vasil", "Levski", 35),
                new Student("Hristo", "Botev", 28),    // (How long lived)
                new Student("Georgi", "Rakovski", 46), 
                new Student("Ivan", "Vazov", 71),
                new Student("Hadji", "Dimityr", 28),
            };

            //using lamda expression
            var result = students.
                Where(s => s.FirstName.CompareTo(s.LastName) < 0)
                .Select(s => s);

            foreach (Student student in result)
                Console.WriteLine(student);

            Console.WriteLine();
            Console.WriteLine("From them students whose first name is \nbefore its last name alphabetically are: ");
            Console.WriteLine();

            //using LINQ query
            var result1 = from student in students
                          where student.FirstName.CompareTo(student.LastName) < 0
                          select student;

            foreach (Student student in result1)
                Console.WriteLine(student);
        }
    }
}