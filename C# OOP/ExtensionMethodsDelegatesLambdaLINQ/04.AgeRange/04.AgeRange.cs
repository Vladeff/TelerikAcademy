namespace ExtensionMethodsDelegatesLambdaLINQ
{
    using System;
    using System.Linq;
    

    class Program
    {
        static void Main()
        {
            Student[] students = new Student[] 
            {
                new Student("Vasil", "Levski", 35),
                new Student("Hristo", "Botev", 28),    // (How long lived)
                new Student("Georgi", "Rakovski", 46), 
                new Student("Ivan", "Vazov", 71),
                new Student("Hadji", "Dimityr", 28)
            };

            //using lambda expression
            var selectedStudents = students
                .Where(s => s.Age < 24 && s.Age > 18)
                .Select(s => new { FirstName = s.FirstName, LastName = s.LastName });

            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student);

            }

            Console.WriteLine();
            //using linq query
            var selectedStudents1 = from student in students
                                    where student.Age > 18 && student.Age < 24
                                    select new { FirstName = student.FirstName, LastName = student.LastName };

            foreach (var student in selectedStudents1)
            {
                Console.WriteLine(student);

            }
        }
    }
}