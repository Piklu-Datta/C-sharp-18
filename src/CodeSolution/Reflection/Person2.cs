using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Person2
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Person2 (string name, int id)
        {
            Name = name;    
            Id = id;
        }
    }
}
