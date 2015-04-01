/*
 Problem 2: Define abstract class Person with first name and last name. Define new class Student which is derived
    from Person and has new field – grade. Define class Worker derived from Person with new property WeekSalary and
    WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper 
    constructors and properties for this hierarchy.
  Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
    Initialize a list of 10 workers and sort them by money per hour in descending order.
    Merge the lists and sort them by first name and last name.*/

namespace _02.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MainProgram
    {
        public static void Main()
        {
            var students = new List<Student>()
            {
                new Student("Pesho", "Peshev", 5),
                new Student("Gosho", "Goshev", 4),
                new Student("Mariq", "Teneva", 12),
                new Student("Nedelina", "Antonovo", 9)                
            };

            var workers = new List<Worker>()
            {
                new Worker("Bojko", "Borisov", 10000.0m, 5),
                new Worker("Slavi", "Trifonov", 70000.0m, 5),
                new Worker("Oprah", "Winfry", 1000000.0m, 1),
                new Worker("Maria", "Sharapova", 300000.0m, 10)                
            };

            var sortedByGrade = students.OrderBy(x => x.Grade);

            Console.WriteLine("Students ordered by ascending grades");
            foreach (var stud in sortedByGrade)
            {
                Console.WriteLine("{0,-7} {1,-8} {2}", stud.FirstName, stud.LastName,stud.Grade);
            }
            Console.WriteLine();

            var sortBySalary = workers.OrderByDescending(x => x.MoneyPerHour());

            Console.WriteLine("Workers ordered by descending money per hour");
            foreach (var worker in sortBySalary)
            {
                Console.WriteLine("{0,-9} {1,-10} {2:C}", worker.FirstName, worker.LastName,worker.MoneyPerHour());

            }
            Console.WriteLine();

            var concatGroups = sortedByGrade
                .Concat<Person>(sortBySalary)
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName);

            //Console.WriteLine("Both groups concatenated and sorted by names");
            //foreach (var person in concatGroups)
            //{
            //    Console.WriteLine("{0,-9} {1, -10}", person.FirstName, person.LastName);
            //}
        }
    }
}