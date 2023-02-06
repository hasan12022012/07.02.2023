using System;

namespace yoxlama3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student(86)
            {
                FullName = "Hikmet Abbasov",
                GroupNo = "p138"
            };

            Console.WriteLine(std1.IsPassed());

            Student std2 = new Student(55)
            {
                FullName = "Nicat Qulamov",
                GroupNo = "p138"
            };
            Console.WriteLine(std2.IsPassed());
        }
    }
}
