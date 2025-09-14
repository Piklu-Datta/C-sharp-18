using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Person3
    {
        public string Name { get; set; }    
        public int Age { get; set; }

        public Person3() { }

        public void setInfo(string name, int age)
        {
            Name=  name;
            Age= age;
        }

        public void displayInfo ()
        {
            Console.WriteLine($"Name is {Name} and Age is {Age}");
        }

    }
}
