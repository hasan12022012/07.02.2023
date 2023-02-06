using System;

namespace yoxlama
{
    class Student
    {
        public string Name;
        public byte age;
        public string surname;
        public string group;

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} - age: {age} - surname: {surname} - group: {group}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student
            {
                Name = "Abbas",
                age = 23,
                surname = "Abbasli",
                group = "p138"
            };
            std.ShowInfo();

            Student std2 = new Student();
            std2.Name = "gulbeniz";
            std2.age = 23;
            std2.surname = "seyidova";
            std2.group = "p138";


            Student[] students = new Student[] { std, std2, new Student { Name="hikmet" } };
            for( int i = 0;i < students.Length;i++)
            {
                students[i].ShowInfo();
            }

        }
    }
}
