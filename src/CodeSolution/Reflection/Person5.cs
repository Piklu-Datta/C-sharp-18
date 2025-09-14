using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Person5
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person5(string name, int age) {
            Name = name;
            Age = age;
        }

      

        public void displayInfo()
        {
            Console.WriteLine($"Name: {Name} Age: {Age}");
        }

        public void Greet()
        {
            Console.WriteLine($"Hey my name is {Name}");
        }
    }
}
