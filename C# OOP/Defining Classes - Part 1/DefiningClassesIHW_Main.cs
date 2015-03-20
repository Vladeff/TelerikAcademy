//One project with several classes for all of the problems

using System;

namespace DefiningClassesPartI
{
    public class Person
    {
        public Person(string firstName)
        {
            this.Name = firstName;
        }
        public string Name { get; private set; }

        public void callName()
        {
            Console.WriteLine(this.Name);
        }
    }
    public class DefiningClassesIHW_Main
    {
        static void Main()
        {
            var pesho = new Person("Pesho");
            pesho.callName();
        }
    }
}