using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Person4
    {
        public string Name { get; set; }
        public int Age { get; set; }    

        public Person4 () { }

        public void SetInfo(string name, int age)
        {
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
