using System;
using System.Collections.Generic;
using System.Text;

namespace yoxlama1
{
    internal class Human
    {
        public string name;
        public string surname;
        public string group;
        public byte age;

        public string GetFullName()
        {
            return name+" "+surname+" "+age+" "+group;
        }
    }
    
    
}
