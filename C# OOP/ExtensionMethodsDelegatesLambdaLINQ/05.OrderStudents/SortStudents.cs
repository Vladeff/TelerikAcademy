namespace ExtensionMethodsDelegatesLambdaLINQ
{
    using System;
    using System.Linq;
    

    class SortStudents
    {
        static void Main()
        {
            Student[] students = new Student[] 
            {
                new Student("Vasil", "Levski", 35),
                new Student("Hristo", "Botev", 28),    // (How long lived)
                new Student("Georgi", "Rakovski", 46), 
                new Student("Hadji", "Dimityr", 28),
                new Student("Ivan", "Vazov", 71),
                
            };

            //using extension methods and lambda expression
            var sortedStudents = students
                .OrderBy(s => s.FirstName)
                .ThenBy(s => s.LastName);

            foreach (Student student in sortedStudents)
            {
                Console.WriteLine(student);

            }

            Console.WriteLine();
            //using LINQ query
            var sortedStudents1 = from student in students
                                  orderby student.FirstName, student.LastName
                                  select student;

            foreach (Student student in sortedStudents1)
            {
                Console.WriteLine(student);
                
            }
        }
    }
}