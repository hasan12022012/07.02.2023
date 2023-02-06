using System;
using System.Security.Cryptography.X509Certificates;

namespace yoxlama1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Human human1= new Human();
            human1.name = "sadiq";
            human1.surname = "abbasov";
            human1.group = "p138";
            human1.age = 23;

            Console.WriteLine(human1.GetFullName());
        }
    }
}
