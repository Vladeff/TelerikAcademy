
namespace Groups

{
    using StudentGroups;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Groups
    {
        static void Main()
        {
            List<Student> students = new List<Student>() 
            {
                new Student("Gosho", "Goshev", 15000, "+3598811111", "Gosho@gmail.com", 1),
                new Student("Pesho", "Peshev", 15001, "+3598922222", "Pesho@gmail.com", 2),
                new Student("Smesho", "Peshev", 15030, "+3598922222", "Pesho@gmail.com", 1),
                new Student("Gesho", "Peshev", 15011, "+3598922222", "Pesho@abv.com", 2)
            };

            Group group = new Group(2, "Mathematics");
            List<Group> groups = new List<Group>() { group };

            var mathStudents = from student in students
                               join gr in groups on student.GroupNumber equals gr.GroupNumber
                               select student;

            foreach (Student student in mathStudents)
                Console.WriteLine(student);
        }
    }
}